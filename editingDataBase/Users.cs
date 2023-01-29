using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace editingDataBase
    {
    public partial class Users : Form
        {
        public static Users formUsers;
       
        public Users()
            {
            formUsers = this;
            InitializeComponent();
            }

        // Глобальные статичные переменные для подключения БД
        public static string pathToDataBase = Application.StartupPath + "/db.accdb";
        public static OleDbConnection connectToDataBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathToDataBase);

        // Загрузка формы
        private void Users_Load(object sender, EventArgs e)
            {
            loadDataFromDataBase();
            }

        // Заполнение dataGridView данными с БД
        public void loadDataFromDataBase()
            {

            // Очистка и создание новых столбцов
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add("1", "ID");
            dataGridView1.Columns.Add("2", "UserName");
            dataGridView1.Columns.Add("3", "Password");

            try
                {

                // SQL запрос
                string query = "SELECT * FROM [Login data];";

                // Запуск подключения
                connectToDataBase.Open();
                OleDbCommand command = new OleDbCommand(query, connectToDataBase); // Отправка команды в БД
                OleDbDataReader reader = command.ExecuteReader(); // Команда на чтение

                // Объявление переменных для данных с БД
                string number, userName, password = null;

                // Получение данных из БД и заполнение dataGridView
                while (reader.Read())
                    {
                    number = reader[0].ToString();
                    userName = reader[1].ToString();
                    password = reader[2].ToString();

                    dataGridView1.Rows.Add(number, userName, password);
                    }
                connectToDataBase.Close();
                }
            
            catch
                {

                // Лог в случае ошибки
                MessageBox.Show("Неопознанная ошибка");
                Console.WriteLine($"Database error");

                }
            }

        private void ДобавлениеЗаписи_Click(object sender, EventArgs e)
            {

            // Получение текущего индекса
            int sendIndex = dataGridView1.Rows.Count;

            // Запуск новой формы
            editingDataBase.controlUsers newForm = new editingDataBase.controlUsers();
            newForm.Show();
            
            // Вызов процедуры добавления в controlUsers
            newForm.loadDataFromUsersAdd(sendIndex);
            }

        private void РедактированиеЗаписи_Click(object sender, EventArgs e)
            {
            // Проверка на выделение пользователя
            if (dataGridView1.SelectedRows.Count != 0)
                {

                // Присвоение переменным данных для редактирования пользователя            
                int sendIndex = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                string sendUserName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                string sendPassword = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                // Запуск новой формы
                editingDataBase.controlUsers newForm = new editingDataBase.controlUsers();
                newForm.Show();

                // Вызов процедуры редактирования в controlUsers
                newForm.loadDataFromUsersEdit(sendIndex, sendUserName, sendPassword);
                }

            }

        private void УдалениеЗаписи_Click(object sender, EventArgs e)
            {
            // Проверка на выделение пользователя
            if (dataGridView1.SelectedRows.Count != 0)
                {

                // Получение индекса удаляемой записи
                int currentIndex = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

                // Запрос на удаление записи
                string query = "DELETE [Login data].Код, [Login data].Username, [Login data].Password FROM[Login data] WHERE((([Login data].Код)=" + currentIndex + "));";

                try
                    {

                    // Открытие подключения и выполнение запроса на удаление
                    connectToDataBase.Open();
                    OleDbCommand command = new OleDbCommand(query, connectToDataBase); // Отправка команды в БД
                    command.ExecuteNonQuery(); // Команда на запись
                    connectToDataBase.Close();

                    // Обновление текущей формы
                    loadDataFromDataBase();

                    }
                catch 
                    {

                    // Лог в случае ошибки
                    Console.WriteLine($"Database error. Info: {this.Name}, {sender}, {query}");

                    }
                }

            }
        }
    }

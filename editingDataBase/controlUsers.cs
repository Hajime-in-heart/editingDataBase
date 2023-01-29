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

namespace editingDataBase
    {
    public partial class controlUsers : Form
        {
        public controlUsers()
            {
            InitializeComponent();
            }

        // Объявление переменных на подключение к БД и на режим формы
        public static string pathToDataBase = Application.StartupPath + "/db.accdb";
        public static OleDbConnection connectToDataBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathToDataBase);
        public bool edit = false;

        private void button1_Click(object sender, EventArgs e)
            {

            // Создание переменных и присвоение им значений текстовых полей
            string index, userName, password;
            string query;
            index = textBox3.Text;
            userName = textBox1.Text;
            password = textBox2.Text;


            // Проверка режима работы формы
            if (edit == true)
                {

                // Запрос на редактирование пользователя
                query = "UPDATE [Login Data] SET [Username]='" + userName + "', [Password]='" + password + "' WHERE ([Код]=" + index + ")";
                }
            else
                {

                // Запрос на добавление пользователя
                query = "Insert Into [Login data] ([Username], [Password]) values('" + userName + "', '" + password + "')";
                }

            try
                {

                // Запуск подключения
                connectToDataBase.Open();
                OleDbCommand command = new OleDbCommand(query, connectToDataBase); // Отправка команды в БД
                command.ExecuteNonQuery(); // Команда на запись
                connectToDataBase.Close();
                }
            catch (Exception)
                {

                // Лог в случае ошибки
                Console.WriteLine($"Database error. Info: {this.Name}, {sender}, {query}");
                }

            // Обновление формы Users и закрытие формы добавления/изменения
            Users.formUsers.loadDataFromDataBase();
            this.Close();

            }

        public void loadDataFromUsersEdit(int index, string userName, string password)
            {

            // Получение данных из формы Users на редактирование
            this.Text = "Edit user";
            edit = true;
            textBox3.Text = Convert.ToString(index);
            textBox1.Text = userName;
            textBox2.Text = password;
            Console.WriteLine($"Open UsersEdit. Data: {index} / {userName} / {password}");
            }


        public void loadDataFromUsersAdd(int index)
            {

            // Получение данных из формы Users на добавление
            this.Text = "Add user";
            edit = false;
            textBox3.Text = Convert.ToString(index);
            Console.WriteLine($"Open UsersAdd. Data: {index}");
            }
        }
    }


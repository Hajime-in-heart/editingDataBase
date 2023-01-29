using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Autorization
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        // Глобальные статичные переменные для подключения БД
        public static string pathToDataBase = Application.StartupPath + "/db.accdb";
        public static OleDbConnection connectToDataBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathToDataBase);

        public void loadDataBase(string userName, string password)
            {

            // SQL запрос
            string query = "SELECT [Username], [Password] FROM [Login data] WHERE ([Username]='" + userName + "');";
           
            // Запуск подключения
            connectToDataBase.Open();
            OleDbCommand command = new OleDbCommand(query, connectToDataBase); // Отправка команды в БД
            OleDbDataReader reader = command.ExecuteReader(); // Команда на чтение


            // Переменные для вывода из БД верных данных для входа в программу
            string rightUserName = null, rightPassword = null;


            // Получение данных из БД
            while (reader.Read())
                {
                rightUserName = reader[0].ToString();
                rightPassword = reader[1].ToString();

                // Проверка валидности введенных данных
                if (userName == rightUserName && password == rightPassword)
                    {
                    Form2 newForm = new Form2();
                    newForm.Show();
                    this.Hide();
                    break;
                    }
                }


            // Закрытие подключения
            reader.Close();
            connectToDataBase.Close();


            // Вывод сообщения об ошибке в случае ввода неверных данных
            if (rightUserName == null || password != rightPassword)
                {
                MessageBox.Show("Wrong username / password");
                Console.WriteLine($"Wrong username / password. Info: {this.Name}; " + 
                    $"Entered data: {userName} / {password}; Right data: {rightUserName} / {rightPassword} ");

                }
            }


        // Очистка поля с никнеймом
        private void textBox1_Click(object sender, EventArgs e)
            {
            if (textBox1.Text == "Username")
                {
                textBox1.Clear();
                }
            }


        // Очистка поля с паролем
        private void textBox2_Click(object sender, EventArgs e)
            {
            if (textBox2.Text == "Password")
                {
                textBox2.Clear();
                }
            }


        // Присвоение введенных данных переменным и вызов процедуры авторизации
        private void button1_Click(object sender, EventArgs e)
            {
            string userName = textBox1.Text, password = textBox2.Text;
            loadDataBase(userName, password);
            }

        }
    }

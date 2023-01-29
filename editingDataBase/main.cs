using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization
    {
    public partial class Form2 : Form
        {

        public Form2()
            {
            InitializeComponent();
            }

        // Объявление глобальных переменных
        static public bool mov = false;
        static public int mouseDownX, mouseDownY;
        public static Point temp = new Point();
        public int windowSizeX;
        public int windowSizeY;


        // Завершение работы программы
        private void button1_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        // Кнопка сворачивания
        private void toolStripButton1_Click(object sender, EventArgs e)
            {
            this.WindowState = FormWindowState.Minimized;
            }

        // Кнопка разворачивания на полный экран
        private void toolStripButton2_Click(object sender, EventArgs e)
            {

            if (WindowState == FormWindowState.Maximized)
                {
                this.WindowState = FormWindowState.Normal;
                }
            else
                {
                this.WindowState = FormWindowState.Maximized;
                }
            }

        // Выход из программы
        private void toolStripButton3_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        // Обработка зажатия ЛКМ на верхней панели. Шаг 1 - (перемещение окна)
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                {
                mov = true;
                mouseDownX = e.X;
                mouseDownY = e.Y;
                }
            }

        // Обработка отпускания ЛКМ на верхней панели. Шаг 3 - (перемещение окна)
        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
            {
            mov = false;
            }

        // Вызов новой формы "Пользователи"
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
            {
            editingDataBase.Users mainForm = new editingDataBase.Users();
            mainForm.Show();

            }


        // Обработка перемещения мыши на верхней панели. Шаг 2 - (перемещение окна)
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
            {
            if (mov == true)
                {
                temp.X = this.Location.X + (e.X - mouseDownX);
                temp.Y = this.Location.Y + (e.Y - mouseDownY);
                this.Location = temp;
                }
            }
        }
    }

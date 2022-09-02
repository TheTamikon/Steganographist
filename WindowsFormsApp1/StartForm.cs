using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganographer
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //перемещение окна
        Point lastPoint;
        private void StartForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void StartForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //закрытие программы
        private void MainClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        //вызов главного окна
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();  //скрываем форму запуска
            MainForm main = new MainForm(this); //в конструкторе передаём форму запуска, чтобы при закрытии других форм можно было закрыть форму запуска
            main.Show();
        }

        //вызов окна инструкции
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Hide(); //скрываем форму запуска
            InstructionForm main = new InstructionForm(this); //в конструкторе передаём форму запуска, чтобы при закрытии других форм можно было закрыть форму запуска
            main.Show();
        }
    }
}

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
    public partial class InstructionForm : Form
    {
        public InstructionForm(StartForm SF)
        {
            InitializeComponent();
            this.SF = SF;
        }
        StartForm SF;

        //вызов главного окна
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(SF); //в конструкторе передаём форму запуска, чтобы при закрытии других форм можно было закрыть форму запуска
            main.Show();
            Close();  //закрытие формы
        }

        //с помощью закрытия формы запуска закрываем программу
        private void InstructionClose_Click(object sender, EventArgs e)
        {
            SF.Close();
        }

        //перемещение окна
        Point lastPoint;
        private void InstructionForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void InstructionForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

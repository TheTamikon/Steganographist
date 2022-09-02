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
    public partial class MainForm : Form
    {
        
        public MainForm(StartForm SF)
        {
            InitializeComponent();
            this.SF = SF;  //берём данные из конструктора
            //Выключаем кнопки до тех пор, пока не выбран комбобокс
            MainButton1.Enabled = false;
            MainButton2.Enabled = false;
            
        }
        StartForm SF;

        //вызов окна шифрования
        private void MainButton1_Click(object sender, EventArgs e)
        {
            EncryptForm main = new EncryptForm(this.MainComboBox1.SelectedItem.ToString(),SF); //передаём выбор из комбобокса и форму запуска
            main.Show();
            Close();
        }

        //с помощью закрытия формы запуска закрываем программу
        private void MainClose_Click(object sender, EventArgs e)
        {
            SF.Close();
        }

        //перемещение окна
        Point lastPoint;
        private void Stenographer_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Stenographer_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //включаем кнопки после выбор комбобокса
        private void MainComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainComboBox1.SelectedItem != null)
            {
                MainButton1.Enabled = true;
                MainButton2.Enabled = true;
            } 
        }

        //вызов окна дешифрования
        private void MainButton2_Click(object sender, EventArgs e)
        {
             DecryptForm main = new DecryptForm(this.MainComboBox1.SelectedItem.ToString(), SF); //передаём выбор из комбобокса и форму запуска
            main.Show();
            Close();
        }
    }
}

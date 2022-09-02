using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Steganographer
{ 
    public partial class EncryptForm : Form
    {
        //метод конвертации BitArray в byte[]
        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }
        
        public EncryptForm(string data, StartForm SF) 
        {
            InitializeComponent();
            this.SF = SF;    //берём данные из конструктора
            this.data = data;  //берём данные из конструктора
            EncryptDownload.Enabled = false;  //выключаем кнопку
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);  //добавляем возможность ползоваться кодировкой Windows-1251
        }
        StartForm SF;
        string data;
        
        //загрузка изображения и подсчёт символов
        private void EncryptLoading_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    EncryptDownload.Enabled = true;  //активация кнопки скачать
                    Bitmap image; //Bitmap для открываемого изображения
                    image = new Bitmap(open_dialog.FileName);
                    EncryptPictureBox.Image = image; //помещаем изображение в pictureBox
                    EncryptPictureBox.Invalidate(); 
                    //считаем, сколько можно зашифровать символов
                    if (data == "Стандартный")
                    {
                        //объявляем базовый и вспомогательный цвета
                        Color pixelColor;
                        Color newPixelColor;
                        pixelColor = image.GetPixel(0, 0);  //назначаем базовый цвет
                        if ((image.GetPixel(0, 0).R == 255) || (image.GetPixel(0, 0).G == 255) || (image.GetPixel(0, 0).B == 255)) //исключение для базового цвета
                        {
                            pixelColor = Color.FromArgb(image.GetPixel(0, 0).R - 1, image.GetPixel(0, 0).G - 1, image.GetPixel(0, 0).B - 1);
                        }
                        newPixelColor = Color.FromArgb(image.GetPixel(0, 0).R + 1, image.GetPixel(0, 0).G + 1, image.GetPixel(0, 0).B + 1); //назначаем вспомогательный цвет
                        //подсчёт пикселей базового и вспомогательного цветов
                        int k = 0;
                        for (int i = 0; i < image.Width; i++)
                        {
                            for (int j = 0; j < image.Height; j++)
                            {
                                if ((image.GetPixel(i, j) == pixelColor) || (image.GetPixel(i, j) == newPixelColor))
                                {
                                    k++;
                                }
                            }
                        }
                        //вывод кол-ва символов в label
                        EncryptLabel.Text = "Вы можете спрятать " + (k / 8-2) + " символов";  //-2, т.к. добавим пробелы
                    }
                    if (data == "LSB")
                    {
                        int k = (image.Width * image.Height * 3) / 8 - 3;  //-3, т.к. добавим пробелы
                        EncryptLabel.Text = "Вы можете спрятать " + k + " символов";  //вывод кол-ва символов в label
                    }
                }
                catch
                {
                    //ошибка, если выбран неправильный тип
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //шифрование и соханение изображения
        private void EncryptDownload_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения
            image = new Bitmap(EncryptPictureBox.Image);
            string s = EncryptTextBox.Text.ToString();  //получаем текст из textBox
            if (data == "Стандартный")
            {
                //объявляем базовый и вспомогательный цвета
                Color pixelColor;
                Color newPixelColor;
                pixelColor = image.GetPixel(0, 0);  //назначаем базовый цвет
                if ((image.GetPixel(0, 0).R == 255) || (image.GetPixel(0, 0).G == 255) || (image.GetPixel(0, 0).B == 255)) //исключение для базового цвета
                {
                    pixelColor = Color.FromArgb(image.GetPixel(0, 0).R - 1, image.GetPixel(0, 0).G - 1, image.GetPixel(0, 0).B - 1);
                }
                newPixelColor = Color.FromArgb(image.GetPixel(0, 0).R + 1, image.GetPixel(0, 0).G + 1, image.GetPixel(0, 0).B + 1); //назначаем вспомогательный цвет
                //массив  байтов с сообщением
                byte[] bytes = Encoding.GetEncoding(1251).GetBytes(s+"  ");  //два пробела обозначают конец сообщения
                BitArray bit = new BitArray(bytes); //массив битов с сообщением
                int k = 0;
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        if ((image.GetPixel(i, j) == pixelColor) || (image.GetPixel(i, j) == newPixelColor))
                        {
                            if ((i == 0) && (j == 0)) continue;  //первый пиксель пропускаем, т.к. он необходим для дешифрования
                            if (k < bit.Length)
                            {
                                //в зависимости от бит сообщения меняем цвета пикселей
                                if (bit[k] == true) image.SetPixel(i, j, pixelColor);
                                if (bit[k] == false) image.SetPixel(i, j, newPixelColor);
                                k++;
                            }
                        }
                        if (k == bit.Length) break;
                    }
                    if (k == bit.Length) break;
                }
                EncryptPictureBox.Image = image; //загружаем а pictureBox
            }
            if (data == "LSB")
            {
                //массив  байтов с сообщением
                byte[] bytes = Encoding.GetEncoding(1251).GetBytes(" "+ s + "  ");  //пробел впереди обозначает, что спрятано сообщение, пробелы сзади - что сообщение окончено
                BitArray bit = new BitArray(bytes);  //массив битов с сообщением
                int k = 0;
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color pixelColor = image.GetPixel(i, j);  //берём цвет пикселя
                        BitArray colorR = new BitArray(new byte[] { pixelColor.R });  //бит массив компонента цвета
                        if (k < bit.Length)
                        {   
                            colorR[0] = bit[k];
                            k++;
                        }
                        BitArray colorG = new BitArray(new byte[] { pixelColor.G });  //бит массив компонента цвета
                        if (k < bit.Length)
                        {
                            colorG[0] = bit[k];
                            k++;
                        }
                        BitArray colorB = new BitArray(new byte[] { pixelColor.B });  //бит массив компонента цвета
                        if (k < bit.Length)
                        {
                            colorB[0] = bit[k];
                            k++;
                        }
                        //собираем в байт массив каждого компонента
                        byte bR = BitArrayToByteArray(colorR)[0];
                        byte bG = BitArrayToByteArray(colorG)[0];
                        byte bB = BitArrayToByteArray(colorB)[0];
                        Color newPixelColor = Color.FromArgb(bR, bG, bB); //определяем новый цвет
                        image.SetPixel(i, j, newPixelColor) ;  //перекрашиваем пиксель
                        if (k == bit.Length) break;
                    }
                    if (k == bit.Length) break;
                }
                EncryptPictureBox.Image = image;  //загружаем а pictureBox
            }
            //сохранение изображения
            if (EncryptPictureBox.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG";
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        switch (Path.GetExtension(savedialog.FileName))
                        {
                            case ".BMP":
                                EncryptPictureBox.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            case ".PNG":
                                EncryptPictureBox.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case ".GIF":
                                EncryptPictureBox.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                            default:
                                break;
                        }
                    }
                    catch
                    {
                        //исключение
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //с помощью закрытия формы запуска закрываем программу
        private void EncryptClose_Click(object sender, EventArgs e)
        {
            SF.Close(); 
        }

        //перемещение окна
        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }        
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //убираем исходное сообщение и вводим шифруемое сообщение в textBox
        private void EncryptTextBox_Click(object sender, EventArgs e)
        {
            if (EncryptTextBox.Text == "Введите текст")
            {
                EncryptTextBox.Text = "";
                this.EncryptTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        //вызов главного окна
        private void EncryptBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(SF);   //передаём форму запуска
            main.Show();
            Close();
        }
    }
}

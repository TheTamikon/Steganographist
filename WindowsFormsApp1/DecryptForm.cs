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

namespace Steganographer
{
    public partial class DecryptForm : Form
    {
        //метод конвертации BitArray в byte[]
        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }

        public DecryptForm(string data, StartForm SF)
        {
            InitializeComponent();
            this.SF = SF;//берём данные из конструктора
            DecryptButton.Enabled = false;  //выключаем кнопку
            this.data = data;  //берём данные из конструктора
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);  //добавляем возможность ползоваться кодировкой Windows-1251
        }
        StartForm SF;
        string data;

        //с помощью закрытия формы запуска закрываем программу
        private void DecryptClose_Click(object sender, EventArgs e)
        {
            SF.Close(); 
        }
        
        Bitmap image; //Bitmap для открываемого изображения
        //загрузка изображения
        private void DecryptLoading_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    //помещаем изображение в пикчабокс
                    image = new Bitmap(open_dialog.FileName);
                    DecryptPictureBox.Image = image;
                    DecryptPictureBox.Invalidate();
                    DecryptButton.Enabled = true;
                }
                catch
                {
                    //ошибка, если выбран неправильный тип
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //перемещение окна
        Point lastPoint;
        private void DecryptForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void DecryptForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //дешифрование
        private void DecryptButton_Click(object sender, EventArgs e)
        {
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
                //ищем пробелы и по ним понимаем длину бит массива
                bool[] boolMas = new bool[16]; //создаём bool[] на 16 элементов, чтобы в него помещать последние 16 бит 
                int n = 0;
                int t = 0;
                int size = 0;
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false))
                        {
                            size = t-17;
                            break;
                        }
                        if (n == 16) //смещение
                        {
                            for (int g = 0; g < 15; g++)
                            {
                                boolMas[g] = boolMas[g + 1];
                            }
                            boolMas[15] = true;  //т.к. последний бит "  " - это 0
                            n = 15;
                        }
                        if ((image.GetPixel(i, j) == pixelColor) && (n != 16))
                        {
                            boolMas[n] = true;
                            n++;
                            t++;
                        }
                        if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false))
                        {
                            size = t-17;
                            break;
                        }
                        if (n == 16)  //смещение
                        {
                            for (int g = 0; g < 15; g++)
                            {
                                boolMas[g] = boolMas[g + 1];
                            }
                            boolMas[15] = true;   //т.к. последний бит "  " - это 0
                            n = 15;
                        }
                        if ((image.GetPixel(i, j) == newPixelColor) && (n != 16))
                        {
                            boolMas[n] = false;
                            n++;
                            t++;
                        }

                    }
                    if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false))
                    {
                        size = t-17;
                        break;
                    }
                }
                    //заполнение массива бит сообщения
                    bool[] bit = new bool[size];  
                int r = 0;
                for (int i = 0; i < image.Width; i++)
                {
                    if (r >= size) break;
                    for (int j = 0; j < image.Height; j++)
                    {
                        if ((i == 0) && (j == 0)) continue;
                        if (image.GetPixel(i, j) == pixelColor)
                        {
                            bit[r] = true;
                            r++;
                        }
                        if (image.GetPixel(i, j) == newPixelColor)
                        {
                            bit[r] = false;
                            r++;
                        }
                        if (r >= size) break;
                    }
                }
                //конвертация в byte[]
                BitArray bit1 = new BitArray(bit);
                byte[] bytes = BitArrayToByteArray(bit1);
                if (size == 0) richTextBox1.Text = "В изображении нет сообщения или использовался другой тип шифрования";
                else
                {
                    richTextBox1.Text = Encoding.GetEncoding(1251).GetString(bytes);   //запись в textBox
                    richTextBox1.Enabled = true;  //активация textBox
                }
            }
            if (data == "LSB")
            {
                //смотрим, есть ли пробел в начале
                BitArray controlBit = new BitArray(8);  //BitArray для первых 8 бит
                int k = 0;
                for (int i = 0; i < 3; i++)
                {
                    Color pixelColor = image.GetPixel(0, i);  //берём цвет пикселя
                    BitArray colorR = new BitArray(new byte[] { pixelColor.R });   //бит массив компонента цвета
                    controlBit[k] = colorR[0];
                    k++;
                    BitArray colorG = new BitArray(new byte[] { pixelColor.G });   //бит массив компонента цвета
                    controlBit[k] = colorG[0];
                    k++;
                    if (k < 8)  //условие, чтобы на третей итерации не записывался бит
                    {
                        BitArray colorB = new BitArray(new byte[] { pixelColor.B });   //бит массив компонента цвета
                        controlBit[k] = colorB[0];
                        k++;
                    }
                }
                if (BitArrayToByteArray(controlBit)[0] != 32) richTextBox1.Text = "В изображении нет сообщения или использовался другой тип шифрования";
                else
                {
                    //ищем пробелы и по ним понимаем длину бит массива
                    bool[] boolMas = new bool[16];  //создаём bool[] на 16 элементов, чтобы в него помещать последние 16 бит 
                    int n = 0;
                    int t = 0;
                    for (int i = 0; i < image.Width; i++)
                    {
                        for (int j = 0; j < image.Height; j++)
                        {
                            Color pixelColor = image.GetPixel(i, j);
                            BitArray colorR = new BitArray(new byte[] { pixelColor.R });  //бит массив компонента цвета
                            BitArray colorG = new BitArray(new byte[] { pixelColor.G });  //бит массив компонента цвета
                            BitArray colorB = new BitArray(new byte[] { pixelColor.B });  //бит массив компонента цвета
                            if (n != 16)
                            {
                                boolMas[n] = colorR[0];
                                n++;
                                t++;
                            }
                            if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false)) break;
                            if (n == 16)  //смещение
                            {
                                for (int g = 0; g < 15; g++)
                                {
                                    boolMas[g] = boolMas[g + 1];
                                }
                                boolMas[15] = true;   //т.к. последний бит "  " - это 0
                                n = 15;
                            }
                            if  (n != 16)
                            {
                                boolMas[n] = colorG[0];
                                n++;
                                t++;
                            }
                            if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false)) break;
                            if (n == 16)  //смещение
                            {
                                for (int g = 0; g < 15; g++)
                                {
                                    boolMas[g] = boolMas[g + 1];
                                }
                                boolMas[15] = true;    //т.к. последний бит "  " - это 0
                                n = 15;
                            }
                            if (n != 16)
                            {
                                boolMas[n] = colorB[0];
                                n++;
                                t++;
                            }
                            if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false)) break;
                            if (n == 16)  //смещение
                            {
                                for (int g = 0; g < 15; g++)
                                {
                                    boolMas[g] = boolMas[g + 1];
                                }
                                boolMas[15] = true;   //т.к. последний бит "  " - это 0
                                n = 15;
                            }
                        }
                        if ((boolMas[0] == false) && (boolMas[1] == false) && (boolMas[2] == false) && (boolMas[3] == false) && (boolMas[4] == false) && (boolMas[5] == true) && (boolMas[6] == false) && (boolMas[7] == false) && (boolMas[8] == false) && (boolMas[9] == false) && (boolMas[10] == false) && (boolMas[11] == false) && (boolMas[12] == false) && (boolMas[13] == true) && (boolMas[14] == false) && (boolMas[15] == false)) break;
                    }
                    int size = t - 16;  //длина бит массива сообщения (-16, т.к. пробелы нам не нужны)
                    BitArray message = new BitArray(size);
                    int r = 0;
                    for (int i = 0; i < image.Width; i++)
                    {
                        for (int j = 0; j < image.Height; j++)
                        {
                            Color pixelColor = image.GetPixel(i, j);   //берём цвет пикселя
                            BitArray colorR = new BitArray(new byte[] { pixelColor.R });    //бит массив компонента цвета
                            message[r] = colorR[0];
                            r++;
                            if (r >= size) break;
                            BitArray colorG = new BitArray(new byte[] { pixelColor.G });    //бит массив компонента цвета
                            message[r] = colorG[0];
                            r++;
                            if (r >= size) break;
                            BitArray colorB = new BitArray(new byte[] { pixelColor.B });    //бит массив компонента цвета
                            message[r] = colorB[0];
                            r++;
                            if (r >= size) break;
                        }
                        if (r >= size) break;
                    }
                    //конвертация в byte[]
                    byte[] bytes = BitArrayToByteArray(message);
                    richTextBox1.Text = Encoding.GetEncoding(1251).GetString(bytes,1,bytes.Length-1); //записываем в textBox начиная со второго символа, т.к. первый - пробел
                    richTextBox1.Enabled = true;  //актвация textBox
                }
            }
        }

        //вызов главного окна
        private void DecryptBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(SF);  //передаём форму запуска
            main.Show();
            Close();
        }
    }
}

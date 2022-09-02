namespace Steganographer
{
    partial class InstructionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.InstructionClose = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // InstructionClose
            // 
            this.InstructionClose.AutoSize = true;
            this.InstructionClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            this.InstructionClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstructionClose.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionClose.Location = new System.Drawing.Point(515, -8);
            this.InstructionClose.Name = "InstructionClose";
            this.InstructionClose.Size = new System.Drawing.Size(31, 39);
            this.InstructionClose.TabIndex = 6;
            this.InstructionClose.Text = "x";
            this.InstructionClose.Click += new System.EventHandler(this.InstructionClose_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(220, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "\"Стеганографист\" - это программа для зашифровки тайных сообщений в изображениях, " +
    "а также для их последующем дешифровании.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "В программе присутствуют два типа шифрования:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 69);
            this.label3.TabIndex = 10;
            this.label3.Text = "- стандартный (этот тип шифрования основывается на перекрашивании пикселей цвета " +
    "левого верхнего, поэтому для этого типа лучше использовать изображения с однород" +
    "ным фоном или просто большие)  ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 55);
            this.label4.TabIndex = 11;
            this.label4.Text = "- LSB (этот тип шифрования основывается на перекрашивании пикселей всех цветов, п" +
    "оэтому нет никаких требований к изображениям)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Как спрятать сообщение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(453, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "1. Выбрать тип шифрования и нажать на кнопку \"Зашифровать\".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(516, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "2. Загрузить необходимое изображение и ввести шифруемое сообщение.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(532, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "3. Нажать на кнопку \"Зашифровать...\" и сохранить картинку на компьютер.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(142, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Как расшифровать сообщение:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(24, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(475, 53);
            this.label10.TabIndex = 17;
            this.label10.Text = "1. Выбрать тип шифрования и нажать на кнопку \"Расшифровать\" (если вы не знаете, к" +
    "ак было зашифровано сообщение, то при неверном выборе типа программа скажет вам " +
    "это).";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(24, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "2. Загрузить изображение.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(24, 594);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "3. Нажать на кнопку \"Расшифровать\".";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Steganographer.Properties.Resources.rdg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 90);
            this.panel1.TabIndex = 20;
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(540, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstructionClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructionForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InstructionForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InstructionForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
    }
}
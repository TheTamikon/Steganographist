namespace Steganographer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainComboBox1 = new System.Windows.Forms.ComboBox();
            this.MainButton1 = new System.Windows.Forms.Button();
            this.MainClose = new System.Windows.Forms.Label();
            this.MainButton2 = new System.Windows.Forms.Button();
            this.MainLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainComboBox1
            // 
            this.MainComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainComboBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainComboBox1.FormattingEnabled = true;
            this.MainComboBox1.Items.AddRange(new object[] {
            "Стандартный",
            "LSB"});
            this.MainComboBox1.Location = new System.Drawing.Point(603, 142);
            this.MainComboBox1.Name = "MainComboBox1";
            this.MainComboBox1.Size = new System.Drawing.Size(170, 24);
            this.MainComboBox1.TabIndex = 2;
            this.MainComboBox1.SelectedIndexChanged += new System.EventHandler(this.MainComboBox1_SelectedIndexChanged);
            // 
            // MainButton1
            // 
            this.MainButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainButton1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton1.Location = new System.Drawing.Point(540, 194);
            this.MainButton1.Name = "MainButton1";
            this.MainButton1.Size = new System.Drawing.Size(300, 100);
            this.MainButton1.TabIndex = 3;
            this.MainButton1.Text = "Зашифровать";
            this.MainButton1.UseVisualStyleBackColor = true;
            this.MainButton1.Click += new System.EventHandler(this.MainButton1_Click);
            // 
            // MainClose
            // 
            this.MainClose.AutoSize = true;
            this.MainClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            this.MainClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainClose.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainClose.Location = new System.Drawing.Point(930, -1);
            this.MainClose.Name = "MainClose";
            this.MainClose.Size = new System.Drawing.Size(31, 39);
            this.MainClose.TabIndex = 4;
            this.MainClose.Text = "x";
            this.MainClose.Click += new System.EventHandler(this.MainClose_Click);
            // 
            // MainButton2
            // 
            this.MainButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainButton2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton2.Location = new System.Drawing.Point(540, 311);
            this.MainButton2.Name = "MainButton2";
            this.MainButton2.Size = new System.Drawing.Size(300, 100);
            this.MainButton2.TabIndex = 5;
            this.MainButton2.Text = "Расшифровать";
            this.MainButton2.UseVisualStyleBackColor = true;
            this.MainButton2.Click += new System.EventHandler(this.MainButton2_Click);
            // 
            // MainLabel1
            // 
            this.MainLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            this.MainLabel1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainLabel1.Location = new System.Drawing.Point(415, 47);
            this.MainLabel1.Name = "MainLabel1";
            this.MainLabel1.Size = new System.Drawing.Size(546, 75);
            this.MainLabel1.TabIndex = 1;
            this.MainLabel1.Text = "Выберите тип шифрования:";
            this.MainLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Steganographer.Properties.Resources.ФОООН;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.MainButton2);
            this.Controls.Add(this.MainClose);
            this.Controls.Add(this.MainButton1);
            this.Controls.Add(this.MainComboBox1);
            this.Controls.Add(this.MainLabel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стеганографист";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stenographer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Stenographer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox MainComboBox1;
        private System.Windows.Forms.Button MainButton1;
        private System.Windows.Forms.Label MainClose;
        private System.Windows.Forms.Button MainButton2;
        private System.Windows.Forms.Label MainLabel1;
    }
}


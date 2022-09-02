namespace Steganographer
{
    partial class EncryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptForm));
            this.EncryptLoading = new System.Windows.Forms.Button();
            this.EncryptDownload = new System.Windows.Forms.Button();
            this.EncryptClose = new System.Windows.Forms.Label();
            this.EncryptLabel = new System.Windows.Forms.Label();
            this.EncryptTextBox = new System.Windows.Forms.RichTextBox();
            this.EncryptBack = new System.Windows.Forms.Panel();
            this.EncryptPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptLoading
            // 
            this.EncryptLoading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptLoading.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptLoading.Location = new System.Drawing.Point(52, 34);
            this.EncryptLoading.Name = "EncryptLoading";
            this.EncryptLoading.Size = new System.Drawing.Size(350, 30);
            this.EncryptLoading.TabIndex = 1;
            this.EncryptLoading.Text = "Нажмите, чтобы выбрать изображение";
            this.EncryptLoading.UseVisualStyleBackColor = true;
            this.EncryptLoading.Click += new System.EventHandler(this.EncryptLoading_Click);
            // 
            // EncryptDownload
            // 
            this.EncryptDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptDownload.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptDownload.Location = new System.Drawing.Point(710, 439);
            this.EncryptDownload.Name = "EncryptDownload";
            this.EncryptDownload.Size = new System.Drawing.Size(200, 32);
            this.EncryptDownload.TabIndex = 4;
            this.EncryptDownload.Text = "Зашифровать и скачать";
            this.EncryptDownload.UseVisualStyleBackColor = true;
            this.EncryptDownload.Click += new System.EventHandler(this.EncryptDownload_Click);
            // 
            // EncryptClose
            // 
            this.EncryptClose.AutoSize = true;
            this.EncryptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptClose.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptClose.Location = new System.Drawing.Point(930, 0);
            this.EncryptClose.Name = "EncryptClose";
            this.EncryptClose.Size = new System.Drawing.Size(31, 39);
            this.EncryptClose.TabIndex = 5;
            this.EncryptClose.Text = "x";
            this.EncryptClose.Click += new System.EventHandler(this.EncryptClose_Click);
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptLabel.Location = new System.Drawing.Point(534, 53);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(338, 103);
            this.EncryptLabel.TabIndex = 2;
            this.EncryptLabel.Text = "Вы можете спрятать 0 символов";
            this.EncryptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EncryptTextBox.Location = new System.Drawing.Point(490, 204);
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(420, 200);
            this.EncryptTextBox.TabIndex = 6;
            this.EncryptTextBox.Text = "Введите текст";
            this.EncryptTextBox.Click += new System.EventHandler(this.EncryptTextBox_Click);
            // 
            // EncryptBack
            // 
            this.EncryptBack.BackgroundImage = global::Steganographer.Properties.Resources._120826;
            this.EncryptBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EncryptBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptBack.Location = new System.Drawing.Point(12, 12);
            this.EncryptBack.Name = "EncryptBack";
            this.EncryptBack.Size = new System.Drawing.Size(35, 30);
            this.EncryptBack.TabIndex = 7;
            this.EncryptBack.Click += new System.EventHandler(this.EncryptBack_Click);
            // 
            // EncryptPictureBox
            // 
            this.EncryptPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.EncryptPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EncryptPictureBox.Location = new System.Drawing.Point(52, 94);
            this.EncryptPictureBox.Name = "EncryptPictureBox";
            this.EncryptPictureBox.Size = new System.Drawing.Size(350, 400);
            this.EncryptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EncryptPictureBox.TabIndex = 0;
            this.EncryptPictureBox.TabStop = false;
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.EncryptBack);
            this.Controls.Add(this.EncryptTextBox);
            this.Controls.Add(this.EncryptClose);
            this.Controls.Add(this.EncryptDownload);
            this.Controls.Add(this.EncryptLabel);
            this.Controls.Add(this.EncryptLoading);
            this.Controls.Add(this.EncryptPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.EncryptPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EncryptPictureBox;
        private System.Windows.Forms.Button EncryptLoading;
        private System.Windows.Forms.Button EncryptDownload;
        private System.Windows.Forms.Label EncryptClose;
        private System.Windows.Forms.Label EncryptLabel;
        private System.Windows.Forms.RichTextBox EncryptTextBox;
        private System.Windows.Forms.Panel EncryptBack;
    }
}
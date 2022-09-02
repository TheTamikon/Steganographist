namespace Steganographer
{
    partial class DecryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptForm));
            this.DecryptClose = new System.Windows.Forms.Label();
            this.DecryptLoading = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DecryptBack = new System.Windows.Forms.Panel();
            this.DecryptPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DecryptClose
            // 
            this.DecryptClose.AutoSize = true;
            this.DecryptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptClose.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptClose.Location = new System.Drawing.Point(930, -1);
            this.DecryptClose.Name = "DecryptClose";
            this.DecryptClose.Size = new System.Drawing.Size(31, 39);
            this.DecryptClose.TabIndex = 5;
            this.DecryptClose.Text = "x";
            this.DecryptClose.Click += new System.EventHandler(this.DecryptClose_Click);
            // 
            // DecryptLoading
            // 
            this.DecryptLoading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptLoading.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptLoading.Location = new System.Drawing.Point(51, 34);
            this.DecryptLoading.Name = "DecryptLoading";
            this.DecryptLoading.Size = new System.Drawing.Size(350, 30);
            this.DecryptLoading.TabIndex = 7;
            this.DecryptLoading.Text = "Нажмите, чтобы выбрать изображение";
            this.DecryptLoading.UseVisualStyleBackColor = true;
            this.DecryptLoading.Click += new System.EventHandler(this.DecryptLoading_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptButton.Location = new System.Drawing.Point(720, 435);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(200, 32);
            this.DecryptButton.TabIndex = 8;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(520, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(400, 300);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // DecryptBack
            // 
            this.DecryptBack.BackgroundImage = global::Steganographer.Properties.Resources._120826;
            this.DecryptBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecryptBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptBack.Location = new System.Drawing.Point(12, 12);
            this.DecryptBack.Name = "DecryptBack";
            this.DecryptBack.Size = new System.Drawing.Size(35, 30);
            this.DecryptBack.TabIndex = 10;
            this.DecryptBack.Click += new System.EventHandler(this.DecryptBack_Click);
            // 
            // DecryptPictureBox
            // 
            this.DecryptPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.DecryptPictureBox.Location = new System.Drawing.Point(51, 95);
            this.DecryptPictureBox.Name = "DecryptPictureBox";
            this.DecryptPictureBox.Size = new System.Drawing.Size(350, 400);
            this.DecryptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DecryptPictureBox.TabIndex = 6;
            this.DecryptPictureBox.TabStop = false;
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.DecryptBack);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DecryptLoading);
            this.Controls.Add(this.DecryptPictureBox);
            this.Controls.Add(this.DecryptClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DecryptForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DecryptForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DecryptPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label DecryptClose;
    private System.Windows.Forms.PictureBox DecryptPictureBox;
    private System.Windows.Forms.Button DecryptLoading;
    private System.Windows.Forms.Button DecryptButton;
    private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel DecryptBack;
    }
}
namespace AbstractOverrideSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonAbstract = new Button();
            richTextBox1 = new RichTextBox();
            ButtonDebug = new Button();
            textBox1 = new TextBox();
            ButtonRelease = new Button();
            SuspendLayout();
            // 
            // ButtonAbstract
            // 
            ButtonAbstract.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAbstract.Location = new Point(28, 99);
            ButtonAbstract.Name = "ButtonAbstract";
            ButtonAbstract.Size = new Size(141, 67);
            ButtonAbstract.TabIndex = 0;
            ButtonAbstract.Text = "Build Abstract Model";
            ButtonAbstract.UseVisualStyleBackColor = true;
            ButtonAbstract.Click += ButtonAbstract_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(232, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(535, 350);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // ButtonDebug
            // 
            ButtonDebug.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDebug.Location = new Point(28, 206);
            ButtonDebug.Name = "ButtonDebug";
            ButtonDebug.Size = new Size(141, 67);
            ButtonDebug.TabIndex = 2;
            ButtonDebug.Text = "Build Debug Mode Model";
            ButtonDebug.UseVisualStyleBackColor = true;
            ButtonDebug.Click += ButtonDebug_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(28, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(739, 61);
            textBox1.TabIndex = 3;
            textBox1.Text = "程式情境是一個出貨程式。正式版只會產出當日、ID 為 D 開頭、價格在 10000 NTD$ 以上、編號為 P 開頭的資料\r\n測試環境需要追溯資料，因此根據不同條件調整，例如指定出貨時間、指定貨物 ID、指定貨物編號等等\r\n實際運行會用諸如電腦 IP 等條件控制測試／正式環境，此處由對應按鈕替代\r\n";
            // 
            // ButtonRelease
            // 
            ButtonRelease.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRelease.Location = new Point(28, 322);
            ButtonRelease.Name = "ButtonRelease";
            ButtonRelease.Size = new Size(141, 67);
            ButtonRelease.TabIndex = 4;
            ButtonRelease.Text = "Build Release Mode Model";
            ButtonRelease.UseVisualStyleBackColor = true;
            ButtonRelease.Click += ButtonRelease_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(ButtonRelease);
            Controls.Add(textBox1);
            Controls.Add(ButtonDebug);
            Controls.Add(richTextBox1);
            Controls.Add(ButtonAbstract);
            Name = "Form1";
            Text = "Abstract_Override_Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAbstract;
        private RichTextBox richTextBox1;
        private Button ButtonDebug;
        private TextBox textBox1;
        private Button ButtonRelease;
    }
}
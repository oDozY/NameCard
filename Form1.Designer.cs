namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 355);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 40F);
            textBox1.Location = new Point(298, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 71);
            textBox1.TabIndex = 1;
            textBox1.Text = "이호준";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("한컴 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox2.Location = new Point(298, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 36);
            textBox2.TabIndex = 2;
            textBox2.Text = "수원대 컴퓨터sw학과";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("한컴 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox3.Location = new Point(298, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 26);
            textBox3.TabIndex = 3;
            textBox3.Text = "odozy@naver.com";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveBorder;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("맑은 고딕", 15F);
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(298, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(314, 27);
            textBox4.TabIndex = 4;
            textBox4.Text = "010-4191-2819";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 30F);
            button1.Location = new Point(298, 337);
            button1.Name = "button1";
            button1.Size = new Size(308, 86);
            button1.TabIndex = 5;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}

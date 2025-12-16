namespace WinFormsApp5
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
            Full_Name = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Full_Name
            // 
            Full_Name.AutoSize = true;
            Full_Name.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Full_Name.Location = new Point(84, 92);
            Full_Name.Margin = new Padding(4, 0, 4, 0);
            Full_Name.Name = "Full_Name";
            Full_Name.Size = new Size(92, 18);
            Full_Name.TabIndex = 0;
            Full_Name.Text = "Student ID";
            Full_Name.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 166);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 207);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 3;
            label1.Text = "Department";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 158);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 26);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 126);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 26);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 248);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(204, 89);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 26);
            textBox4.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(204, 199);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 26);
            textBox6.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(42, 287);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(134, 50);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 287);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(134, 50);
            button2.TabIndex = 13;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(395, 287);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(134, 50);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Moccasin;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(371, 345);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-1, 359);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(335, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Brush Script MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(142, 7);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(407, 59);
            label5.TabIndex = 17;
            label5.Text = "Welcom Back to School";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(204, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 26);
            textBox3.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(422, 69);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(351, 198);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(586, 273);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(269, 218);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(204, 359);
            button4.Name = "button4";
            button4.Size = new Size(172, 51);
            button4.TabIndex = 21;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(717, 174);
            button5.Name = "button5";
            button5.Size = new Size(98, 51);
            button5.TabIndex = 22;
            button5.Text = "search";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(843, 528);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Full_Name);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Full_Name;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button5;
    }
}

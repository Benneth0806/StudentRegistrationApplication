namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(112, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(459, 50);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(69, 102);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(67, 162);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(67, 229);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 3;
            label4.Text = "Middle Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(147, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 29);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Azure;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(147, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 29);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Azure;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(147, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 29);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(66, 293);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 7;
            label5.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(64, 341);
            label8.Name = "label8";
            label8.Size = new Size(114, 21);
            label8.TabIndex = 10;
            label8.Text = " Date Of Birth:";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(147, 416);
            button1.Name = "button1";
            button1.Size = new Size(245, 95);
            button1.TabIndex = 11;
            button1.Text = "Register Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Azure;
            radioButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton1.Location = new Point(147, 293);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 25);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Azure;
            radioButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton2.Location = new Point(217, 293);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 25);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Azure;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 365);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(60, 29);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Azure;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 365);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(60, 29);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.Azure;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(237, 365);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(60, 29);
            comboBox3.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(709, 523);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label8;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}
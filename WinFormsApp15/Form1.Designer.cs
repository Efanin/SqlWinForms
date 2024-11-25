namespace WinFormsApp15
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            comboBox2 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            comboBox3 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(208, 216);
            button1.Name = "button1";
            button1.Size = new Size(73, 23);
            button1.TabIndex = 2;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(311, 68);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 3;
            label1.Text = "Пусто";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox2.Location = new Point(208, 176);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(73, 23);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "1";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(24, 176);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(24, 68);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(257, 23);
            comboBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(24, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 7;
            label2.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(24, 94);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 8;
            label3.Text = "Деталь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(208, 148);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 9;
            label4.Text = "Кол-во";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(84, 148);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 10;
            label5.Text = "Дата";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(311, 9);
            label6.Name = "label6";
            label6.Size = new Size(184, 30);
            label6.TabIndex = 11;
            label6.Text = "Новая продажа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 353);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox3);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox2;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

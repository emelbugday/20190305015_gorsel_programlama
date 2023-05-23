namespace _20190305015_EMEL_BUGDAY_CINEMA
{
    partial class Form2
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaptionText;
            textBox3.ForeColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(165, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaptionText;
            textBox4.ForeColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(165, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 23);
            textBox4.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ActiveCaptionText;
            comboBox2.ForeColor = SystemColors.ButtonHighlight;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Action", "Fantasy", "Horror", "Comedy", "Romantic" });
            comboBox2.Location = new Point(165, 181);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(165, 258);
            button2.Name = "button2";
            button2.Size = new Size(140, 28);
            button2.TabIndex = 10;
            button2.Text = "Add Movie";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(52, 220);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 9;
            label4.Text = "Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(52, 182);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 8;
            label5.Text = "Movie Genre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(52, 147);
            label6.Name = "label6";
            label6.Size = new Size(102, 17);
            label6.TabIndex = 7;
            label6.Text = "Movie Name:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.movie;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(666, 431);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Name = "Form2";
            Text = "Add Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
namespace Ticket_Ease
{
    partial class AddConcertLocationDetailsAdmin
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
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            UpdateBtn = new Button();
            ConnectionTestBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(107, 122);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Select concert:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(107, 243);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Select Venue:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(217, 348);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(107, 351);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "Select Time:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(218, 119);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 8;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.MenuHighlight;
            UpdateBtn.Location = new Point(431, 430);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(164, 29);
            UpdateBtn.TabIndex = 29;
            UpdateBtn.Text = "Update Concert";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // ConnectionTestBtn
            // 
            ConnectionTestBtn.BackColor = SystemColors.MenuHighlight;
            ConnectionTestBtn.Location = new Point(695, 468);
            ConnectionTestBtn.Name = "ConnectionTestBtn";
            ConnectionTestBtn.Size = new Size(164, 29);
            ConnectionTestBtn.TabIndex = 30;
            ConnectionTestBtn.Text = "ConnectionTest";
            ConnectionTestBtn.UseVisualStyleBackColor = false;
            // 
            // AddConcertLocationDetailsAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 509);
            Controls.Add(ConnectionTestBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AddConcertLocationDetailsAdmin";
            Text = "AddConcertLocationDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Button UpdateBtn;
        private Button ConnectionTestBtn;
    }
}
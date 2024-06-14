namespace Ticket_Ease
{
    partial class ConcertDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcertDetailsForm));
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            BuyTicket_btn = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(218, 45);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(590, 28);
            comboBox2.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BuyTicket_btn);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 119);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1031, 575);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // BuyTicket_btn
            // 
            BuyTicket_btn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BuyTicket_btn.Location = new Point(905, 492);
            BuyTicket_btn.Margin = new Padding(3, 4, 3, 4);
            BuyTicket_btn.Name = "BuyTicket_btn";
            BuyTicket_btn.Size = new Size(86, 51);
            BuyTicket_btn.TabIndex = 7;
            BuyTicket_btn.Text = "BUY TICKET";
            BuyTicket_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(40, 327);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(814, 240);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(545, 47);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 248);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 153);
            label5.Name = "label5";
            label5.Size = new Size(161, 22);
            label5.TabIndex = 4;
            label5.Text = "Concert Date and Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 100);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 3;
            label4.Text = "Concert ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 272);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 2;
            label3.Text = "Performer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 208);
            label2.Name = "label2";
            label2.Size = new Size(108, 22);
            label2.TabIndex = 1;
            label2.Text = "Concert Venue:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 0;
            label1.Text = "Concert Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(104, 48);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 11;
            label6.Text = "List of concerts:";
            // 
            // ConcertDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 709);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConcertDetailsForm";
            Text = "AddConcertForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BuyTicket_btn;
        private GroupBox groupBox2;
        private Label label6;
    }
}
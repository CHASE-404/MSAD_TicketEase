namespace Ticket_Ease
{
    partial class ConcertDetailsFormAdminn
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
            ConID_txtbx = new TextBox();
            PerformerTbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CONSD_dateTimePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            Venuetbx = new TextBox();
            PosterUrlBtn = new Button();
            Contitle_txtbx = new TextBox();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ConcertDetailcomboBox = new ComboBox();
            label8 = new Label();
            UpdateBtn = new Button();
            label9 = new Label();
            Timetxbx = new TextBox();
            ConcertPicbx = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ConcertPicbx).BeginInit();
            SuspendLayout();
            // 
            // ConID_txtbx
            // 
            ConID_txtbx.Location = new Point(142, 213);
            ConID_txtbx.Name = "ConID_txtbx";
            ConID_txtbx.Size = new Size(333, 27);
            ConID_txtbx.TabIndex = 3;
            // 
            // PerformerTbx
            // 
            PerformerTbx.Location = new Point(142, 261);
            PerformerTbx.Name = "PerformerTbx";
            PerformerTbx.Size = new Size(333, 27);
            PerformerTbx.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(356, 77);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 6;
            label1.Text = "ADMIN ADD / REMOVE  / UPDATE CONCERT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 162);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 8;
            label2.Text = "Concert Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 213);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 9;
            label3.Text = "Concert ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(40, 264);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 10;
            label4.Text = "Performer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(545, 162);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 11;
            label5.Text = "Scheduled Date:";
            // 
            // CONSD_dateTimePicker
            // 
            CONSD_dateTimePicker.Location = new Point(668, 159);
            CONSD_dateTimePicker.Name = "CONSD_dateTimePicker";
            CONSD_dateTimePicker.Size = new Size(256, 27);
            CONSD_dateTimePicker.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(545, 306);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "Poster";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Info;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(545, 213);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Venue";
            // 
            // Venuetbx
            // 
            Venuetbx.Location = new Point(668, 213);
            Venuetbx.Name = "Venuetbx";
            Venuetbx.Size = new Size(312, 27);
            Venuetbx.TabIndex = 15;
            // 
            // PosterUrlBtn
            // 
            PosterUrlBtn.BackColor = SystemColors.MenuHighlight;
            PosterUrlBtn.Location = new Point(668, 441);
            PosterUrlBtn.Name = "PosterUrlBtn";
            PosterUrlBtn.Size = new Size(164, 29);
            PosterUrlBtn.TabIndex = 20;
            PosterUrlBtn.Text = "Open Poster";
            PosterUrlBtn.UseVisualStyleBackColor = false;
            PosterUrlBtn.Click += PosterUrlBtn_Click;
            // 
            // Contitle_txtbx
            // 
            Contitle_txtbx.Location = new Point(142, 159);
            Contitle_txtbx.Name = "Contitle_txtbx";
            Contitle_txtbx.Size = new Size(333, 27);
            Contitle_txtbx.TabIndex = 22;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.MenuHighlight;
            DeleteBtn.Location = new Point(232, 441);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(164, 29);
            DeleteBtn.TabIndex = 24;
            DeleteBtn.Text = "Delete Concert";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.MenuHighlight;
            SaveBtn.Location = new Point(40, 441);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(164, 29);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Add Concert";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ConcertDetailcomboBox
            // 
            ConcertDetailcomboBox.FormattingEnabled = true;
            ConcertDetailcomboBox.Location = new Point(40, 354);
            ConcertDetailcomboBox.Name = "ConcertDetailcomboBox";
            ConcertDetailcomboBox.Size = new Size(179, 28);
            ConcertDetailcomboBox.TabIndex = 26;
            ConcertDetailcomboBox.Text = "Choose Concert Title";
            ConcertDetailcomboBox.SelectedIndexChanged += ConcertDetailcomboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Info;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(42, 310);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 27;
            label8.Text = "Select Concert:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.MenuHighlight;
            UpdateBtn.Location = new Point(414, 441);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(164, 29);
            UpdateBtn.TabIndex = 28;
            UpdateBtn.Text = "Update Concert";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Info;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(545, 261);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 29;
            label9.Text = "Time:";
            // 
            // Timetxbx
            // 
            Timetxbx.Location = new Point(668, 261);
            Timetxbx.Name = "Timetxbx";
            Timetxbx.Size = new Size(312, 27);
            Timetxbx.TabIndex = 30;
            // 
            // ConcertPicbx
            // 
            ConcertPicbx.BackgroundImageLayout = ImageLayout.Stretch;
            ConcertPicbx.Location = new Point(668, 306);
            ConcertPicbx.Name = "ConcertPicbx";
            ConcertPicbx.Size = new Size(312, 129);
            ConcertPicbx.TabIndex = 31;
            ConcertPicbx.TabStop = false;
            // 
            // ConcertDetailsFormAdminn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1013, 495);
            Controls.Add(ConcertPicbx);
            Controls.Add(Timetxbx);
            Controls.Add(label9);
            Controls.Add(UpdateBtn);
            Controls.Add(label8);
            Controls.Add(ConcertDetailcomboBox);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(Contitle_txtbx);
            Controls.Add(PosterUrlBtn);
            Controls.Add(Venuetbx);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(CONSD_dateTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PerformerTbx);
            Controls.Add(ConID_txtbx);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "ConcertDetailsFormAdminn";
            Text = "AddConcert";
            Load += AddRemoveConcert_Load;
            ((System.ComponentModel.ISupportInitialize)ConcertPicbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ConID_txtbx;
        private TextBox PerformerTbx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker CONSD_dateTimePicker;
        private Label label6;
        private Label label7;
        private TextBox Venuetbx;
        private Button PosterUrlBtn;
        private TextBox Contitle_txtbx;
        private Button DeleteBtn;
        private Button SaveBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ComboBox ConcertDetailcomboBox;
        private Label label8;
        private Button UpdateBtn;
        private Label label9;
        private TextBox Timetxbx;
        private PictureBox ConcertPicbx;
    }
}
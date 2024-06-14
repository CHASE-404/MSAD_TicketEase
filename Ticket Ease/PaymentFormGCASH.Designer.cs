namespace Ticket_Ease
{
    partial class PaymentFormGCASH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentFormGCASH));
            RETURNbtn = new Button();
            GCASHBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            CreditCardBtn = new Button();
            PAYbtn = new Button();
            Paytxtbx = new TextBox();
            Paymenttxtbx = new TextBox();
            MobileNumtxtbx = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // RETURNbtn
            // 
            RETURNbtn.ForeColor = Color.Black;
            RETURNbtn.Location = new Point(50, 349);
            RETURNbtn.Margin = new Padding(3, 4, 3, 4);
            RETURNbtn.Name = "RETURNbtn";
            RETURNbtn.Size = new Size(76, 31);
            RETURNbtn.TabIndex = 23;
            RETURNbtn.Text = "RETURN";
            RETURNbtn.UseVisualStyleBackColor = true;
            RETURNbtn.Click += RETURNbtn_Click;
            // 
            // GCASHBtn
            // 
            GCASHBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GCASHBtn.BackColor = Color.Transparent;
            GCASHBtn.FlatStyle = FlatStyle.Flat;
            GCASHBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GCASHBtn.ImageAlign = ContentAlignment.MiddleRight;
            GCASHBtn.Location = new Point(247, 56);
            GCASHBtn.Margin = new Padding(3, 4, 3, 4);
            GCASHBtn.Name = "GCASHBtn";
            GCASHBtn.Size = new Size(87, 55);
            GCASHBtn.TabIndex = 21;
            GCASHBtn.Text = "GCash";
            GCASHBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(184, 56);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 55);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(52, 56);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 55);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // CreditCardBtn
            // 
            CreditCardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreditCardBtn.BackColor = Color.Transparent;
            CreditCardBtn.FlatStyle = FlatStyle.Flat;
            CreditCardBtn.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreditCardBtn.ImageAlign = ContentAlignment.MiddleRight;
            CreditCardBtn.Location = new Point(84, 56);
            CreditCardBtn.Margin = new Padding(3, 4, 3, 4);
            CreditCardBtn.Name = "CreditCardBtn";
            CreditCardBtn.Size = new Size(87, 55);
            CreditCardBtn.TabIndex = 19;
            CreditCardBtn.Text = "CREDIT CARD";
            CreditCardBtn.TextAlign = ContentAlignment.MiddleRight;
            CreditCardBtn.UseVisualStyleBackColor = false;
            CreditCardBtn.Click += CreditCardBtn_Click;
            // 
            // PAYbtn
            // 
            PAYbtn.Location = new Point(256, 349);
            PAYbtn.Margin = new Padding(3, 4, 3, 4);
            PAYbtn.Name = "PAYbtn";
            PAYbtn.Size = new Size(78, 31);
            PAYbtn.TabIndex = 17;
            PAYbtn.Text = "PAY";
            PAYbtn.UseVisualStyleBackColor = true;
            PAYbtn.Click += PAYbtn_Click;
            // 
            // Paytxtbx
            // 
            Paytxtbx.BackColor = SystemColors.Control;
            Paytxtbx.Location = new Point(161, 263);
            Paytxtbx.Margin = new Padding(3, 4, 3, 4);
            Paytxtbx.Name = "Paytxtbx";
            Paytxtbx.Size = new Size(172, 27);
            Paytxtbx.TabIndex = 16;
            // 
            // Paymenttxtbx
            // 
            Paymenttxtbx.BackColor = SystemColors.Control;
            Paymenttxtbx.Location = new Point(50, 206);
            Paymenttxtbx.Margin = new Padding(3, 4, 3, 4);
            Paymenttxtbx.Name = "Paymenttxtbx";
            Paymenttxtbx.Size = new Size(283, 27);
            Paymenttxtbx.TabIndex = 15;
            Paymenttxtbx.Text = "Payment:";
            // 
            // MobileNumtxtbx
            // 
            MobileNumtxtbx.BackColor = SystemColors.Control;
            MobileNumtxtbx.Location = new Point(50, 148);
            MobileNumtxtbx.Margin = new Padding(3, 4, 3, 4);
            MobileNumtxtbx.Name = "MobileNumtxtbx";
            MobileNumtxtbx.Size = new Size(283, 27);
            MobileNumtxtbx.TabIndex = 13;
            MobileNumtxtbx.Text = "Mobile Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 266);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 24;
            label1.Text = "Total Payment:";
            // 
            // PaymentFormGCASH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 437);
            Controls.Add(label1);
            Controls.Add(RETURNbtn);
            Controls.Add(GCASHBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(CreditCardBtn);
            Controls.Add(PAYbtn);
            Controls.Add(Paytxtbx);
            Controls.Add(Paymenttxtbx);
            Controls.Add(MobileNumtxtbx);
            DoubleBuffered = true;
            Name = "PaymentFormGCASH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentFormGCASH_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RETURNbtn;
        private Button GCASHBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button CreditCardBtn;
        private Button PAYbtn;
        private TextBox Paytxtbx;
        private TextBox Paymenttxtbx;
        private TextBox MobileNumtxtbx;
        private Label label1;
    }
}
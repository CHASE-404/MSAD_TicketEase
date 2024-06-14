namespace Ticket_Ease
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            CardNumtxtbx = new TextBox();
            CWtxtbx = new TextBox();
            CardholderNametxtbx = new TextBox();
            Expirytxtbx = new TextBox();
            PayBtn = new Button();
            pictureBox1 = new PictureBox();
            CreditCardBtn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            GCASHBtn = new Button();
            ReturnBtn = new Button();
            label1 = new Label();
            Paytxtbx = new TextBox();
            Paymenttxtbx = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // CardNumtxtbx
            // 
            CardNumtxtbx.BackColor = SystemColors.Control;
            CardNumtxtbx.Location = new Point(53, 122);
            CardNumtxtbx.Margin = new Padding(3, 4, 3, 4);
            CardNumtxtbx.Name = "CardNumtxtbx";
            CardNumtxtbx.Size = new Size(283, 27);
            CardNumtxtbx.TabIndex = 0;
            CardNumtxtbx.Text = "Card Number";
            // 
            // CWtxtbx
            // 
            CWtxtbx.BackColor = SystemColors.Control;
            CWtxtbx.Location = new Point(257, 267);
            CWtxtbx.Margin = new Padding(3, 4, 3, 4);
            CWtxtbx.Name = "CWtxtbx";
            CWtxtbx.Size = new Size(77, 27);
            CWtxtbx.TabIndex = 1;
            CWtxtbx.Text = "CVV";
            // 
            // CardholderNametxtbx
            // 
            CardholderNametxtbx.BackColor = SystemColors.Control;
            CardholderNametxtbx.Location = new Point(53, 168);
            CardholderNametxtbx.Margin = new Padding(3, 4, 3, 4);
            CardholderNametxtbx.Name = "CardholderNametxtbx";
            CardholderNametxtbx.Size = new Size(283, 27);
            CardholderNametxtbx.TabIndex = 2;
            CardholderNametxtbx.Text = "Cardholder Name";
            // 
            // Expirytxtbx
            // 
            Expirytxtbx.BackColor = SystemColors.Control;
            Expirytxtbx.Location = new Point(51, 267);
            Expirytxtbx.Margin = new Padding(3, 4, 3, 4);
            Expirytxtbx.Name = "Expirytxtbx";
            Expirytxtbx.Size = new Size(119, 27);
            Expirytxtbx.TabIndex = 3;
            Expirytxtbx.Text = "Expiry (MM/YY)";
            // 
            // PayBtn
            // 
            PayBtn.Location = new Point(257, 352);
            PayBtn.Margin = new Padding(3, 4, 3, 4);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(78, 31);
            PayBtn.TabIndex = 4;
            PayBtn.Text = "PAY";
            PayBtn.UseVisualStyleBackColor = true;
            PayBtn.Click += PayBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(225, 267);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 31);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CreditCardBtn
            // 
            CreditCardBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreditCardBtn.BackColor = Color.Transparent;
            CreditCardBtn.FlatStyle = FlatStyle.Flat;
            CreditCardBtn.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreditCardBtn.ImageAlign = ContentAlignment.MiddleRight;
            CreditCardBtn.Location = new Point(85, 59);
            CreditCardBtn.Margin = new Padding(3, 4, 3, 4);
            CreditCardBtn.Name = "CreditCardBtn";
            CreditCardBtn.Size = new Size(87, 55);
            CreditCardBtn.TabIndex = 8;
            CreditCardBtn.Text = "CREDIT CARD";
            CreditCardBtn.TextAlign = ContentAlignment.MiddleRight;
            CreditCardBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(53, 59);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 55);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(185, 59);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 55);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // GCASHBtn
            // 
            GCASHBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GCASHBtn.BackColor = Color.Transparent;
            GCASHBtn.FlatStyle = FlatStyle.Flat;
            GCASHBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GCASHBtn.ImageAlign = ContentAlignment.MiddleRight;
            GCASHBtn.Location = new Point(248, 59);
            GCASHBtn.Margin = new Padding(3, 4, 3, 4);
            GCASHBtn.Name = "GCASHBtn";
            GCASHBtn.Size = new Size(87, 55);
            GCASHBtn.TabIndex = 10;
            GCASHBtn.Text = "GCash";
            GCASHBtn.UseVisualStyleBackColor = false;
            GCASHBtn.Click += GCASHBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.ForeColor = Color.Black;
            ReturnBtn.Location = new Point(51, 352);
            ReturnBtn.Margin = new Padding(3, 4, 3, 4);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(76, 31);
            ReturnBtn.TabIndex = 12;
            ReturnBtn.Text = "RETURN";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 312);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 26;
            label1.Text = "Total Payment:";
            // 
            // Paytxtbx
            // 
            Paytxtbx.BackColor = SystemColors.Control;
            Paytxtbx.Location = new Point(162, 309);
            Paytxtbx.Margin = new Padding(3, 4, 3, 4);
            Paytxtbx.Name = "Paytxtbx";
            Paytxtbx.Size = new Size(172, 27);
            Paytxtbx.TabIndex = 25;
            // 
            // Paymenttxtbx
            // 
            Paymenttxtbx.BackColor = SystemColors.Control;
            Paymenttxtbx.Location = new Point(51, 216);
            Paymenttxtbx.Margin = new Padding(3, 4, 3, 4);
            Paymenttxtbx.Name = "Paymenttxtbx";
            Paymenttxtbx.Size = new Size(283, 27);
            Paymenttxtbx.TabIndex = 27;
            Paymenttxtbx.Text = "Payment:";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 437);
            Controls.Add(Paymenttxtbx);
            Controls.Add(label1);
            Controls.Add(Paytxtbx);
            Controls.Add(ReturnBtn);
            Controls.Add(GCASHBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(CreditCardBtn);
            Controls.Add(pictureBox1);
            Controls.Add(PayBtn);
            Controls.Add(Expirytxtbx);
            Controls.Add(CardholderNametxtbx);
            Controls.Add(CWtxtbx);
            Controls.Add(CardNumtxtbx);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CardNumtxtbx;
        private TextBox CWtxtbx;
        private TextBox CardholderNametxtbx;
        private TextBox Expirytxtbx;
        private Button PayBtn;
        private PictureBox pictureBox1;
        private Button CreditCardBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button GCASHBtn;
        private Button ReturnBtn;
        private Label label1;
        private TextBox Paytxtbx;
        private TextBox Paymenttxtbx;
    }
}
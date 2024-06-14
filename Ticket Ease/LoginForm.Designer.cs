namespace Ticket_Ease
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            RegisterLinkLbl = new LinkLabel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label1 = new Label();
            ForgotPasswordLinkLbl = new LinkLabel();
            Password_txtbx = new TextBox();
            UserName_txtbx = new TextBox();
            LoginBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(RegisterLinkLbl);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ForgotPasswordLinkLbl);
            panel1.Controls.Add(Password_txtbx);
            panel1.Controls.Add(UserName_txtbx);
            panel1.Controls.Add(LoginBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 721);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(87, 467);
            label2.Name = "label2";
            label2.Size = new Size(192, 46);
            label2.TabIndex = 66;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(82, 403);
            label4.Name = "label4";
            label4.Size = new Size(197, 46);
            label4.TabIndex = 65;
            label4.Text = "Username:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(488, 300);
            label3.Name = "label3";
            label3.Size = new Size(300, 46);
            label3.TabIndex = 56;
            label3.Text = "\"Discover, Book, and Rock Your Way\r\nto Unmissable Concerts\"";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(252, 48);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(259, 334);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 54;
            pictureBox6.TabStop = false;
            // 
            // RegisterLinkLbl
            // 
            RegisterLinkLbl.Anchor = AnchorStyles.None;
            RegisterLinkLbl.AutoSize = true;
            RegisterLinkLbl.BackColor = Color.Transparent;
            RegisterLinkLbl.Location = new Point(586, 679);
            RegisterLinkLbl.Name = "RegisterLinkLbl";
            RegisterLinkLbl.Size = new Size(63, 20);
            RegisterLinkLbl.TabIndex = 62;
            RegisterLinkLbl.TabStop = true;
            RegisterLinkLbl.Text = "Register";
            RegisterLinkLbl.LinkClicked += RegisterLinkLbl_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(519, 35);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(299, 260);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(533, 354);
            label9.Name = "label9";
            label9.Size = new Size(215, 28);
            label9.TabIndex = 57;
            label9.Text = "Concert Ticketing App";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(421, 679);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 63;
            label1.Text = "Don't have an account?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgotPasswordLinkLbl
            // 
            ForgotPasswordLinkLbl.Anchor = AnchorStyles.None;
            ForgotPasswordLinkLbl.AutoSize = true;
            ForgotPasswordLinkLbl.BackColor = Color.Transparent;
            ForgotPasswordLinkLbl.Location = new Point(484, 648);
            ForgotPasswordLinkLbl.Name = "ForgotPasswordLinkLbl";
            ForgotPasswordLinkLbl.Size = new Size(125, 20);
            ForgotPasswordLinkLbl.TabIndex = 61;
            ForgotPasswordLinkLbl.TabStop = true;
            ForgotPasswordLinkLbl.Text = "Forgot Password?";
            ForgotPasswordLinkLbl.LinkClicked += ForgotPasswordLinkLbl_LinkClicked;
            // 
            // Password_txtbx
            // 
            Password_txtbx.Anchor = AnchorStyles.None;
            Password_txtbx.BackColor = Color.LightBlue;
            Password_txtbx.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Password_txtbx.ForeColor = Color.FromArgb(64, 64, 64);
            Password_txtbx.Location = new Point(285, 478);
            Password_txtbx.Margin = new Padding(3, 4, 3, 4);
            Password_txtbx.Name = "Password_txtbx";
            Password_txtbx.Size = new Size(533, 35);
            Password_txtbx.TabIndex = 60;
            Password_txtbx.TextAlign = HorizontalAlignment.Center;
            // 
            // UserName_txtbx
            // 
            UserName_txtbx.Anchor = AnchorStyles.None;
            UserName_txtbx.BackColor = Color.LightBlue;
            UserName_txtbx.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_txtbx.ForeColor = Color.FromArgb(64, 64, 64);
            UserName_txtbx.Location = new Point(285, 414);
            UserName_txtbx.Margin = new Padding(3, 4, 3, 4);
            UserName_txtbx.Name = "UserName_txtbx";
            UserName_txtbx.Size = new Size(533, 35);
            UserName_txtbx.TabIndex = 59;
            UserName_txtbx.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.BackColor = Color.ForestGreen;
            LoginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.Control;
            LoginBtn.Location = new Point(322, 549);
            LoginBtn.Margin = new Padding(3, 4, 3, 4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(450, 95);
            LoginBtn.TabIndex = 58;
            LoginBtn.Text = "LOG IN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox6;
        private LinkLabel RegisterLinkLbl;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label1;
        private LinkLabel ForgotPasswordLinkLbl;
        private TextBox Password_txtbx;
        private TextBox UserName_txtbx;
        private Button LoginBtn;
    }
}
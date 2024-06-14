namespace Ticket_Ease
{
    partial class ForgotPasswordForm
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
            label7 = new Label();
            PasswordTbx = new TextBox();
            UsernameTbx = new TextBox();
            textBox1 = new TextBox();
            RegisterBtn = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(193, 79);
            label7.Name = "label7";
            label7.Size = new Size(297, 32);
            label7.TabIndex = 26;
            label7.Text = "FORGOT PASSWORD";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // PasswordTbx
            // 
            PasswordTbx.BackColor = SystemColors.Control;
            PasswordTbx.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTbx.ForeColor = Color.FromArgb(64, 64, 64);
            PasswordTbx.Location = new Point(234, 324);
            PasswordTbx.Margin = new Padding(3, 4, 3, 4);
            PasswordTbx.Name = "PasswordTbx";
            PasswordTbx.Size = new Size(276, 29);
            PasswordTbx.TabIndex = 28;
            PasswordTbx.TextAlign = HorizontalAlignment.Center;
            // 
            // UsernameTbx
            // 
            UsernameTbx.BackColor = SystemColors.Control;
            UsernameTbx.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTbx.ForeColor = Color.FromArgb(64, 64, 64);
            UsernameTbx.Location = new Point(234, 157);
            UsernameTbx.Margin = new Padding(3, 4, 3, 4);
            UsernameTbx.Name = "UsernameTbx";
            UsernameTbx.Size = new Size(276, 29);
            UsernameTbx.TabIndex = 27;
            UsernameTbx.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(234, 261);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 29);
            textBox1.TabIndex = 29;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = SystemColors.Window;
            RegisterBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterBtn.ForeColor = Color.FromArgb(64, 64, 64);
            RegisterBtn.Location = new Point(290, 204);
            RegisterBtn.Margin = new Padding(3, 4, 3, 4);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.RightToLeft = RightToLeft.Yes;
            RegisterBtn.Size = new Size(170, 32);
            RegisterBtn.TabIndex = 30;
            RegisterBtn.Text = "Send Verification Code";
            RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(234, 388);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 29);
            textBox2.TabIndex = 31;
            textBox2.Text = "Confirm New Password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(249, 523);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(155, 41);
            button1.TabIndex = 32;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(150, 157);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 33;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 261);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 34;
            label2.Text = "Enter Verification Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(92, 324);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 35;
            label3.Text = "New Password:";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 609);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(RegisterBtn);
            Controls.Add(textBox1);
            Controls.Add(PasswordTbx);
            Controls.Add(UsernameTbx);
            Controls.Add(label7);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox PasswordTbx;
        private TextBox UsernameTbx;
        private TextBox textBox1;
        private Button RegisterBtn;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        //private Button GoBackBtn;
    }
}
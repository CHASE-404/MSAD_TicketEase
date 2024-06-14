namespace Ticket_Ease
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            AvailableConcertsBtn = new Button();
            NotificationBtn = new Button();
            MenuBtn = new Button();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1 = new Panel();
            SideBarFlowLayoutPnl = new FlowLayoutPanel();
            ProfileBtn = new Button();
            ChangePassBtn = new Button();
            LogoutBtn = new Button();
            AdminActionPanel = new Panel();
            AddConcertInfo = new Button();
            AddRemoveConcertBtn = new Button();
            AdminBtn = new Button();
            MenuTimer = new System.Windows.Forms.Timer(components);
            AdminActionsTimer = new System.Windows.Forms.Timer(components);
            BookedConcertBtn = new Button();
            BuyTicketBtn = new Button();
            ChangePassModalTimer = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            SideBarFlowLayoutPnl.SuspendLayout();
            AdminActionPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AvailableConcertsBtn
            // 
            AvailableConcertsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AvailableConcertsBtn.BackColor = Color.Transparent;
            AvailableConcertsBtn.BackgroundImage = (Image)resources.GetObject("AvailableConcertsBtn.BackgroundImage");
            AvailableConcertsBtn.BackgroundImageLayout = ImageLayout.Zoom;
            AvailableConcertsBtn.FlatStyle = FlatStyle.Flat;
            AvailableConcertsBtn.Location = new Point(777, 13);
            AvailableConcertsBtn.Margin = new Padding(3, 4, 3, 4);
            AvailableConcertsBtn.Name = "AvailableConcertsBtn";
            AvailableConcertsBtn.Size = new Size(57, 60);
            AvailableConcertsBtn.TabIndex = 1;
            AvailableConcertsBtn.UseVisualStyleBackColor = false;
            AvailableConcertsBtn.Click += AvailableConcertsBtn_Click;
            // 
            // NotificationBtn
            // 
            NotificationBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NotificationBtn.BackColor = Color.Transparent;
            NotificationBtn.BackgroundImage = (Image)resources.GetObject("NotificationBtn.BackgroundImage");
            NotificationBtn.BackgroundImageLayout = ImageLayout.Zoom;
            NotificationBtn.FlatStyle = FlatStyle.Flat;
            NotificationBtn.Location = new Point(963, 13);
            NotificationBtn.Margin = new Padding(3, 4, 3, 4);
            NotificationBtn.Name = "NotificationBtn";
            NotificationBtn.Size = new Size(57, 60);
            NotificationBtn.TabIndex = 3;
            NotificationBtn.UseVisualStyleBackColor = false;
            NotificationBtn.Click += NotificationBtn_Click;
            // 
            // MenuBtn
            // 
            MenuBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MenuBtn.BackColor = Color.Transparent;
            MenuBtn.BackgroundImage = (Image)resources.GetObject("MenuBtn.BackgroundImage");
            MenuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.Location = new Point(1026, 13);
            MenuBtn.Margin = new Padding(3, 4, 3, 4);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(57, 60);
            MenuBtn.TabIndex = 4;
            MenuBtn.UseVisualStyleBackColor = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(6, 12);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(82, 127);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.ErrorImage = null;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(77, 12);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(162, 127);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(SideBarFlowLayoutPnl);
            panel1.Location = new Point(47, 213);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 646);
            panel1.TabIndex = 17;
            // 
            // SideBarFlowLayoutPnl
            // 
            SideBarFlowLayoutPnl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SideBarFlowLayoutPnl.Controls.Add(ProfileBtn);
            SideBarFlowLayoutPnl.Controls.Add(ChangePassBtn);
            SideBarFlowLayoutPnl.Controls.Add(LogoutBtn);
            SideBarFlowLayoutPnl.Controls.Add(AdminActionPanel);
            SideBarFlowLayoutPnl.Location = new Point(878, 3);
            SideBarFlowLayoutPnl.Name = "SideBarFlowLayoutPnl";
            SideBarFlowLayoutPnl.Size = new Size(153, 250);
            SideBarFlowLayoutPnl.TabIndex = 6;
            // 
            // ProfileBtn
            // 
            ProfileBtn.ForeColor = Color.Black;
            ProfileBtn.Location = new Point(3, 3);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(147, 29);
            ProfileBtn.TabIndex = 0;
            ProfileBtn.Text = "Profile";
            ProfileBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProfileBtn.UseVisualStyleBackColor = true;
            ProfileBtn.Click += ProfileBtn_Click_1;
            // 
            // ChangePassBtn
            // 
            ChangePassBtn.ForeColor = Color.Black;
            ChangePassBtn.Location = new Point(3, 38);
            ChangePassBtn.Name = "ChangePassBtn";
            ChangePassBtn.Size = new Size(147, 29);
            ChangePassBtn.TabIndex = 1;
            ChangePassBtn.Text = "Change Password";
            ChangePassBtn.TextAlign = ContentAlignment.MiddleLeft;
            ChangePassBtn.UseVisualStyleBackColor = true;
            ChangePassBtn.Click += ChangePassBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.ForeColor = Color.Black;
            LogoutBtn.Location = new Point(3, 73);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(147, 29);
            LogoutBtn.TabIndex = 2;
            LogoutBtn.Text = "Log Out";
            LogoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click_1;
            // 
            // AdminActionPanel
            // 
            AdminActionPanel.Controls.Add(AddConcertInfo);
            AdminActionPanel.Controls.Add(AddRemoveConcertBtn);
            AdminActionPanel.Controls.Add(AdminBtn);
            AdminActionPanel.Location = new Point(3, 108);
            AdminActionPanel.MaximumSize = new Size(153, 308);
            AdminActionPanel.MinimumSize = new Size(147, 35);
            AdminActionPanel.Name = "AdminActionPanel";
            AdminActionPanel.Size = new Size(147, 134);
            AdminActionPanel.TabIndex = 19;
            // 
            // AddConcertInfo
            // 
            AddConcertInfo.ForeColor = Color.Black;
            AddConcertInfo.Location = new Point(3, 97);
            AddConcertInfo.Name = "AddConcertInfo";
            AddConcertInfo.Size = new Size(141, 28);
            AddConcertInfo.TabIndex = 5;
            AddConcertInfo.Text = "Add concert info";
            AddConcertInfo.TextAlign = ContentAlignment.MiddleLeft;
            AddConcertInfo.UseVisualStyleBackColor = true;
            AddConcertInfo.Click += AddConcertInfo_Click;
            // 
            // AddRemoveConcertBtn
            // 
            AddRemoveConcertBtn.ForeColor = Color.Black;
            AddRemoveConcertBtn.Location = new Point(4, 38);
            AddRemoveConcertBtn.Name = "AddRemoveConcertBtn";
            AddRemoveConcertBtn.Size = new Size(140, 53);
            AddRemoveConcertBtn.TabIndex = 4;
            AddRemoveConcertBtn.Text = "Add/Remove concert";
            AddRemoveConcertBtn.TextAlign = ContentAlignment.MiddleLeft;
            AddRemoveConcertBtn.UseVisualStyleBackColor = true;
            AddRemoveConcertBtn.Click += AddRemoveConcertBtn_Click;
            // 
            // AdminBtn
            // 
            AdminBtn.ForeColor = Color.Black;
            AdminBtn.Location = new Point(3, 3);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(141, 29);
            AdminBtn.TabIndex = 3;
            AdminBtn.Text = "Admin";
            AdminBtn.TextAlign = ContentAlignment.MiddleLeft;
            AdminBtn.UseVisualStyleBackColor = true;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // MenuTimer
            // 
            MenuTimer.Enabled = true;
            MenuTimer.Interval = 1;
            MenuTimer.Tick += MenuTimer_Tick;
            // 
            // AdminActionsTimer
            // 
            AdminActionsTimer.Enabled = true;
            AdminActionsTimer.Interval = 10;
            AdminActionsTimer.Tick += AdminActionsTimer_Tick;
            // 
            // BookedConcertBtn
            // 
            BookedConcertBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BookedConcertBtn.BackColor = Color.Transparent;
            BookedConcertBtn.BackgroundImage = (Image)resources.GetObject("BookedConcertBtn.BackgroundImage");
            BookedConcertBtn.BackgroundImageLayout = ImageLayout.Zoom;
            BookedConcertBtn.FlatStyle = FlatStyle.Flat;
            BookedConcertBtn.Location = new Point(840, 13);
            BookedConcertBtn.Margin = new Padding(3, 4, 3, 4);
            BookedConcertBtn.Name = "BookedConcertBtn";
            BookedConcertBtn.Size = new Size(57, 60);
            BookedConcertBtn.TabIndex = 18;
            BookedConcertBtn.UseVisualStyleBackColor = false;
            BookedConcertBtn.Click += BookedConcertBtn_Click;
            // 
            // BuyTicketBtn
            // 
            BuyTicketBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BuyTicketBtn.BackColor = Color.Transparent;
            BuyTicketBtn.BackgroundImage = (Image)resources.GetObject("BuyTicketBtn.BackgroundImage");
            BuyTicketBtn.BackgroundImageLayout = ImageLayout.Zoom;
            BuyTicketBtn.FlatStyle = FlatStyle.Flat;
            BuyTicketBtn.Location = new Point(903, 13);
            BuyTicketBtn.Margin = new Padding(3, 4, 3, 4);
            BuyTicketBtn.Name = "BuyTicketBtn";
            BuyTicketBtn.Size = new Size(57, 60);
            BuyTicketBtn.TabIndex = 19;
            BuyTicketBtn.UseVisualStyleBackColor = false;
            BuyTicketBtn.Click += BuyTicketBtn_Click;
            // 
            // ChangePassModalTimer
            // 
            ChangePassModalTimer.Enabled = true;
            ChangePassModalTimer.Interval = 10;
            ChangePassModalTimer.Tick += ChangePassModalTimer_Tick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(BuyTicketBtn);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(BookedConcertBtn);
            groupBox1.Controls.Add(AvailableConcertsBtn);
            groupBox1.Controls.Add(NotificationBtn);
            groupBox1.Controls.Add(MenuBtn);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1102, 147);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 872);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardForm";
            Text = "DashboardForm";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            SideBarFlowLayoutPnl.ResumeLayout(false);
            AdminActionPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AvailableConcertsBtn;
        private Button NotificationBtn;
        private Button MenuBtn;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Panel panel1;
        private System.Windows.Forms.Timer MenuTimer;
        private Button ChangePassBtn;
        private Button ProfileBtn;
        private Button LogoutBtn;
        private Panel AdminActionPanel;
        private Button AddConcertInfo;
        private Button AddRemoveConcertBtn;
        private Button AdminBtn;
        private System.Windows.Forms.Timer AdminActionsTimer;
        private FlowLayoutPanel SideBarFlowLayoutPnl;
        private Button BookedConcertBtn;
        private Button BuyTicketBtn;
        private System.Windows.Forms.Timer ChangePassModalTimer;
        private GroupBox groupBox1;
    }
}
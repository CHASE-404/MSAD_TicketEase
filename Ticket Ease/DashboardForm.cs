using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ticket_Ease
{
    public partial class DashboardForm : Form
    {
        //#region-MsAccess-
        //OleDbCommand? cmd;
        //OleDbConnection? conn;
        //OleDbDataReader? reader;
        //private static string CreateConnection()
        //{
        //    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\TicketEaseDatabase.accdb;Jet OLEDB:Database Password=ADMIN123";
        //    return connectionString;
        //}
        //#endregion


        #region-TypeOfUser-

        private string loggedInUser;

        public string LoggedInUser
        {
            get { return loggedInUser; }
            set { loggedInUser = value; }
        }

        private bool isAdmin;

        #endregion

        #region-AdminActionsAnimation-
        bool AdminBtnCollapsed;
        #endregion

        #region - Dashboard Animation -
        //Collection of Dashboard Buttons
        readonly List<Button> dashboard;


        readonly private int TargetPosition = 60; // final destination of button
        readonly private int animationSpeed = 1; // how fast the animation is 
        private int currentIndex = 0; // current index of ani. btn & increment to next index 
        #endregion

        public DashboardForm(string username, bool isAdmin)
        {
            InitializeComponent();
            dashboard = new List<Button>() { AvailableConcertsBtn, BookedConcertBtn, BuyTicketBtn, NotificationBtn, MenuBtn };
            currentChildForm = new Form();
            AttachMenuHandler(dashboard);
            SideBarFlowLayoutPnl.Hide();
            loggedInUser = username;
            this.isAdmin = isAdmin;
            AdminBtn.Visible = isAdmin;

        }

        //private bool CheckIfUserIsAdmin(string username)
        //{
        //    bool isAdmin = false;

        //    string connectionString = CreateConnection();
        //    using (conn = new OleDbConnection(connectionString))
        //    {
        //        conn.Open();
        //        cmd = new OleDbCommand("SELECT * FROM UserRegistrationTable WHERE Username=@Uname AND IsAdmin=true", conn);
        //        cmd.Parameters.AddWithValue("@Uname", username);

        //        reader = cmd.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            // User is an admin
        //            isAdmin = true;
        //        }

        //        reader.Close();
        //    }

        //    return isAdmin;

        //}

        #region -Dashboard Animation-

        //attach event handlers to list of buttons
        private void AttachMenuHandler(List<Button> dashboard)
        {
            foreach (var button in dashboard)
            {
                //Hide Menu
                //button.Hide();

                //attach mousehover & mouseleave event handlers to the buttons
                button.MouseHover += Button_MouseHover;
                button.MouseLeave += Button_MouseLeave;

            }

        }


        private void Button_MouseHover(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(241, 214, 131);
            }
        }
        private void Button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(241, 164, 123);
            }

        }
        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            Button CurrentMenu = dashboard[currentIndex];

            if (CurrentMenu.Top < TargetPosition)
            {
                CurrentMenu.Top += animationSpeed;
                CurrentMenu.Show();
            }
            else if (CurrentMenu.Top > TargetPosition)
            {
                CurrentMenu.Top -= animationSpeed;
            }
            else
            {
                currentIndex++;
                if (currentIndex >= dashboard.Count)
                {
                    MenuTimer.Stop();
                }
                else
                {
                    MenuTimer.Start();
                }
            }
        }

        #endregion

        #region-FormInForm-
        private Form currentChildForm;
        void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm?.Close();
            // Remove the previously added child form

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(currentChildForm);
            panel1.Tag = currentChildForm;

            currentChildForm.BringToFront();
            currentChildForm.Show();
        }



        private void AvailableConcertsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AvailableConcerts());
        }

        private void BookedConcertBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookedTicketsForm());
        }

        #endregion



        #region-MenuBar-
        private bool isSideBarVisible = false;

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (isSideBarVisible)
            {
                SideBarFlowLayoutPnl.Hide();
                isSideBarVisible = false;
            }
            else
            {
                SideBarFlowLayoutPnl.Show();
                isSideBarVisible = true;
                SideBarFlowLayoutPnl.BringToFront();
            }
        }

        public static int parentX, parentY;
        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            Form modalBackground = new ForgotPasswordForm();
            using (ForgotPasswordForm modal = new ForgotPasswordForm())
            {
                modalBackground.Opacity = -50d;
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();
            }

        }


        private void ProfileBtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm(loggedInUser, isAdmin));
        }


        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            //ConnectionManager.TurnOffSqlConnection();
            var login = new LoginForm();
            login.Show();
            this.Hide();

        }
        #endregion


        #region-admin-
        private void AdminActionsTimer_Tick(object sender, EventArgs e)
        {
            if (AdminBtnCollapsed)
            {
                AdminActionPanel.Height += 10;
                if (AdminActionPanel.Height >= AdminActionPanel.MaximumSize.Height)
                {
                    AdminBtnCollapsed = false;
                    AdminActionsTimer.Stop();
                }
            }
            else
            {
                AdminActionPanel.Height -= 10;
                if (AdminActionPanel.Height <= AdminActionPanel.MinimumSize.Height)
                {
                    AdminBtnCollapsed = true;
                    AdminActionsTimer.Stop();
                }
            }
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {

            AdminActionsTimer.Start();
        }


        private void AddRemoveConcertBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConcertDetailsFormAdminn());
            SideBarFlowLayoutPnl.Visible = false;

        }
        #endregion





        private void AddConcertInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddConcertLocationDetailsAdmin());
            SideBarFlowLayoutPnl.Visible = false;
        }

        private void BuyTicketBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuyTicketInformationForm(loggedInUser));

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new AvailableConcerts());
        }

        private void ChangePassModalTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                ChangePassModalTimer.Stop();
            }
            else
                Opacity += .03;
        }

        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewNotificationForm());
            SideBarFlowLayoutPnl.Visible = false;
        }
    }
}

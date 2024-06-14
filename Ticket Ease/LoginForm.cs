using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Ease
{
    public partial class LoginForm : Form
    {
        private string loggedInUser;

        public LoginForm()
        {
            InitializeComponent();

        }

        private bool CheckIfUserIsAdmin(string username)
        {
            // Check if the given username exists in the Admin_Account table
            using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
            {
                string query = "SELECT COUNT(*) FROM Admin_Account WHERE Username=@username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Will check in database if username and password is a user, or an admin.

            string username = UserName_txtbx.Text;
            string password = Password_txtbx.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                bool isAdmin = CheckIfUserIsAdmin(username);
                if (isAdmin)
                {
                    // Check if the credentials exist in Admin_Account table
                    using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                    {
                        string query = "SELECT COUNT(*) FROM Admin_Account WHERE Username=@username AND Password=@password";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loggedInUser = username;
                                var dashboard = new DashboardForm(username, isAdmin);
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    // Check if the credentials exist in User_Account table
                    using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                    {
                        string query = "SELECT COUNT(*) FROM User_Account WHERE Username=@username AND Password=@password";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("User login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loggedInUser = username;
                                var dashboard = new DashboardForm(username, isAdmin);
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RegisterLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void ForgotPasswordLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*var forgotpassword = new ForgotPasswordForm();
            forgotpassword.Show();
            this.Hide();*/
            Form modalBackground = new ForgotPasswordForm();
            using (ForgotPasswordForm modal = new ForgotPasswordForm())
            {
                modalBackground.Opacity = -50d;
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }
    }
}


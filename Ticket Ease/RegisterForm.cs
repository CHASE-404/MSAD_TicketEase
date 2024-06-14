using System;
using System.Data.SQLite;
using System.Web;

namespace Ticket_Ease
{
    public partial class RegisterForm : Form
    {
        private Random random = new Random();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void GobackBtn_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            bool CheckBox1Checked = CheckBox1.Checked;

            if (!CheckBox1Checked)
            {
                MessageBox.Show("You need to know the Policy and Term's and Condition's" + "before registering");
            }

            else if (!ValidateFormFields())
            {
                MessageBox.Show("Please fill in all the required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string username = UsernameTbx.Text;
                string password = PasswordTbx.Text;
                string email = EmailTbx.Text;
                string phone = PhoneTbx.Text;
                string mobilenum = MobileNumtxtbx.Text;
                string country = CountrycomBox.SelectedItem.ToString();
                string city = Citytxtbx.Text;
                string province = Provincetxtbx.Text;
                string barangay = Barangaytxtbx.Text;
                string zipCode = ZipCodetxtbx.Text;
                string lastName = LNametxtbx.Text;
                string firstName = Fnametxtbx.Text;
                int age = Convert.ToInt32(AgecomboBox.SelectedItem);
                string gender = GcomboBox.SelectedItem.ToString();
                string Bday = Birthdaytxtbx.Text;
                int userID = GenerateRandomUserID();

                try
                {
                    using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                    {
                        string query = @"INSERT INTO User_Account (UserID, Username, Password, Email, Telephone, PhoneNumber, Country, City, Province, Barangay, Zipcode, LastName, FirstName, Gender, Age, Birthday) 
                                     VALUES (@UserID, @Username, @Password, @Email, @Telephone, @PhoneNumber, @Country, @City, @Province, @Barangay, @Zipcode, @LastName, @FirstName, @Gender, @Age, @Birthday)";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", userID);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Telephone", phone);
                            command.Parameters.AddWithValue("@PhoneNumber", mobilenum);
                            command.Parameters.AddWithValue("@Country", country);
                            command.Parameters.AddWithValue("@City", city);
                            command.Parameters.AddWithValue("@Province", province);
                            command.Parameters.AddWithValue("@Barangay", barangay);
                            command.Parameters.AddWithValue("@Zipcode", zipCode);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Age", age);
                            command.Parameters.AddWithValue("@Birthday", Bday);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during registration: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    var loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private int GenerateRandomUserID()
        {
            return random.Next(1000000, 9999999);
        }

        private bool ValidateFormFields()
        {
            if (string.IsNullOrWhiteSpace(UsernameTbx.Text) ||
                string.IsNullOrWhiteSpace(PasswordTbx.Text) ||
                string.IsNullOrWhiteSpace(EmailTbx.Text) ||
                string.IsNullOrWhiteSpace(PhoneTbx.Text) ||
                string.IsNullOrWhiteSpace(LNametxtbx.Text) ||
                string.IsNullOrWhiteSpace(Fnametxtbx.Text) ||
                AgecomboBox.SelectedItem == null ||
                GcomboBox.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTbx_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTbx_Click(object sender, EventArgs e)
        {

        }
        private void EmailTbx_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTbx_Click(object sender, EventArgs e)
        {

        }

        private void MobileNumtxtbx_Click(object sender, EventArgs e)
        {

        }

        private void Citytxtbx_Click(object sender, EventArgs e)
        {

        }

        private void Provincetxtbx_Click(object sender, EventArgs e)
        {

        }

        private void Barangaytxtbx_Click(object sender, EventArgs e)
        {

        }

        private void ZipCodetxtbx_Click(object sender, EventArgs e)
        {

        }

        private void Fnametxtbx_Click(object sender, EventArgs e)
        {

        }

        private void LNametxtbx_Click(object sender, EventArgs e)
        {

        }

        private void Birthdaytxtbx_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Ease
{
    public partial class ProfileForm : Form
    {
        private string username;
        private bool isAdmin;
        private bool isEditMode = false;

        public ProfileForm(string username, bool isAdmin)
        {
            InitializeComponent();
            this.username = username;
            this.isAdmin = isAdmin;

            // Load the user's profile data from the database and display it in the form
            LoadProfileData();
            EnableControls(false);
            Edit_btn.Visible = true;

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadProfileData()
        {
            try
            {
                string tableName = isAdmin ? "Admin_Account" : "User_Account";
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = $"SELECT * FROM {tableName} WHERE Username = @username";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Username_txtbx.Text = reader["Username"].ToString();
                                FirstName_txtbx.Text = reader["FirstName"].ToString();
                                LastName_txtbx.Text = reader["LastName"].ToString();
                                Email_txtbx.Text = reader["Email"].ToString();
                                Password_txtbx.Text = reader["Password"].ToString();
                                Age_txtbx.Text = reader["Age"].ToString();
                                Gender_txtbx.Text = reader["Gender"].ToString();
                                Telephone_txtbx.Text = reader["Telephone"].ToString();
                                MobileNum_txtbx.Text = reader["PhoneNumber"].ToString();
                                Country_txtbx.Text = reader["Country"].ToString();
                                City_txtbx.Text = reader["City"].ToString();
                                Province_txtbx.Text = reader["Province"].ToString();
                                Barangay_txtbx.Text = reader["Barangay"].ToString();
                                ZipCode_txtbx.Text = reader["Zipcode"].ToString();
                                Bday_txtbx.Text = reader["Birthday"].ToString();

                                // Load and display the profile image (if available)
                                if (reader["ProfileImage"] != DBNull.Value && !string.IsNullOrEmpty(reader["ProfileImage"].ToString()))
                                {
                                    byte[] imageData = (byte[])reader["ProfileImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    // If no profile image is available, you can display a default image here
                                    pictureBox1.Image = null; // Set to a default image or leave it blank
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            isEditMode = !isEditMode;
            EnableControls(isEditMode);

            if (isEditMode)
            {
                Edit_btn.Text = "Cancel";
                Gender_cmbBox.Visible = true; // Show ComboBoxes in edit mode
                Age_cmbBox.Visible = true;
                Country_cmbBox.Visible = true;
                Gender_txtbx.Visible = false; // Hide TextBoxes in edit mode
                Age_txtbx.Visible = false;
                Country_txtbx.Visible = false;
            }
            else
            {
                // Reload the profile data to revert the changes made in edit mode
                LoadProfileData();
                Edit_btn.Text = "Edit";
                Gender_cmbBox.Visible = false; // Hide ComboBoxes in view mode
                Age_cmbBox.Visible = false;
                Country_cmbBox.Visible = false;
                Gender_txtbx.Visible = true; // Show TextBoxes in view mode
                Age_txtbx.Visible = true;
                Country_txtbx.Visible = true;
            }
        }

        private void UploadImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the selected image file and convert it to a byte array
                        byte[] imageData;
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            imageData = new byte[fs.Length];
                            fs.Read(imageData, 0, imageData.Length);
                        }

                        // Display the selected image in the PictureBox
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                        // Update the profile image in the database
                        string tableName = isAdmin ? "Admin_Account" : "User_Account";
                        using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                        {
                            string query = $"UPDATE {tableName} SET ProfileImage = @imageData WHERE Username = @username";
                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@imageData", imageData);
                                command.Parameters.AddWithValue("@username", username);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeProfileBtn_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                // Save the profile data (similar to the previous implementation, call a method to handle saving the data)
                SaveProfileData();
            }
        }

        private void SaveProfileData()
        {
            try
            {
                string tableName = isAdmin ? "Admin_Account" : "User_Account";
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = $"UPDATE {tableName} SET " +
                           "FirstName = @firstName, " +
                           "LastName = @lastName, " +
                           "Email = @email, " +
                           "Telephone = @telephone, " +
                           "PhoneNumber = @phoneNumber, " +
                           "Country = @country, " +
                           "City = @city, " +
                           "Province = @province, " +
                           "Barangay = @barangay, " +
                           "Zipcode = @zipcode, " +
                           "Birthday = @birthday, " +
                           "Gender = @gender, " +
                           "Age = @age " +
                           "WHERE Username = @username";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", FirstName_txtbx.Text);
                        command.Parameters.AddWithValue("@lastName", LastName_txtbx.Text);
                        command.Parameters.AddWithValue("@email", Email_txtbx.Text);
                        command.Parameters.AddWithValue("@telephone", Telephone_txtbx.Text);
                        command.Parameters.AddWithValue("@phoneNumber", MobileNum_txtbx.Text);
                        command.Parameters.AddWithValue("@country", Country_cmbBox.Text);
                        command.Parameters.AddWithValue("@city", City_txtbx.Text);
                        command.Parameters.AddWithValue("@province", Province_txtbx.Text);
                        command.Parameters.AddWithValue("@barangay", Barangay_txtbx.Text);
                        command.Parameters.AddWithValue("@zipcode", ZipCode_txtbx.Text);
                        command.Parameters.AddWithValue("@birthday", Bday_txtbx.Text);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@gender", Gender_cmbBox.Text);
                        command.Parameters.AddWithValue("@age", Age_cmbBox.Text);
                        command.ExecuteNonQuery();

                        // Display a success message
                        MessageBox.Show("Profile details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the profile details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EnableControls(bool enable)
        {
            Username_txtbx.ReadOnly = !enable;
            Password_txtbx.ReadOnly = true; // Password should not be editable during edit mode
            FirstName_txtbx.ReadOnly = !enable;
            LastName_txtbx.ReadOnly = !enable;
            Email_txtbx.ReadOnly = !enable;
            Telephone_txtbx.ReadOnly = !enable;
            MobileNum_txtbx.ReadOnly = !enable;
            Country_txtbx.ReadOnly = !enable;
            City_txtbx.ReadOnly = !enable;
            Province_txtbx.ReadOnly = !enable;
            Barangay_txtbx.ReadOnly = !enable;
            ZipCode_txtbx.ReadOnly = !enable;
            Bday_txtbx.ReadOnly = !enable;

            Gender_txtbx.Visible = !enable;
            Age_txtbx.Visible = !enable;
            Country_txtbx.Visible = !enable;

            Gender_cmbBox.Visible = enable;
            Age_cmbBox.Visible = enable;
            Country_cmbBox.Visible = enable;

            UploadImageBtn.Visible = enable;
            ChangeProfileBtn.Visible = enable;
        }
    }
}

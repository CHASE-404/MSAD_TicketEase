using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Ease
{
    public partial class ConcertDetailsFormAdminn : Form
    {
        private byte[] concertPosterBytes;

        public ConcertDetailsFormAdminn()
        {
            InitializeComponent();
            LoadConcertTitles();
        }

        private void AddRemoveConcert_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string concertID = ConID_txtbx.Text;
            string concertTitle = Contitle_txtbx.Text;
            string performer = PerformerTbx.Text;
            string scheduleDate = CONSD_dateTimePicker.Value.ToString("yyyy-MM-dd");
            string venue = Venuetbx.Text;
            string time = Timetxbx.Text;


            if (string.IsNullOrWhiteSpace(concertID) || string.IsNullOrWhiteSpace(concertTitle) ||
                string.IsNullOrWhiteSpace(performer) || string.IsNullOrWhiteSpace(venue) || string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = "INSERT INTO Concert_Main (Concert_ID, Concert_Title, Perfomer, ScheduleDate, Venue, Time, Poster) " +
               "VALUES (@concertID, @concertTitle, @performer, @scheduleDate, @venue, @time, @poster)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@concertID", concertID);
                        command.Parameters.AddWithValue("@concertTitle", concertTitle);
                        command.Parameters.AddWithValue("@performer", performer);
                        command.Parameters.AddWithValue("@scheduleDate", scheduleDate);
                        command.Parameters.AddWithValue("@venue", venue);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@poster", concertPosterBytes);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Concert details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally, you can clear the textboxes after successful save
                            ClearTextBoxes();
                            this.Refresh();
                           
                        }
                        else
                        {
                            MessageBox.Show("Failed to save concert details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving concert details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string selectedConcertTitle = ConcertDetailcomboBox.Text;

            if (string.IsNullOrWhiteSpace(selectedConcertTitle))
            {
                MessageBox.Show("Please select a concert to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = "DELETE FROM Concert_Main WHERE Concert_Title=@concertTitle";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@concertTitle", selectedConcertTitle);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Concert deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                            this.Refresh();
                           /* LoadConcertTitles()*/; // Refresh the ComboBox after deletion
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the concert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the concert: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string concertID = ConID_txtbx.Text;
            string concertTitle = Contitle_txtbx.Text;
            string performer = PerformerTbx.Text;
            string scheduleDate = CONSD_dateTimePicker.Value.ToString("yyyy-MM-dd");
            string venue = Venuetbx.Text;
            string time = Timetxbx.Text;

            if (string.IsNullOrWhiteSpace(concertID) || string.IsNullOrWhiteSpace(concertTitle) ||
                string.IsNullOrWhiteSpace(performer) || string.IsNullOrWhiteSpace(venue) || string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = "UPDATE Concert_Main SET Concert_ID=@concertID, Perfomer=@performer, " +
                          "ScheduleDate=@scheduleDate, Venue=@venue, Time=@time, Poster=@poster " +
                          "WHERE Concert_Title=@concertTitle";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@concertID", concertID);
                        command.Parameters.AddWithValue("@concertTitle", concertTitle);
                        command.Parameters.AddWithValue("@performer", performer);
                        command.Parameters.AddWithValue("@scheduleDate", scheduleDate);
                        command.Parameters.AddWithValue("@venue", venue);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@poster", concertPosterBytes);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Concert details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Refresh();
                            /*LoadConcertTitles()*/; // Refresh the ComboBox after update
                        }
                        else
                        {
                            MessageBox.Show("Failed to update concert details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating concert details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            ConID_txtbx.Text = "";
            Contitle_txtbx.Text = "";
            PerformerTbx.Text = "";
            CONSD_dateTimePicker.Value = DateTime.Now;
            Venuetbx.Text = "";
            Timetxbx.Text = "";
        }

        private void LoadConcertTitles()
        {
            try
            {
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = "SELECT Concert_Title FROM Concert_Main";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the Concert_Title values to the ComboBox
                        ConcertDetailcomboBox.DataSource = dataTable;
                        ConcertDetailcomboBox.DisplayMember = "Concert_Title";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading concert titles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void PosterUrlBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory (optional)
            openFileDialog.InitialDirectory = @"C:\";

            // Set the title of the dialog
            openFileDialog.Title = "Open Image File";

            // Filter the types of files to be displayed (optional)
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif";

            // Show the dialog and check if the user clicked "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the selected image file into bytes
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        concertPosterBytes = new byte[fs.Length];
                        fs.Read(concertPosterBytes, 0, (int)fs.Length);
                    }

                    // Display the image in the PictureBox
                    using (MemoryStream ms = new MemoryStream(concertPosterBytes))
                    {
                        ConcertPicbx.Image = Image.FromStream(ms);
                        ConcertPicbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConcertDetailcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected concert title from the ComboBox
            string selectedConcertTitle = ConcertDetailcomboBox.Text;

            try
            {
                using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
                {
                    string query = "SELECT * FROM Concert_Main WHERE Concert_Title=@concertTitle";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@concertTitle", selectedConcertTitle);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display the data in the textboxes based on the selected concert
                                ConID_txtbx.Text = reader["Concert_ID"].ToString();
                                Contitle_txtbx.Text = reader["Concert_Title"].ToString();
                                PerformerTbx.Text = reader["Perfomer"].ToString();
                                CONSD_dateTimePicker.Value = DateTime.Parse(reader["ScheduleDate"].ToString());
                                Venuetbx.Text = reader["Venue"].ToString();
                                Timetxbx.Text = reader["Time"].ToString();

                                byte[] posterBytes = (byte[])reader["Poster"];
                                if (posterBytes != null && posterBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(posterBytes))
                                    {
                                        ConcertPicbx.Image = Image.FromStream(ms);
                                        ConcertPicbx.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                }
                                else
                                {
                                    // If there is no poster, clear the PictureBox
                                    ConcertPicbx.Image = null;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving concert details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

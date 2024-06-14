using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Ticket_Ease
{

    public partial class BuyTicketInformationForm : Form
    {
        private SQLiteConnection connection;
        private string selectedConcertID;
        private int totalPrice = 0;
        private string loggedInUser;
        private List<string> selectedSeats = new List<string>();

        public BuyTicketInformationForm(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void BuyTicketInformationForm_Load(object sender, EventArgs e)
        {
            connection = ConnectionManager.GetSqlConnection();
            LoadConcertTitles();
        }

        private void LoadConcertTitles()
        {
            string query = "SELECT Concert_ID, Concert_Title FROM Concert_Main";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the concert titles to the combobox
                SelectConcetCombx.DisplayMember = "Concert_Title";
                SelectConcetCombx.ValueMember = "Concert_ID";
                SelectConcetCombx.DataSource = dt;
            }
        }

        private void SelectConcetCombx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSeatButtons();

            // Get the selected concert ID from the combobox
            selectedConcertID = SelectConcetCombx.SelectedValue.ToString();

            // Load the seats for the selected concert
            LoadSeats(selectedConcertID);
        }

        private void LoadSeats(string concertID)
        {
            string query = "SELECT SeatId, Name, IsTaken, Price FROM Seats WHERE ConcertID = @ConcertID";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@ConcertID", concertID);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Populate the seat buttons
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["Name"].ToString();
                    bool isTaken = Convert.ToBoolean(row["IsTaken"]);
                    int price = Convert.ToInt32(row["Price"]);

                    Button seatBtn = GetSeatButtonByName(name);
                    if (seatBtn != null)
                    {
                        seatBtn.Text = name;
                        seatBtn.BackColor = isTaken ? Color.Red : Color.White;
                        seatBtn.Enabled = !isTaken;
                        seatBtn.Tag = price; // Store the price as Tag for each seat button
                    }
                }
            }
        }

        private Button GetSeatButtonByName(string name)
        {
            // Find the seat button based on the name
            Control[] matches = this.Controls.Find(name + "Btn", true);
            return matches.Length > 0 ? matches[0] as Button : null;
        }

        private void ClearSeatButtons()
        {
            // Reset all the seat buttons
            foreach (Control control in this.Controls)
            {
                if (control is Button seatBtn && seatBtn.Name.EndsWith("Btn"))
                {
                    seatBtn.Text = "";
                    seatBtn.BackColor = Color.White;
                    seatBtn.Enabled = true;
                    seatBtn.Tag = null;
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            // Handle the click event of seat buttons
            Button seatBtn = sender as Button;
            if (seatBtn != null && seatBtn.BackColor == Color.White) // Available seat
            {
                seatBtn.BackColor = Color.Green;
                totalPrice += Convert.ToInt32(seatBtn.Tag);
            }
            else if (seatBtn != null && seatBtn.BackColor == Color.Green) // Selected seat (deselect)
            {
                seatBtn.BackColor = Color.White;
                totalPrice -= Convert.ToInt32(seatBtn.Tag);
            }

            // Update the TotalPricetxtbx
            TotalPricetxtbx.Text = totalPrice.ToString();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            bool seatsSelected = false;
            foreach (Control control in this.Controls)
            {
                if (control is Button seatBtn && seatBtn.BackColor == Color.Green)
                {
                    seatsSelected = true;
                    break;
                }
            }
            var paymentForm = new PaymentForm(loggedInUser, selectedConcertID, selectedSeats, totalPrice);
            paymentForm.Show();
            this.Hide();
        }
        private List<string> GetSelectedSeats()
        {
            List<string> selectedSeats = new List<string>();
            foreach (Control control in this.Controls)
            {
                if (control is Button seatBtn && seatBtn.BackColor == Color.Green)
                {
                    selectedSeats.Add(seatBtn.Text);
                }
            }
            return selectedSeats;
        }
    }
}

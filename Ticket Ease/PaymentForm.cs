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
    public partial class PaymentForm : Form
    {
        private List<string> selectedSeats;
        private int totalPrice;

        private string loggedInUser;
        private string selectedConcertID;

        public PaymentForm(string loggedInUser, string selectedConcertID, List<string> selectedSeats, int totalPrice)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.selectedConcertID = selectedConcertID;
            this.selectedSeats = selectedSeats; // Store the selected seats
            this.totalPrice = totalPrice;
        }

        private void GCASHBtn_Click(object sender, EventArgs e)
        {
            var GCASH = new PaymentFormGCASH(loggedInUser, selectedConcertID, selectedSeats, totalPrice);
            GCASH.Show();
            this.Hide();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            int paymentAmount = Convert.ToInt32(Paymenttxtbx.Text);
            if (paymentAmount < totalPrice)
            {
                MessageBox.Show("The payment amount is less than the total price. Please enter the correct payment amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the ticket purchase in the Tickets table
            using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    foreach (string seat in selectedSeats)
                    {
                        string insertQuery = "INSERT INTO Tickets (ConcertId, SeatId, UserID, PaymentType) VALUES (@ConcertId, @SeatId, @UserID, @PaymentType)";
                        command.Parameters.AddWithValue("@ConcertId", selectedConcertID);
                        command.Parameters.AddWithValue("@SeatId", GetSeatIdByName(seat));
                        command.Parameters.AddWithValue("@UserID", GetLoggedInUserID());
                        command.Parameters.AddWithValue("@PaymentType", "Credit Card"); // Assuming payment type is Credit Card for now, modify as per your requirement.

                        command.ExecuteNonQuery();
                    }

                    // Get the last inserted TicketId (AUTOINCREMENT feature)
                    command.CommandText = "SELECT last_insert_rowid()";
                    int ticketId = Convert.ToInt32(command.ExecuteScalar());
                    MessageBox.Show("Ticket purchase successful! Your Ticket ID is: " + ticketId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int GetLoggedInUserID()
        {
            // Get the UserID of the currently logged-in user from the User_Account table.
            using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
            {
                string query = "SELECT UserID FROM User_Account WHERE Username = @Username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", loggedInUser);
                    command.Parameters.AddWithValue("@ConcertId", selectedConcertID);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private int GetSeatIdByName(string seatName)
        {
            // Get the SeatId from the Seats table based on the seat name.
            using (SQLiteConnection connection = ConnectionManager.GetSqlConnection())
            {
                string query = "SELECT SeatId FROM Seats WHERE ConcertID = @ConcertID AND Name = @Name";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ConcertID", selectedConcertID);
                    command.Parameters.AddWithValue("@Name", seatName);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            var ticket = new BuyTicketInformationForm(loggedInUser);
            ticket.Show();
            this.Hide();
        }
    }
}

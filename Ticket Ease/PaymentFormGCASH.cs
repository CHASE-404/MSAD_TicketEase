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
    public partial class PaymentFormGCASH : Form
    {
        private string loggedInUser;
        private string selectedConcertID;
        private List<string> selectedSeats;
        private int totalPrice;

        public PaymentFormGCASH(string loggedInUser, string selectedConcertID, List<string> selectedSeats, int totalPrice)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.selectedConcertID = selectedConcertID;
            this.selectedSeats = selectedSeats;
            this.totalPrice = totalPrice;
        }

        private void PAYbtn_Click(object sender, EventArgs e)
        {
            // Check if payment is enough
            int paymentAmount = Convert.ToInt32(Paymenttxtbx.Text);
            if (paymentAmount < totalPrice)
            {
                MessageBox.Show("The payment amount is less than the total price. Please enter the correct payment amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                        command.Parameters.AddWithValue("@PaymentType", "GCASH"); // Payment type for GCASH

                        command.ExecuteNonQuery();
                    }
                    command.CommandText = "SELECT last_insert_rowid()";
                    int ticketId = Convert.ToInt32(command.ExecuteScalar());
                    MessageBox.Show("Ticket purchase successful! Your Ticket ID is: " + ticketId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Show a success message or do further processing as needed
            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Return to the BuyTicketInformationForm
            var ticket = new BuyTicketInformationForm(loggedInUser);
            ticket.Show();
            this.Hide();
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

        private void RETURNbtn_Click(object sender, EventArgs e)
        {
            var ticket = new BuyTicketInformationForm(loggedInUser);
            ticket.Show();
            this.Hide();
        }

        private void CreditCardBtn_Click(object sender, EventArgs e)
        {
            var PaymentForm = new PaymentForm(loggedInUser, selectedConcertID, selectedSeats, totalPrice);
            PaymentForm.Show();
            this.Hide();
        }

        private void PaymentFormGCASH_Load(object sender, EventArgs e)
        {

        }
    }
}

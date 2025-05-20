using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DeleteBookingForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public DeleteBookingForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookingId;
            if (int.TryParse(txtBookingId.Text, out bookingId))
            {
                bool success = DeleteBooking(bookingId);

                if (success)
                    MessageBox.Show("Booking deleted successfully.");
                else
                    MessageBox.Show("Failed to delete booking.");
            }
            else
            {
                MessageBox.Show("Invalid Booking ID.");
            }
        }

        public bool DeleteBooking(int bookingId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteBooking", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@B_ID", bookingId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting booking: " + ex.Message);
                return false;
            }
        }

        private void DeleteBookingForm_Load(object sender, EventArgs e) { }
    }
}

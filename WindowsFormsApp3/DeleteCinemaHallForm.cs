using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DeleteCinemaHallForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public DeleteCinemaHallForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the Hall number from the TextBox
            if (int.TryParse(txtHallNo.Text, out int hallNo))
            {
                // Call the DeleteCinemaHall method
                bool success = DeleteCinemaHall(hallNo);

                if (success)
                {
                    MessageBox.Show("Cinema Hall deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete Cinema Hall.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Hall Number.");
            }
        }

        public bool DeleteCinemaHall(int hallNo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteCinemaHall", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Hall_no", hallNo);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting cinema hall: " + ex.Message);
                return false;
            }
        }

        private void DeleteCinemaHallForm_Load(object sender, EventArgs e)
        {
            // Optional: any initialization if needed
        }
    }
}

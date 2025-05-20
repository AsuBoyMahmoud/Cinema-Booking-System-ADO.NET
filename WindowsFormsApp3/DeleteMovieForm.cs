using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DeleteMovieForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public DeleteMovieForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string title = txtMovieTitle.Text.Trim();

            if (!string.IsNullOrEmpty(title))
            {
                bool success = DeleteMovie(title);

                if (success)
                {
                    MessageBox.Show("Movie deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete movie.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a movie title.");
            }
        }

        public bool DeleteMovie(string title)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteMovie", conn)) // Ensure the procedure is named correctly
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Correct the parameter name to match the stored procedure
                        cmd.Parameters.AddWithValue("@Title", title); // This must match the SP parameter name

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting movie: " + ex.Message);
                return false;
            }
        }

        private void DeleteMovieForm_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic
        }
    }
}

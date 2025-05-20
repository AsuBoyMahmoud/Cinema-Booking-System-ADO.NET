using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BookNow : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public BookNow()
        {
            InitializeComponent();
        }

        private void bookNow_Load(object sender, EventArgs e)
        {
            // Load movies into DataGridView when form loads
            LoadMovies();
        }

        // Method to load movies into the DataGridView
        private void LoadMovies()
        {
            string query = @"
                SELECT DISTINCT 
                    M.Title AS [Movie Title], 
                    MG.Genre, 
                    P.Hall_no AS [Hall Number]
                FROM MOVIE M
                LEFT JOIN MOVIE_GENRE MG ON M.Title = MG.Movie_title
                LEFT JOIN plays P ON M.Title = P.Movie_title";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // Check if required fields are filled
            if (dataGridView1.SelectedRows.Count == 0 || string.IsNullOrWhiteSpace(txtCustomerID.Text) || cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie, enter your Customer ID, and select a payment method.");
                return;
            }

            // Gather data
            string movieTitle = dataGridView1.SelectedRows[0].Cells["Movie Title"].Value.ToString();
            string customerID = txtCustomerID.Text.Trim();
            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString(); // Get selected payment method
            int adminID = 1; // For example, assuming Admin ID is 1. You can change this as needed

            // Get current date and time automatically
            DateTime currentDateTime = DateTime.Now;
            int hour = currentDateTime.Hour;  // Set the current hour
            int minute = currentDateTime.Minute;  // Set the current minute
            DateTime bookingDate = currentDateTime.Date;  // Set the current date

            // Insert booking data into the database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string insertQuery = @"
                    INSERT INTO BOOKING (Hour, Minute, Date, P_method, Cust_ID, Movie_Title, AdminID)
                    VALUES (@Hour, @Minute, @Date, @Method, @CustID, @MovieTitle, @AdminID)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Hour", hour);
                    cmd.Parameters.AddWithValue("@Minute", minute);
                    cmd.Parameters.AddWithValue("@Date", bookingDate);
                    cmd.Parameters.AddWithValue("@Method", paymentMethod);
                    cmd.Parameters.AddWithValue("@CustID", customerID);
                    cmd.Parameters.AddWithValue("@MovieTitle", movieTitle);
                    cmd.Parameters.AddWithValue("@AdminID", adminID);  // Make sure Admin ID is added

                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Booking successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

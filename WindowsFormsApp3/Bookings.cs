using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Bookings : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public Bookings()
        {
            InitializeComponent();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.Text = "Bookings Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Show bookings in DataGridView
        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT B_ID, Hour, Minute, Date, P_method, Cust_ID, Movie_Title, AdminID FROM BOOKING;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Replaced Add Booking with Edit Halls
     


        // Delete selected booking
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            DeleteBookingForm deleteForm = new DeleteBookingForm();
            deleteForm.Show();
        }

        // Update selected booking
        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int B_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["B_ID"].Value);
                UpdateBookingForm updateForm = new UpdateBookingForm(B_ID);
                updateForm.ShowDialog();
                btnShowBookings.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select a booking to update.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

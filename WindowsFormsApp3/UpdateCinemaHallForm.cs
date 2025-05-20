using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UpdateCinemaHallForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private int hallNo;

        public UpdateCinemaHallForm(int hallNo)
        {
            InitializeComponent();
            this.hallNo = hallNo;
        }

        private void UpdateCinemaHallForm_Load(object sender, EventArgs e)
        {
            // Load the current cinema hall's information into the textboxes
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT Ttype, Capacity, AdmID 
                        FROM CINEMA_HALL
                        WHERE Hall_no = @hallNo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hallNo", hallNo);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Display Hall_no as a label, not editable
                        lblHallNo.Text = hallNo.ToString();
                        txtTtype.Text = reader["Ttype"].ToString();
                        txtCapacity.Text = reader["Capacity"].ToString();
                        txtAdmID.Text = reader["AdmID"].ToString();  // Set the Admin ID
                    }
                    else
                    {
                        MessageBox.Show("Cinema Hall not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newTtype = txtTtype.Text;
            string newCapacity = txtCapacity.Text;
            string newAdmID = txtAdmID.Text;

            if (string.IsNullOrWhiteSpace(newTtype) || string.IsNullOrWhiteSpace(newCapacity) || string.IsNullOrWhiteSpace(newAdmID))
            {
                MessageBox.Show("Ttype, capacity, and admin ID must be provided.");
                return;
            }

            // Update the cinema hall's information in the CINEMA_HALL table
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE CINEMA_HALL
                        SET Ttype = @ttype, Capacity = @capacity, AdmID = @admID
                        WHERE Hall_no = @hallNo;
                    ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ttype", newTtype);
                    cmd.Parameters.AddWithValue("@capacity", newCapacity);
                    cmd.Parameters.AddWithValue("@admID", newAdmID);
                    cmd.Parameters.AddWithValue("@hallNo", hallNo);  // Hall_no remains the same

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cinema Hall updated successfully!");
                        this.Close();  // Close the update form
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

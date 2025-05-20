using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DeleteCustomerForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the customer ID from the TextBox
            int customerId;
            if (int.TryParse(txtCustomerId.Text, out customerId))
            {
                // Call the DeleteCustomer method
                bool success = DeleteCustomer(customerId);

                if (success)
                {
                    MessageBox.Show("Customer deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete customer.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Customer ID.");
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DeleteCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@target_id", customerId);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log the error and return false
                MessageBox.Show("Error deleting customer: " + ex.Message);
                return false;
            }
        }

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {
            // This can be left empty or used for initializations.
        }
    }
}

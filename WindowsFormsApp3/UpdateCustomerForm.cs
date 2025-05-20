using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UpdateCustomerForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private int customerId;

        public UpdateCustomerForm(int custId)
        {
            InitializeComponent();
            customerId = custId;
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            // Load the current customer's information into the textboxes
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT c.name, c.Address, cp.Number 
                        FROM CUSTOMER c
                        JOIN CUSTOMER_PHONE cp ON c.Cust_ID = cp.Cust_ID
                        WHERE c.Cust_ID = @custId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtName.Text = reader["name"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                        txtPhone.Text = reader["Number"].ToString();  // Set the phone number
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
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
            string newName = txtName.Text;
            string newAddress = txtAddress.Text;
            string newPhone = txtPhone.Text;

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newAddress) || string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Name, address, and phone number must be provided.");
                return;
            }

            // Update the customer's information in both CUSTOMER and CUSTOMER_PHONE tables
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE CUSTOMER
                        SET name = @name, Address = @address
                        WHERE Cust_ID = @custId;

                        UPDATE CUSTOMER_PHONE
                        SET Number = @phone
                        WHERE Cust_ID = @custId;
                    ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@address", newAddress);
                    cmd.Parameters.AddWithValue("@phone", newPhone);
                    cmd.Parameters.AddWithValue("@custId", customerId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully!");
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

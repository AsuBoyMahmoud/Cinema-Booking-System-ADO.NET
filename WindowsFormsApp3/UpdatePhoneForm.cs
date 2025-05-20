using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UpdatePhoneForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private int customerId;
        private string phoneNo;

        public UpdatePhoneForm(int custId, string Phone)
        {
            InitializeComponent();
            customerId = custId;
            phoneNo = Phone;
        }

        private void UpdatePhoneForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT Number 
                        FROM CUSTOMER_PHONE
                        WHERE Cust_ID = @custId AND Number = @phone";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@phone", phoneNo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtPhone.Text = reader["Number"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Phone number not found for the customer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            string newPhone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("Phone number must be provided.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE CUSTOMER_PHONE
                        SET Number = @newPhone
                        WHERE Cust_ID = @custId AND Number = @oldPhone;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@newPhone", newPhone);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@oldPhone", phoneNo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer phone updated successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Make sure the original phone exists.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string currentPhone = txtPhone.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        DELETE FROM CUSTOMER_PHONE 
                        WHERE Cust_ID = @custId AND Number = @phone;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@phone", currentPhone);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer phone deleted successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed. Make sure the phone number is correct.");
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
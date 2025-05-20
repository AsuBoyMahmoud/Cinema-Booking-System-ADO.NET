using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UpdateCard : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private int customerId;
        private int cardNo;

        public UpdateCard(int cust_Id, int card_No)
        {
            InitializeComponent();
            customerId = cust_Id;
            cardNo = card_No;
        }

        private void UpdateCard_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT CVC, ExpDate 
                        FROM CUSTOMER_CARD_DETAILS
                        WHERE Cust_ID = @custId AND CardNo = @cardNo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@cardNo", cardNo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCVC.Text = reader["CVC"].ToString();
                        txtExpDate.Text = Convert.ToDateTime(reader["ExpDate"]).ToString("MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show("Card not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdateCard_Click(object sender, EventArgs e)
        {
            string newCVC = txtCVC.Text.Trim();
            string newExpDate = txtExpDate.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCVC) || string.IsNullOrWhiteSpace(newExpDate))
            {
                MessageBox.Show("CVC and Expiration Date must be provided.");
                return;
            }

            if (!DateTime.TryParseExact(newExpDate, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedExpDate))
            {
                MessageBox.Show("Invalid date format. Please enter as MM/yyyy.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                UPDATE CUSTOMER_CARD_DETAILS
                SET CVC = @cvc, ExpDate = @expDate
                WHERE Cust_ID = @custId AND CardNo = @cardNo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cvc", newCVC);
                    cmd.Parameters.AddWithValue("@expDate", parsedExpDate);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@cardNo", cardNo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer card updated successfully!");
                        this.Close();
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


        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        DELETE FROM CUSTOMER_CARD_DETAILS
                        WHERE Cust_ID = @custId AND CardNo = @cardNo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@cardNo", cardNo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer card deleted successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed!");
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
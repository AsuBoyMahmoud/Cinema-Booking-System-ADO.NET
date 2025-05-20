using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class UpdateBookingForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private int bookingId;

        public UpdateBookingForm(int bId)
        {
            InitializeComponent();
            bookingId = bId;
        }
        private void LoadPaymentMethods()
        {
            updCmbPaymentMethod.Items.Clear();

            updCmbPaymentMethod.Items.AddRange(new object[]
            {
                "Cash",
                "Card",
                "Online"
            });

            updCmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateBookingForm_Load(object sender, EventArgs e)
        {
            // First load the payment methods
            LoadPaymentMethods();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT Hour, Minute, Date, P_method, AdminID, Cust_ID 
                FROM BOOKING 
                WHERE B_ID = @bookingId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bookingId", bookingId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        updTxtHour.Text = reader["Hour"].ToString();
                        updTxtMinute.Text = reader["Minute"].ToString();
                        updDtpDate.Value = Convert.ToDateTime(reader["Date"]);

                        // Set the payment method properly
                        string paymentMethod = reader["P_method"].ToString();
                        updCmbPaymentMethod.SelectedItem = paymentMethod;

                        updTxtAdminId.Text = reader["AdminID"].ToString();
                        updTxtCustomerId.Text = reader["Cust_ID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Booking not found.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading booking data: " + ex.Message);
                    this.Close();
                }
            }
        }

        private void updBtnUpdate_Click(object sender, EventArgs e)
        {
            string newHour = updTxtHour.Text;
            string newMin = updTxtMinute.Text;
            DateTime newDate = updDtpDate.Value;
            string newPM = updCmbPaymentMethod.Text;
            string newAD = updTxtAdminId.Text;
            string newCus = updTxtCustomerId.Text;

            if (string.IsNullOrWhiteSpace(newHour) || string.IsNullOrWhiteSpace(newMin) ||newDate.Equals("") ||
                string.IsNullOrWhiteSpace(newPM) || string.IsNullOrWhiteSpace(newAD) || string.IsNullOrWhiteSpace(newCus))
                 {
                MessageBox.Show("Time, date, payment method, admin ID and customer ID must be provided.");
                return;
                 }

                using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

                    conn.Open();
                    string query = @"
                        UPDATE BOOKING
                        SET Hour = @hour, Minute = @minute, Date = @date, P_method = @pmethod, AdminID = @adminId, Cust_ID = @custId
                        WHERE B_ID = @bookingId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hour", updTxtHour.Text);
                    cmd.Parameters.AddWithValue("@minute", updTxtMinute.Text);
                    cmd.Parameters.AddWithValue("@date", updDtpDate.Value);
                    cmd.Parameters.AddWithValue("@pmethod", updCmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@adminId", updTxtAdminId.Text);
                    cmd.Parameters.AddWithValue("@custId", updTxtCustomerId.Text);
                    cmd.Parameters.AddWithValue("@bookingId", bookingId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking updated successfully!");
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
    }
}

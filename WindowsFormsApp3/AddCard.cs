using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddCard : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private List<string> additionalPhones = new List<string>();

        public AddCard()
        {
            InitializeComponent();
        }

        private void AddCard_Load(object sender, EventArgs e)
        {
            SetPlaceholderText();

            // Set DateTimePicker to show only month and year
            dtpExpDate.Format = DateTimePickerFormat.Custom;
            dtpExpDate.CustomFormat = "MM/yyyy";
            dtpExpDate.ShowUpDown = true;
        }

        private void SetPlaceholderText()
        {
            txtCustID.Text = "CustID";
            txtCVC.Text = "CVC";
            txtCardNo.Text = "CardNo";
        }

        private void txtCustID_Enter(object sender, EventArgs e)
        {
            if (txtCustID.Text == "CustID") { txtCustID.Text = ""; txtCustID.ForeColor = System.Drawing.Color.Black; }
        }
        private void txtCustID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustID.Text)) { txtCustID.Text = "CustID"; txtCustID.ForeColor = System.Drawing.Color.Gray; }
        }

        private void txtCVC_Enter(object sender, EventArgs e)
        {
            if (txtCVC.Text == "CVC") { txtCVC.Text = ""; txtCVC.ForeColor = System.Drawing.Color.Black; }
        }
        private void txtCVC_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCVC.Text)) { txtCVC.Text = "CVC"; txtCVC.ForeColor = System.Drawing.Color.Gray; }
        }

        private void txtCardNo_Enter(object sender, EventArgs e)
        {
            if (txtCardNo.Text == "CardNo") { txtCardNo.Text = ""; txtCardNo.ForeColor = System.Drawing.Color.Black; }
        }
        private void txtCardNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNo.Text)) { txtCardNo.Text = "CardNo"; txtCardNo.ForeColor = System.Drawing.Color.Gray; }
        }

        public bool AddCardNo(int CustID, int CardNo, int CVC, DateTime ExpDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO CUSTOMER_CARD_DETAILS(Cust_ID, CVC, CardNo, ExpDate)
                                     VALUES(@custID, @CVC, @CardNo, @ExpDate);";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custID", CustID);
                    cmd.Parameters.AddWithValue("@CVC", CVC);
                    cmd.Parameters.AddWithValue("@CardNo", CardNo);
                    cmd.Parameters.AddWithValue("@ExpDate", ExpDate);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustID.Text, out int Cust_ID) ||
                !int.TryParse(txtCVC.Text, out int CVC) ||
                !int.TryParse(txtCardNo.Text, out int CardNo))
            {
                MessageBox.Show("Please enter valid numeric values for ID, CVC, and Card Number.");
                return;
            }

            // Force day to 1 for consistency
            DateTime selectedDate = dtpExpDate.Value;
            DateTime ExpDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);

            bool success = AddCardNo(Cust_ID, CardNo, CVC, ExpDate);

            if (success)
            {
                MessageBox.Show("Customer card added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add customer card.");
            }
        }
    }
}
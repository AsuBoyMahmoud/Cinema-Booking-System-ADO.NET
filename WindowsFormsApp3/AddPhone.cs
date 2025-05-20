using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;



namespace WindowsFormsApp3
{
    public partial class AddPhone : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;"; private List<string> additionalPhones = new List<string>();

        public AddPhone()
        {
            InitializeComponent();

        }

        private void AddPhone_Load(object sender, EventArgs e)
        {
            SetPlaceholderText();


        }

        private void SetPlaceholderText()
        {
            txtCustID.Text = "CustID";
            txtPhone.Text = "Phone";

        }

        private void txtCustID_Enter(object sender, EventArgs e)
        {
            if (txtCustID.Text == "CustID")
            {
                txtCustID.Text = "";
                txtCustID.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCustID_Leave(object sender, EventArgs e)
        {
            if (txtCustID.Text == "CustID")
            {
                txtCustID.Text = "";
                txtCustID.ForeColor = System.Drawing.Color.Gray;
            }
        }



        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone";
                txtPhone.ForeColor = System.Drawing.Color.Gray;
            }
        }




        public bool AddPhoneNo(int CustID, string Phone)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string query = @" Insert Into CUSTOMER_PHONE(Cust_ID,Number)
                                              Values(@custID,@phone);";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@custId", CustID);
                    cmd.Parameters.AddWithValue("@phone", Phone);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return false;
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int Cust_ID = int.Parse(txtCustID.Text);
            string phone = txtPhone.Text;


            // Validate inputs
            if (txtCustID.Text == "CustID" || string.IsNullOrWhiteSpace(txtCustID.Text))
            {
                MessageBox.Show("ID is required.");
                return;
            }

            if (phone == "Phone" || string.IsNullOrWhiteSpace(phone) || !phone.All(char.IsDigit))
            {
                MessageBox.Show("A valid phone number (digits only) is required.");
                return;
            }


            bool success = AddPhoneNo(Cust_ID, phone);

            if (success)
            {
                MessageBox.Show("Customer Phone added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add customer phone.");
            }
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddPhone_Load_1(object sender, EventArgs e)
        {

        }
    }
}
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;



namespace WindowsFormsApp3
{
    public partial class AddCustomerForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private List<string> additionalPhones = new List<string>();

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            SetPlaceholderText();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            ListBox1.Items.Clear();
        }

        private void SetPlaceholderText()
        {
            txtName.Text = "Name";
            txtPassword.Text = "Password";
            //txtPhone.Text = "Phone";
            txtAddress.Text = "Address";
            txtCVC.Text = "CVC";
            txtCardNo.Text = "Card Number";
            txtExpDate.Text = "Expiration Date (MM/YYYY)";
            ListBox1.Items.Add("Add another phone number if exists");
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtCVC_Enter(object sender, EventArgs e)
        {
            if (txtCVC.Text == "CVC")
            {
                txtCVC.Text = "";
                txtCVC.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCVC_Leave(object sender, EventArgs e)
        {
            if (txtCVC.Text == "")
            {
                txtCVC.Text = "CVC";
                txtCVC.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtExpDate_Enter(object sender, EventArgs e)
        {
            if (txtExpDate.Text == "Expiration Date (MM/YYYY)")
            {
                txtExpDate.Text = "";
                txtExpDate.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            if (txtExpDate.Text == "")
            {
                txtExpDate.Text = "Expiration Date (MM/YYYY)";
                txtExpDate.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtCardNo_Enter(object sender, EventArgs e)
        {
            if (txtCardNo.Text == "Card Number")
            {
                txtCardNo.Text = "";
                txtCardNo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCardNo_Leave(object sender, EventArgs e)
        {
            if (txtCardNo.Text == "")
            {
                txtCardNo.Text = "Card Number";
                txtCardNo.ForeColor = System.Drawing.Color.Gray;
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
       
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string newPhone = Prompt.ShowDialog("Enter additional phone number:", "Add Phone");
            if (!string.IsNullOrWhiteSpace(newPhone) && newPhone.All(char.IsDigit))
            {
                additionalPhones.Add(newPhone);
                ListBox1.Items.Add(newPhone);
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number (digits only).");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex >= 0)
            {
                additionalPhones.RemoveAt(ListBox1.SelectedIndex);
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a phone number to remove.");
            }
        }


        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        public bool AddCustomer(string name, string password, string phone, string address, string phone2, string CVC, string CardNo, string ExpDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@CVC", CVC);
                        cmd.Parameters.AddWithValue("@CardNo", CardNo);
                        if (DateTime.TryParseExact(ExpDate, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime expDateParsed))
                        {
                            cmd.Parameters.AddWithValue("@ExpDate", expDateParsed);
                        }
                        else
                        {
                            MessageBox.Show("Invalid expiration date format. Use MM/YYYY.");
                            return false;
                        }

                        if (string.IsNullOrEmpty(phone2))
                        {
                            cmd.Parameters.AddWithValue("@Phone2", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Phone2", phone2);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string ExpDate = txtExpDate.Text;
            string CVC = txtCVC.Text;
            string CardNo = txtCardNo.Text;
            string phone2 = additionalPhones.Any() ? additionalPhones[0] : null; // Use first additional phone, if any

            // Validate inputs
            if (name == "Name" || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }
            if (password == "Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }
            if (phone == "Phone" || string.IsNullOrWhiteSpace(phone) || !phone.All(char.IsDigit))
            {
                MessageBox.Show("A valid primary phone number (digits only) is required.");
                return;
            }
            if (address == "Address" || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required.");
                return;
            }
            if (CVC == "CVC" || string.IsNullOrWhiteSpace(CVC) || !CVC.All(char.IsDigit))
            {
                MessageBox.Show("CVC must be numeric.");
                return;
            }
            if (CardNo == "Card Number" || string.IsNullOrWhiteSpace(CardNo) || !CardNo.All(char.IsDigit))
            {
                MessageBox.Show("Card number must be numeric.");
                return;
            }
            if (ExpDate == "Expiration Date (MM/YYYY)" || string.IsNullOrWhiteSpace(ExpDate))
            {
                MessageBox.Show("Expiration date is required.");
                return;
            }

            bool success = AddCustomer(name, password, phone, address, phone2, CVC, CardNo, ExpDate);

            if (success)
            {
                MessageBox.Show("Customer added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add customer.");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
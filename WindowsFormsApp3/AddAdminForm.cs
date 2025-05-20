using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class AddAdminForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public AddAdminForm()
        {
            InitializeComponent();
        }

        private void AddAdminForm_Load(object sender, EventArgs e)
        {
            SetPlaceholderText();
        }

        private void SetPlaceholderText()
        {
            txtEmail.Text = "Email";
            txtPassword.Text = "Password";
        }

 

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        public bool AddAdmin( string email, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddAdmin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@E_mail", email);
                        cmd.Parameters.AddWithValue("@pass", password);
                 
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding admin: " + ex.Message);
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;


            bool success = AddAdmin(email, password);
            if (success)
            {
                MessageBox.Show("Admin added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add Admin.");
            }
        }
    }
}
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class UpdateAdminForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private int adminId;

        public UpdateAdminForm(int admId)
        {
            InitializeComponent();
            adminId = admId;
        }

        private void UpdateAdminForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AdmID, E_mail, pass FROM ADMIN WHERE AdmID = @adminId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtEmail.Text = reader["E_mail"].ToString();
                        txtPassword.Text = reader["pass"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Admin not found.");
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
            string newEmail = txtEmail.Text;
            string newPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Email and password must be provided.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE ADMIN
                        SET E_mail = @E_mail, pass = @pass
                        WHERE AdmID = @adminId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@E_MAIL", newEmail);
                    cmd.Parameters.AddWithValue("@pass", newPassword);
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin updated successfully!");
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

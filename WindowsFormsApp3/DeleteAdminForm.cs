using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DeleteAdminForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public DeleteAdminForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deleteAdminId;
            if (int.TryParse(txtDeleteAdminId.Text, out deleteAdminId))
            {
                bool deleteSuccess = DeleteAdmin(deleteAdminId);

                if (deleteSuccess)
                {
                    MessageBox.Show("Admin deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete admin.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Admin ID.");
            }
        }

        public bool DeleteAdmin(int deleteAdminId)
        {
            try
            {
                using (SqlConnection deleteConn = new SqlConnection(connectionString))
                {
                    deleteConn.Open();
                    using (SqlCommand deleteCmd = new SqlCommand("DeleteAdmin", deleteConn))
                    {
                        deleteCmd.CommandType = CommandType.StoredProcedure;
                        deleteCmd.Parameters.AddWithValue("@AdmID", deleteAdminId);

                        deleteCmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting admin: " + ex.Message);
                return false;
            }
        }

        private void DeleteAdminForm_Load(object sender, EventArgs e)
        {
        }
    }
}

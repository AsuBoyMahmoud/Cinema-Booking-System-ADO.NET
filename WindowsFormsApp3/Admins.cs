using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Admins : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public Admins()
        {
            InitializeComponent();
        }

        private void Admins_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.Text = "Admin Panel";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AddAdminForm addAdminForm = new AddAdminForm();
            addAdminForm.Show();
        }
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            DeleteAdminForm deleteAdminForm = new DeleteAdminForm();
            deleteAdminForm.Show();
        }

        private void btnShowAdmins_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AdmID, E_mail, Pass FROM ADMIN;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected customer's ID from the DataGridView
                int admID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AdmID"].Value);

                // Open the UpdateCustomerForm to get the new name and address
                UpdateAdminForm updateAdminForm = new UpdateAdminForm(admID);
                updateAdminForm.ShowDialog();

                // After update, refresh the customer data in DataGridView
                btnShowAdmins.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select an Admin to update.");
            }
        }
    }
}
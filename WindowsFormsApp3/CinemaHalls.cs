using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class CinemaHalls : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public CinemaHalls()
        {
            InitializeComponent();
        }

        private void CinemaHalls_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.Text = "Cinema Halls";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            AddCinemaHallForm addForm = new AddCinemaHallForm();
            addForm.Show();
        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {
            DeleteCinemaHallForm deleteForm = new DeleteCinemaHallForm();
            deleteForm.Show();
        }

        private void btnShowHalls_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Hall_no, Ttype, Capacity, AdmID FROM CINEMA_HALL;";
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

        private void btnUpdateHall_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int hallNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Hall_no"].Value);
                UpdateCinemaHallForm updateForm = new UpdateCinemaHallForm(hallNo);
                updateForm.ShowDialog();
                btnShowHalls.PerformClick(); // refresh
            }
            else
            {
                MessageBox.Show("Please select a hall to update.");
            }
        }
    }
}

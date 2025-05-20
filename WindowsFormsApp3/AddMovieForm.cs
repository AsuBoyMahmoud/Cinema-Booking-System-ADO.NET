using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddMovieForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            LoadHallNumbers();
            LoadPlays(); 
        }

        private void LoadHallNumbers()
        {
            cmbHallNumber.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Hall_no FROM Cinema_Hall", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbHallNumber.Items.Add(reader["Hall_no"].ToString());
                }
            }
        }

        private void LoadPlays()
        {
            dgvPlays.Rows.Clear();

            if (dgvPlays.Columns.Count == 0)
            {
                dgvPlays.Columns.Add("Movie_title", "Movie Title");
                dgvPlays.Columns.Add("Hall_no", "Hall No");
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Movie_title, Hall_no FROM plays", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dgvPlays.Rows.Add(
                        reader["Movie_title"],
                        reader["Hall_no"]
                    );
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                float duration = float.Parse(txtDuration.Text.Trim());
                int adminID = int.Parse(txtAdminID.Text.Trim());
                string genre = txtGenre.Text.Trim();
                int hallNo = int.Parse(cmbHallNumber.SelectedItem.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EXEC AddMovie @Title, @Duration, @AdminID, @Genre, @Hall_no", conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Duration", duration);
                    cmd.Parameters.AddWithValue("@AdminID", adminID);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Hall_no", hallNo);

                    cmd.ExecuteNonQuery();
                }

                LoadPlays();

                txtTitle.Clear();
                txtDuration.Clear();
                txtAdminID.Clear();
                txtGenre.Clear();
                cmbHallNumber.SelectedIndex = -1;

                MessageBox.Show("Movie added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

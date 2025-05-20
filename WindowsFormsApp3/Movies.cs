using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Movies : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public Movies()
        {
            InitializeComponent();
        }
        private void btnEditHalls_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedMovieTitle = dataGridView1.SelectedRows[0].Cells["Title"].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedMovieTitle))
                {
                    EditHallsForm editHallsForm = new EditHallsForm(selectedMovieTitle);
                    editHallsForm.ShowDialog();

                    btnShowMovies.PerformClick();  
                }
                else
                {
                    MessageBox.Show("Please select a movie to edit halls.");
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to edit.");
            }
        }


        private void Movies_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.Text = "Movies Management";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            addMovieForm.Show();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            DeleteMovieForm deleteForm = new DeleteMovieForm();
            deleteForm.Show();
        }

        private void btnShowMovies_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT Title, Duration, AdminID, Genre
                        FROM MOVIE;";

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

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedTitle = dataGridView1.SelectedRows[0].Cells["Title"].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedTitle))
                {
                    UpdateMovieForm updateForm = new UpdateMovieForm(selectedTitle);
                    updateForm.ShowDialog();
                    btnShowMovies.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to update.");
            }
        }
    }
}

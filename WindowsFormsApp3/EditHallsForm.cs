using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class EditHallsForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private string selectedMovieTitle;

        public EditHallsForm(string movieTitle)
        {
            InitializeComponent();
            selectedMovieTitle = movieTitle;
        }

        private void EditHallsForm_Load(object sender, EventArgs e)
        {
            LoadAvailableHalls();
        }

        // Load available halls into ComboBox
        private void LoadAvailableHalls()
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

        // Button click to add a hall for the selected movie
        private void btnAssignHall_Click(object sender, EventArgs e)
        {
            if (cmbHallNumber.SelectedItem != null)
            {
                int hallNo = int.Parse(cmbHallNumber.SelectedItem.ToString());

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO plays (Movie_title, Hall_no) VALUES (@MovieTitle, @HallNo)", conn);
                        cmd.Parameters.AddWithValue("@MovieTitle", selectedMovieTitle);
                        cmd.Parameters.AddWithValue("@HallNo", hallNo);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hall assigned successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error assigning hall: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a hall.");
            }
        }
    }
}

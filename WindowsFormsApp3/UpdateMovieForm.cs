using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UpdateMovieForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";
        private string movieTitle;

        public UpdateMovieForm(string title)
        {
            InitializeComponent();
            movieTitle = title;
        }

        private void UpdateMovieForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string movieQuery = "SELECT Duration FROM Movie WHERE Title = @title";
                    SqlCommand movieCmd = new SqlCommand(movieQuery, conn);
                    movieCmd.Parameters.AddWithValue("@title", movieTitle);

                    string genreQuery = "SELECT Genre FROM MOVIE_GENRE WHERE Movie_title = @title";
                    SqlCommand genreCmd = new SqlCommand(genreQuery, conn);
                    genreCmd.Parameters.AddWithValue("@title", movieTitle);

                    var duration = movieCmd.ExecuteScalar()?.ToString();
                    var genre = genreCmd.ExecuteScalar()?.ToString();

                    if (duration != null)
                    {
                        txtTitle.Text = movieTitle;
                        txtTitle.ReadOnly = true;
                        txtDuration.Text = duration;
                        txtGenre.Text = genre ?? ""; 
                    }
                    else
                    {
                        MessageBox.Show("Movie not found.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    this.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newGenre = txtGenre.Text;
            string newDuration = txtDuration.Text;

            if (string.IsNullOrWhiteSpace(newGenre) || string.IsNullOrWhiteSpace(newDuration))
            {
                MessageBox.Show("Genre and duration must be provided.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string movieQuery = "UPDATE Movie SET Duration = @duration WHERE Title = @title";
                        SqlCommand movieCmd = new SqlCommand(movieQuery, conn, transaction);
                        movieCmd.Parameters.AddWithValue("@duration", newDuration);
                        movieCmd.Parameters.AddWithValue("@title", movieTitle);
                        movieCmd.ExecuteNonQuery();

                        // Update or insert into MOVIE_GENRE table
                        string genreQuery = @"
                            IF EXISTS (SELECT 1 FROM MOVIE_GENRE WHERE Movie_title = @title)
                                UPDATE MOVIE_GENRE SET Genre = @genre WHERE Movie_title = @title
                            ELSE
                                INSERT INTO MOVIE_GENRE (Movie_title, Genre) VALUES (@title, @genre)";

                        SqlCommand genreCmd = new SqlCommand(genreQuery, conn, transaction);
                        genreCmd.Parameters.AddWithValue("@genre", newGenre);
                        genreCmd.Parameters.AddWithValue("@title", movieTitle);
                        genreCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Movie updated successfully!");
                        this.Close();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating movie: " + ex.Message);
                }
            }
        }
    }
}
using System;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WinFormsApp3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Optional: Add logic to run on form load
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Admins adminForm = new Admins();
            this.Hide();
            adminForm.FormClosed += (s, args) => this.Show();
            adminForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Customers custForm = new Customers();
            this.Hide();
            custForm.FormClosed += (s, args) => this.Show();
            custForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CinemaHalls cinemaForm = new CinemaHalls();
            this.Hide();
            cinemaForm.FormClosed += (s, args) => this.Show();
            cinemaForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Movies movieForm = new Movies();
            this.Hide();
            movieForm.FormClosed += (s, args) => this.Show();
            movieForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Background click handler (optional)
        }

       

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Bookings bookingForm = new Bookings();
            this.Hide();
            bookingForm.FormClosed += (s, args) => this.Show();
            bookingForm.Show();
        }
    }

}

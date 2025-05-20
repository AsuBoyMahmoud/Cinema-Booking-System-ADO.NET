using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class AddCinemaHallForm : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public AddCinemaHallForm()
        {
            InitializeComponent();
        }

        private void AddCinemaHallForm_Load(object sender, EventArgs e)
        {
            SetPlaceholderText();
        }

        private void SetPlaceholderText()
        {
            txtType.Text = "Type";
            txtCapacity.Text = "Capacity";
            txtCAdminID.Text = "Admin ID";
        }



        private void txtType_Enter(object sender, EventArgs e)
        {
            if (txtType.Text == "Type")
            {
                txtType.Text = "";
                txtType.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtType_Leave(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                txtType.Text = "Type";
                txtType.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtCapacity_Enter(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "Capacity")
            {
                txtCapacity.Text = "";
                txtCapacity.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (txtCapacity.Text == "")
            {
                txtCapacity.Text = "Capacity";
                txtCapacity.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtCAdminID_Enter(object sender, EventArgs e)
        {
            if (txtCAdminID.Text == "Admin ID")
            {
                txtCAdminID.Text = "";
                txtCAdminID.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCAdminID_Leave(object sender, EventArgs e)
        {
            if (txtCAdminID.Text == "")
            {
                txtCAdminID.Text = "Admin ID";
                txtCAdminID.ForeColor = System.Drawing.Color.Gray;
            }
        }

        public bool AddCinemaHall(string type, int capacity, int adminID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddCinemaHall", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Ttype", type);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@AdmID", adminID);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding cinema hall: " + ex.Message);
                return false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string type = txtType.Text;
            int capacity = int.Parse(txtCapacity.Text);
            int admID = int.Parse(txtCAdminID.Text); ;

            bool success = AddCinemaHall(type, capacity, admID);

            if (success)
            {
                MessageBox.Show("Cinema Hall added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add Cinema hall.");
            }
        }
    }
}

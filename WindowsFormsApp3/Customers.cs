using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Customers : Form
    {
        private string connectionString = @"Server=MAHMOUDS-LENOVO;Database=cinemaTickets;Integrated Security=True;";

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // Allow the title bar and control box (minimize/maximize/close buttons)
            this.FormBorderStyle = FormBorderStyle.Sizable;  // Title bar with X button
            this.ControlBox = true;  // Enable the close button (X)
            this.Text = "Main Menu";  // Title for the form
            this.StartPosition = FormStartPosition.CenterScreen;  // Center the form on the screen
        }

        // Method to open the AddCustomerForm
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        // Method to open the DeleteCustomerForm
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm deleteForm = new DeleteCustomerForm();
            deleteForm.Show();
        }

        // Show customers (ID, name, address, phone) in DataGridView
        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Load Customer Info
                    string customerQuery = @"SELECT Cust_ID, Name, Address, Password FROM CUSTOMER";
                    SqlDataAdapter customerAdapter = new SqlDataAdapter(customerQuery, conn);
                    DataTable customerTable = new DataTable();
                    customerAdapter.Fill(customerTable);
                    dataGridView1.DataSource = customerTable;

                    // Load Card Details
                    string cardQuery = @"SELECT Cust_ID, CVC, CardNo, ExpDate FROM CUSTOMER_CARD_DETAILS";
                    SqlDataAdapter cardAdapter = new SqlDataAdapter(cardQuery, conn);
                    DataTable cardTable = new DataTable();
                    cardAdapter.Fill(cardTable);
                    dataGridView2.DataSource = cardTable;

                    // Load Phone Numbers
                    string phoneQuery = @"SELECT Cust_ID, Number AS PhoneNumber FROM CUSTOMER_PHONE";
                    SqlDataAdapter phoneAdapter = new SqlDataAdapter(phoneQuery, conn);
                    DataTable phoneTable = new DataTable();
                    phoneAdapter.Fill(phoneTable);
                    dataGridView3.DataSource = phoneTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Update customer information
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int custId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Cust_ID"].Value);
                UpdateCustomerForm updateForm = new UpdateCustomerForm(custId);
                updateForm.ShowDialog();
                btnShow.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int custId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["Cust_ID"].Value);
                string phone = dataGridView3.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                UpdatePhoneForm updateForm = new UpdatePhoneForm(custId, phone);
                updateForm.ShowDialog();
                btnShow.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select a customer phone to update.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPhone addForm = new AddPhone();
            addForm.Show();
        }

        private void btnUpdateCard_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int custId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Cust_ID"].Value);
                int cardNo = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["CardNo"].Value);
                UpdateCard updateForm = new UpdateCard(custId, cardNo);
                updateForm.ShowDialog();
                btnShow.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select a card to update.");
            }
        }


        private void btnAddCard_Click(object sender, EventArgs e)
        {
            AddCard addForm = new AddCard();
            addForm.Show();
        }
    }
}
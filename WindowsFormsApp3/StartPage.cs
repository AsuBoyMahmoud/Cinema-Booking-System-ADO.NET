using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;

namespace WindowsFormsApp3
{
    public partial class StartPage: Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage admin = new MainPage();
            this.Hide();
            admin.FormClosed += (s, args) => this.Show();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPageCustomer customer = new mainPageCustomer();
            customer.FormClosed += (s, args) => this.Show();
            customer.Show();
        }
    }
}

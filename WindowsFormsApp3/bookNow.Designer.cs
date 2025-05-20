namespace WindowsFormsApp3
{
    partial class BookNow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblMovieSelection;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblMovieSelection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(560, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(12, 290);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Cash",
            "PayPal"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(12, 330);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(200, 24);
            this.cmbPaymentMethod.TabIndex = 2;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(12, 370);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(200, 23);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(220, 290);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(114, 16);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "Enter Customer ID";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(220, 330);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(149, 16);
            this.lblPaymentMethod.TabIndex = 5;
            this.lblPaymentMethod.Text = "Select Payment Method";
            // 
            // lblMovieSelection
            // 
            this.lblMovieSelection.AutoSize = true;
            this.lblMovieSelection.Location = new System.Drawing.Point(12, 20);
            this.lblMovieSelection.Name = "lblMovieSelection";
            this.lblMovieSelection.Size = new System.Drawing.Size(99, 16);
            this.lblMovieSelection.TabIndex = 6;
            this.lblMovieSelection.Text = "Select a Movie:";
            // 
            // BookNow
            // 
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lblMovieSelection);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookNow";
            this.Text = "Book Movie Ticket";
            this.Load += new System.EventHandler(this.bookNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

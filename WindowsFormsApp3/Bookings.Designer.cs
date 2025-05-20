namespace WindowsFormsApp3
{
    partial class Bookings
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowBookings;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnUpdateBooking;

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
            this.btnShowBookings = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnUpdateBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(760, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.Location = new System.Drawing.Point(12, 380);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(120, 30);
            this.btnShowBookings.TabIndex = 1;
            this.btnShowBookings.Text = "Show Bookings";
            this.btnShowBookings.UseVisualStyleBackColor = true;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(150, 380);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteBooking.TabIndex = 2;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnUpdateBooking
            // 
            this.btnUpdateBooking.Location = new System.Drawing.Point(290, 380);
            this.btnUpdateBooking.Name = "btnUpdateBooking";
            this.btnUpdateBooking.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateBooking.TabIndex = 3;
            this.btnUpdateBooking.Text = "Update Booking";
            this.btnUpdateBooking.UseVisualStyleBackColor = true;
            this.btnUpdateBooking.Click += new System.EventHandler(this.btnUpdateBooking_Click);
            // 
            // Bookings
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnUpdateBooking);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnShowBookings);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bookings";
            this.Text = "Bookings Management";
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

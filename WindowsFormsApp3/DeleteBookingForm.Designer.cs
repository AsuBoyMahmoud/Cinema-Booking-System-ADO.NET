namespace WindowsFormsApp3
{
    partial class DeleteBookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblBookingId;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtBookingId
            this.txtBookingId.Location = new System.Drawing.Point(30, 50);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(200, 20);
            this.txtBookingId.TabIndex = 0;

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(30, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Booking";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // lblBookingId
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Location = new System.Drawing.Point(30, 30);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(65, 13);
            this.lblBookingId.TabIndex = 2;
            this.lblBookingId.Text = "Booking ID:";

            // DeleteBookingForm
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblBookingId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBookingId);
            this.Name = "DeleteBookingForm";
            this.Text = "Delete Booking";
            this.Load += new System.EventHandler(this.DeleteBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

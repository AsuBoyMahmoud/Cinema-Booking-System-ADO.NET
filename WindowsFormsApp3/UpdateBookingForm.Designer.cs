namespace WindowsFormsApp3
{
    partial class UpdateBookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox updTxtHour;
        private System.Windows.Forms.TextBox updTxtMinute;
        private System.Windows.Forms.DateTimePicker updDtpDate;
        private System.Windows.Forms.ComboBox updCmbPaymentMethod;
        private System.Windows.Forms.TextBox updTxtAdminId;
        private System.Windows.Forms.TextBox updTxtCustomerId;
        private System.Windows.Forms.Button updBtnUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.updTxtHour = new System.Windows.Forms.TextBox();
            this.updTxtMinute = new System.Windows.Forms.TextBox();
            this.updDtpDate = new System.Windows.Forms.DateTimePicker();
            this.updCmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.updTxtAdminId = new System.Windows.Forms.TextBox();
            this.updTxtCustomerId = new System.Windows.Forms.TextBox();
            this.updBtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // updTxtHour
            this.updTxtHour.Location = new System.Drawing.Point(50, 30);
            this.updTxtHour.Name = "updTxtHour";
            this.updTxtHour.Size = new System.Drawing.Size(200, 22);

            // updTxtMinute
            this.updTxtMinute.Location = new System.Drawing.Point(50, 70);
            this.updTxtMinute.Name = "updTxtMinute";
            this.updTxtMinute.Size = new System.Drawing.Size(200, 22);

            // updDtpDate
            this.updDtpDate.Location = new System.Drawing.Point(50, 110);
            this.updDtpDate.Name = "updDtpDate";
            this.updDtpDate.Size = new System.Drawing.Size(200, 22);

            // updCmbPaymentMethod
            this.updCmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updCmbPaymentMethod.FormattingEnabled = true;
            this.updCmbPaymentMethod.Location = new System.Drawing.Point(50, 150);
            this.updCmbPaymentMethod.Name = "updCmbPaymentMethod";
            this.updCmbPaymentMethod.Size = new System.Drawing.Size(200, 21);

            // updTxtAdminId
            this.updTxtAdminId.Location = new System.Drawing.Point(50, 190);
            this.updTxtAdminId.Name = "updTxtAdminId";
            this.updTxtAdminId.Size = new System.Drawing.Size(200, 22);

            // updTxtCustomerId
            this.updTxtCustomerId.Location = new System.Drawing.Point(50, 230);
            this.updTxtCustomerId.Name = "updTxtCustomerId";
            this.updTxtCustomerId.Size = new System.Drawing.Size(200, 22);

            // updBtnUpdate
            this.updBtnUpdate.Location = new System.Drawing.Point(50, 270);
            this.updBtnUpdate.Name = "updBtnUpdate";
            this.updBtnUpdate.Size = new System.Drawing.Size(200, 40);
            this.updBtnUpdate.Text = "Update Booking";
            this.updBtnUpdate.UseVisualStyleBackColor = true;
            this.updBtnUpdate.Click += new System.EventHandler(this.updBtnUpdate_Click);

            // UpdateBookingForm
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.updTxtHour);
            this.Controls.Add(this.updTxtMinute);
            this.Controls.Add(this.updDtpDate);
            this.Controls.Add(this.updCmbPaymentMethod);
            this.Controls.Add(this.updTxtAdminId);
            this.Controls.Add(this.updTxtCustomerId);
            this.Controls.Add(this.updBtnUpdate);
            this.Name = "UpdateBookingForm";
            this.Text = "Update Booking";
            this.Load += new System.EventHandler(this.UpdateBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

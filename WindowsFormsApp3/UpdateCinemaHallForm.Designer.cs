namespace WindowsFormsApp3
{
    partial class UpdateCinemaHallForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTtype;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtAdmID;
        private System.Windows.Forms.Label lblHallNo;  // Add a label to display Hall_no
        private System.Windows.Forms.Button btnUpdate;

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
            this.txtTtype = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtAdmID = new System.Windows.Forms.TextBox();
            this.lblHallNo = new System.Windows.Forms.Label();  // Initialize the label
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtTtype
            // 
            this.txtTtype.Location = new System.Drawing.Point(50, 30);
            this.txtTtype.Name = "txtTtype";
            this.txtTtype.Size = new System.Drawing.Size(200, 22);
            this.txtTtype.TabIndex = 0;

            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(50, 70);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(200, 22);
            this.txtCapacity.TabIndex = 1;

            // 
            // txtAdmID
            // 
            this.txtAdmID.Location = new System.Drawing.Point(50, 110);
            this.txtAdmID.Name = "txtAdmID";
            this.txtAdmID.Size = new System.Drawing.Size(200, 22);
            this.txtAdmID.TabIndex = 2;

            // 
            // lblHallNo
            // 
            this.lblHallNo.Location = new System.Drawing.Point(50, 150);
            this.lblHallNo.Name = "lblHallNo";
            this.lblHallNo.Size = new System.Drawing.Size(200, 22);
            this.lblHallNo.TabIndex = 3;
            this.lblHallNo.Text = "Hall No: ";  // This will display Hall_no
            this.lblHallNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Cinema Hall";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // UpdateCinemaHallForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblHallNo);  // Add the label to the form
            this.Controls.Add(this.txtAdmID);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtTtype);
            this.Name = "UpdateCinemaHallForm";
            this.Text = "Update Cinema Hall";
            this.Load += new System.EventHandler(this.UpdateCinemaHallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

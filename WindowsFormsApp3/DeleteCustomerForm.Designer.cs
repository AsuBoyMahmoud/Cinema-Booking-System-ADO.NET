namespace WindowsFormsApp3
{
    partial class DeleteCustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCustomerId;

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
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(30, 50);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerId.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(30, 30);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(70, 13);
            this.lblCustomerId.TabIndex = 2;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // DeleteCustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtCustomerId);
            this.Name = "DeleteCustomerForm";
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.DeleteCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

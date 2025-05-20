namespace WindowsFormsApp3
{
    partial class UpdateCustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 0;

            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(50, 70);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 1;

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(50, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 2;

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // UpdateCustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "UpdateCustomerForm";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.UpdateCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

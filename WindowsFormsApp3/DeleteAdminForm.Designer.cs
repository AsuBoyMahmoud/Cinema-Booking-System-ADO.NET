namespace WindowsFormsApp3
{
    partial class DeleteAdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDeleteAdminId;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Label lblDeleteAdminId;

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
            this.txtDeleteAdminId = new System.Windows.Forms.TextBox();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.lblDeleteAdminId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDeleteAdminId
            // 
            this.txtDeleteAdminId.Location = new System.Drawing.Point(30, 50);
            this.txtDeleteAdminId.Name = "txtDeleteAdminId";
            this.txtDeleteAdminId.Size = new System.Drawing.Size(200, 20);
            this.txtDeleteAdminId.TabIndex = 0;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Location = new System.Drawing.Point(30, 90);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(200, 30);
            this.btnDeleteAdmin.TabIndex = 1;
            this.btnDeleteAdmin.Text = "Delete Admin";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDeleteAdminId
            // 
            this.lblDeleteAdminId.AutoSize = true;
            this.lblDeleteAdminId.Location = new System.Drawing.Point(30, 30);
            this.lblDeleteAdminId.Name = "lblDeleteAdminId";
            this.lblDeleteAdminId.Size = new System.Drawing.Size(55, 13);
            this.lblDeleteAdminId.TabIndex = 2;
            this.lblDeleteAdminId.Text = "Admin ID:";
            // 
            // DeleteAdminForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblDeleteAdminId);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.txtDeleteAdminId);
            this.Name = "DeleteAdminForm";
            this.Text = "Delete Admin";
            this.Load += new System.EventHandler(this.DeleteAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

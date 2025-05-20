namespace WindowsFormsApp3
{
    partial class UpdateCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.TextBox txtExpDate;
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
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtCVC.Location = new System.Drawing.Point(50, 110);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(200, 27);
            this.txtCVC.TabIndex = 2;
            // 
            this.txtExpDate.Location = new System.Drawing.Point(50, 130);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(200, 27);
            this.txtExpDate.TabIndex = 2;
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Customer Card";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateCard_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Customer Card";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteCard_Click);
            // 
            // UpdatePhoneForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.txtExpDate);

            this.Name = "UpdateCard";
            this.Text = "Update Customer Card";
            this.Load += new System.EventHandler(this.UpdateCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnDelete;
    }
}
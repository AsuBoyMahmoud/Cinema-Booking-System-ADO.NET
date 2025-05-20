namespace WindowsFormsApp3
{
    partial class AddCinemaHallForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtCAdminID;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtCAdminID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
         
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(30, 60);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 1;
            this.txtType.Enter += new System.EventHandler(this.txtType_Enter);
            this.txtType.Leave += new System.EventHandler(this.txtType_Leave);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(30, 90);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(200, 20);
            this.txtCapacity.TabIndex = 2;
            this.txtCapacity.Enter += new System.EventHandler(this.txtCapacity_Enter);
            this.txtCapacity.Leave += new System.EventHandler(this.txtCapacity_Leave);
            // 
            // txtAdminID
            // 
            this.txtCAdminID.Location = new System.Drawing.Point(30, 120);
            this.txtCAdminID.Name = "txtAdminID";
            this.txtCAdminID.Size = new System.Drawing.Size(200, 20);
            this.txtCAdminID.TabIndex = 3;
            this.txtCAdminID.Enter += new System.EventHandler(this.txtCAdminID_Enter);
            this.txtCAdminID.Leave += new System.EventHandler(this.txtCAdminID_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(30, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Add Cinema Hall";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddCinemaHallForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtCAdminID);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AddCinemaHallForm";
            this.Text = "Add Cinema Hall";
            this.Load += new System.EventHandler(this.AddCinemaHallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

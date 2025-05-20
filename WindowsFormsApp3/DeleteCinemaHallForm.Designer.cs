namespace WindowsFormsApp3
{
    partial class DeleteCinemaHallForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHallNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHallNo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtHallNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHallNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHallNo
            // 
            this.txtHallNo.Location = new System.Drawing.Point(30, 50);
            this.txtHallNo.Name = "txtHallNo";
            this.txtHallNo.Size = new System.Drawing.Size(200, 20);
            this.txtHallNo.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Cinema Hall";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHallNo
            // 
            this.lblHallNo.AutoSize = true;
            this.lblHallNo.Location = new System.Drawing.Point(30, 30);
            this.lblHallNo.Name = "lblHallNo";
            this.lblHallNo.Size = new System.Drawing.Size(56, 13);
            this.lblHallNo.TabIndex = 2;
            this.lblHallNo.Text = "Hall Number:";
            // 
            // DeleteCinemaHallForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblHallNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtHallNo);
            this.Name = "DeleteCinemaHallForm";
            this.Text = "Delete Cinema Hall";
            this.Load += new System.EventHandler(this.DeleteCinemaHallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

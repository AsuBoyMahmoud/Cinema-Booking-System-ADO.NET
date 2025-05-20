namespace WindowsFormsApp3
{
    partial class EditHallsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbHallNumber;
        private System.Windows.Forms.Button btnAssignHall;
        private System.Windows.Forms.Label lblSelectHall;

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
            this.cmbHallNumber = new System.Windows.Forms.ComboBox();
            this.btnAssignHall = new System.Windows.Forms.Button();
            this.lblSelectHall = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // cmbHallNumber
            // 
            this.cmbHallNumber.FormattingEnabled = true;
            this.cmbHallNumber.Location = new System.Drawing.Point(30, 50);
            this.cmbHallNumber.Name = "cmbHallNumber";
            this.cmbHallNumber.Size = new System.Drawing.Size(200, 24);
            this.cmbHallNumber.TabIndex = 0;

            // 
            // btnAssignHall
            // 
            this.btnAssignHall.Location = new System.Drawing.Point(30, 100);
            this.btnAssignHall.Name = "btnAssignHall";
            this.btnAssignHall.Size = new System.Drawing.Size(200, 30);
            this.btnAssignHall.TabIndex = 1;
            this.btnAssignHall.Text = "Assign Hall";
            this.btnAssignHall.UseVisualStyleBackColor = true;
            this.btnAssignHall.Click += new System.EventHandler(this.btnAssignHall_Click);

            // 
            // lblSelectHall
            // 
            this.lblSelectHall.AutoSize = true;
            this.lblSelectHall.Location = new System.Drawing.Point(30, 30);
            this.lblSelectHall.Name = "lblSelectHall";
            this.lblSelectHall.Size = new System.Drawing.Size(97, 17);
            this.lblSelectHall.TabIndex = 2;
            this.lblSelectHall.Text = "Select Hall No:";

            // 
            // EditHallsForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblSelectHall);
            this.Controls.Add(this.btnAssignHall);
            this.Controls.Add(this.cmbHallNumber);
            this.Name = "EditHallsForm";
            this.Text = "Edit Halls";
            this.Load += new System.EventHandler(this.EditHallsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

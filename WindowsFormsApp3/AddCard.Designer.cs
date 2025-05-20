namespace WindowsFormsApp3
{
    partial class AddCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(300, 50);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(200, 27);
            this.txtCustID.TabIndex = 0;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(300, 90);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(200, 27);
            this.txtCardNo.TabIndex = 1;
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(300, 130);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(200, 27);
            this.txtCVC.TabIndex = 2;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "MM/yyyy";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.ShowUpDown = true;
            this.dtpExpDate.Location = new System.Drawing.Point(300, 170);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(200, 27);
            this.dtpExpDate.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(300, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 30);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Add Card";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AddCard";
            this.Text = "AddCard";
            this.Load += new System.EventHandler(this.AddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Button btnSubmit;
    }
}
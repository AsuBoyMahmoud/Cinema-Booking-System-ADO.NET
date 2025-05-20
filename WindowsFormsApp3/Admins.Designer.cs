namespace WindowsFormsApp3
{
    partial class Admins
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnShowAdmins;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        

        private System.Windows.Forms.DataGridView dataGridView1;

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
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnShowAdmins = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // btnAddAdmin
            //
            this.btnAddAdmin.Location = new System.Drawing.Point(50, 50);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(150, 40);
            this.btnAddAdmin.TabIndex = 1;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);

            this.btnDeleteAdmin.Location = new System.Drawing.Point(50, 110);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteAdmin.TabIndex = 1;
            this.btnDeleteAdmin.Text = "Delete Admin";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            //
            // btnShowAdmins
            //
            this.btnShowAdmins.Location = new System.Drawing.Point(50, 170);
            this.btnShowAdmins.Name = "btnShowAdmins";
            this.btnShowAdmins.Size = new System.Drawing.Size(150, 40);
            this.btnShowAdmins.TabIndex = 1;
            this.btnShowAdmins.Text = "Show Admins";
            this.btnShowAdmins.UseVisualStyleBackColor = true;
            this.btnShowAdmins.Click += new System.EventHandler(this.btnShowAdmins_Click);
            //

            this.btnUpdateAdmin.Location = new System.Drawing.Point(50, 230);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateAdmin.TabIndex = 3;
            this.btnUpdateAdmin.Text = "Update Admin";
            this.btnUpdateAdmin.UseVisualStyleBackColor = true;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);

            // dataGridView1
            //
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 220);
            this.dataGridView1.TabIndex = 4;
             
           
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateAdmin);
            this.Controls.Add(this.btnShowAdmins);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnAddAdmin);
            this.Name = "Admins";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Admins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

  
        }
    }
}
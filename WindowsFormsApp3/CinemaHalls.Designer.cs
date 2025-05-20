namespace WindowsFormsApp3
{
    partial class CinemaHalls
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.Button btnDeleteHall;
        private System.Windows.Forms.Button btnShowHalls;
        private System.Windows.Forms.Button btnUpdateHall;
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
            this.btnAddHall = new System.Windows.Forms.Button();
            this.btnDeleteHall = new System.Windows.Forms.Button();
            this.btnShowHalls = new System.Windows.Forms.Button();
            this.btnUpdateHall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddHall
            // 
            this.btnAddHall.Location = new System.Drawing.Point(50, 50);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(150, 40);
            this.btnAddHall.TabIndex = 0;
            this.btnAddHall.Text = "Add Hall";
            this.btnAddHall.UseVisualStyleBackColor = true;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // btnDeleteHall
            // 
            this.btnDeleteHall.Location = new System.Drawing.Point(50, 110);
            this.btnDeleteHall.Name = "btnDeleteHall";
            this.btnDeleteHall.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteHall.TabIndex = 1;
            this.btnDeleteHall.Text = "Delete Hall";
            this.btnDeleteHall.UseVisualStyleBackColor = true;
            this.btnDeleteHall.Click += new System.EventHandler(this.btnDeleteHall_Click);
            // 
            // btnShowHalls
            // 
            this.btnShowHalls.Location = new System.Drawing.Point(50, 170);
            this.btnShowHalls.Name = "btnShowHalls";
            this.btnShowHalls.Size = new System.Drawing.Size(150, 40);
            this.btnShowHalls.TabIndex = 2;
            this.btnShowHalls.Text = "Show Halls";
            this.btnShowHalls.UseVisualStyleBackColor = true;
            this.btnShowHalls.Click += new System.EventHandler(this.btnShowHalls_Click);
            // 
            // btnUpdateHall
            // 
            this.btnUpdateHall.Location = new System.Drawing.Point(50, 230);
            this.btnUpdateHall.Name = "btnUpdateHall";
            this.btnUpdateHall.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateHall.TabIndex = 3;
            this.btnUpdateHall.Text = "Update Hall";
            this.btnUpdateHall.UseVisualStyleBackColor = true;
            this.btnUpdateHall.Click += new System.EventHandler(this.btnUpdateHall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 220);
            this.dataGridView1.TabIndex = 4;
            // 
            // CinemaHalls
            // 
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateHall);
            this.Controls.Add(this.btnShowHalls);
            this.Controls.Add(this.btnDeleteHall);
            this.Controls.Add(this.btnAddHall);
            this.Name = "CinemaHalls";
            this.Text = "Cinema Halls";
            this.Load += new System.EventHandler(this.CinemaHalls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

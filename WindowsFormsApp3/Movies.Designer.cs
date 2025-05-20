namespace WindowsFormsApp3
{
    partial class Movies
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnShowMovies;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnEditHalls;  // New button for Edit Halls
        private System.Windows.Forms.DataGridView dataGridView1;

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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnShowMovies = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnEditHalls = new System.Windows.Forms.Button();  // Initialize the Edit Halls button
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(50, 50);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(150, 40);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(50, 110);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteMovie.TabIndex = 1;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnShowMovies
            // 
            this.btnShowMovies.Location = new System.Drawing.Point(50, 170);
            this.btnShowMovies.Name = "btnShowMovies";
            this.btnShowMovies.Size = new System.Drawing.Size(150, 40);
            this.btnShowMovies.TabIndex = 2;
            this.btnShowMovies.Text = "Show Movies";
            this.btnShowMovies.UseVisualStyleBackColor = true;
            this.btnShowMovies.Click += new System.EventHandler(this.btnShowMovies_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(50, 230);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateMovie.TabIndex = 3;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnEditHalls
            // 
            this.btnEditHalls.Location = new System.Drawing.Point(50, 290);  // Positioning the Edit Halls button
            this.btnEditHalls.Name = "btnEditHalls";
            this.btnEditHalls.Size = new System.Drawing.Size(150, 40);
            this.btnEditHalls.TabIndex = 4;
            this.btnEditHalls.Text = "Edit Halls";
            this.btnEditHalls.UseVisualStyleBackColor = true;
            this.btnEditHalls.Click += new System.EventHandler(this.btnEditHalls_Click); // Click event for Edit Halls
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 220);
            this.dataGridView1.TabIndex = 5;
            // 
            // Movies
            // 
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditHalls);  // Add Edit Halls button to the form
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnShowMovies);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Movies";
            this.Text = "Movies Management";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}


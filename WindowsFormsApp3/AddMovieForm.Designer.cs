namespace WindowsFormsApp3
{
    partial class AddMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.dgvPlays = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.cmbHallNumber = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblHallNumber = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lblPlays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlays
            // 
            this.dgvPlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlays.Location = new System.Drawing.Point(200, 80);
            this.dgvPlays.Name = "dgvPlays";
            this.dgvPlays.RowHeadersWidth = 51;
            this.dgvPlays.Size = new System.Drawing.Size(318, 150);
            this.dgvPlays.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(286, 281);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(286, 321);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 22);
            this.txtDuration.TabIndex = 3;
            // 
            // txtAdminID
            // 
            this.txtAdminID.Location = new System.Drawing.Point(286, 361);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(200, 22);
            this.txtAdminID.TabIndex = 4;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(286, 401);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(200, 22);
            this.txtGenre.TabIndex = 5;
            // 
            // cmbHallNumber
            // 
            this.cmbHallNumber.FormattingEnabled = true;
            this.cmbHallNumber.Location = new System.Drawing.Point(92, 580);
            this.cmbHallNumber.Name = "cmbHallNumber";
            this.cmbHallNumber.Size = new System.Drawing.Size(200, 24);
            this.cmbHallNumber.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(92, 620);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 30);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Add Movie";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(206, 284);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(206, 324);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(60, 16);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "Duration:";
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Location = new System.Drawing.Point(206, 364);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(64, 16);
            this.lblAdminID.TabIndex = 10;
            this.lblAdminID.Text = "Admin ID:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(206, 404);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 16);
            this.lblGenre.TabIndex = 11;
            this.lblGenre.Text = "Genre:";
            // 
            // lblHallNumber
            // 
            this.lblHallNumber.AutoSize = true;
            this.lblHallNumber.Location = new System.Drawing.Point(12, 583);
            this.lblHallNumber.Name = "lblHallNumber";
            this.lblHallNumber.Size = new System.Drawing.Size(85, 16);
            this.lblHallNumber.TabIndex = 12;
            this.lblHallNumber.Text = "Hall Number:";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(12, 30);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(0, 16);
            this.lblMovies.TabIndex = 13;
            // 
            // lblPlays
            // 
            this.lblPlays.AutoSize = true;
            this.lblPlays.Location = new System.Drawing.Point(4, 46);
            this.lblPlays.Name = "lblPlays";
            this.lblPlays.Size = new System.Drawing.Size(44, 16);
            this.lblPlays.TabIndex = 14;
            this.lblPlays.Text = "Plays:";
            // 
            // AddMovieForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblPlays);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblHallNumber);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbHallNumber);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dgvPlays);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPlays;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.ComboBox cmbHallNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblHallNumber;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblPlays;
    }
}

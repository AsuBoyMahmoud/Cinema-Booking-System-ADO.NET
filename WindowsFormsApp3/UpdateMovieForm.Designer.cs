namespace WindowsFormsApp3
{
    partial class UpdateMovieForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDuration;
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(50, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(50, 70);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(200, 22);
            this.txtGenre.TabIndex = 1;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(50, 110);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 22);
            this.txtDuration.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(50, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateMovieForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Name = "UpdateMovieForm";
            this.Text = "Update Movie";
            this.Load += new System.EventHandler(this.UpdateMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

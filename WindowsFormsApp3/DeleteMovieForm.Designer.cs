namespace WindowsFormsApp3
{
    partial class DeleteMovieForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMovieTitle;

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
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(30, 50);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(200, 20);
            this.txtMovieTitle.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Movie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(30, 30);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(61, 13);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = "Movie Title:";
            // 
            // DeleteMovieForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtMovieTitle);
            this.Name = "DeleteMovieForm";
            this.Text = "Delete Movie";
            this.Load += new System.EventHandler(this.DeleteMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

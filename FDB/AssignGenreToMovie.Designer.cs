namespace FDB
{
    partial class AssignGenreToMovie
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbSelectedGenres = new System.Windows.Forms.ListBox();
            this.txtGenSearch = new System.Windows.Forms.TextBox();
            this.lbSearchedGenres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // lbSelectedGenres
            // 
            this.lbSelectedGenres.FormattingEnabled = true;
            this.lbSelectedGenres.Location = new System.Drawing.Point(260, 71);
            this.lbSelectedGenres.Name = "lbSelectedGenres";
            this.lbSelectedGenres.Size = new System.Drawing.Size(139, 212);
            this.lbSelectedGenres.TabIndex = 23;
            // 
            // txtGenSearch
            // 
            this.txtGenSearch.Location = new System.Drawing.Point(49, 45);
            this.txtGenSearch.Name = "txtGenSearch";
            this.txtGenSearch.Size = new System.Drawing.Size(139, 20);
            this.txtGenSearch.TabIndex = 20;
            this.txtGenSearch.TextChanged += new System.EventHandler(this.txtGenSearch_TextChanged);
            // 
            // lbSearchedGenres
            // 
            this.lbSearchedGenres.FormattingEnabled = true;
            this.lbSearchedGenres.Location = new System.Drawing.Point(49, 71);
            this.lbSearchedGenres.Name = "lbSearchedGenres";
            this.lbSearchedGenres.Size = new System.Drawing.Size(139, 212);
            this.lbSearchedGenres.TabIndex = 19;
            this.lbSearchedGenres.DoubleClick += new System.EventHandler(this.lbSearchedGenres_DoubleClick);
            // 
            // AssignGenreToMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSelectedGenres);
            this.Controls.Add(this.txtGenSearch);
            this.Controls.Add(this.lbSearchedGenres);
            this.Name = "AssignGenreToMovie";
            this.Text = "AssignGenreToMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSelectedGenres;
        private System.Windows.Forms.TextBox txtGenSearch;
        private System.Windows.Forms.ListBox lbSearchedGenres;
    }
}
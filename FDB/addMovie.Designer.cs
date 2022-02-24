namespace FDB
{
    partial class addMovie
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRuntime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.btnAssignActors = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.btnAssignGenres = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMovieRemove = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(219, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(163, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(243, 208);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 2;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnaddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rel_year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Runtime";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(219, 52);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(163, 20);
            this.txtYear.TabIndex = 13;
            // 
            // txtRuntime
            // 
            this.txtRuntime.Location = new System.Drawing.Point(219, 88);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(163, 20);
            this.txtRuntime.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Resume";
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(219, 126);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(163, 73);
            this.txtResume.TabIndex = 18;
            // 
            // btnAssignActors
            // 
            this.btnAssignActors.Location = new System.Drawing.Point(12, 195);
            this.btnAssignActors.Name = "btnAssignActors";
            this.btnAssignActors.Size = new System.Drawing.Size(94, 23);
            this.btnAssignActors.TabIndex = 19;
            this.btnAssignActors.Text = "Assign Actors";
            this.btnAssignActors.UseVisualStyleBackColor = true;
            this.btnAssignActors.Click += new System.EventHandler(this.btnAssignActors_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 143);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(94, 23);
            this.btnLoadImage.TabIndex = 20;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPreview.Location = new System.Drawing.Point(12, 14);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(94, 111);
            this.pbPreview.TabIndex = 22;
            this.pbPreview.TabStop = false;
            // 
            // btnAssignGenres
            // 
            this.btnAssignGenres.Location = new System.Drawing.Point(12, 224);
            this.btnAssignGenres.Name = "btnAssignGenres";
            this.btnAssignGenres.Size = new System.Drawing.Size(94, 23);
            this.btnAssignGenres.TabIndex = 23;
            this.btnAssignGenres.Text = "Assign Genres";
            this.btnAssignGenres.UseVisualStyleBackColor = true;
            this.btnAssignGenres.Click += new System.EventHandler(this.btnAssignGenres_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(423, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(161, 266);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnMovieRemove
            // 
            this.btnMovieRemove.Location = new System.Drawing.Point(243, 237);
            this.btnMovieRemove.Name = "btnMovieRemove";
            this.btnMovieRemove.Size = new System.Drawing.Size(75, 23);
            this.btnMovieRemove.TabIndex = 26;
            this.btnMovieRemove.Text = "Remove";
            this.btnMovieRemove.UseVisualStyleBackColor = true;
            this.btnMovieRemove.Click += new System.EventHandler(this.btnMovieRemove_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Location = new System.Drawing.Point(243, 266);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMovieUpdate.TabIndex = 25;
            this.btnMovieUpdate.Text = "Update";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 27;
            // 
            // addMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMovieRemove);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAssignGenres);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnAssignActors);
            this.Controls.Add(this.txtResume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRuntime);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txtTitle);
            this.Name = "addMovie";
            this.Text = "addMovie";
            this.Load += new System.EventHandler(this.addMovie_Load);
            this.Click += new System.EventHandler(this.addMovie_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRuntime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.Button btnAssignActors;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button btnAssignGenres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMovieRemove;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Label label5;
    }
}
namespace FDB
{
    partial class addGenre
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
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.txtGenreTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenreUpdate = new System.Windows.Forms.Button();
            this.btnGenreRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(96, 81);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // txtGenreTitle
            // 
            this.txtGenreTitle.Location = new System.Drawing.Point(72, 28);
            this.txtGenreTitle.Name = "txtGenreTitle";
            this.txtGenreTitle.Size = new System.Drawing.Size(146, 20);
            this.txtGenreTitle.TabIndex = 11;
            this.txtGenreTitle.Click += new System.EventHandler(this.txtGenreTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(280, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(138, 230);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGenreUpdate
            // 
            this.btnGenreUpdate.Location = new System.Drawing.Point(96, 139);
            this.btnGenreUpdate.Name = "btnGenreUpdate";
            this.btnGenreUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnGenreUpdate.TabIndex = 15;
            this.btnGenreUpdate.Text = "Update";
            this.btnGenreUpdate.UseVisualStyleBackColor = true;
            this.btnGenreUpdate.Click += new System.EventHandler(this.btnGenreUpdate_Click);
            // 
            // btnGenreRemove
            // 
            this.btnGenreRemove.Location = new System.Drawing.Point(96, 110);
            this.btnGenreRemove.Name = "btnGenreRemove";
            this.btnGenreRemove.Size = new System.Drawing.Size(75, 23);
            this.btnGenreRemove.TabIndex = 16;
            this.btnGenreRemove.Text = "Remove";
            this.btnGenreRemove.UseVisualStyleBackColor = true;
            this.btnGenreRemove.Click += new System.EventHandler(this.btnGenreRemove_Click);
            // 
            // addGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 279);
            this.Controls.Add(this.btnGenreRemove);
            this.Controls.Add(this.btnGenreUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.txtGenreTitle);
            this.Controls.Add(this.label1);
            this.Name = "addGenre";
            this.Text = "addGenre";
            this.Load += new System.EventHandler(this.addGenre_Load);
            this.Click += new System.EventHandler(this.addGenre_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.TextBox txtGenreTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenreUpdate;
        private System.Windows.Forms.Button btnGenreRemove;
    }
}
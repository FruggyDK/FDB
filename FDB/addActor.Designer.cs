namespace FDB
{
    partial class addActor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtActFname = new System.Windows.Forms.TextBox();
            this.txtActLname = new System.Windows.Forms.TextBox();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActorRemove = new System.Windows.Forms.Button();
            this.btnActorUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtActFname
            // 
            this.txtActFname.Location = new System.Drawing.Point(207, 29);
            this.txtActFname.Name = "txtActFname";
            this.txtActFname.Size = new System.Drawing.Size(147, 20);
            this.txtActFname.TabIndex = 4;
            // 
            // txtActLname
            // 
            this.txtActLname.Location = new System.Drawing.Point(207, 72);
            this.txtActLname.Name = "txtActLname";
            this.txtActLname.Size = new System.Drawing.Size(147, 20);
            this.txtActLname.TabIndex = 5;
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(161, 175);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(112, 22);
            this.btnAddActor.TabIndex = 6;
            this.btnAddActor.Text = "Add";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPreview.Location = new System.Drawing.Point(32, 29);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(72, 79);
            this.pbPreview.TabIndex = 8;
            this.pbPreview.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(29, 114);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(392, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(138, 230);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnActorRemove
            // 
            this.btnActorRemove.Location = new System.Drawing.Point(161, 203);
            this.btnActorRemove.Name = "btnActorRemove";
            this.btnActorRemove.Size = new System.Drawing.Size(112, 22);
            this.btnActorRemove.TabIndex = 16;
            this.btnActorRemove.Text = "Remove";
            this.btnActorRemove.UseVisualStyleBackColor = true;
            this.btnActorRemove.Click += new System.EventHandler(this.btnActorRemove_Click);
            // 
            // btnActorUpdate
            // 
            this.btnActorUpdate.Location = new System.Drawing.Point(161, 231);
            this.btnActorUpdate.Name = "btnActorUpdate";
            this.btnActorUpdate.Size = new System.Drawing.Size(112, 22);
            this.btnActorUpdate.TabIndex = 17;
            this.btnActorUpdate.Text = "Update";
            this.btnActorUpdate.UseVisualStyleBackColor = true;
            this.btnActorUpdate.Click += new System.EventHandler(this.btnActorUpdate_Click);
            // 
            // addActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 281);
            this.Controls.Add(this.btnActorUpdate);
            this.Controls.Add(this.btnActorRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnAddActor);
            this.Controls.Add(this.txtActLname);
            this.Controls.Add(this.txtActFname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addActor";
            this.Text = "addActor";
            this.Load += new System.EventHandler(this.addActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtActFname;
        private System.Windows.Forms.TextBox txtActLname;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActorRemove;
        private System.Windows.Forms.Button btnActorUpdate;
    }
}
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
            this.label4 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtActFname
            // 
            this.txtActFname.Location = new System.Drawing.Point(155, 48);
            this.txtActFname.Name = "txtActFname";
            this.txtActFname.Size = new System.Drawing.Size(200, 20);
            this.txtActFname.TabIndex = 4;
            // 
            // txtActLname
            // 
            this.txtActLname.Location = new System.Drawing.Point(155, 81);
            this.txtActLname.Name = "txtActLname";
            this.txtActLname.Size = new System.Drawing.Size(200, 20);
            this.txtActLname.TabIndex = 5;
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(196, 199);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(112, 22);
            this.btnAddActor.TabIndex = 6;
            this.btnAddActor.Text = "Add";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Headshot";
            // 
            // pictureBox1
            // 
            this.pbPreview.Location = new System.Drawing.Point(405, 76);
            this.pbPreview.Name = "pictureBox1";
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
            this.btnLoadImage.Location = new System.Drawing.Point(405, 161);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // addActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 250);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddActor);
            this.Controls.Add(this.txtActLname);
            this.Controls.Add(this.txtActFname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addActor";
            this.Text = "addActor";
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadImage;
    }
}
namespace FDB
{
    partial class AssignActorToMovie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtActSearch = new System.Windows.Forms.TextBox();
            this.lbSearchedActors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAssignActor = new System.Windows.Forms.Button();
            this.btnRemoveActor = new System.Windows.Forms.Button();
            this.btnUpdateActor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActSearch
            // 
            this.txtActSearch.Location = new System.Drawing.Point(48, 52);
            this.txtActSearch.Name = "txtActSearch";
            this.txtActSearch.Size = new System.Drawing.Size(139, 20);
            this.txtActSearch.TabIndex = 6;
            this.txtActSearch.Click += new System.EventHandler(this.txtActSearch_Click);
            this.txtActSearch.TextChanged += new System.EventHandler(this.txtActSearch_TextChanged);
            // 
            // lbSearchedActors
            // 
            this.lbSearchedActors.FormattingEnabled = true;
            this.lbSearchedActors.Location = new System.Drawing.Point(48, 78);
            this.lbSearchedActors.Name = "lbSearchedActors";
            this.lbSearchedActors.Size = new System.Drawing.Size(139, 212);
            this.lbSearchedActors.TabIndex = 4;
            this.lbSearchedActors.SelectedIndexChanged += new System.EventHandler(this.lbSearchedActors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(206, 112);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(108, 20);
            this.txtRole.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Role";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(332, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(244, 212);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAssignActor
            // 
            this.btnAssignActor.Location = new System.Drawing.Point(228, 151);
            this.btnAssignActor.Name = "btnAssignActor";
            this.btnAssignActor.Size = new System.Drawing.Size(62, 20);
            this.btnAssignActor.TabIndex = 21;
            this.btnAssignActor.Text = "Assign";
            this.btnAssignActor.UseVisualStyleBackColor = true;
            this.btnAssignActor.Click += new System.EventHandler(this.btnAssignActor_Click);
            // 
            // btnRemoveActor
            // 
            this.btnRemoveActor.Location = new System.Drawing.Point(228, 177);
            this.btnRemoveActor.Name = "btnRemoveActor";
            this.btnRemoveActor.Size = new System.Drawing.Size(62, 20);
            this.btnRemoveActor.TabIndex = 22;
            this.btnRemoveActor.Text = "Remove";
            this.btnRemoveActor.UseVisualStyleBackColor = true;
            this.btnRemoveActor.Click += new System.EventHandler(this.btnRemoveActor_Click);
            // 
            // btnUpdateActor
            // 
            this.btnUpdateActor.Location = new System.Drawing.Point(228, 203);
            this.btnUpdateActor.Name = "btnUpdateActor";
            this.btnUpdateActor.Size = new System.Drawing.Size(62, 20);
            this.btnUpdateActor.TabIndex = 23;
            this.btnUpdateActor.Text = "Update";
            this.btnUpdateActor.UseVisualStyleBackColor = true;
            this.btnUpdateActor.Click += new System.EventHandler(this.btnUpdateActor_Click);
            // 
            // AssignActorToMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 351);
            this.Controls.Add(this.btnUpdateActor);
            this.Controls.Add(this.btnRemoveActor);
            this.Controls.Add(this.btnAssignActor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActSearch);
            this.Controls.Add(this.lbSearchedActors);
            this.Name = "AssignActorToMovie";
            this.Text = "AssignActorToMovie";
            this.Load += new System.EventHandler(this.AssignActorToMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtActSearch;
        private System.Windows.Forms.ListBox lbSearchedActors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAssignActor;
        private System.Windows.Forms.Button btnRemoveActor;
        private System.Windows.Forms.Button btnUpdateActor;
    }
}
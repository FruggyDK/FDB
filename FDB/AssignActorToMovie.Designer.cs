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
            this.txtActSearch = new System.Windows.Forms.TextBox();
            this.lbSearchedActors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAssignActor = new System.Windows.Forms.Button();
            this.btnRemoveActor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActSearch
            // 
            this.txtActSearch.Location = new System.Drawing.Point(48, 52);
            this.txtActSearch.Name = "txtActSearch";
            this.txtActSearch.Size = new System.Drawing.Size(139, 20);
            this.txtActSearch.TabIndex = 6;
            this.txtActSearch.TextChanged += new System.EventHandler(this.txtActSearch_TextChanged);
            // 
            // lbSearchedActors
            // 
            this.lbSearchedActors.FormattingEnabled = true;
            this.lbSearchedActors.Location = new System.Drawing.Point(48, 78);
            this.lbSearchedActors.Name = "lbSearchedActors";
            this.lbSearchedActors.Size = new System.Drawing.Size(139, 212);
            this.lbSearchedActors.TabIndex = 4;
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
            this.txtRole.Location = new System.Drawing.Point(215, 99);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 20);
            this.txtRole.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Role";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 212);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnAssignActor
            // 
            this.btnAssignActor.Location = new System.Drawing.Point(229, 138);
            this.btnAssignActor.Name = "btnAssignActor";
            this.btnAssignActor.Size = new System.Drawing.Size(62, 20);
            this.btnAssignActor.TabIndex = 21;
            this.btnAssignActor.Text = "Assign";
            this.btnAssignActor.UseVisualStyleBackColor = true;
            // 
            // btnRemoveActor
            // 
            this.btnRemoveActor.Location = new System.Drawing.Point(229, 173);
            this.btnRemoveActor.Name = "btnRemoveActor";
            this.btnRemoveActor.Size = new System.Drawing.Size(62, 20);
            this.btnRemoveActor.TabIndex = 22;
            this.btnRemoveActor.Text = "Remove";
            this.btnRemoveActor.UseVisualStyleBackColor = true;
            // 
            // AssignActorToMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 351);
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
    }
}
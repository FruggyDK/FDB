namespace FDB
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SceneControl = new System.Windows.Forms.TabControl();
            this.tpFrontPage = new System.Windows.Forms.TabPage();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSøg = new System.Windows.Forms.TextBox();
            this.tpResultsPage = new System.Windows.Forms.TabPage();
            this.cbSearchType1 = new System.Windows.Forms.ComboBox();
            this.dgMovieResults = new System.Windows.Forms.DataGridView();
            this.btnSeach1 = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lvActors = new System.Windows.Forms.ListView();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.SceneControl.SuspendLayout();
            this.tpFrontPage.SuspendLayout();
            this.tpResultsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovieResults)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 426);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.addNewEntryToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.connectToolStripMenuItem.Text = "Connect to database";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // addNewEntryToolStripMenuItem
            // 
            this.addNewEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.actorToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.addNewEntryToolStripMenuItem.Name = "addNewEntryToolStripMenuItem";
            this.addNewEntryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addNewEntryToolStripMenuItem.Text = "Manage entities";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.movieToolStripMenuItem.Text = "Movie";
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // actorToolStripMenuItem
            // 
            this.actorToolStripMenuItem.Name = "actorToolStripMenuItem";
            this.actorToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.actorToolStripMenuItem.Text = "Actor";
            this.actorToolStripMenuItem.Click += new System.EventHandler(this.actorToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // SceneControl
            // 
            this.SceneControl.Controls.Add(this.tpFrontPage);
            this.SceneControl.Controls.Add(this.tpResultsPage);
            this.SceneControl.Controls.Add(this.tabPage1);
            this.SceneControl.Location = new System.Drawing.Point(0, 0);
            this.SceneControl.Name = "SceneControl";
            this.SceneControl.SelectedIndex = 0;
            this.SceneControl.Size = new System.Drawing.Size(800, 450);
            this.SceneControl.TabIndex = 2;
            this.SceneControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbMoviePage_Selected);
            // 
            // tpFrontPage
            // 
            this.tpFrontPage.Controls.Add(this.cbSearchType);
            this.tpFrontPage.Controls.Add(this.btnSearch);
            this.tpFrontPage.Controls.Add(this.label1);
            this.tpFrontPage.Controls.Add(this.txtSøg);
            this.tpFrontPage.Location = new System.Drawing.Point(4, 22);
            this.tpFrontPage.Name = "tpFrontPage";
            this.tpFrontPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpFrontPage.Size = new System.Drawing.Size(792, 424);
            this.tpFrontPage.TabIndex = 0;
            this.tpFrontPage.Text = "Front";
            this.tpFrontPage.UseVisualStyleBackColor = true;
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Movies",
            "Actors",
            "Genres"});
            this.cbSearchType.Location = new System.Drawing.Point(131, 183);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(62, 21);
            this.cbSearchType.TabIndex = 25;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(539, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 20);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 75);
            this.label1.TabIndex = 14;
            this.label1.Text = "FDB.com";
            // 
            // txtSøg
            // 
            this.txtSøg.Location = new System.Drawing.Point(192, 184);
            this.txtSøg.Name = "txtSøg";
            this.txtSøg.Size = new System.Drawing.Size(341, 20);
            this.txtSøg.TabIndex = 13;
            // 
            // tpResultsPage
            // 
            this.tpResultsPage.Controls.Add(this.cbSearchType1);
            this.tpResultsPage.Controls.Add(this.dgMovieResults);
            this.tpResultsPage.Controls.Add(this.btnSeach1);
            this.tpResultsPage.Controls.Add(this.lbLogo);
            this.tpResultsPage.Controls.Add(this.textBox1);
            this.tpResultsPage.Location = new System.Drawing.Point(4, 22);
            this.tpResultsPage.Name = "tpResultsPage";
            this.tpResultsPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpResultsPage.Size = new System.Drawing.Size(792, 424);
            this.tpResultsPage.TabIndex = 1;
            this.tpResultsPage.Text = "Results";
            this.tpResultsPage.UseVisualStyleBackColor = true;
            // 
            // cbSearchType1
            // 
            this.cbSearchType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType1.FormattingEnabled = true;
            this.cbSearchType1.Items.AddRange(new object[] {
            "Movies",
            "Actors",
            "Genres"});
            this.cbSearchType1.Location = new System.Drawing.Point(163, 22);
            this.cbSearchType1.Name = "cbSearchType1";
            this.cbSearchType1.Size = new System.Drawing.Size(62, 21);
            this.cbSearchType1.TabIndex = 24;
            this.cbSearchType1.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // dgMovieResults
            // 
            this.dgMovieResults.AllowUserToAddRows = false;
            this.dgMovieResults.AllowUserToDeleteRows = false;
            this.dgMovieResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMovieResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovieResults.Location = new System.Drawing.Point(50, 90);
            this.dgMovieResults.Name = "dgMovieResults";
            this.dgMovieResults.ReadOnly = true;
            this.dgMovieResults.Size = new System.Drawing.Size(678, 311);
            this.dgMovieResults.TabIndex = 23;
            // 
            // btnSeach1
            // 
            this.btnSeach1.Location = new System.Drawing.Point(578, 22);
            this.btnSeach1.Name = "btnSeach1";
            this.btnSeach1.Size = new System.Drawing.Size(61, 20);
            this.btnSeach1.TabIndex = 20;
            this.btnSeach1.Text = "Search";
            this.btnSeach1.UseVisualStyleBackColor = true;
            this.btnSeach1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(3, 4);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(154, 45);
            this.lbLogo.TabIndex = 19;
            this.lbLogo.Text = "FDB.com";
            this.lbLogo.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lvActors);
            this.tabPage1.Controls.Add(this.lblScore);
            this.tabPage1.Controls.Add(this.lblResume);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tpMoviePage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Actors:";
            // 
            // lvActors
            // 
            this.lvActors.HideSelection = false;
            this.lvActors.Location = new System.Drawing.Point(26, 230);
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(474, 171);
            this.lvActors.TabIndex = 7;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            this.lvActors.SelectedIndexChanged += new System.EventHandler(this.lvActors_SelectedIndexChanged);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(465, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // lblResume
            // 
            this.lblResume.Location = new System.Drawing.Point(198, 66);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(100, 100);
            this.lblResume.TabIndex = 2;
            this.lblResume.Text = "Resume";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(198, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SceneControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SceneControl.ResumeLayout(false);
            this.tpFrontPage.ResumeLayout(false);
            this.tpFrontPage.PerformLayout();
            this.tpResultsPage.ResumeLayout(false);
            this.tpResultsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovieResults)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.TabControl SceneControl;
        private System.Windows.Forms.TabPage tpFrontPage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSøg;
        private System.Windows.Forms.TabPage tpResultsPage;
        private System.Windows.Forms.Button btnSeach1;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgMovieResults;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox cbSearchType1;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.Label label3;
    }
}


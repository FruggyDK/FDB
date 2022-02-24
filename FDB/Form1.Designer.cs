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
            this.manageEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SceneControl = new System.Windows.Forms.TabControl();
            this.tpFrontPage = new System.Windows.Forms.TabPage();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tpResultsPage = new System.Windows.Forms.TabPage();
            this.lblSearchQuery = new System.Windows.Forms.Label();
            this.cbSearchType1 = new System.Windows.Forms.ComboBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.btnSeach1 = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.txtSeach1 = new System.Windows.Forms.TextBox();
            this.tpMoviePage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.lvGenres = new System.Windows.Forms.ListView();
            this.cbSearchType2 = new System.Windows.Forms.ComboBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lvActors = new System.Windows.Forms.ListView();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbCoverImage = new System.Windows.Forms.PictureBox();
            this.tpActorPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.cbSearchType3 = new System.Windows.Forms.ComboBox();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch3 = new System.Windows.Forms.TextBox();
            this.lvMovies = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.pbHeadshot = new System.Windows.Forms.PictureBox();
            this.databaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEntitiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configureDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SceneControl.SuspendLayout();
            this.tpFrontPage.SuspendLayout();
            this.tpResultsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tpMoviePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).BeginInit();
            this.tpActorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadshot)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 415);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEntitiesToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // manageEntitiesToolStripMenuItem
            // 
            this.manageEntitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.actorToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.manageEntitiesToolStripMenuItem.Name = "manageEntitiesToolStripMenuItem";
            this.manageEntitiesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.manageEntitiesToolStripMenuItem.Text = "Manage entities";
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
            this.SceneControl.Controls.Add(this.tpMoviePage);
            this.SceneControl.Controls.Add(this.tpActorPage);
            this.SceneControl.Location = new System.Drawing.Point(0, 0);
            this.SceneControl.Name = "SceneControl";
            this.SceneControl.SelectedIndex = 0;
            this.SceneControl.Size = new System.Drawing.Size(740, 439);
            this.SceneControl.TabIndex = 2;
            // 
            // tpFrontPage
            // 
            this.tpFrontPage.Controls.Add(this.cbSearchType);
            this.tpFrontPage.Controls.Add(this.btnSearch);
            this.tpFrontPage.Controls.Add(this.label1);
            this.tpFrontPage.Controls.Add(this.txtSearch);
            this.tpFrontPage.Location = new System.Drawing.Point(4, 22);
            this.tpFrontPage.Name = "tpFrontPage";
            this.tpFrontPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpFrontPage.Size = new System.Drawing.Size(732, 413);
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 184);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(341, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // tpResultsPage
            // 
            this.tpResultsPage.Controls.Add(this.lblSearchQuery);
            this.tpResultsPage.Controls.Add(this.cbSearchType1);
            this.tpResultsPage.Controls.Add(this.dgResults);
            this.tpResultsPage.Controls.Add(this.btnSeach1);
            this.tpResultsPage.Controls.Add(this.lbLogo);
            this.tpResultsPage.Controls.Add(this.txtSeach1);
            this.tpResultsPage.Location = new System.Drawing.Point(4, 22);
            this.tpResultsPage.Name = "tpResultsPage";
            this.tpResultsPage.Padding = new System.Windows.Forms.Padding(3);
            this.tpResultsPage.Size = new System.Drawing.Size(732, 413);
            this.tpResultsPage.TabIndex = 1;
            this.tpResultsPage.Text = "Results";
            this.tpResultsPage.UseVisualStyleBackColor = true;
            // 
            // lblSearchQuery
            // 
            this.lblSearchQuery.AutoSize = true;
            this.lblSearchQuery.Location = new System.Drawing.Point(8, 57);
            this.lblSearchQuery.Name = "lblSearchQuery";
            this.lblSearchQuery.Size = new System.Drawing.Size(35, 13);
            this.lblSearchQuery.TabIndex = 25;
            this.lblSearchQuery.Text = "label3";
            // 
            // cbSearchType1
            // 
            this.cbSearchType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType1.FormattingEnabled = true;
            this.cbSearchType1.Items.AddRange(new object[] {
            "Movies",
            "Actors",
            "Genres"});
            this.cbSearchType1.Location = new System.Drawing.Point(163, 21);
            this.cbSearchType1.Name = "cbSearchType1";
            this.cbSearchType1.Size = new System.Drawing.Size(62, 21);
            this.cbSearchType1.TabIndex = 24;
            this.cbSearchType1.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            this.dgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(11, 82);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResults.Size = new System.Drawing.Size(713, 323);
            this.dgResults.TabIndex = 23;
            this.dgResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellDoubleClick);
            // 
            // btnSeach1
            // 
            this.btnSeach1.Location = new System.Drawing.Point(578, 21);
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
            this.lbLogo.Location = new System.Drawing.Point(3, 3);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(154, 45);
            this.lbLogo.TabIndex = 19;
            this.lbLogo.Text = "FDB.com";
            this.lbLogo.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // txtSeach1
            // 
            this.txtSeach1.Location = new System.Drawing.Point(231, 21);
            this.txtSeach1.Name = "txtSeach1";
            this.txtSeach1.Size = new System.Drawing.Size(341, 20);
            this.txtSeach1.TabIndex = 18;
            // 
            // tpMoviePage
            // 
            this.tpMoviePage.Controls.Add(this.label5);
            this.tpMoviePage.Controls.Add(this.lvGenres);
            this.tpMoviePage.Controls.Add(this.cbSearchType2);
            this.tpMoviePage.Controls.Add(this.btnSearch2);
            this.tpMoviePage.Controls.Add(this.label2);
            this.tpMoviePage.Controls.Add(this.txtSearch2);
            this.tpMoviePage.Controls.Add(this.lblRuntime);
            this.tpMoviePage.Controls.Add(this.lvActors);
            this.tpMoviePage.Controls.Add(this.lblResume);
            this.tpMoviePage.Controls.Add(this.lblTitle);
            this.tpMoviePage.Controls.Add(this.pbCoverImage);
            this.tpMoviePage.Location = new System.Drawing.Point(4, 22);
            this.tpMoviePage.Name = "tpMoviePage";
            this.tpMoviePage.Padding = new System.Windows.Forms.Padding(3);
            this.tpMoviePage.Size = new System.Drawing.Size(732, 413);
            this.tpMoviePage.TabIndex = 2;
            this.tpMoviePage.Text = "tpMoviePage";
            this.tpMoviePage.UseVisualStyleBackColor = true;
            this.tpMoviePage.Enter += new System.EventHandler(this.tpMoviePage_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Genres";
            // 
            // lvGenres
            // 
            this.lvGenres.HideSelection = false;
            this.lvGenres.Location = new System.Drawing.Point(154, 204);
            this.lvGenres.MultiSelect = false;
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(337, 50);
            this.lvGenres.TabIndex = 30;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            this.lvGenres.View = System.Windows.Forms.View.List;
            // 
            // cbSearchType2
            // 
            this.cbSearchType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType2.FormattingEnabled = true;
            this.cbSearchType2.Items.AddRange(new object[] {
            "Movies",
            "Actors",
            "Genres"});
            this.cbSearchType2.Location = new System.Drawing.Point(163, 21);
            this.cbSearchType2.Name = "cbSearchType2";
            this.cbSearchType2.Size = new System.Drawing.Size(62, 21);
            this.cbSearchType2.TabIndex = 28;
            this.cbSearchType2.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(578, 21);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(61, 20);
            this.btnSearch2.TabIndex = 27;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 45);
            this.label2.TabIndex = 26;
            this.label2.Text = "FDB.com";
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Location = new System.Drawing.Point(231, 21);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(341, 20);
            this.txtSearch2.TabIndex = 25;
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(8, 266);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(46, 13);
            this.lblRuntime.TabIndex = 10;
            this.lblRuntime.Text = "Runtime";
            // 
            // lvActors
            // 
            this.lvActors.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvActors.AllowColumnReorder = true;
            this.lvActors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActors.HideSelection = false;
            this.lvActors.Location = new System.Drawing.Point(520, 103);
            this.lvActors.MultiSelect = false;
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(150, 302);
            this.lvActors.TabIndex = 7;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            // 
            // lblResume
            // 
            this.lblResume.Location = new System.Drawing.Point(154, 103);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(337, 80);
            this.lblResume.TabIndex = 2;
            this.lblResume.Text = "Resume";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // pbCoverImage
            // 
            this.pbCoverImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCoverImage.Location = new System.Drawing.Point(11, 103);
            this.pbCoverImage.Name = "pbCoverImage";
            this.pbCoverImage.Size = new System.Drawing.Size(123, 151);
            this.pbCoverImage.TabIndex = 0;
            this.pbCoverImage.TabStop = false;
            // 
            // tpActorPage
            // 
            this.tpActorPage.Controls.Add(this.label4);
            this.tpActorPage.Controls.Add(this.lblDob);
            this.tpActorPage.Controls.Add(this.cbSearchType3);
            this.tpActorPage.Controls.Add(this.btnSearch3);
            this.tpActorPage.Controls.Add(this.label3);
            this.tpActorPage.Controls.Add(this.txtSearch3);
            this.tpActorPage.Controls.Add(this.lvMovies);
            this.tpActorPage.Controls.Add(this.lblName);
            this.tpActorPage.Controls.Add(this.pbHeadshot);
            this.tpActorPage.Location = new System.Drawing.Point(4, 22);
            this.tpActorPage.Name = "tpActorPage";
            this.tpActorPage.Size = new System.Drawing.Size(732, 413);
            this.tpActorPage.TabIndex = 3;
            this.tpActorPage.Text = "tpActorPage";
            this.tpActorPage.UseVisualStyleBackColor = true;
            this.tpActorPage.Enter += new System.EventHandler(this.tpActorPage_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Starring in";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(140, 103);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(35, 13);
            this.lblDob.TabIndex = 40;
            this.lblDob.Text = "label4";
            // 
            // cbSearchType3
            // 
            this.cbSearchType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType3.FormattingEnabled = true;
            this.cbSearchType3.Items.AddRange(new object[] {
            "Movies",
            "Actors",
            "Genres"});
            this.cbSearchType3.Location = new System.Drawing.Point(163, 21);
            this.cbSearchType3.Name = "cbSearchType3";
            this.cbSearchType3.Size = new System.Drawing.Size(62, 21);
            this.cbSearchType3.TabIndex = 39;
            this.cbSearchType3.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // btnSearch3
            // 
            this.btnSearch3.Location = new System.Drawing.Point(578, 21);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(61, 20);
            this.btnSearch3.TabIndex = 38;
            this.btnSearch3.Text = "Search";
            this.btnSearch3.UseVisualStyleBackColor = true;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 45);
            this.label3.TabIndex = 37;
            this.label3.Text = "FDB.com";
            this.label3.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // txtSearch3
            // 
            this.txtSearch3.Location = new System.Drawing.Point(231, 21);
            this.txtSearch3.Name = "txtSearch3";
            this.txtSearch3.Size = new System.Drawing.Size(341, 20);
            this.txtSearch3.TabIndex = 36;
            // 
            // lvMovies
            // 
            this.lvMovies.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvMovies.AllowColumnReorder = true;
            this.lvMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMovies.HideSelection = false;
            this.lvMovies.Location = new System.Drawing.Point(375, 119);
            this.lvMovies.MultiSelect = false;
            this.lvMovies.Name = "lvMovies";
            this.lvMovies.Size = new System.Drawing.Size(182, 260);
            this.lvMovies.TabIndex = 34;
            this.lvMovies.UseCompatibleStateImageBehavior = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 25);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name";
            // 
            // pbHeadshot
            // 
            this.pbHeadshot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHeadshot.Location = new System.Drawing.Point(11, 103);
            this.pbHeadshot.Name = "pbHeadshot";
            this.pbHeadshot.Size = new System.Drawing.Size(123, 151);
            this.pbHeadshot.TabIndex = 31;
            this.pbHeadshot.TabStop = false;
            // 
            // databaseToolStripMenuItem1
            // 
            this.databaseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureDatabaseToolStripMenuItem,
            this.manageEntitiesToolStripMenuItem1});
            this.databaseToolStripMenuItem1.Name = "databaseToolStripMenuItem1";
            this.databaseToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem1.Text = "Database";
            // 
            // manageEntitiesToolStripMenuItem1
            // 
            this.manageEntitiesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.actorsToolStripMenuItem,
            this.genresToolStripMenuItem});
            this.manageEntitiesToolStripMenuItem1.Name = "manageEntitiesToolStripMenuItem1";
            this.manageEntitiesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.manageEntitiesToolStripMenuItem1.Text = "Manage entities";
            // 
            // configureDatabaseToolStripMenuItem
            // 
            this.configureDatabaseToolStripMenuItem.Name = "configureDatabaseToolStripMenuItem";
            this.configureDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configureDatabaseToolStripMenuItem.Text = "Configure Database";
            this.configureDatabaseToolStripMenuItem.Click += new System.EventHandler(this.configureDatabaseToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // actorsToolStripMenuItem
            // 
            this.actorsToolStripMenuItem.Name = "actorsToolStripMenuItem";
            this.actorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actorsToolStripMenuItem.Text = "Actors";
            this.actorsToolStripMenuItem.Click += new System.EventHandler(this.actorToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 439);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SceneControl);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SceneControl.ResumeLayout(false);
            this.tpFrontPage.ResumeLayout(false);
            this.tpFrontPage.PerformLayout();
            this.tpResultsPage.ResumeLayout(false);
            this.tpResultsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tpMoviePage.ResumeLayout(false);
            this.tpMoviePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).EndInit();
            this.tpActorPage.ResumeLayout(false);
            this.tpActorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.TabControl SceneControl;
        private System.Windows.Forms.TabPage tpFrontPage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tpResultsPage;
        private System.Windows.Forms.Button btnSeach1;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.TextBox txtSeach1;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.TabPage tpMoviePage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbCoverImage;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.ComboBox cbSearchType1;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.ComboBox cbSearchType2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.ListView lvGenres;
        private System.Windows.Forms.Label lblSearchQuery;
        private System.Windows.Forms.TabPage tpActorPage;
        private System.Windows.Forms.ComboBox cbSearchType3;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbHeadshot;
        private System.Windows.Forms.ListView lvMovies;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configureDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEntitiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
    }
}


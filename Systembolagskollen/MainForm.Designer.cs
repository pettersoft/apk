namespace Systembolagskollen
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.tsLblAmountOfArticles = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdateDatabase = new System.Windows.Forms.ToolStripMenuItem();
			this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.omProgrammetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gBoxData = new System.Windows.Forms.GroupBox();
			this.lblPage = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.beverageGridView = new System.Windows.Forms.DataGridView();
			this.beverageDataSource = new System.Windows.Forms.BindingSource(this.components);
			this.gBoxFilter = new System.Windows.Forms.GroupBox();
			this.lblBytesReceived = new System.Windows.Forms.Label();
			this.txtArticleNumberTo = new System.Windows.Forms.TextBox();
			this.cBoxAPK = new System.Windows.Forms.CheckBox();
			this.pgBarDownload = new System.Windows.Forms.ProgressBar();
			this.gBoxInformation = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblType = new System.Windows.Forms.Label();
			this.lblPercentage = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAlcoholTo = new System.Windows.Forms.TextBox();
			this.txtAlcoholFrom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cBoxTypes = new System.Windows.Forms.ComboBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.checkEthical = new System.Windows.Forms.CheckBox();
			this.checkKoscher = new System.Windows.Forms.CheckBox();
			this.checkEco = new System.Windows.Forms.CheckBox();
			this.lblCurrency = new System.Windows.Forms.Label();
			this.lblPriceDiverter = new System.Windows.Forms.Label();
			this.txtPriceTo = new System.Windows.Forms.TextBox();
			this.txtPriceFrom = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtArticleNumberFrom = new System.Windows.Forms.TextBox();
			this.lblArticleNumber = new System.Windows.Forms.Label();
			this.cBoxSortByArticleNumber = new System.Windows.Forms.CheckBox();
			this.mainStatusStrip.SuspendLayout();
			this.gBoxData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.beverageGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.beverageDataSource)).BeginInit();
			this.gBoxFilter.SuspendLayout();
			this.gBoxInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblAmountOfArticles});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 666);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.mainStatusStrip.Size = new System.Drawing.Size(1448, 22);
			this.mainStatusStrip.TabIndex = 4;
			// 
			// tsLblAmountOfArticles
			// 
			this.tsLblAmountOfArticles.Name = "tsLblAmountOfArticles";
			this.tsLblAmountOfArticles.Size = new System.Drawing.Size(86, 17);
			this.tsLblAmountOfArticles.Text = "Antal artiklar: 0";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// btnUpdateDatabase
			// 
			this.btnUpdateDatabase.Name = "btnUpdateDatabase";
			this.btnUpdateDatabase.Size = new System.Drawing.Size(32, 19);
			// 
			// omToolStripMenuItem
			// 
			this.omToolStripMenuItem.Name = "omToolStripMenuItem";
			this.omToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// omProgrammetToolStripMenuItem
			// 
			this.omProgrammetToolStripMenuItem.Name = "omProgrammetToolStripMenuItem";
			this.omProgrammetToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// gBoxData
			// 
			this.gBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gBoxData.Controls.Add(this.lblPage);
			this.gBoxData.Controls.Add(this.btnUpdate);
			this.gBoxData.Controls.Add(this.btnOpen);
			this.gBoxData.Controls.Add(this.btnPrevious);
			this.gBoxData.Controls.Add(this.btnNext);
			this.gBoxData.Controls.Add(this.beverageGridView);
			this.gBoxData.Location = new System.Drawing.Point(17, 15);
			this.gBoxData.Margin = new System.Windows.Forms.Padding(4);
			this.gBoxData.Name = "gBoxData";
			this.gBoxData.Padding = new System.Windows.Forms.Padding(4);
			this.gBoxData.Size = new System.Drawing.Size(896, 642);
			this.gBoxData.TabIndex = 2;
			this.gBoxData.TabStop = false;
			this.gBoxData.Text = "Drycker";
			// 
			// lblPage
			// 
			this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPage.AutoSize = true;
			this.lblPage.Location = new System.Drawing.Point(240, 591);
			this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPage.Name = "lblPage";
			this.lblPage.Size = new System.Drawing.Size(39, 16);
			this.lblPage.TabIndex = 8;
			this.lblPage.Text = "Sida ";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(647, 583);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 28);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Uppdatera";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Enabled = false;
			this.btnOpen.Location = new System.Drawing.Point(755, 583);
			this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(133, 28);
			this.btnOpen.TabIndex = 6;
			this.btnOpen.Text = "Öppna artikel";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrevious.Location = new System.Drawing.Point(24, 583);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(100, 28);
			this.btnPrevious.TabIndex = 5;
			this.btnPrevious.Text = "Föregående";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNext.Location = new System.Drawing.Point(132, 583);
			this.btnNext.Margin = new System.Windows.Forms.Padding(4);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(100, 28);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "Nästa";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// beverageGridView
			// 
			this.beverageGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.beverageGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.beverageGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this.beverageGridView.BackgroundColor = System.Drawing.SystemColors.Control;
			this.beverageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.beverageGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.beverageGridView.Location = new System.Drawing.Point(24, 23);
			this.beverageGridView.Margin = new System.Windows.Forms.Padding(4);
			this.beverageGridView.Name = "beverageGridView";
			this.beverageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.beverageGridView.Size = new System.Drawing.Size(872, 554);
			this.beverageGridView.TabIndex = 3;
			this.beverageGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.beverageGridView_CellClick);
			this.beverageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.beverageGridView_CellContentClick);
			// 
			// gBoxFilter
			// 
			this.gBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gBoxFilter.Controls.Add(this.cBoxSortByArticleNumber);
			this.gBoxFilter.Controls.Add(this.lblBytesReceived);
			this.gBoxFilter.Controls.Add(this.txtArticleNumberTo);
			this.gBoxFilter.Controls.Add(this.cBoxAPK);
			this.gBoxFilter.Controls.Add(this.pgBarDownload);
			this.gBoxFilter.Controls.Add(this.gBoxInformation);
			this.gBoxFilter.Controls.Add(this.btnClose);
			this.gBoxFilter.Controls.Add(this.lblType);
			this.gBoxFilter.Controls.Add(this.lblPercentage);
			this.gBoxFilter.Controls.Add(this.label2);
			this.gBoxFilter.Controls.Add(this.txtAlcoholTo);
			this.gBoxFilter.Controls.Add(this.txtAlcoholFrom);
			this.gBoxFilter.Controls.Add(this.label3);
			this.gBoxFilter.Controls.Add(this.cBoxTypes);
			this.gBoxFilter.Controls.Add(this.btnClear);
			this.gBoxFilter.Controls.Add(this.btnSearch);
			this.gBoxFilter.Controls.Add(this.lblName);
			this.gBoxFilter.Controls.Add(this.txtName);
			this.gBoxFilter.Controls.Add(this.checkEthical);
			this.gBoxFilter.Controls.Add(this.checkKoscher);
			this.gBoxFilter.Controls.Add(this.checkEco);
			this.gBoxFilter.Controls.Add(this.lblCurrency);
			this.gBoxFilter.Controls.Add(this.lblPriceDiverter);
			this.gBoxFilter.Controls.Add(this.txtPriceTo);
			this.gBoxFilter.Controls.Add(this.txtPriceFrom);
			this.gBoxFilter.Controls.Add(this.lblPrice);
			this.gBoxFilter.Controls.Add(this.txtArticleNumberFrom);
			this.gBoxFilter.Controls.Add(this.lblArticleNumber);
			this.gBoxFilter.Location = new System.Drawing.Point(921, 33);
			this.gBoxFilter.Margin = new System.Windows.Forms.Padding(4);
			this.gBoxFilter.Name = "gBoxFilter";
			this.gBoxFilter.Padding = new System.Windows.Forms.Padding(4);
			this.gBoxFilter.Size = new System.Drawing.Size(511, 624);
			this.gBoxFilter.TabIndex = 3;
			this.gBoxFilter.TabStop = false;
			this.gBoxFilter.Text = "Filtrera";
			this.gBoxFilter.Enter += new System.EventHandler(this.gBoxFilter_Enter);
			// 
			// lblBytesReceived
			// 
			this.lblBytesReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBytesReceived.AutoSize = true;
			this.lblBytesReceived.Location = new System.Drawing.Point(259, 594);
			this.lblBytesReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBytesReceived.Name = "lblBytesReceived";
			this.lblBytesReceived.Size = new System.Drawing.Size(0, 16);
			this.lblBytesReceived.TabIndex = 26;
			// 
			// txtArticleNumberTo
			// 
			this.txtArticleNumberTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtArticleNumberTo.Location = new System.Drawing.Point(297, 25);
			this.txtArticleNumberTo.Margin = new System.Windows.Forms.Padding(4);
			this.txtArticleNumberTo.Name = "txtArticleNumberTo";
			this.txtArticleNumberTo.Size = new System.Drawing.Size(116, 22);
			this.txtArticleNumberTo.TabIndex = 25;
			// 
			// cBoxAPK
			// 
			this.cBoxAPK.AutoSize = true;
			this.cBoxAPK.Location = new System.Drawing.Point(119, 245);
			this.cBoxAPK.Margin = new System.Windows.Forms.Padding(4);
			this.cBoxAPK.Name = "cBoxAPK";
			this.cBoxAPK.Size = new System.Drawing.Size(132, 20);
			this.cBoxAPK.TabIndex = 24;
			this.cBoxAPK.Text = "Sortera efter APK ";
			this.cBoxAPK.UseVisualStyleBackColor = true;
			// 
			// pgBarDownload
			// 
			this.pgBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pgBarDownload.Location = new System.Drawing.Point(15, 588);
			this.pgBarDownload.Margin = new System.Windows.Forms.Padding(4);
			this.pgBarDownload.Name = "pgBarDownload";
			this.pgBarDownload.Size = new System.Drawing.Size(236, 28);
			this.pgBarDownload.Step = 5;
			this.pgBarDownload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pgBarDownload.TabIndex = 23;
			this.pgBarDownload.Visible = false;
			// 
			// gBoxInformation
			// 
			this.gBoxInformation.Controls.Add(this.label1);
			this.gBoxInformation.Location = new System.Drawing.Point(15, 438);
			this.gBoxInformation.Margin = new System.Windows.Forms.Padding(4);
			this.gBoxInformation.Name = "gBoxInformation";
			this.gBoxInformation.Padding = new System.Windows.Forms.Padding(4);
			this.gBoxInformation.Size = new System.Drawing.Size(488, 121);
			this.gBoxInformation.TabIndex = 22;
			this.gBoxInformation.TabStop = false;
			this.gBoxInformation.Text = "Tips och information";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(4, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(371, 80);
			this.label1.TabIndex = 1;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(403, 588);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 28);
			this.btnClose.TabIndex = 21;
			this.btnClose.Text = "Stäng";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(8, 214);
			this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(32, 16);
			this.lblType.TabIndex = 20;
			this.lblType.Text = "Typ";
			// 
			// lblPercentage
			// 
			this.lblPercentage.AutoSize = true;
			this.lblPercentage.Location = new System.Drawing.Point(423, 178);
			this.lblPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPercentage.Name = "lblPercentage";
			this.lblPercentage.Size = new System.Drawing.Size(20, 16);
			this.lblPercentage.TabIndex = 19;
			this.lblPercentage.Text = "%";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(267, 178);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "-";
			// 
			// txtAlcoholTo
			// 
			this.txtAlcoholTo.Location = new System.Drawing.Point(316, 175);
			this.txtAlcoholTo.Margin = new System.Windows.Forms.Padding(4);
			this.txtAlcoholTo.Name = "txtAlcoholTo";
			this.txtAlcoholTo.Size = new System.Drawing.Size(84, 22);
			this.txtAlcoholTo.TabIndex = 17;
			this.txtAlcoholTo.Text = "0";
			// 
			// txtAlcoholFrom
			// 
			this.txtAlcoholFrom.Location = new System.Drawing.Point(148, 175);
			this.txtAlcoholFrom.Margin = new System.Windows.Forms.Padding(4);
			this.txtAlcoholFrom.Name = "txtAlcoholFrom";
			this.txtAlcoholFrom.Size = new System.Drawing.Size(84, 22);
			this.txtAlcoholFrom.TabIndex = 16;
			this.txtAlcoholFrom.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 178);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Alkoholhalt";
			// 
			// cBoxTypes
			// 
			this.cBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxTypes.FormattingEnabled = true;
			this.cBoxTypes.Location = new System.Drawing.Point(116, 210);
			this.cBoxTypes.Margin = new System.Windows.Forms.Padding(4);
			this.cBoxTypes.Name = "cBoxTypes";
			this.cBoxTypes.Size = new System.Drawing.Size(385, 24);
			this.cBoxTypes.TabIndex = 14;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(180, 273);
			this.btnClear.Margin = new System.Windows.Forms.Padding(4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 69);
			this.btnClear.TabIndex = 13;
			this.btnClear.Text = "Rensa";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(315, 273);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 69);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "Sök";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(11, 144);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(44, 16);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Namn";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(116, 140);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(385, 22);
			this.txtName.TabIndex = 10;
			// 
			// checkEthical
			// 
			this.checkEthical.AutoSize = true;
			this.checkEthical.Location = new System.Drawing.Point(332, 98);
			this.checkEthical.Margin = new System.Windows.Forms.Padding(4);
			this.checkEthical.Name = "checkEthical";
			this.checkEthical.Size = new System.Drawing.Size(59, 20);
			this.checkEthical.TabIndex = 9;
			this.checkEthical.Text = "Etiskt";
			this.checkEthical.UseVisualStyleBackColor = true;
			// 
			// checkKoscher
			// 
			this.checkKoscher.AutoSize = true;
			this.checkKoscher.Location = new System.Drawing.Point(237, 98);
			this.checkKoscher.Margin = new System.Windows.Forms.Padding(4);
			this.checkKoscher.Name = "checkKoscher";
			this.checkKoscher.Size = new System.Drawing.Size(76, 20);
			this.checkKoscher.TabIndex = 8;
			this.checkKoscher.Text = "Koscher";
			this.checkKoscher.UseVisualStyleBackColor = true;
			// 
			// checkEco
			// 
			this.checkEco.AutoSize = true;
			this.checkEco.Location = new System.Drawing.Point(133, 98);
			this.checkEco.Margin = new System.Windows.Forms.Padding(4);
			this.checkEco.Name = "checkEco";
			this.checkEco.Size = new System.Drawing.Size(87, 20);
			this.checkEco.TabIndex = 7;
			this.checkEco.Text = "Ekologisk";
			this.checkEco.UseVisualStyleBackColor = true;
			// 
			// lblCurrency
			// 
			this.lblCurrency.AutoSize = true;
			this.lblCurrency.Location = new System.Drawing.Point(423, 60);
			this.lblCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(34, 16);
			this.lblCurrency.TabIndex = 6;
			this.lblCurrency.Text = "SEK";
			// 
			// lblPriceDiverter
			// 
			this.lblPriceDiverter.AutoSize = true;
			this.lblPriceDiverter.Location = new System.Drawing.Point(267, 60);
			this.lblPriceDiverter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPriceDiverter.Name = "lblPriceDiverter";
			this.lblPriceDiverter.Size = new System.Drawing.Size(12, 16);
			this.lblPriceDiverter.TabIndex = 5;
			this.lblPriceDiverter.Text = "-";
			// 
			// txtPriceTo
			// 
			this.txtPriceTo.Location = new System.Drawing.Point(316, 57);
			this.txtPriceTo.Margin = new System.Windows.Forms.Padding(4);
			this.txtPriceTo.Name = "txtPriceTo";
			this.txtPriceTo.Size = new System.Drawing.Size(84, 22);
			this.txtPriceTo.TabIndex = 4;
			this.txtPriceTo.Text = "0";
			// 
			// txtPriceFrom
			// 
			this.txtPriceFrom.Location = new System.Drawing.Point(148, 57);
			this.txtPriceFrom.Margin = new System.Windows.Forms.Padding(4);
			this.txtPriceFrom.Name = "txtPriceFrom";
			this.txtPriceFrom.Size = new System.Drawing.Size(84, 22);
			this.txtPriceFrom.TabIndex = 3;
			this.txtPriceFrom.Text = "0";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(11, 60);
			this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(31, 16);
			this.lblPrice.TabIndex = 2;
			this.lblPrice.Text = "Pris";
			// 
			// txtArticleNumberFrom
			// 
			this.txtArticleNumberFrom.Location = new System.Drawing.Point(133, 23);
			this.txtArticleNumberFrom.Margin = new System.Windows.Forms.Padding(4);
			this.txtArticleNumberFrom.Name = "txtArticleNumberFrom";
			this.txtArticleNumberFrom.Size = new System.Drawing.Size(116, 22);
			this.txtArticleNumberFrom.TabIndex = 1;
			// 
			// lblArticleNumber
			// 
			this.lblArticleNumber.AutoSize = true;
			this.lblArticleNumber.Location = new System.Drawing.Point(11, 28);
			this.lblArticleNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblArticleNumber.Name = "lblArticleNumber";
			this.lblArticleNumber.Size = new System.Drawing.Size(93, 16);
			this.lblArticleNumber.TabIndex = 0;
			this.lblArticleNumber.Text = "Artikelnummer";
			// 
			// cBoxSortByArticleNumber
			// 
			this.cBoxSortByArticleNumber.AutoSize = true;
			this.cBoxSortByArticleNumber.Location = new System.Drawing.Point(262, 245);
			this.cBoxSortByArticleNumber.Margin = new System.Windows.Forms.Padding(4);
			this.cBoxSortByArticleNumber.Name = "cBoxSortByArticleNumber";
			this.cBoxSortByArticleNumber.Size = new System.Drawing.Size(187, 20);
			this.cBoxSortByArticleNumber.TabIndex = 27;
			this.cBoxSortByArticleNumber.Text = "Sortera efter artikelnummer";
			this.cBoxSortByArticleNumber.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1448, 688);
			this.Controls.Add(this.gBoxFilter);
			this.Controls.Add(this.gBoxData);
			this.Controls.Add(this.mainStatusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Systembolagskollen";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.gBoxData.ResumeLayout(false);
			this.gBoxData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.beverageGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.beverageDataSource)).EndInit();
			this.gBoxFilter.ResumeLayout(false);
			this.gBoxFilter.PerformLayout();
			this.gBoxInformation.ResumeLayout(false);
			this.gBoxInformation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxData;
        private System.Windows.Forms.DataGridView beverageGridView;
        private System.Windows.Forms.BindingSource beverageDataSource;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.Label lblArticleNumber;
        private System.Windows.Forms.TextBox txtArticleNumberFrom;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceDiverter;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.CheckBox checkEco;
        private System.Windows.Forms.CheckBox checkKoscher;
        private System.Windows.Forms.CheckBox checkEthical;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlcoholTo;
        private System.Windows.Forms.TextBox txtAlcoholFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxTypes;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox gBoxInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omProgrammetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateDatabase;
        private System.Windows.Forms.ProgressBar pgBarDownload;
        private System.Windows.Forms.CheckBox cBoxAPK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtArticleNumberTo;
        private System.Windows.Forms.Label lblBytesReceived;
        private System.Windows.Forms.ToolStripStatusLabel tsLblAmountOfArticles;
        private System.Windows.Forms.Label lblPage;
		private System.Windows.Forms.CheckBox cBoxSortByArticleNumber;
	}
}


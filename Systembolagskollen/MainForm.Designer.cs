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
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omProgrammetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxData = new System.Windows.Forms.GroupBox();
            this.lblAmountOfArticles = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.beverageGridView = new System.Windows.Forms.DataGridView();
            this.beverageDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
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
            this.lblBytesReceived = new System.Windows.Forms.Label();
            this.gBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beverageGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverageDataSource)).BeginInit();
            this.gBoxFilter.SuspendLayout();
            this.gBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 537);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1086, 22);
            this.mainStatusStrip.TabIndex = 4;
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
            this.gBoxData.Controls.Add(this.lblAmountOfArticles);
            this.gBoxData.Controls.Add(this.btnUpdate);
            this.gBoxData.Controls.Add(this.btnOpen);
            this.gBoxData.Controls.Add(this.btnPrevious);
            this.gBoxData.Controls.Add(this.btnNext);
            this.gBoxData.Controls.Add(this.beverageGridView);
            this.gBoxData.Location = new System.Drawing.Point(13, 12);
            this.gBoxData.Name = "gBoxData";
            this.gBoxData.Size = new System.Drawing.Size(672, 522);
            this.gBoxData.TabIndex = 2;
            this.gBoxData.TabStop = false;
            this.gBoxData.Text = "Drycker";
            // 
            // lblAmountOfArticles
            // 
            this.lblAmountOfArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmountOfArticles.AutoSize = true;
            this.lblAmountOfArticles.Location = new System.Drawing.Point(6, 479);
            this.lblAmountOfArticles.Name = "lblAmountOfArticles";
            this.lblAmountOfArticles.Size = new System.Drawing.Size(65, 13);
            this.lblAmountOfArticles.TabIndex = 26;
            this.lblAmountOfArticles.Text = "Antal artiklar";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(485, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Uppdatera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(566, 475);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Öppna artikel";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.Location = new System.Drawing.Point(118, 475);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Föregående";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(199, 475);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
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
            this.beverageGridView.Location = new System.Drawing.Point(18, 19);
            this.beverageGridView.Name = "beverageGridView";
            this.beverageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.beverageGridView.Size = new System.Drawing.Size(660, 450);
            this.beverageGridView.TabIndex = 3;
            this.beverageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.beverageGridView_CellContentClick);
            this.beverageGridView.DoubleClick += new System.EventHandler(this.beverageGridView_DoubleClick);
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gBoxFilter.Location = new System.Drawing.Point(691, 27);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(383, 507);
            this.gBoxFilter.TabIndex = 3;
            this.gBoxFilter.TabStop = false;
            this.gBoxFilter.Text = "Filtrera";
            this.gBoxFilter.Enter += new System.EventHandler(this.gBoxFilter_Enter);
            // 
            // txtArticleNumberTo
            // 
            this.txtArticleNumberTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticleNumberTo.Location = new System.Drawing.Point(223, 20);
            this.txtArticleNumberTo.Name = "txtArticleNumberTo";
            this.txtArticleNumberTo.Size = new System.Drawing.Size(88, 20);
            this.txtArticleNumberTo.TabIndex = 25;
            // 
            // cBoxAPK
            // 
            this.cBoxAPK.AutoSize = true;
            this.cBoxAPK.Location = new System.Drawing.Point(111, 199);
            this.cBoxAPK.Name = "cBoxAPK";
            this.cBoxAPK.Size = new System.Drawing.Size(111, 17);
            this.cBoxAPK.TabIndex = 24;
            this.cBoxAPK.Text = "Sortera efter APK ";
            this.cBoxAPK.UseVisualStyleBackColor = true;
            // 
            // pgBarDownload
            // 
            this.pgBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgBarDownload.Location = new System.Drawing.Point(11, 478);
            this.pgBarDownload.Name = "pgBarDownload";
            this.pgBarDownload.Size = new System.Drawing.Size(177, 23);
            this.pgBarDownload.Step = 5;
            this.pgBarDownload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBarDownload.TabIndex = 23;
            this.pgBarDownload.Visible = false;
            // 
            // gBoxInformation
            // 
            this.gBoxInformation.Controls.Add(this.label1);
            this.gBoxInformation.Location = new System.Drawing.Point(11, 289);
            this.gBoxInformation.Name = "gBoxInformation";
            this.gBoxInformation.Size = new System.Drawing.Size(366, 165);
            this.gBoxInformation.TabIndex = 22;
            this.gBoxInformation.TabStop = false;
            this.gBoxInformation.Text = "Tips och information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(302, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Stäng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 174);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(25, 13);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Typ";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(317, 145);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage.TabIndex = 19;
            this.lblPercentage.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "-";
            // 
            // txtAlcoholTo
            // 
            this.txtAlcoholTo.Location = new System.Drawing.Point(237, 142);
            this.txtAlcoholTo.Name = "txtAlcoholTo";
            this.txtAlcoholTo.Size = new System.Drawing.Size(64, 20);
            this.txtAlcoholTo.TabIndex = 17;
            this.txtAlcoholTo.Text = "0";
            // 
            // txtAlcoholFrom
            // 
            this.txtAlcoholFrom.Location = new System.Drawing.Point(111, 142);
            this.txtAlcoholFrom.Name = "txtAlcoholFrom";
            this.txtAlcoholFrom.Size = new System.Drawing.Size(64, 20);
            this.txtAlcoholFrom.TabIndex = 16;
            this.txtAlcoholFrom.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alkoholhalt";
            // 
            // cBoxTypes
            // 
            this.cBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTypes.FormattingEnabled = true;
            this.cBoxTypes.Location = new System.Drawing.Point(87, 171);
            this.cBoxTypes.Name = "cBoxTypes";
            this.cBoxTypes.Size = new System.Drawing.Size(290, 21);
            this.cBoxTypes.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 56);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Rensa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(237, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 56);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Namn";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 20);
            this.txtName.TabIndex = 10;
            // 
            // checkEthical
            // 
            this.checkEthical.AutoSize = true;
            this.checkEthical.Location = new System.Drawing.Point(249, 80);
            this.checkEthical.Name = "checkEthical";
            this.checkEthical.Size = new System.Drawing.Size(52, 17);
            this.checkEthical.TabIndex = 9;
            this.checkEthical.Text = "Etiskt";
            this.checkEthical.UseVisualStyleBackColor = true;
            // 
            // checkKoscher
            // 
            this.checkKoscher.AutoSize = true;
            this.checkKoscher.Location = new System.Drawing.Point(178, 80);
            this.checkKoscher.Name = "checkKoscher";
            this.checkKoscher.Size = new System.Drawing.Size(65, 17);
            this.checkKoscher.TabIndex = 8;
            this.checkKoscher.Text = "Koscher";
            this.checkKoscher.UseVisualStyleBackColor = true;
            // 
            // checkEco
            // 
            this.checkEco.AutoSize = true;
            this.checkEco.Location = new System.Drawing.Point(100, 80);
            this.checkEco.Name = "checkEco";
            this.checkEco.Size = new System.Drawing.Size(72, 17);
            this.checkEco.TabIndex = 7;
            this.checkEco.Text = "Ekologisk";
            this.checkEco.UseVisualStyleBackColor = true;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(317, 49);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(28, 13);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "SEK";
            // 
            // lblPriceDiverter
            // 
            this.lblPriceDiverter.AutoSize = true;
            this.lblPriceDiverter.Location = new System.Drawing.Point(200, 49);
            this.lblPriceDiverter.Name = "lblPriceDiverter";
            this.lblPriceDiverter.Size = new System.Drawing.Size(10, 13);
            this.lblPriceDiverter.TabIndex = 5;
            this.lblPriceDiverter.Text = "-";
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.Location = new System.Drawing.Point(237, 46);
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Size = new System.Drawing.Size(64, 20);
            this.txtPriceTo.TabIndex = 4;
            this.txtPriceTo.Text = "0";
            // 
            // txtPriceFrom
            // 
            this.txtPriceFrom.Location = new System.Drawing.Point(111, 46);
            this.txtPriceFrom.Name = "txtPriceFrom";
            this.txtPriceFrom.Size = new System.Drawing.Size(64, 20);
            this.txtPriceFrom.TabIndex = 3;
            this.txtPriceFrom.Text = "0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 49);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Pris";
            // 
            // txtArticleNumberFrom
            // 
            this.txtArticleNumberFrom.Location = new System.Drawing.Point(100, 19);
            this.txtArticleNumberFrom.Name = "txtArticleNumberFrom";
            this.txtArticleNumberFrom.Size = new System.Drawing.Size(88, 20);
            this.txtArticleNumberFrom.TabIndex = 1;
            // 
            // lblArticleNumber
            // 
            this.lblArticleNumber.AutoSize = true;
            this.lblArticleNumber.Location = new System.Drawing.Point(8, 23);
            this.lblArticleNumber.Name = "lblArticleNumber";
            this.lblArticleNumber.Size = new System.Drawing.Size(73, 13);
            this.lblArticleNumber.TabIndex = 0;
            this.lblArticleNumber.Text = "Artikelnummer";
            // 
            // lblBytesReceived
            // 
            this.lblBytesReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBytesReceived.AutoSize = true;
            this.lblBytesReceived.Location = new System.Drawing.Point(194, 483);
            this.lblBytesReceived.Name = "lblBytesReceived";
            this.lblBytesReceived.Size = new System.Drawing.Size(0, 13);
            this.lblBytesReceived.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 559);
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.gBoxData);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Systembolagskollen";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblAmountOfArticles;
        private System.Windows.Forms.Label lblBytesReceived;
    }
}


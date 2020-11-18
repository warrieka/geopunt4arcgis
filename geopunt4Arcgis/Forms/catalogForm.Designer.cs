namespace geopunt4Arcgis
{
    partial class catalogForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogForm));
         this.statusStrip = new System.Windows.Forms.StatusStrip();
         this.statusMsgLbl = new System.Windows.Forms.ToolStripStatusLabel();
         this.helpLbl = new System.Windows.Forms.ToolStripStatusLabel();
         this.keywordTxt = new System.Windows.Forms.TextBox();
         this.zoekBtn = new System.Windows.Forms.Button();
         this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
         this.searchResultsList = new System.Windows.Forms.ListBox();
         this.webView = new System.Windows.Forms.WebBrowser();
         this.OpenArcgisBtn = new System.Windows.Forms.Button();
         this.addWMSbtn = new System.Windows.Forms.Button();
         this.closeBtn = new System.Windows.Forms.Button();
         this.filterResultsCbx = new System.Windows.Forms.ComboBox();
         this.filterBox = new System.Windows.Forms.GroupBox();
         this.filterPane = new System.Windows.Forms.TableLayoutPanel();
         this.typeLbl = new System.Windows.Forms.Label();
         this.INSPIREthemeLbl = new System.Windows.Forms.Label();
         this.typeCbx = new System.Windows.Forms.ComboBox();
         this.bronCatCbx = new System.Windows.Forms.ComboBox();
         this.INSPIREthemeCbx = new System.Windows.Forms.ComboBox();
         this.orgNameCbx = new System.Windows.Forms.ComboBox();
         this.GDIthemeCbx = new System.Windows.Forms.ComboBox();
         this.GDIthemaLbl = new System.Windows.Forms.Label();
         this.orgName = new System.Windows.Forms.Label();
         this.BronLbl = new System.Windows.Forms.Label();
         this.statusStrip.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
         this.contentSplitContainer.Panel1.SuspendLayout();
         this.contentSplitContainer.Panel2.SuspendLayout();
         this.contentSplitContainer.SuspendLayout();
         this.filterBox.SuspendLayout();
         this.filterPane.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip
         // 
         this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMsgLbl,
            this.helpLbl});
         this.statusStrip.Location = new System.Drawing.Point(0, 573);
         this.statusStrip.Name = "statusStrip";
         this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
         this.statusStrip.Size = new System.Drawing.Size(948, 25);
         this.statusStrip.TabIndex = 0;
         this.statusStrip.Text = "statusStrip1";
         // 
         // statusMsgLbl
         // 
         this.statusMsgLbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
         this.statusMsgLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
         this.statusMsgLbl.Name = "statusMsgLbl";
         this.statusMsgLbl.Size = new System.Drawing.Size(887, 20);
         this.statusMsgLbl.Spring = true;
         // 
         // helpLbl
         // 
         this.helpLbl.IsLink = true;
         this.helpLbl.Name = "helpLbl";
         this.helpLbl.Size = new System.Drawing.Size(41, 20);
         this.helpLbl.Text = "Help";
         this.helpLbl.Click += new System.EventHandler(this.helpLbl_Click);
         // 
         // keywordTxt
         // 
         this.keywordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.keywordTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
         this.keywordTxt.Location = new System.Drawing.Point(12, 21);
         this.keywordTxt.Margin = new System.Windows.Forms.Padding(4);
         this.keywordTxt.Name = "keywordTxt";
         this.keywordTxt.Size = new System.Drawing.Size(829, 22);
         this.keywordTxt.TabIndex = 1;
         this.keywordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keywordTxt_KeyPress);
         // 
         // zoekBtn
         // 
         this.zoekBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.zoekBtn.Location = new System.Drawing.Point(851, 15);
         this.zoekBtn.Margin = new System.Windows.Forms.Padding(4);
         this.zoekBtn.Name = "zoekBtn";
         this.zoekBtn.Size = new System.Drawing.Size(85, 28);
         this.zoekBtn.TabIndex = 3;
         this.zoekBtn.Text = "Zoek";
         this.zoekBtn.UseVisualStyleBackColor = true;
         this.zoekBtn.Click += new System.EventHandler(this.zoekBtn_Click);
         // 
         // contentSplitContainer
         // 
         this.contentSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.contentSplitContainer.Location = new System.Drawing.Point(13, 183);
         this.contentSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.contentSplitContainer.Name = "contentSplitContainer";
         // 
         // contentSplitContainer.Panel1
         // 
         this.contentSplitContainer.Panel1.Controls.Add(this.searchResultsList);
         // 
         // contentSplitContainer.Panel2
         // 
         this.contentSplitContainer.Panel2.Controls.Add(this.webView);
         this.contentSplitContainer.Size = new System.Drawing.Size(917, 340);
         this.contentSplitContainer.SplitterDistance = 298;
         this.contentSplitContainer.TabIndex = 10;
         // 
         // searchResultsList
         // 
         this.searchResultsList.Dock = System.Windows.Forms.DockStyle.Fill;
         this.searchResultsList.FormattingEnabled = true;
         this.searchResultsList.HorizontalScrollbar = true;
         this.searchResultsList.ItemHeight = 16;
         this.searchResultsList.Location = new System.Drawing.Point(0, 0);
         this.searchResultsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.searchResultsList.Name = "searchResultsList";
         this.searchResultsList.Size = new System.Drawing.Size(298, 340);
         this.searchResultsList.TabIndex = 0;
         this.searchResultsList.SelectedIndexChanged += new System.EventHandler(this.searchResultsList_SelectedIndexChanged);
         // 
         // webView
         // 
         this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.webView.Location = new System.Drawing.Point(0, 0);
         this.webView.MinimumSize = new System.Drawing.Size(20, 20);
         this.webView.Name = "webView";
         this.webView.Size = new System.Drawing.Size(615, 340);
         this.webView.TabIndex = 1;
         // 
         // OpenArcgisBtn
         // 
         this.OpenArcgisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.OpenArcgisBtn.Enabled = false;
         this.OpenArcgisBtn.Location = new System.Drawing.Point(685, 533);
         this.OpenArcgisBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.OpenArcgisBtn.Name = "OpenArcgisBtn";
         this.OpenArcgisBtn.Size = new System.Drawing.Size(116, 34);
         this.OpenArcgisBtn.TabIndex = 11;
         this.OpenArcgisBtn.Text = "Arcgis server";
         this.OpenArcgisBtn.UseVisualStyleBackColor = true;
         this.OpenArcgisBtn.Click += new System.EventHandler(this.OpenDownloadBtn_Click);
         // 
         // addWMSbtn
         // 
         this.addWMSbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.addWMSbtn.Enabled = false;
         this.addWMSbtn.Location = new System.Drawing.Point(529, 533);
         this.addWMSbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.addWMSbtn.Name = "addWMSbtn";
         this.addWMSbtn.Size = new System.Drawing.Size(150, 34);
         this.addWMSbtn.TabIndex = 12;
         this.addWMSbtn.Text = "WMS-toevoegen";
         this.addWMSbtn.UseVisualStyleBackColor = true;
         this.addWMSbtn.Click += new System.EventHandler(this.addWMSbtn_Click);
         // 
         // closeBtn
         // 
         this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.closeBtn.Location = new System.Drawing.Point(821, 533);
         this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.closeBtn.Name = "closeBtn";
         this.closeBtn.Size = new System.Drawing.Size(109, 34);
         this.closeBtn.TabIndex = 13;
         this.closeBtn.Text = "Sluiten";
         this.closeBtn.UseVisualStyleBackColor = true;
         this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
         // 
         // filterResultsCbx
         // 
         this.filterResultsCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.filterResultsCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.filterResultsCbx.FormattingEnabled = true;
         this.filterResultsCbx.Items.AddRange(new object[] {
            "Alles weergeven",
            "WMS",
            "Download"});
         this.filterResultsCbx.Location = new System.Drawing.Point(13, 533);
         this.filterResultsCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.filterResultsCbx.Name = "filterResultsCbx";
         this.filterResultsCbx.Size = new System.Drawing.Size(132, 24);
         this.filterResultsCbx.TabIndex = 14;
         this.filterResultsCbx.SelectedIndexChanged += new System.EventHandler(this.filterResultsCbx_SelectedIndexChanged);
         // 
         // filterBox
         // 
         this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.filterBox.Controls.Add(this.filterPane);
         this.filterBox.Location = new System.Drawing.Point(12, 50);
         this.filterBox.Name = "filterBox";
         this.filterBox.Padding = new System.Windows.Forms.Padding(8);
         this.filterBox.Size = new System.Drawing.Size(918, 128);
         this.filterBox.TabIndex = 15;
         this.filterBox.TabStop = false;
         this.filterBox.Text = "Filtercriteria metadata";
         // 
         // filterPane
         // 
         this.filterPane.ColumnCount = 4;
         this.filterPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.filterPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
         this.filterPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.filterPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
         this.filterPane.Controls.Add(this.typeLbl, 2, 0);
         this.filterPane.Controls.Add(this.INSPIREthemeLbl, 2, 1);
         this.filterPane.Controls.Add(this.typeCbx, 3, 0);
         this.filterPane.Controls.Add(this.bronCatCbx, 1, 2);
         this.filterPane.Controls.Add(this.INSPIREthemeCbx, 3, 1);
         this.filterPane.Controls.Add(this.orgNameCbx, 1, 1);
         this.filterPane.Controls.Add(this.GDIthemeCbx, 1, 0);
         this.filterPane.Controls.Add(this.GDIthemaLbl, 0, 0);
         this.filterPane.Controls.Add(this.orgName, 0, 1);
         this.filterPane.Controls.Add(this.BronLbl, 0, 2);
         this.filterPane.Dock = System.Windows.Forms.DockStyle.Fill;
         this.filterPane.Location = new System.Drawing.Point(8, 23);
         this.filterPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.filterPane.Name = "filterPane";
         this.filterPane.RowCount = 3;
         this.filterPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.filterPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.filterPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.filterPane.Size = new System.Drawing.Size(902, 97);
         this.filterPane.TabIndex = 10;
         // 
         // typeLbl
         // 
         this.typeLbl.AutoSize = true;
         this.typeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.typeLbl.Location = new System.Drawing.Point(453, 0);
         this.typeLbl.Name = "typeLbl";
         this.typeLbl.Size = new System.Drawing.Size(174, 32);
         this.typeLbl.TabIndex = 17;
         this.typeLbl.Text = "Type: ";
         // 
         // INSPIREthemeLbl
         // 
         this.INSPIREthemeLbl.AutoSize = true;
         this.INSPIREthemeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.INSPIREthemeLbl.Location = new System.Drawing.Point(453, 32);
         this.INSPIREthemeLbl.Name = "INSPIREthemeLbl";
         this.INSPIREthemeLbl.Size = new System.Drawing.Size(174, 32);
         this.INSPIREthemeLbl.TabIndex = 9;
         this.INSPIREthemeLbl.Text = "INSPIRE-thema:";
         // 
         // typeCbx
         // 
         this.typeCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
         this.typeCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.typeCbx.Dock = System.Windows.Forms.DockStyle.Fill;
         this.typeCbx.FormattingEnabled = true;
         this.typeCbx.Location = new System.Drawing.Point(633, 2);
         this.typeCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.typeCbx.Name = "typeCbx";
         this.typeCbx.Size = new System.Drawing.Size(266, 24);
         this.typeCbx.TabIndex = 16;
         // 
         // bronCatCbx
         // 
         this.bronCatCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
         this.bronCatCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.bronCatCbx.Dock = System.Windows.Forms.DockStyle.Fill;
         this.bronCatCbx.FormattingEnabled = true;
         this.bronCatCbx.Location = new System.Drawing.Point(183, 66);
         this.bronCatCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.bronCatCbx.Name = "bronCatCbx";
         this.bronCatCbx.Size = new System.Drawing.Size(264, 24);
         this.bronCatCbx.TabIndex = 14;
         // 
         // INSPIREthemeCbx
         // 
         this.INSPIREthemeCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
         this.INSPIREthemeCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.INSPIREthemeCbx.Dock = System.Windows.Forms.DockStyle.Fill;
         this.INSPIREthemeCbx.FormattingEnabled = true;
         this.INSPIREthemeCbx.Location = new System.Drawing.Point(633, 34);
         this.INSPIREthemeCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.INSPIREthemeCbx.Name = "INSPIREthemeCbx";
         this.INSPIREthemeCbx.Size = new System.Drawing.Size(266, 24);
         this.INSPIREthemeCbx.TabIndex = 13;
         // 
         // orgNameCbx
         // 
         this.orgNameCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
         this.orgNameCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.orgNameCbx.Dock = System.Windows.Forms.DockStyle.Fill;
         this.orgNameCbx.FormattingEnabled = true;
         this.orgNameCbx.Location = new System.Drawing.Point(183, 34);
         this.orgNameCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.orgNameCbx.Name = "orgNameCbx";
         this.orgNameCbx.Size = new System.Drawing.Size(264, 24);
         this.orgNameCbx.TabIndex = 12;
         // 
         // GDIthemeCbx
         // 
         this.GDIthemeCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
         this.GDIthemeCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.GDIthemeCbx.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GDIthemeCbx.FormattingEnabled = true;
         this.GDIthemeCbx.Location = new System.Drawing.Point(183, 2);
         this.GDIthemeCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.GDIthemeCbx.Name = "GDIthemeCbx";
         this.GDIthemeCbx.Size = new System.Drawing.Size(264, 24);
         this.GDIthemeCbx.TabIndex = 10;
         // 
         // GDIthemaLbl
         // 
         this.GDIthemaLbl.AutoSize = true;
         this.GDIthemaLbl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.GDIthemaLbl.Location = new System.Drawing.Point(3, 0);
         this.GDIthemaLbl.Name = "GDIthemaLbl";
         this.GDIthemaLbl.Size = new System.Drawing.Size(174, 32);
         this.GDIthemaLbl.TabIndex = 4;
         this.GDIthemaLbl.Text = "GDI-thema:";
         // 
         // orgName
         // 
         this.orgName.AutoSize = true;
         this.orgName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.orgName.Location = new System.Drawing.Point(3, 32);
         this.orgName.Name = "orgName";
         this.orgName.Size = new System.Drawing.Size(174, 32);
         this.orgName.TabIndex = 5;
         this.orgName.Text = "Organisatie naam:";
         // 
         // BronLbl
         // 
         this.BronLbl.AutoSize = true;
         this.BronLbl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BronLbl.Location = new System.Drawing.Point(3, 64);
         this.BronLbl.Name = "BronLbl";
         this.BronLbl.Size = new System.Drawing.Size(174, 33);
         this.BronLbl.TabIndex = 6;
         this.BronLbl.Text = "Bron catalogus";
         // 
         // catalogForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(948, 598);
         this.Controls.Add(this.filterBox);
         this.Controls.Add(this.filterResultsCbx);
         this.Controls.Add(this.closeBtn);
         this.Controls.Add(this.addWMSbtn);
         this.Controls.Add(this.OpenArcgisBtn);
         this.Controls.Add(this.contentSplitContainer);
         this.Controls.Add(this.zoekBtn);
         this.Controls.Add(this.keywordTxt);
         this.Controls.Add(this.statusStrip);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.MinimumSize = new System.Drawing.Size(600, 497);
         this.Name = "catalogForm";
         this.Text = "Geopunt-catalogus";
         this.statusStrip.ResumeLayout(false);
         this.statusStrip.PerformLayout();
         this.contentSplitContainer.Panel1.ResumeLayout(false);
         this.contentSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
         this.contentSplitContainer.ResumeLayout(false);
         this.filterBox.ResumeLayout(false);
         this.filterPane.ResumeLayout(false);
         this.filterPane.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMsgLbl;
        private System.Windows.Forms.ToolStripStatusLabel helpLbl;
        private System.Windows.Forms.TextBox keywordTxt;
        private System.Windows.Forms.Button zoekBtn;
        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.ListBox searchResultsList;
        private System.Windows.Forms.Button OpenArcgisBtn;
        private System.Windows.Forms.Button addWMSbtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox filterResultsCbx;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.TableLayoutPanel filterPane;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.ComboBox bronCatCbx;
        private System.Windows.Forms.ComboBox INSPIREthemeCbx;
        private System.Windows.Forms.ComboBox orgNameCbx;
        private System.Windows.Forms.ComboBox GDIthemeCbx;
        private System.Windows.Forms.Label GDIthemaLbl;
        private System.Windows.Forms.Label orgName;
        private System.Windows.Forms.Label BronLbl;
        private System.Windows.Forms.WebBrowser webView;
        private System.Windows.Forms.Label INSPIREthemeLbl;
        private System.Windows.Forms.Label typeLbl;
    }
}
namespace Wproject22.GUI
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_category = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_CTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_CCategorycode = new System.Windows.Forms.TextBox();
            this.TB_CName = new System.Windows.Forms.TextBox();
            this.TB_CId = new System.Windows.Forms.TextBox();
            this.CB_Active = new System.Windows.Forms.CheckBox();
            this.DGV_Categories = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategoriescode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project22DataSet = new Wproject22.project22DataSet();
            this.TS_Categories = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ECSV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ICSV = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_IJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_IXML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_CNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_CEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_CDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_CSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_CRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Print_TSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_CCancel = new System.Windows.Forms.ToolStripButton();
            this.categoriesTableAdapter = new Wproject22.project22DataSetTableAdapters.categoriesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_ST_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project22DataSet)).BeginInit();
            this.TS_Categories.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_category});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_category
            // 
            this.TSSL_category.Name = "TSSL_category";
            this.TSSL_category.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 78);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_Categories);
            this.splitContainer1.Size = new System.Drawing.Size(666, 391);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_CTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TB_CDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TB_CCategorycode);
            this.groupBox2.Controls.Add(this.TB_CName);
            this.groupBox2.Controls.Add(this.TB_CId);
            this.groupBox2.Controls.Add(this.CB_Active);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 66);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID :";
            // 
            // TB_CTime
            // 
            this.TB_CTime.Location = new System.Drawing.Point(566, 30);
            this.TB_CTime.Name = "TB_CTime";
            this.TB_CTime.Size = new System.Drawing.Size(88, 20);
            this.TB_CTime.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time :";
            // 
            // TB_CDate
            // 
            this.TB_CDate.Location = new System.Drawing.Point(459, 30);
            this.TB_CDate.Name = "TB_CDate";
            this.TB_CDate.Size = new System.Drawing.Size(88, 20);
            this.TB_CDate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date :";
            // 
            // TB_CCategorycode
            // 
            this.TB_CCategorycode.Location = new System.Drawing.Point(176, 30);
            this.TB_CCategorycode.Name = "TB_CCategorycode";
            this.TB_CCategorycode.Size = new System.Drawing.Size(89, 20);
            this.TB_CCategorycode.TabIndex = 1;
            // 
            // TB_CName
            // 
            this.TB_CName.Location = new System.Drawing.Point(281, 30);
            this.TB_CName.Name = "TB_CName";
            this.TB_CName.Size = new System.Drawing.Size(163, 20);
            this.TB_CName.TabIndex = 1;
            // 
            // TB_CId
            // 
            this.TB_CId.Location = new System.Drawing.Point(67, 30);
            this.TB_CId.Name = "TB_CId";
            this.TB_CId.Size = new System.Drawing.Size(100, 20);
            this.TB_CId.TabIndex = 1;
            // 
            // CB_Active
            // 
            this.CB_Active.AutoSize = true;
            this.CB_Active.Location = new System.Drawing.Point(15, 30);
            this.CB_Active.Name = "CB_Active";
            this.CB_Active.Size = new System.Drawing.Size(56, 17);
            this.CB_Active.TabIndex = 0;
            this.CB_Active.Text = "Active";
            this.CB_Active.UseVisualStyleBackColor = true;
            // 
            // DGV_Categories
            // 
            this.DGV_Categories.AllowUserToAddRows = false;
            this.DGV_Categories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Categories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Categories.AutoGenerateColumns = false;
            this.DGV_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.ccategoriescode,
            this.cactive,
            this.cname,
            this.cdate,
            this.ctime,
            this.cuser});
            this.DGV_Categories.DataSource = this.categoriesBindingSource;
            this.DGV_Categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Categories.Location = new System.Drawing.Point(0, 0);
            this.DGV_Categories.Name = "DGV_Categories";
            this.DGV_Categories.ReadOnly = true;
            this.DGV_Categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Categories.Size = new System.Drawing.Size(666, 321);
            this.DGV_Categories.TabIndex = 0;
            this.DGV_Categories.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Categories_ColumnHeaderMouseClick);
            this.DGV_Categories.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Categories_RowEnter);
            this.DGV_Categories.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Categories_RowPostPaint);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "ID";
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Width = 50;
            // 
            // ccategoriescode
            // 
            this.ccategoriescode.DataPropertyName = "categories_code";
            this.ccategoriescode.HeaderText = "Categories code";
            this.ccategoriescode.Name = "ccategoriescode";
            this.ccategoriescode.ReadOnly = true;
            // 
            // cactive
            // 
            this.cactive.DataPropertyName = "active";
            this.cactive.HeaderText = "Active";
            this.cactive.Name = "cactive";
            this.cactive.ReadOnly = true;
            this.cactive.Width = 50;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            // 
            // cdate
            // 
            this.cdate.DataPropertyName = "date";
            this.cdate.HeaderText = "Date";
            this.cdate.Name = "cdate";
            this.cdate.ReadOnly = true;
            this.cdate.Width = 80;
            // 
            // ctime
            // 
            this.ctime.DataPropertyName = "time";
            this.ctime.HeaderText = "Time";
            this.ctime.Name = "ctime";
            this.ctime.ReadOnly = true;
            this.ctime.Width = 80;
            // 
            // cuser
            // 
            this.cuser.DataPropertyName = "user";
            this.cuser.HeaderText = "User";
            this.cuser.Name = "cuser";
            this.cuser.ReadOnly = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.project22DataSet;
            // 
            // project22DataSet
            // 
            this.project22DataSet.DataSetName = "project22DataSet";
            this.project22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TS_Categories
            // 
            this.TS_Categories.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TS_Categories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator6,
            this.TSB_CNew,
            this.toolStripSeparator1,
            this.TSB_CEdit,
            this.toolStripSeparator2,
            this.TSB_CDelete,
            this.toolStripSeparator4,
            this.TSB_CSearch,
            this.toolStripSeparator3,
            this.TSB_CRefresh,
            this.toolStripSeparator5,
            this.Print_TSB,
            this.toolStripButton2,
            this.toolStripSeparator7,
            this.TSB_CCancel});
            this.TS_Categories.Location = new System.Drawing.Point(0, 24);
            this.TS_Categories.Name = "TS_Categories";
            this.TS_Categories.Size = new System.Drawing.Size(666, 54);
            this.TS_Categories.TabIndex = 9;
            this.TS_Categories.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton2.Image = global::Wproject22.Properties.Resources.file_icon;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(38, 51);
            this.toolStripDropDownButton2.Text = "File";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ECSV,
            this.TSMI_EJSON,
            this.TSMI_EXML});
            this.toolStripMenuItem1.Image = global::Wproject22.Properties.Resources.export_icon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem1.Text = "Export";
            // 
            // TSMI_ECSV
            // 
            this.TSMI_ECSV.Name = "TSMI_ECSV";
            this.TSMI_ECSV.Size = new System.Drawing.Size(102, 22);
            this.TSMI_ECSV.Text = "CSV";
            this.TSMI_ECSV.Click += new System.EventHandler(this.TSMI_ECSV_Click);
            // 
            // TSMI_EJSON
            // 
            this.TSMI_EJSON.Name = "TSMI_EJSON";
            this.TSMI_EJSON.Size = new System.Drawing.Size(102, 22);
            this.TSMI_EJSON.Text = "JSON";
            // 
            // TSMI_EXML
            // 
            this.TSMI_EXML.Name = "TSMI_EXML";
            this.TSMI_EXML.Size = new System.Drawing.Size(102, 22);
            this.TSMI_EXML.Text = "XML";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ICSV,
            this.TSMI_IJSON,
            this.TSMI_IXML});
            this.toolStripMenuItem2.Image = global::Wproject22.Properties.Resources.import_icon;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "Import";
            // 
            // TSMI_ICSV
            // 
            this.TSMI_ICSV.Name = "TSMI_ICSV";
            this.TSMI_ICSV.Size = new System.Drawing.Size(102, 22);
            this.TSMI_ICSV.Text = "CSV";
            // 
            // TSMI_IJSON
            // 
            this.TSMI_IJSON.Name = "TSMI_IJSON";
            this.TSMI_IJSON.Size = new System.Drawing.Size(102, 22);
            this.TSMI_IJSON.Text = "JSON";
            // 
            // TSMI_IXML
            // 
            this.TSMI_IXML.Name = "TSMI_IXML";
            this.TSMI_IXML.Size = new System.Drawing.Size(102, 22);
            this.TSMI_IXML.Text = "XML";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_CNew
            // 
            this.TSB_CNew.Image = global::Wproject22.Properties.Resources.new_file_icon;
            this.TSB_CNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_CNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CNew.Name = "TSB_CNew";
            this.TSB_CNew.Size = new System.Drawing.Size(36, 51);
            this.TSB_CNew.Text = "New";
            this.TSB_CNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_CNew.Click += new System.EventHandler(this.TSB_CNew_Click);
            this.TSB_CNew.MouseHover += new System.EventHandler(this.TSB_CNew_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_CEdit
            // 
            this.TSB_CEdit.Image = global::Wproject22.Properties.Resources.edit_validated_icon;
            this.TSB_CEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CEdit.Name = "TSB_CEdit";
            this.TSB_CEdit.Size = new System.Drawing.Size(31, 51);
            this.TSB_CEdit.Text = "Edit";
            this.TSB_CEdit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.TSB_CEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_CEdit.Click += new System.EventHandler(this.TSB_CEdit_Click);
            this.TSB_CEdit.MouseHover += new System.EventHandler(this.TSB_CEdit_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_CDelete
            // 
            this.TSB_CDelete.Image = global::Wproject22.Properties.Resources.Delete_icon;
            this.TSB_CDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CDelete.Name = "TSB_CDelete";
            this.TSB_CDelete.Size = new System.Drawing.Size(44, 51);
            this.TSB_CDelete.Text = "Delete";
            this.TSB_CDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_CDelete.Click += new System.EventHandler(this.TSB_CDelete_Click);
            this.TSB_CDelete.MouseHover += new System.EventHandler(this.TSB_CDelete_MouseHover);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_CSearch
            // 
            this.TSB_CSearch.Image = global::Wproject22.Properties.Resources.Zoom_icon;
            this.TSB_CSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CSearch.Name = "TSB_CSearch";
            this.TSB_CSearch.Size = new System.Drawing.Size(46, 51);
            this.TSB_CSearch.Text = "Search";
            this.TSB_CSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_CSearch.MouseHover += new System.EventHandler(this.TSB_CSearch_MouseHover);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_CRefresh
            // 
            this.TSB_CRefresh.Image = global::Wproject22.Properties.Resources.Misc_Download_Database_icon;
            this.TSB_CRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CRefresh.Name = "TSB_CRefresh";
            this.TSB_CRefresh.Size = new System.Drawing.Size(50, 51);
            this.TSB_CRefresh.Text = "Refresh";
            this.TSB_CRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_CRefresh.Click += new System.EventHandler(this.TSB_CRefresh_Click);
            this.TSB_CRefresh.MouseHover += new System.EventHandler(this.TSB_CRefresh_MouseHover);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // Print_TSB
            // 
            this.Print_TSB.Image = ((System.Drawing.Image)(resources.GetObject("Print_TSB.Image")));
            this.Print_TSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print_TSB.Name = "Print_TSB";
            this.Print_TSB.Size = new System.Drawing.Size(36, 51);
            this.Print_TSB.Text = "Print";
            this.Print_TSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 51);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_CCancel
            // 
            this.TSB_CCancel.Image = global::Wproject22.Properties.Resources.Close_icon1;
            this.TSB_CCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CCancel.Name = "TSB_CCancel";
            this.TSB_CCancel.Size = new System.Drawing.Size(47, 51);
            this.TSB_CCancel.Text = "Cancel";
            this.TSB_CCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_CCancel.Click += new System.EventHandler(this.TSB_CCancel_Click);
            this.TSB_CCancel.MouseHover += new System.EventHandler(this.TSB_CCancel_MouseHover);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_ST_TSMI,
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuBar_ST_TSMI
            // 
            this.menuBar_ST_TSMI.Checked = true;
            this.menuBar_ST_TSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBar_ST_TSMI.Name = "menuBar_ST_TSMI";
            this.menuBar_ST_TSMI.Size = new System.Drawing.Size(180, 22);
            this.menuBar_ST_TSMI.Text = "Menu bar";
            this.menuBar_ST_TSMI.Click += new System.EventHandler(this.MenuBar_ST_TSMI_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1,
            this.jSONToolStripMenuItem1,
            this.xMLToolStripMenuItem1,
            this.pDFToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem1.Text = "JSON";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 491);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TS_Categories);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Categories ";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project22DataSet)).EndInit();
            this.TS_Categories.ResumeLayout(false);
            this.TS_Categories.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_CName;
        private System.Windows.Forms.TextBox TB_CId;
        private System.Windows.Forms.CheckBox CB_Active;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_CTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_CCategorycode;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_category;
        private System.Windows.Forms.ToolStrip TS_Categories;
        private System.Windows.Forms.ToolStripButton TSB_CNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_CEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_CDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSB_CSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_CRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSB_CCancel;
        private System.Windows.Forms.DataGridView DGV_Categories;
        private project22DataSet project22DataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private project22DataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategoryscode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ECSV;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EJSON;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EXML;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ICSV;
        private System.Windows.Forms.ToolStripMenuItem TSMI_IJSON;
        private System.Windows.Forms.ToolStripMenuItem TSMI_IXML;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBar_ST_TSMI;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategoriescode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuser;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton Print_TSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}
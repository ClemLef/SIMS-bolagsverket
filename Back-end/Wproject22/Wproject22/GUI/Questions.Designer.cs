namespace Wproject22.GUI
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_Question = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RB_Hasset_no = new System.Windows.Forms.RadioButton();
            this.RB_Hasset_yes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_DSubcategory = new System.Windows.Forms.CheckBox();
            this.TB_QuestionID = new System.Windows.Forms.TextBox();
            this.CBB_QCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project22DataSet = new Wproject22.project22DataSet();
            this.TB_setquestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_subquestiongroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Display_Question = new System.Windows.Forms.CheckBox();
            this.TB_setanswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_QuestionText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_Helpinformation = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_Questions = new System.Windows.Forms.DataGridView();
            this.qid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qanswerset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qhassubquestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qsubquestiongroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qsetquestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qhelpinformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TS_Questions = new System.Windows.Forms.ToolStrip();
            this.TSDDB_QFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSMI_QExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.XML_Q_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QImport = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_QNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_QEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_QDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_QSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_QRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Setname = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Print_TSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_QCancel = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsTableAdapter = new Wproject22.project22DataSetTableAdapters.questionsTableAdapter();
            this.categoriesTableAdapter = new Wproject22.project22DataSetTableAdapters.categoriesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_MB_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CSV_STQ_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.XML_TS_TSMI = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project22DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.TS_Questions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Question});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_Question
            // 
            this.TSSL_Question.Name = "TSSL_Question";
            this.TSSL_Question.Size = new System.Drawing.Size(45, 17);
            this.TSSL_Question.Text = "Display";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 78);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(875, 434);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RB_Hasset_no);
            this.splitContainer2.Panel1.Controls.Add(this.RB_Hasset_yes);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.CB_DSubcategory);
            this.splitContainer2.Panel1.Controls.Add(this.TB_QuestionID);
            this.splitContainer2.Panel1.Controls.Add(this.CBB_QCategory);
            this.splitContainer2.Panel1.Controls.Add(this.TB_setquestion);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.TB_subquestiongroup);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.CB_Display_Question);
            this.splitContainer2.Panel1.Controls.Add(this.TB_setanswer);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(875, 171);
            this.splitContainer2.SplitterDistance = 61;
            this.splitContainer2.TabIndex = 21;
            // 
            // RB_Hasset_no
            // 
            this.RB_Hasset_no.AutoSize = true;
            this.RB_Hasset_no.Location = new System.Drawing.Point(583, 32);
            this.RB_Hasset_no.Name = "RB_Hasset_no";
            this.RB_Hasset_no.Size = new System.Drawing.Size(39, 17);
            this.RB_Hasset_no.TabIndex = 21;
            this.RB_Hasset_no.TabStop = true;
            this.RB_Hasset_no.Text = "No";
            this.RB_Hasset_no.UseVisualStyleBackColor = true;
            // 
            // RB_Hasset_yes
            // 
            this.RB_Hasset_yes.AutoSize = true;
            this.RB_Hasset_yes.Location = new System.Drawing.Point(518, 31);
            this.RB_Hasset_yes.Name = "RB_Hasset_yes";
            this.RB_Hasset_yes.Size = new System.Drawing.Size(43, 17);
            this.RB_Hasset_yes.TabIndex = 20;
            this.RB_Hasset_yes.TabStop = true;
            this.RB_Hasset_yes.Text = "Yes";
            this.RB_Hasset_yes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question number:";
            // 
            // CB_DSubcategory
            // 
            this.CB_DSubcategory.AutoSize = true;
            this.CB_DSubcategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_DSubcategory.Location = new System.Drawing.Point(375, 34);
            this.CB_DSubcategory.Name = "CB_DSubcategory";
            this.CB_DSubcategory.Size = new System.Drawing.Size(120, 17);
            this.CB_DSubcategory.TabIndex = 5;
            this.CB_DSubcategory.Text = "Show Sub Question";
            this.CB_DSubcategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CB_DSubcategory.UseVisualStyleBackColor = true;
            // 
            // TB_QuestionID
            // 
            this.TB_QuestionID.BackColor = System.Drawing.SystemColors.Info;
            this.TB_QuestionID.Location = new System.Drawing.Point(12, 30);
            this.TB_QuestionID.Name = "TB_QuestionID";
            this.TB_QuestionID.ReadOnly = true;
            this.TB_QuestionID.Size = new System.Drawing.Size(87, 20);
            this.TB_QuestionID.TabIndex = 2;
            // 
            // CBB_QCategory
            // 
            this.CBB_QCategory.DataSource = this.categoriesBindingSource;
            this.CBB_QCategory.DisplayMember = "name";
            this.CBB_QCategory.FormattingEnabled = true;
            this.CBB_QCategory.Location = new System.Drawing.Point(111, 28);
            this.CBB_QCategory.Name = "CBB_QCategory";
            this.CBB_QCategory.Size = new System.Drawing.Size(138, 21);
            this.CBB_QCategory.TabIndex = 4;
            this.CBB_QCategory.SelectionChangeCommitted += new System.EventHandler(this.CBB_QCategory_SelectionChangeCommitted);
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
            // TB_setquestion
            // 
            this.TB_setquestion.Location = new System.Drawing.Point(762, 28);
            this.TB_setquestion.Name = "TB_setquestion";
            this.TB_setquestion.Size = new System.Drawing.Size(101, 20);
            this.TB_setquestion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Has Set Sub Question :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set question :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Category :";
            // 
            // TB_subquestiongroup
            // 
            this.TB_subquestiongroup.Location = new System.Drawing.Point(648, 29);
            this.TB_subquestiongroup.Name = "TB_subquestiongroup";
            this.TB_subquestiongroup.Size = new System.Drawing.Size(104, 20);
            this.TB_subquestiongroup.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub question group :";
            // 
            // CB_Display_Question
            // 
            this.CB_Display_Question.AutoSize = true;
            this.CB_Display_Question.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_Display_Question.Location = new System.Drawing.Point(375, 10);
            this.CB_Display_Question.Name = "CB_Display_Question";
            this.CB_Display_Question.Size = new System.Drawing.Size(105, 17);
            this.CB_Display_Question.TabIndex = 3;
            this.CB_Display_Question.Text = "Display Question";
            this.CB_Display_Question.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CB_Display_Question.UseVisualStyleBackColor = true;
            // 
            // TB_setanswer
            // 
            this.TB_setanswer.Location = new System.Drawing.Point(255, 29);
            this.TB_setanswer.Name = "TB_setanswer";
            this.TB_setanswer.Size = new System.Drawing.Size(89, 20);
            this.TB_setanswer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Set answer :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_QuestionText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question :";
            // 
            // TB_QuestionText
            // 
            this.TB_QuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_QuestionText.Location = new System.Drawing.Point(3, 16);
            this.TB_QuestionText.Multiline = true;
            this.TB_QuestionText.Name = "TB_QuestionText";
            this.TB_QuestionText.Size = new System.Drawing.Size(869, 34);
            this.TB_QuestionText.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_Helpinformation);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Help information :";
            // 
            // TB_Helpinformation
            // 
            this.TB_Helpinformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Helpinformation.Location = new System.Drawing.Point(3, 16);
            this.TB_Helpinformation.Multiline = true;
            this.TB_Helpinformation.Name = "TB_Helpinformation";
            this.TB_Helpinformation.Size = new System.Drawing.Size(869, 34);
            this.TB_Helpinformation.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_Questions);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(875, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question List :";
            // 
            // DGV_Questions
            // 
            this.DGV_Questions.AllowUserToAddRows = false;
            this.DGV_Questions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_Questions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Questions.AutoGenerateColumns = false;
            this.DGV_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qid,
            this.qcategory,
            this.qactive,
            this.qanswerset,
            this.qhassubquestion,
            this.qsubquestiongroup,
            this.qsetquestion,
            this.qhelpinformation});
            this.DGV_Questions.DataSource = this.questionsBindingSource;
            this.DGV_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Questions.Location = new System.Drawing.Point(3, 16);
            this.DGV_Questions.Name = "DGV_Questions";
            this.DGV_Questions.ReadOnly = true;
            this.DGV_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Questions.Size = new System.Drawing.Size(869, 240);
            this.DGV_Questions.TabIndex = 12;
            this.DGV_Questions.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Questions_ColumnHeaderMouseClick);
            this.DGV_Questions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Questions_RowEnter);
            this.DGV_Questions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGV_Questions_RowPostPaint);
            // 
            // qid
            // 
            this.qid.DataPropertyName = "id";
            this.qid.HeaderText = "ID";
            this.qid.Name = "qid";
            this.qid.ReadOnly = true;
            this.qid.Width = 40;
            // 
            // qcategory
            // 
            this.qcategory.DataPropertyName = "category";
            this.qcategory.HeaderText = "Category";
            this.qcategory.Name = "qcategory";
            this.qcategory.ReadOnly = true;
            this.qcategory.Width = 60;
            // 
            // qactive
            // 
            this.qactive.DataPropertyName = "active";
            this.qactive.HeaderText = "Active";
            this.qactive.Name = "qactive";
            this.qactive.ReadOnly = true;
            this.qactive.Width = 40;
            // 
            // qanswerset
            // 
            this.qanswerset.DataPropertyName = "answer_set";
            this.qanswerset.HeaderText = "Set answer";
            this.qanswerset.Name = "qanswerset";
            this.qanswerset.ReadOnly = true;
            this.qanswerset.Width = 50;
            // 
            // qhassubquestion
            // 
            this.qhassubquestion.DataPropertyName = "has_sub_question";
            this.qhassubquestion.HeaderText = "Has sub question";
            this.qhassubquestion.Name = "qhassubquestion";
            this.qhassubquestion.ReadOnly = true;
            this.qhassubquestion.Width = 60;
            // 
            // qsubquestiongroup
            // 
            this.qsubquestiongroup.DataPropertyName = "sub_question_group";
            this.qsubquestiongroup.HeaderText = "Sub question group";
            this.qsubquestiongroup.Name = "qsubquestiongroup";
            this.qsubquestiongroup.ReadOnly = true;
            this.qsubquestiongroup.Width = 50;
            // 
            // qsetquestion
            // 
            this.qsetquestion.DataPropertyName = "set_question";
            this.qsetquestion.HeaderText = "Set question";
            this.qsetquestion.Name = "qsetquestion";
            this.qsetquestion.ReadOnly = true;
            this.qsetquestion.Width = 350;
            // 
            // qhelpinformation
            // 
            this.qhelpinformation.DataPropertyName = "help_information";
            this.qhelpinformation.HeaderText = "Help information";
            this.qhelpinformation.Name = "qhelpinformation";
            this.qhelpinformation.ReadOnly = true;
            this.qhelpinformation.Width = 300;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "questions";
            this.questionsBindingSource.DataSource = this.project22DataSet;
            // 
            // TS_Questions
            // 
            this.TS_Questions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TS_Questions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDDB_QFile,
            this.toolStripSeparator7,
            this.TSB_QNew,
            this.toolStripSeparator1,
            this.TSB_QEdit,
            this.toolStripSeparator2,
            this.TSB_QDelete,
            this.toolStripSeparator4,
            this.TSB_QSearch,
            this.toolStripSeparator3,
            this.TSB_QRefresh,
            this.toolStripSeparator5,
            this.TSB_Setname,
            this.toolStripSeparator6,
            this.Print_TSB,
            this.toolStripButton2,
            this.toolStripSeparator8,
            this.TSB_QCancel});
            this.TS_Questions.Location = new System.Drawing.Point(0, 24);
            this.TS_Questions.Name = "TS_Questions";
            this.TS_Questions.Size = new System.Drawing.Size(875, 54);
            this.TS_Questions.TabIndex = 1;
            this.TS_Questions.Text = "toolStrip1";
            // 
            // TSDDB_QFile
            // 
            this.TSDDB_QFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_QExport,
            this.TSMI_QImport});
            this.TSDDB_QFile.Image = global::Wproject22.Properties.Resources.file_icon;
            this.TSDDB_QFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_QFile.Name = "TSDDB_QFile";
            this.TSDDB_QFile.Size = new System.Drawing.Size(38, 51);
            this.TSDDB_QFile.Text = "File";
            this.TSDDB_QFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSDDB_QFile.MouseHover += new System.EventHandler(this.TSDDB_QFile_MouseHover);
            // 
            // TSMI_QExport
            // 
            this.TSMI_QExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.XML_Q_TSMI,
            this.toolStripMenuItem4});
            this.TSMI_QExport.Image = global::Wproject22.Properties.Resources.export_icon;
            this.TSMI_QExport.Name = "TSMI_QExport";
            this.TSMI_QExport.Size = new System.Drawing.Size(110, 22);
            this.TSMI_QExport.Text = "Export";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem1.Text = "CSV";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "JSON";
            // 
            // XML_Q_TSMI
            // 
            this.XML_Q_TSMI.Name = "XML_Q_TSMI";
            this.XML_Q_TSMI.Size = new System.Drawing.Size(102, 22);
            this.XML_Q_TSMI.Text = "XML";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem4.Text = "PDF";
            // 
            // TSMI_QImport
            // 
            this.TSMI_QImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1,
            this.jSONToolStripMenuItem2,
            this.xMLToolStripMenuItem2});
            this.TSMI_QImport.Image = global::Wproject22.Properties.Resources.import_icon;
            this.TSMI_QImport.Name = "TSMI_QImport";
            this.TSMI_QImport.Size = new System.Drawing.Size(110, 22);
            this.TSMI_QImport.Text = "Import";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            // 
            // jSONToolStripMenuItem2
            // 
            this.jSONToolStripMenuItem2.Name = "jSONToolStripMenuItem2";
            this.jSONToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem2.Text = "JSON";
            // 
            // xMLToolStripMenuItem2
            // 
            this.xMLToolStripMenuItem2.Name = "xMLToolStripMenuItem2";
            this.xMLToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.xMLToolStripMenuItem2.Text = "XML";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_QNew
            // 
            this.TSB_QNew.Image = global::Wproject22.Properties.Resources.new_file_icon;
            this.TSB_QNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_QNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QNew.Name = "TSB_QNew";
            this.TSB_QNew.Size = new System.Drawing.Size(36, 51);
            this.TSB_QNew.Text = "New";
            this.TSB_QNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_QNew.Click += new System.EventHandler(this.TSB_QNew_Click);
            this.TSB_QNew.MouseHover += new System.EventHandler(this.TSB_QNew_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_QEdit
            // 
            this.TSB_QEdit.Image = global::Wproject22.Properties.Resources.edit_validated_icon;
            this.TSB_QEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QEdit.Name = "TSB_QEdit";
            this.TSB_QEdit.Size = new System.Drawing.Size(31, 51);
            this.TSB_QEdit.Text = "Edit";
            this.TSB_QEdit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.TSB_QEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_QEdit.Click += new System.EventHandler(this.TSB_QEdit_Click);
            this.TSB_QEdit.MouseHover += new System.EventHandler(this.TSB_QEdit_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_QDelete
            // 
            this.TSB_QDelete.Image = global::Wproject22.Properties.Resources.Delete_icon;
            this.TSB_QDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QDelete.Name = "TSB_QDelete";
            this.TSB_QDelete.Size = new System.Drawing.Size(44, 51);
            this.TSB_QDelete.Text = "Delete";
            this.TSB_QDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_QDelete.Click += new System.EventHandler(this.TSB_QDelete_Click);
            this.TSB_QDelete.MouseHover += new System.EventHandler(this.TSB_QDelete_MouseHover);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_QSearch
            // 
            this.TSB_QSearch.Image = global::Wproject22.Properties.Resources.Zoom_icon;
            this.TSB_QSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QSearch.Name = "TSB_QSearch";
            this.TSB_QSearch.Size = new System.Drawing.Size(46, 51);
            this.TSB_QSearch.Text = "Search";
            this.TSB_QSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_QSearch.Click += new System.EventHandler(this.TSB_QSearch_Click);
            this.TSB_QSearch.MouseHover += new System.EventHandler(this.TSB_QSearch_MouseHover);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_QRefresh
            // 
            this.TSB_QRefresh.Image = global::Wproject22.Properties.Resources.Misc_Download_Database_icon;
            this.TSB_QRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QRefresh.Name = "TSB_QRefresh";
            this.TSB_QRefresh.Size = new System.Drawing.Size(50, 51);
            this.TSB_QRefresh.Text = "Refresh";
            this.TSB_QRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_QRefresh.Click += new System.EventHandler(this.TSB_QRefresh_Click);
            this.TSB_QRefresh.MouseHover += new System.EventHandler(this.TSB_QRefresh_MouseHover);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_Setname
            // 
            this.TSB_Setname.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Setname.Image")));
            this.TSB_Setname.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Setname.Name = "TSB_Setname";
            this.TSB_Setname.Size = new System.Drawing.Size(60, 51);
            this.TSB_Setname.Text = "Set name";
            this.TSB_Setname.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_Setname.Click += new System.EventHandler(this.TSB_Setname_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 54);
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
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 54);
            // 
            // TSB_QCancel
            // 
            this.TSB_QCancel.Image = global::Wproject22.Properties.Resources.Close_icon1;
            this.TSB_QCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QCancel.Name = "TSB_QCancel";
            this.TSB_QCancel.Size = new System.Drawing.Size(47, 51);
            this.TSB_QCancel.Text = "Cancel";
            this.TSB_QCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_QCancel.Click += new System.EventHandler(this.TSB_QCancel_Click);
            this.TSB_QCancel.MouseHover += new System.EventHandler(this.TSB_QCancel_MouseHover);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 16;
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
            this.Exit_MB_TSMI});
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
            // Exit_MB_TSMI
            // 
            this.Exit_MB_TSMI.Name = "Exit_MB_TSMI";
            this.Exit_MB_TSMI.Size = new System.Drawing.Size(112, 22);
            this.Exit_MB_TSMI.Text = "Exit";
            this.Exit_MB_TSMI.Click += new System.EventHandler(this.Exit_MB_TSMI_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_TSMI,
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuBar_TSMI
            // 
            this.menuBar_TSMI.Checked = true;
            this.menuBar_TSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBar_TSMI.Name = "menuBar_TSMI";
            this.menuBar_TSMI.Size = new System.Drawing.Size(180, 22);
            this.menuBar_TSMI.Text = "Menu bar";
            this.menuBar_TSMI.Click += new System.EventHandler(this.menuBar_TSMI_Click);
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
            this.CSV_STQ_TSMI,
            this.jSONToolStripMenuItem1,
            this.XML_TS_TSMI,
            this.pDFToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // CSV_STQ_TSMI
            // 
            this.CSV_STQ_TSMI.Name = "CSV_STQ_TSMI";
            this.CSV_STQ_TSMI.Size = new System.Drawing.Size(102, 22);
            this.CSV_STQ_TSMI.Text = "CSV";
            this.CSV_STQ_TSMI.Click += new System.EventHandler(this.CSV_STQ_TSMI_Click);
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem1.Text = "JSON";
            // 
            // XML_TS_TSMI
            // 
            this.XML_TS_TSMI.Name = "XML_TS_TSMI";
            this.XML_TS_TSMI.Size = new System.Drawing.Size(102, 22);
            this.XML_TS_TSMI.Text = "XML";
            this.XML_TS_TSMI.Click += new System.EventHandler(this.XML_TS_TSMI_Click);
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
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 534);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TS_Questions);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Question_FormClosed);
            this.Load += new System.EventHandler(this.Question_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project22DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.TS_Questions.ResumeLayout(false);
            this.TS_Questions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox CB_Display_Question;
        private System.Windows.Forms.TextBox TB_QuestionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_setquestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_subquestiongroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_setanswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_QuestionText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBB_QCategory;
        private System.Windows.Forms.ToolStrip TS_Questions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_QEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSB_QDelete;
        private System.Windows.Forms.ToolStripButton TSB_QNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSB_QSearch;
        private System.Windows.Forms.ToolStripButton TSB_QRefresh;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Question;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSB_QCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ToolStripButton TSB_Setname;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox CB_DSubcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Questions;
        private project22DataSet project22DataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private project22DataSetTableAdapters.questionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_Helpinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn qid;
        private System.Windows.Forms.DataGridViewTextBoxColumn qcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn qactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn qanswerset;
        private System.Windows.Forms.DataGridViewTextBoxColumn qhassubquestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn qsubquestiongroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn qsetquestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn qhelpinformation;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private project22DataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ToolStripDropDownButton TSDDB_QFile;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QExport;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.RadioButton RB_Hasset_no;
        private System.Windows.Forms.RadioButton RB_Hasset_yes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_MB_TSMI;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBar_TSMI;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CSV_STQ_TSMI;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem XML_TS_TSMI;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem XML_Q_TSMI;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton Print_TSB;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}
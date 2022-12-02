namespace Wproject22.GUI
{
    partial class Test
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economicalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economicalflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envirmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envirmentflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.influenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.influenceflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project22DataSet = new Wproject22.project22DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.answer_AITableAdapter = new Wproject22.project22DataSetTableAdapters.Answer_AITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urcDataGridViewTextBoxColumn,
            this.socialDataGridViewTextBoxColumn,
            this.socialflagDataGridViewTextBoxColumn,
            this.economicalDataGridViewTextBoxColumn,
            this.economicalflagDataGridViewTextBoxColumn,
            this.envirmentDataGridViewTextBoxColumn,
            this.envirmentflagDataGridViewTextBoxColumn,
            this.influenceDataGridViewTextBoxColumn,
            this.influenceflagDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.answerAIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // urcDataGridViewTextBoxColumn
            // 
            this.urcDataGridViewTextBoxColumn.DataPropertyName = "urc";
            this.urcDataGridViewTextBoxColumn.HeaderText = "User reg code";
            this.urcDataGridViewTextBoxColumn.Name = "urcDataGridViewTextBoxColumn";
            this.urcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socialDataGridViewTextBoxColumn
            // 
            this.socialDataGridViewTextBoxColumn.DataPropertyName = "social";
            this.socialDataGridViewTextBoxColumn.HeaderText = "social";
            this.socialDataGridViewTextBoxColumn.Name = "socialDataGridViewTextBoxColumn";
            this.socialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socialflagDataGridViewTextBoxColumn
            // 
            this.socialflagDataGridViewTextBoxColumn.DataPropertyName = "social_flag";
            this.socialflagDataGridViewTextBoxColumn.HeaderText = "social_flag";
            this.socialflagDataGridViewTextBoxColumn.Name = "socialflagDataGridViewTextBoxColumn";
            this.socialflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economicalDataGridViewTextBoxColumn
            // 
            this.economicalDataGridViewTextBoxColumn.DataPropertyName = "economical";
            this.economicalDataGridViewTextBoxColumn.HeaderText = "economical";
            this.economicalDataGridViewTextBoxColumn.Name = "economicalDataGridViewTextBoxColumn";
            this.economicalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economicalflagDataGridViewTextBoxColumn
            // 
            this.economicalflagDataGridViewTextBoxColumn.DataPropertyName = "economical_flag";
            this.economicalflagDataGridViewTextBoxColumn.HeaderText = "economical_flag";
            this.economicalflagDataGridViewTextBoxColumn.Name = "economicalflagDataGridViewTextBoxColumn";
            this.economicalflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // envirmentDataGridViewTextBoxColumn
            // 
            this.envirmentDataGridViewTextBoxColumn.DataPropertyName = "envirment";
            this.envirmentDataGridViewTextBoxColumn.HeaderText = "envirment";
            this.envirmentDataGridViewTextBoxColumn.Name = "envirmentDataGridViewTextBoxColumn";
            this.envirmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // envirmentflagDataGridViewTextBoxColumn
            // 
            this.envirmentflagDataGridViewTextBoxColumn.DataPropertyName = "envirment_flag";
            this.envirmentflagDataGridViewTextBoxColumn.HeaderText = "envirment_flag";
            this.envirmentflagDataGridViewTextBoxColumn.Name = "envirmentflagDataGridViewTextBoxColumn";
            this.envirmentflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // influenceDataGridViewTextBoxColumn
            // 
            this.influenceDataGridViewTextBoxColumn.DataPropertyName = "influence";
            this.influenceDataGridViewTextBoxColumn.HeaderText = "influence";
            this.influenceDataGridViewTextBoxColumn.Name = "influenceDataGridViewTextBoxColumn";
            this.influenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // influenceflagDataGridViewTextBoxColumn
            // 
            this.influenceflagDataGridViewTextBoxColumn.DataPropertyName = "influence_flag";
            this.influenceflagDataGridViewTextBoxColumn.HeaderText = "influence_flag";
            this.influenceflagDataGridViewTextBoxColumn.Name = "influenceflagDataGridViewTextBoxColumn";
            this.influenceflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerAIBindingSource
            // 
            this.answerAIBindingSource.DataMember = "Answer_AI";
            this.answerAIBindingSource.DataSource = this.project22DataSet;
            // 
            // project22DataSet
            // 
            this.project22DataSet.DataSetName = "project22DataSet";
            this.project22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(385, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(413, 214);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(362, 224);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // answer_AITableAdapter
            // 
            this.answer_AITableAdapter.ClearBeforeFill = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private project22DataSet project22DataSet;
        private System.Windows.Forms.BindingSource answerAIBindingSource;
        private project22DataSetTableAdapters.Answer_AITableAdapter answer_AITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economicalflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envirmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envirmentflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn influenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn influenceflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
    }
}
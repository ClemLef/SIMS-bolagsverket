namespace Winform_PDFtoWORD
{
    partial class PDFtoWord
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_convert_word = new System.Windows.Forms.Button();
            this.B_upload_pdf = new System.Windows.Forms.Button();
            this.TB_filepdf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.RTB_pdf_to_word = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RTB_pdf_to_word);
            this.splitContainer1.Size = new System.Drawing.Size(802, 495);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B_convert_word);
            this.groupBox1.Controls.Add(this.B_upload_pdf);
            this.groupBox1.Controls.Add(this.TB_filepdf);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose PDF file for convert  to Word :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name :";
            // 
            // B_convert_word
            // 
            this.B_convert_word.Location = new System.Drawing.Point(683, 23);
            this.B_convert_word.Name = "B_convert_word";
            this.B_convert_word.Size = new System.Drawing.Size(97, 34);
            this.B_convert_word.TabIndex = 2;
            this.B_convert_word.Text = "Convert to word";
            this.B_convert_word.UseVisualStyleBackColor = true;
            this.B_convert_word.Click += new System.EventHandler(this.B_convert_word_Click);
            // 
            // B_upload_pdf
            // 
            this.B_upload_pdf.Location = new System.Drawing.Point(574, 23);
            this.B_upload_pdf.Name = "B_upload_pdf";
            this.B_upload_pdf.Size = new System.Drawing.Size(97, 34);
            this.B_upload_pdf.TabIndex = 1;
            this.B_upload_pdf.Text = "Upload PDF";
            this.B_upload_pdf.UseVisualStyleBackColor = true;
            this.B_upload_pdf.Click += new System.EventHandler(this.B_upload_pdf_Click);
            // 
            // TB_filepdf
            // 
            this.TB_filepdf.Location = new System.Drawing.Point(76, 31);
            this.TB_filepdf.Name = "TB_filepdf";
            this.TB_filepdf.Size = new System.Drawing.Size(481, 20);
            this.TB_filepdf.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.B_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TB_Search);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(802, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search in convert file :";
            // 
            // B_search
            // 
            this.B_search.Location = new System.Drawing.Point(683, 30);
            this.B_search.Name = "B_search";
            this.B_search.Size = new System.Drawing.Size(97, 34);
            this.B_search.TabIndex = 5;
            this.B_search.Text = "Search";
            this.B_search.UseVisualStyleBackColor = true;
            this.B_search.Click += new System.EventHandler(this.B_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search  :";
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(66, 38);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(593, 20);
            this.TB_Search.TabIndex = 1;
            // 
            // RTB_pdf_to_word
            // 
            this.RTB_pdf_to_word.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_pdf_to_word.Location = new System.Drawing.Point(0, 0);
            this.RTB_pdf_to_word.Name = "RTB_pdf_to_word";
            this.RTB_pdf_to_word.Size = new System.Drawing.Size(802, 327);
            this.RTB_pdf_to_word.TabIndex = 0;
            this.RTB_pdf_to_word.Text = "";
            // 
            // PDFtoWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 520);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PDFtoWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert PDF to Word";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_convert_word;
        private System.Windows.Forms.Button B_upload_pdf;
        private System.Windows.Forms.TextBox TB_filepdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.RichTextBox RTB_pdf_to_word;
    }
}


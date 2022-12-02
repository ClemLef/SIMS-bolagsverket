namespace Wproject22.GUI_Search
{
    partial class FSE_Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSE_Question));
            this.CB_IAQuestion = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_QuestionCode = new System.Windows.Forms.TextBox();
            this.TB_CategoryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_QuestionText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_IAQuestion
            // 
            this.CB_IAQuestion.AutoSize = true;
            this.CB_IAQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_IAQuestion.Location = new System.Drawing.Point(12, 17);
            this.CB_IAQuestion.Name = "CB_IAQuestion";
            this.CB_IAQuestion.Size = new System.Drawing.Size(105, 17);
            this.CB_IAQuestion.TabIndex = 37;
            this.CB_IAQuestion.Text = "Display Question";
            this.CB_IAQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CB_IAQuestion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CB_IAQuestion);
            this.panel1.Controls.Add(this.B_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 51);
            this.panel1.TabIndex = 32;
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cancel.Image = global::Wproject22.Properties.Resources.Close_icon;
            this.B_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Cancel.Location = new System.Drawing.Point(207, 6);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 36);
            this.B_Cancel.TabIndex = 10;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Category ID  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Question ID :";
            // 
            // TB_QuestionCode
            // 
            this.TB_QuestionCode.BackColor = System.Drawing.SystemColors.Info;
            this.TB_QuestionCode.Location = new System.Drawing.Point(15, 22);
            this.TB_QuestionCode.Name = "TB_QuestionCode";
            this.TB_QuestionCode.Size = new System.Drawing.Size(270, 20);
            this.TB_QuestionCode.TabIndex = 28;
            this.TB_QuestionCode.TextChanged += new System.EventHandler(this.TB_QuestionCode_TextChanged);
            // 
            // TB_CategoryID
            // 
            this.TB_CategoryID.BackColor = System.Drawing.SystemColors.Info;
            this.TB_CategoryID.Location = new System.Drawing.Point(15, 70);
            this.TB_CategoryID.Name = "TB_CategoryID";
            this.TB_CategoryID.Size = new System.Drawing.Size(270, 20);
            this.TB_CategoryID.TabIndex = 29;
            this.TB_CategoryID.TextChanged += new System.EventHandler(this.TB_CategoryID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Question :";
            // 
            // TB_QuestionText
            // 
            this.TB_QuestionText.BackColor = System.Drawing.SystemColors.Info;
            this.TB_QuestionText.Location = new System.Drawing.Point(12, 120);
            this.TB_QuestionText.Multiline = true;
            this.TB_QuestionText.Name = "TB_QuestionText";
            this.TB_QuestionText.Size = new System.Drawing.Size(270, 79);
            this.TB_QuestionText.TabIndex = 34;
            this.TB_QuestionText.TextChanged += new System.EventHandler(this.TB_QuestionText_TextChanged);
            // 
            // FSE_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_QuestionCode);
            this.Controls.Add(this.TB_CategoryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_QuestionText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FSE_Question";
            this.Text = "Search in Question";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_IAQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_QuestionCode;
        private System.Windows.Forms.TextBox TB_CategoryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_QuestionText;
    }
}
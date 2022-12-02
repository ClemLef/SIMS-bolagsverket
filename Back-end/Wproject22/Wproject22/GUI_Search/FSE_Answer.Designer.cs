namespace Wproject22.GUI_Search
{
    partial class FSE_Answer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSE_Answer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SAnswerID = new System.Windows.Forms.TextBox();
            this.TB_SA_URC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_SAQuestionID = new System.Windows.Forms.TextBox();
            this.TB_SAQuestion = new System.Windows.Forms.TextBox();
            this.CB_IAQuestion = new System.Windows.Forms.CheckBox();
            this.TB_SADate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.B_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 51);
            this.panel1.TabIndex = 22;
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cancel.Image = global::Wproject22.Properties.Resources.Close_icon;
            this.B_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Cancel.Location = new System.Drawing.Point(170, 6);
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
            this.label2.Location = new System.Drawing.Point(123, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "User Registration code : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Answer Code :";
            // 
            // TB_SAnswerID
            // 
            this.TB_SAnswerID.BackColor = System.Drawing.SystemColors.Info;
            this.TB_SAnswerID.Location = new System.Drawing.Point(12, 28);
            this.TB_SAnswerID.Name = "TB_SAnswerID";
            this.TB_SAnswerID.Size = new System.Drawing.Size(87, 20);
            this.TB_SAnswerID.TabIndex = 18;
            this.TB_SAnswerID.TextChanged += new System.EventHandler(this.TB_SAnswerID_TextChanged);
            // 
            // TB_SA_URC
            // 
            this.TB_SA_URC.BackColor = System.Drawing.SystemColors.Info;
            this.TB_SA_URC.Location = new System.Drawing.Point(124, 28);
            this.TB_SA_URC.Name = "TB_SA_URC";
            this.TB_SA_URC.Size = new System.Drawing.Size(123, 20);
            this.TB_SA_URC.TabIndex = 19;
            this.TB_SA_URC.TextChanged += new System.EventHandler(this.TB_SA_URC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Question :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Question ID :";
            // 
            // TB_SAQuestionID
            // 
            this.TB_SAQuestionID.BackColor = System.Drawing.SystemColors.Info;
            this.TB_SAQuestionID.Location = new System.Drawing.Point(12, 77);
            this.TB_SAQuestionID.Name = "TB_SAQuestionID";
            this.TB_SAQuestionID.Size = new System.Drawing.Size(90, 20);
            this.TB_SAQuestionID.TabIndex = 23;
            this.TB_SAQuestionID.TextChanged += new System.EventHandler(this.TB_SAQuestionID_TextChanged);
            // 
            // TB_SAQuestion
            // 
            this.TB_SAQuestion.BackColor = System.Drawing.SystemColors.Info;
            this.TB_SAQuestion.Location = new System.Drawing.Point(12, 123);
            this.TB_SAQuestion.Multiline = true;
            this.TB_SAQuestion.Name = "TB_SAQuestion";
            this.TB_SAQuestion.Size = new System.Drawing.Size(235, 79);
            this.TB_SAQuestion.TabIndex = 24;
            this.TB_SAQuestion.TextChanged += new System.EventHandler(this.TB_SAQuestion_TextChanged);
            // 
            // CB_IAQuestion
            // 
            this.CB_IAQuestion.AutoSize = true;
            this.CB_IAQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_IAQuestion.Location = new System.Drawing.Point(16, 218);
            this.CB_IAQuestion.Name = "CB_IAQuestion";
            this.CB_IAQuestion.Size = new System.Drawing.Size(143, 17);
            this.CB_IAQuestion.TabIndex = 27;
            this.CB_IAQuestion.Text = "Display Answer Question";
            this.CB_IAQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CB_IAQuestion.UseVisualStyleBackColor = true;
            // 
            // TB_SADate
            // 
            this.TB_SADate.BackColor = System.Drawing.SystemColors.Info;
            this.TB_SADate.Location = new System.Drawing.Point(124, 77);
            this.TB_SADate.Name = "TB_SADate";
            this.TB_SADate.Size = new System.Drawing.Size(123, 20);
            this.TB_SADate.TabIndex = 28;
            this.TB_SADate.TextChanged += new System.EventHandler(this.TB_SADate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date :";
            // 
            // FSE_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 296);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_SADate);
            this.Controls.Add(this.CB_IAQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SAnswerID);
            this.Controls.Add(this.TB_SA_URC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_SAQuestionID);
            this.Controls.Add(this.TB_SAQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSE_Answer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search on Answer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SAnswerID;
        private System.Windows.Forms.TextBox TB_SA_URC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_SAQuestionID;
        private System.Windows.Forms.TextBox TB_SAQuestion;
        private System.Windows.Forms.CheckBox CB_IAQuestion;
        private System.Windows.Forms.TextBox TB_SADate;
        private System.Windows.Forms.Label label5;
    }
}
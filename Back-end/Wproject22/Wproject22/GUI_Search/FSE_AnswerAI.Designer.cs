namespace Wproject22.GUI_Search
{
    partial class FSE_AnswerAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSE_AnswerAI));
            this.CB_IAQuestion = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_QuestionCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_IAQuestion
            // 
            this.CB_IAQuestion.AutoSize = true;
            this.CB_IAQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_IAQuestion.Location = new System.Drawing.Point(12, 17);
            this.CB_IAQuestion.Name = "CB_IAQuestion";
            this.CB_IAQuestion.Size = new System.Drawing.Size(63, 17);
            this.CB_IAQuestion.TabIndex = 37;
            this.CB_IAQuestion.Text = "Display ";
            this.CB_IAQuestion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CB_IAQuestion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CB_IAQuestion);
            this.panel1.Controls.Add(this.B_Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 51);
            this.panel1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cancel.Image = global::Wproject22.Properties.Resources.Close_icon;
            this.B_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Cancel.Location = new System.Drawing.Point(245, 6);
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
            this.label2.Location = new System.Drawing.Point(175, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "End date:";
            // 
            // TB_QuestionCode
            // 
            this.TB_QuestionCode.BackColor = System.Drawing.SystemColors.Info;
            this.TB_QuestionCode.Location = new System.Drawing.Point(234, 56);
            this.TB_QuestionCode.Name = "TB_QuestionCode";
            this.TB_QuestionCode.Size = new System.Drawing.Size(90, 20);
            this.TB_QuestionCode.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Start date :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Social ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(86, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 44;
            this.checkBox2.Text = "Economical";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(173, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(73, 17);
            this.checkBox3.TabIndex = 44;
            this.checkBox3.Text = "Envirment";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(252, 18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 44;
            this.checkBox4.Text = "Influence";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(79, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 37;
            // 
            // FSE_AnswerAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 184);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TB_QuestionCode);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FSE_AnswerAI";
            this.Text = "Display AI report";
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
        private System.Windows.Forms.TextBox TB_QuestionCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
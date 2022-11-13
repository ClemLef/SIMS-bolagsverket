namespace Wproject22.GUI
{
    partial class DBConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnection));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.WPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WUser = new System.Windows.Forms.TextBox();
            this.WDatabas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B_TestConnection = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.WPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.WUser);
            this.groupBox1.Controls.Add(this.WDatabas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.B_TestConnection);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 176);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hostname (Server) :";
            // 
            // WServer
            // 
            this.WServer.Location = new System.Drawing.Point(9, 37);
            this.WServer.Name = "WServer";
            this.WServer.Size = new System.Drawing.Size(354, 20);
            this.WServer.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password :";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(381, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 20);
            this.txtPort.TabIndex = 14;
            this.txtPort.Text = "3306";
            // 
            // WPassword
            // 
            this.WPassword.Location = new System.Drawing.Point(194, 82);
            this.WPassword.Name = "WPassword";
            this.WPassword.Size = new System.Drawing.Size(166, 20);
            this.WPassword.TabIndex = 21;
            this.WPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Välj databas (schema)";
            // 
            // WUser
            // 
            this.WUser.Location = new System.Drawing.Point(9, 82);
            this.WUser.Name = "WUser";
            this.WUser.Size = new System.Drawing.Size(166, 20);
            this.WUser.TabIndex = 16;
            // 
            // WDatabas
            // 
            this.WDatabas.FormattingEnabled = true;
            this.WDatabas.Items.AddRange(new object[] {
            "project22"});
            this.WDatabas.Location = new System.Drawing.Point(12, 134);
            this.WDatabas.Name = "WDatabas";
            this.WDatabas.Size = new System.Drawing.Size(196, 21);
            this.WDatabas.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username :";
            // 
            // B_TestConnection
            // 
            this.B_TestConnection.Image = ((System.Drawing.Image)(resources.GetObject("B_TestConnection.Image")));
            this.B_TestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_TestConnection.Location = new System.Drawing.Point(312, 127);
            this.B_TestConnection.Name = "B_TestConnection";
            this.B_TestConnection.Size = new System.Drawing.Size(124, 33);
            this.B_TestConnection.TabIndex = 18;
            this.B_TestConnection.Text = "Test Connection";
            this.B_TestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_TestConnection.UseVisualStyleBackColor = true;
            this.B_TestConnection.Click += new System.EventHandler(this.B_TestConnection_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 176);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DBConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connection tools";
            this.Load += new System.EventHandler(this.DBConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox WPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WUser;
        private System.Windows.Forms.ComboBox WDatabas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_TestConnection;
        private System.Windows.Forms.Timer timer1;
    }
}
/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :Users.cs
 * 
 * Here User form that can add,edit,delete,expot,import information from users table.
 */
using System;
using System.Data;
using System.Windows.Forms;
using Utilities.Classes;
using Wproject22.Classes;
using Wproject22.Prints;


namespace Wproject22.GUI
{
    public partial class Users : Form
    {
        private int Get_Current_Row;
        private Boolean hold = false;
        private string Print_Image = "Apu";
        public Users()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            DGV_Users.Columns["users_active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //---------------------------------------------------------------------------------
        // Button
        //---------------------------------------------------------------------------------
        private void TSB_UsersNew_Click(object sender, EventArgs e)
        {

        }

        private void TSB_UsersEdit_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Edit Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlgResult)
                {
                    case DialogResult.Yes:

                        string ett = "UPDATE users SET active ='" + Value_Active("")  + "' WHERE urc = '" + TB_URC.Text.ToString().Trim() + "'";

                        C_Connection.connection_table("open", usersTableAdapter.Connection);
                        CExecuteScalar.execute_table(ref ett, usersTableAdapter.Connection);
                        C_Connection.connection_table("close", usersTableAdapter.Connection);
                        hold = true;
                        this.usersTableAdapter.Fill(this.project22DataSet.users);
                         // jump to row that edited
                        if (DGV_Users.Rows.Count > 0)
                        {
                          
                            DGV_Users.ClearSelection();
                            DGV_Users.Rows[Get_Current_Row].Selected = true;
                            DGV_Users.FirstDisplayedScrollingRowIndex = Get_Current_Row;
                            DGV_Users.Focus();
                            hold = false;
                        }
                        break;

                    case DialogResult.No:
                        MessageBox.Show("Your information is not change !! ");
                        break;
                }
            }
            catch (Exception ETSB_CEdit) { Write_Exception.EWrite_Exception(ETSB_CEdit); }
        }

        private void TSB_UsersDelete_Click(object sender, EventArgs e)
        {

        }

        private void TSB_UsersSearch_Click(object sender, EventArgs e)
        {

        }

        private void TSB_UsersRefresh_Click(object sender, EventArgs e)
        {
            try
            {
              usersBindingSource.Filter = "";
                this.usersTableAdapter.Fill(this.project22DataSet.users);

            }
            catch (Exception ETSB_CRefresh) { Write_Exception.EWrite_Exception(ETSB_CRefresh); }

        }

        private void TSB_UsersCancel_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception E_TSB_UsersCancel) { Write_Exception.EWrite_Exception(E_TSB_UsersCancel); }

        }

        private void TSMI_ECSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen to CSV file ?", "Export users list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    C_Path cpath = new C_Path();
                    string path = cpath.Current_Paths();
                    path = path.Replace("\\", "\\\\");
                    string ett = "SELECT 'ID', 'urc', 'us_date', 'active' UNION ALL SELECT * FROM users INTO OUTFILE '"
                               + path + "\\\\" + cpath.Check_Path("CSV") + "\\\\" + cpath.Check_FileName("User") + ".csv' FIELDS TERMINATED BY ','; ";

                    C_Connection.connection_table("open", usersTableAdapter.Connection);
                    CExecuteScalar.execute_table(ref ett, usersTableAdapter.Connection);
                    C_Connection.connection_table("close", usersTableAdapter.Connection);

                }
                else if (dlgResult == DialogResult.No)
                {
                    MessageBox.Show("Informaioner is Cancelled !! ");

                }
            }catch (Exception ETSB_CNew) { Write_Exception.EWrite_Exception(ETSB_CNew); }

        }

        //---------------------------------------------------------------------------------
        // Display information
        //---------------------------------------------------------------------------------
        private void User_Load(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.Fill(this.project22DataSet.users);
            }catch (Exception E_User_Load) { Write_Exception.EWrite_Exception(E_User_Load); }
        }

        private void ToolStripDropDownButton2_MouseHover(object sender, EventArgs e)
        {

        }

        private void TSB_UsersNew_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Add new users information in users table.";
        }

        private void TSB_UsersEdit_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Edit users information in users table.";
        }

        private void TSB_UsersDelete_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Delete information in users table.";
        }

        private void TSB_UsersSearch_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Search information in users table. ";
        }

        private void TSB_UsersRefresh_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Refresh information in users table.";
        }

        private void TSB_UsersCancel_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Cancel User form.";
        }

        private void ToolStrip1_MouseHover(object sender, EventArgs e)
        {
            TSSL_Users.Text = "Menu bar";
        }
        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------
        private void DGV_Users_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_Users.Rows.Count > 0)
                {
                    TB_URC.Text = DGV_Users.Rows[e.RowIndex].Cells["users_urc"].Value.ToString().Trim();
                    string[] datetime = DGV_Users.Rows[e.RowIndex].Cells["users_date"].Value.ToString().Trim().Split(' ');
                    TB_UserDate.Text = datetime[0];
                    TB_UserTime.Text = datetime[1];

                    string c_active = DGV_Users.Rows[e.RowIndex].Cells["users_active"].Value.ToString().Trim();
                    if (c_active == "1")
                    { CB_Active.Checked = true; }
                    else { CB_Active.Checked = false; }
                }

            }  catch (Exception EDGV_User) { Write_Exception.EWrite_Exception(EDGV_User); }

        }

        private void DGV_Users_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Users.Rows.Count > 0 && hold == false)
            {
                Get_Current_Row = DGV_Users.SelectedRows[0].Index;
                textBox3.Text = Get_Current_Row.ToString();
            }
        }


        //---------------------------------------------------------------------------------
        // Search
        //---------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------
        // Function
        //---------------------------------------------------------------------------------
        private string Value_Active(string get_value)
        {
            switch (CB_Active.Checked)
            {
                case true:
                    get_value = "1";
                    break;

                case false:
                    get_value = "0";
                    break;
                default:
                    get_value = "1";
                    break;
            }
            return get_value;
        }

        private void TS_Users_Click(object sender, EventArgs e)
        {

        }

        private void PrintPreview_ST_TSMI_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument_users.DocumentName = "PrintItem";
                printDialog_users.Document = PrintDocument_users;
                printDialog_users.AllowSelection = true;
                printDialog_users.AllowSomePages = true;
                if (printDialog_users.ShowDialog() == DialogResult.OK)
                {
                    PrintDocument_users.Print();
                }
            }
            catch (Exception Print)
            {
                MessageBox.Show(Print.ToString());
            }
        }

        private void Print_ST_TSMI_Click(object sender, EventArgs e)
        {
            try
            {
                //-------------------------------
                printPreviewDialog_user.WindowState = FormWindowState.Maximized;
                printPreviewDialog_user.PrintPreviewControl.Zoom = 1.0;

                PrintDocument_users.DocumentName = "PrintItem";
                printPreviewDialog_user.Document = PrintDocument_users;
                ToolStripButton b = new ToolStripButton();
              //  b.Image = Properties.Resources.print_icon;
                b.DisplayStyle = ToolStripItemDisplayStyle.Image;
                b.Click += printPreview_PrintClick;
                ((ToolStrip)(printPreviewDialog_user.Controls[1])).Items.RemoveAt(0);
                ((ToolStrip)(printPreviewDialog_user.Controls[1])).Items.Insert(0, b);
                printPreviewDialog_user.ShowDialog();
                //-------------------------------

            }
            catch (Exception PrintPreview)
            {
                MessageBox.Show(PrintPreview.ToString());
            }
        }

        private void printPreview_PrintClick(object sender, EventArgs e)
        {
            try
            {
                printDialog_users.Document = PrintDocument_users;
                if (printDialog_users.ShowDialog() == DialogResult.OK)
                {
                    PrintDocument_users.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ToString());
            }
        }
        private void PrintDocument_users_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           UserPrint IP = new UserPrint(e, "test", "test", "test", "test", Print_Image);
        }


        private void MenuBar_ST_TSMI_Click(object sender, EventArgs e)
        {
            if (menuBar_ST_TSMI.Checked == false)
            {
                TS_Users.Visible = true;
                menuBar_ST_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_Users.Visible = false;
                menuBar_ST_TSMI.CheckState = CheckState.Unchecked;
            }
        }
    }
}

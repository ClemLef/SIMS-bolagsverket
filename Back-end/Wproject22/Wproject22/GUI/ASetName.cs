
/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :ASetName.cs
 * 
 * Here Answer format form that can add,edit,delete,expot,import information from set_name_answer table.
 */
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wproject22.Classes;
using Utilities.Classes;
using System.IO;
using Wproject22.GUI_Search;
using System.ComponentModel;

namespace Wproject22.GUI
{
    public partial class ASetName : Form
    {
        private int Get_Current_Row_ID;
        private string c_active = string.Empty, check_find = string.Empty;
        public ASetName()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            DGV_GSN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_GSN.Columns["asngroup"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_GSN.Columns["asnvalue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TSB_ASNSearch.Enabled = false;
            TSB_ASNDelete.Enabled = false;
        }

        private void GSetName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.answer_sets' table. You can move, or remove it, as needed.
            
            try
            {
                this.answer_setsTableAdapter.Fill(this.project22DataSet.answer_sets);
                
            }
            catch (Exception EGSetName_Load) { Write_Exception.EWrite_Exception(EGSetName_Load); }
        }

        //---------------------------------------------------------------------------------
        // Menu Strip
        //---------------------------------------------------------------------------------
        private void Exit_MB_TSMI_Click(object sender, EventArgs e)
        {
            TSB_ACancel_Click(sender, e);
        }
        private void MenuBar_MS_TSMI_Click(object sender, EventArgs e)
        {
            if (MenuBar_MS_TSMI.Checked == false)
            {
                TS_ASetName.Visible = true;
                MenuBar_MS_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_ASetName.Visible = false;
                MenuBar_MS_TSMI.CheckState = CheckState.Unchecked;
            }
        }
        //---------------------------------------------------------------------------------
        // Tool Strip Meun Item
        //---------------------------------------------------------------------------------
        private void TSB_ASNNew_Click(object sender, EventArgs e)
        {
            try
            {
                check_find = check_information_mysql("");
                if (check_find == string.Empty)
                { }
                else
                {
                    MessageBox.Show("This set name code is  exist!");
                    return;
                }
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Insert new answer name ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlgResult)
                {
                    case DialogResult.Yes:
                        string get_name = TB_GSN_Name.Text.ToString().Trim();
                        string upper_name = char.ToUpper(get_name[0]) + get_name.Substring(1);
                        string ett = "INSERT INTO set_name_answer(set_name,set_group)";
                        string tvo = " values(" + upper_name + ",'" + TB_GSN_Group.Text.ToString().Trim() + "');";
                        string tre = ett + tvo;

                        C_Connection.connection_table("open", answer_setsTableAdapter.Connection);
                        CExecuteScalar.execute_table(ref tre, answer_setsTableAdapter.Connection);
                        C_Connection.connection_table("close", answer_setsTableAdapter.Connection);
                        this.answer_setsTableAdapter.Fill(this.project22DataSet.answer_sets);
                        DGV_GSN.FirstDisplayedScrollingRowIndex = DGV_GSN.SelectedRows[0].Index;
                        break;

                    case DialogResult.No:
                        MessageBox.Show("Your information is not change !! ");
                        break;
                }
            }
            catch (Exception TSB_ASNNew) { Write_Exception.EWrite_Exception(TSB_ASNNew); }
        }
        private void TSB_ASNEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Edit set name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlgResult)
                {
                    case DialogResult.Yes:

                        string get_name = TB_GSN_Name.Text.ToString().Trim();
                        string upper_name = char.ToUpper(get_name[0]) + get_name.Substring(1);

                        string ett = "UPDATE set_name_answer set set_name ='" + upper_name
                                                     + "',set_group ='" + TB_GSN_Group.Text.ToString().Trim()
                                                     + "'  where ID = '" + Get_Current_Row_ID + "'";

                        C_Connection.connection_table("open", answer_setsTableAdapter.Connection);
                        CExecuteScalar.execute_table(ref ett, answer_setsTableAdapter.Connection);
                        C_Connection.connection_table("close", answer_setsTableAdapter.Connection);
                        this.answer_setsTableAdapter.Fill(this.project22DataSet.answer_sets);
                       
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Your information is not change !! ");
                        break;
                }
            }
            catch (Exception TSB_ASNEdit) { Write_Exception.EWrite_Exception(TSB_ASNEdit); }
        }
        private void TSB_ASNDelete_Click(object sender, EventArgs e)
        {
            //string test = TB_GSN_Name.Text.ToString().Trim();
            //string test2 = char.ToUpper(test[0]) + test.Substring(1);
        }
        private void TSB_ASNSearch_Click(object sender, EventArgs e)
        {

        }
        private void TSB_ASNRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                answersetsBindingSource.Filter = "";
                this.answer_setsTableAdapter.Fill(this.project22DataSet.answer_sets);
            }catch (Exception TSB_ASNRefresh) { Write_Exception.EWrite_Exception(TSB_ASNRefresh); }
        }
        private void TSB_ACancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch (Exception ETSB_ACancel) { Write_Exception.EWrite_Exception(ETSB_ACancel); }
        }
        //---------------------------------------------------------------------------------
        // Export
        //---------------------------------------------------------------------------------
        private void CSV_EM_TSMI_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen to CSV file ?", "Export set name answer list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    C_Path cpath = new C_Path();
                    string path = cpath.Current_Paths();
                    path = path.Replace("\\", "\\\\");
                    string ett = "SELECT 'ID', 'set_name', 'set_group', 'set_value' UNION ALL SELECT * FROM set_name_answer INTO OUTFILE '"
                               + path + "\\\\" + cpath.Check_Path("CSV") + "\\\\" + cpath.Check_FileName("SetNameAnswer") + ".csv' FIELDS TERMINATED BY ','; ";

                    C_Connection.connection_table("open", answer_setsTableAdapter.Connection);
                    CExecuteScalar.execute_table(ref ett, answer_setsTableAdapter.Connection);
                    C_Connection.connection_table("close", answer_setsTableAdapter.Connection);

                }
                else if (dlgResult == DialogResult.No)
                {
                    MessageBox.Show("Informaioner is Cancelled !! ");

                }
            }
            catch (Exception ETSB_CNew) { Write_Exception.EWrite_Exception(ETSB_CNew); }
        }
        private void CSV_EI_TSMI_Click(object sender, EventArgs e)
        {
            CSV_EM_TSMI_Click(sender, e);
        }
        //---------------------------------------------------------------------------------
        // Import
        //---------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------
        // Display information
        //---------------------------------------------------------------------------------
        private void TSB_ASNNew_MouseHover(object sender, EventArgs e)
        {
            TSSL_Setname.Text = "Input new set name information";
        }
        private void TSB_ASNEdit_MouseHover(object sender, EventArgs e)
        {
            TSSL_Setname.Text = "Edit set name information";
        }
        private void TSB_ASNDelete_MouseHover(object sender, EventArgs e)
        {
            TSSL_Setname.Text = "Delete information";
        }
        private void TSB_ASNRefresh_MouseHover(object sender, EventArgs e)
        {
            TSSL_Setname.Text = "Refresh information";
        }
        private void TSB_ACancel_MouseHover(object sender, EventArgs e)
        {
            TSSL_Setname.Text = "Cancel set name form";
        }
        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------
        private void DGV_GSN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TB_GSN_ID.Text = DGV_GSN.Rows[e.RowIndex].Cells["asnid"].Value.ToString().Trim();
                TB_GSNValue.Text = DGV_GSN.Rows[e.RowIndex].Cells["asnvalue"].Value.ToString().Trim();
                TB_GSN_Name.Text = DGV_GSN.Rows[e.RowIndex].Cells["asnname"].Value.ToString().Trim();
                TB_GSN_Group.Text = DGV_GSN.Rows[e.RowIndex].Cells["asngroup"].Value.ToString().Trim();
                Get_Current_Row_ID = int.Parse(TB_GSN_ID.Text.ToString().Trim());
            }catch (Exception DGV_GSN) { Write_Exception.EWrite_Exception(DGV_GSN); }
        }
        private void DGV_GSN_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DGV_GSN.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void DGV_GSN_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGV_GSN.Columns[e.ColumnIndex].HeaderText == "ID")
            {
                DGV_GSN.Sort(DGV_GSN.Columns["asnid"], ListSortDirection.Ascending);
            }
        }

       

        //---------------------------------------------------------------------------------
        // Search
        //---------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------
        // Check information
        //---------------------------------------------------------------------------------
        private string check_information_mysql(string value_find)
        {
            try
            {
                string ett = "SELECT id FROM set_name_answer WHERE id ='" + TB_GSN_ID.Text.ToString().Trim() + "'";
                C_Connection.connection_table("open", answer_setsTableAdapter.Connection);
                value_find = CExecuteScalar.execute_table(ref ett, answer_setsTableAdapter.Connection);
                C_Connection.connection_table("close", answer_setsTableAdapter.Connection);
            }catch (Exception Ecim_name) { Write_Exception.EWrite_Exception(Ecim_name); }
            return value_find;
        }


    }
}

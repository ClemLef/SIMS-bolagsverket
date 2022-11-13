/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :Categories.cs
 * 
 * Here Categories form that can add,edit,delete,expot,import information from categories table.
 */


using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wproject22.Classes;
using Utilities.Classes;
using System.ComponentModel;

namespace Wproject22.GUI
{
    public partial class Categories : Form
    {
        private string[] input_category = new string[6];
        private string c_active = string.Empty,check_find=string.Empty;
        private int Get_Current_Row_ID;
        public Categories()
        {
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            DGV_Categories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Categories.Columns["cname"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Categories.Columns["cuser"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Categories.Columns["cdate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Categories.Columns["ctime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Categories.Columns["cactive"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Categories.Columns["ccategoriescode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TSB_CSearch.Enabled = false;

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.Fill(this.project22DataSet.categories);
            }catch (Exception ECategories_Load) { Write_Exception.EWrite_Exception(ECategories_Load); }
        }
        //---------------------------------------------------------------------------------
        // Button
        //---------------------------------------------------------------------------------

        private void TSB_CNew_Click(object sender, EventArgs e)
        {
            try
            {
                check_find = check_information_mysql("");
                if (check_find == string.Empty)
                {   } else{
                    MessageBox.Show("This category code is  exist!");
                    return;
                }
 
              input_category[0] = TB_CId.Text.Trim();
              input_category[1] = TB_CName.Text.Trim();
              input_category[2] = TB_CCategorycode.Text.Trim();
                switch (CB_Active.Checked)
                {
                  case true:
                    input_category[3] = "1";
                    break;
                  case false:
                    input_category[3] = "0";
                    break;
                }

                input_category[4] = TB_CDate.Text.Trim();
                input_category[5] = TB_CTime.Text.Trim();

                DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Insert new Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                string ett = "INSERT INTO categories(name,categories_code,active,date,time)";
                string tvo = " values('" + input_category[1] + "','" 
                                         + input_category[2] + "','"
                                         + input_category[3] + "','" 
                                         + input_category[4] + "','" 
                                         + input_category[5] + "');";
                string tre = ett + tvo;

                    C_Connection.connection_table("open", categoriesTableAdapter.Connection);
                    CExecuteScalar.execute_table(ref tre, categoriesTableAdapter.Connection);
                    C_Connection.connection_table("close", categoriesTableAdapter.Connection);
                    this.categoriesTableAdapter.Fill(this.project22DataSet.categories);
                }
                else if (dlgResult == DialogResult.No)
                {
                MessageBox.Show("informaioner !! ");

                }
            }catch (Exception ETSB_CNew) { Write_Exception.EWrite_Exception(ETSB_CNew); }
        }

        private void TSB_CEdit_Click(object sender, EventArgs e)
        {
            try
            {
                   
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Edit Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlgResult)
                {
                    case DialogResult.Yes:

                        string get_name = TB_CName.Text.ToString().Trim();
                        string upper_name = char.ToUpper(get_name[0]) + get_name.Substring(1);

                        string ett = "UPDATE categories SET name ='" + upper_name
                                                     + "',categories_code ='" + TB_CCategorycode.Text.ToString().Trim()
                                                     + "' WHERE ID = '" + TB_CId.Text.ToString().Trim() + "'";

                        C_Connection.connection_table("open", categoriesTableAdapter.Connection);
                        CExecuteScalar.execute_table(ref ett, categoriesTableAdapter.Connection);
                        C_Connection.connection_table("close", categoriesTableAdapter.Connection);
                        this.categoriesTableAdapter.Fill(this.project22DataSet.categories);
                        break;

                    case DialogResult.No:
                        MessageBox.Show("Your information is not change !! ");
                        break;
                }
            }catch (Exception ETSB_CEdit) { Write_Exception.EWrite_Exception(ETSB_CEdit); }
        }

        private void TSB_CDelete_Click(object sender, EventArgs e)
        {
            try
            { 
             DialogResult dlgResult = MessageBox.Show("Do you want delete informationen ?", "Delete Categories", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (dlgResult == DialogResult.Yes)
               {
                string D_row = DGV_Categories.Rows[Get_Current_Row_ID].Cells["cid"].Value.ToString().Trim();
                string ett = "DELETE FROM categories WHERE id=" + D_row + "";

                C_Connection.connection_table("open", categoriesTableAdapter.Connection);
                CExecuteScalar.execute_table(ref ett, categoriesTableAdapter.Connection);
                C_Connection.connection_table("close", categoriesTableAdapter.Connection);
                this.categoriesTableAdapter.Fill(this.project22DataSet.categories);
               }
            else if (dlgResult == DialogResult.No)
            {
                MessageBox.Show("informaioner !! ");
            }
        }catch (Exception ETSB_CDelete) { Write_Exception.EWrite_Exception(ETSB_CDelete); }
}

        private void TSB_CRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                categoriesBindingSource.Filter = "";
                this.categoriesTableAdapter.Fill(this.project22DataSet.categories);

            }catch (Exception ETSB_CRefresh) { Write_Exception.EWrite_Exception(ETSB_CRefresh); }
        }

        private void TSB_CCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch (Exception ETSB_CCancel) { Write_Exception.EWrite_Exception(ETSB_CCancel); }

        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                TSB_CCancel_Click(sender, e);
            }
            catch (Exception ETSB_CCancel) { Write_Exception.EWrite_Exception(ETSB_CCancel); }

            
        }
        //---------------------------------------------------------------------------------
        // Export
        //---------------------------------------------------------------------------------

        private void TSMI_ECSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen to CSV file ?", "Export categories list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    C_Path cpath = new C_Path();
                    string path = cpath.Current_Paths();
                    path = path.Replace("\\", "\\\\");
                    string ett = "SELECT 'ID', 'name', 'user', 'date', 'time', 'categories_code', 'active' UNION ALL SELECT * FROM categories INTO OUTFILE '"
                               + path + "\\\\" + cpath.Check_Path("CSV") + "\\\\" + cpath.Check_FileName("Categories") + ".csv' FIELDS TERMINATED BY ','; ";

                    C_Connection.connection_table("open", categoriesTableAdapter.Connection);
                    CExecuteScalar.execute_table(ref ett, categoriesTableAdapter.Connection);
                    C_Connection.connection_table("close", categoriesTableAdapter.Connection);

                }
                else if (dlgResult == DialogResult.No)
                {
                    MessageBox.Show("Informaioner is Cancelled !! ");

                }
            }
            catch (Exception ETSB_CNew) { Write_Exception.EWrite_Exception(ETSB_CNew); }
        }

        //---------------------------------------------------------------------------------
        // Import
        //---------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------
        // Display information
        //---------------------------------------------------------------------------------
        private void TSB_CNew_MouseHover(object sender, EventArgs e)
        {
            TSSL_category.Text = "Input new Category information";
        }

        private void TSB_CEdit_MouseHover(object sender, EventArgs e)
        {
            TSSL_category.Text = "Edit Category information";
        }

        private void TSB_CDelete_MouseHover(object sender, EventArgs e)
        {
            TSSL_category.Text = "Delete information";
        }

        private void TSB_CSearch_MouseHover(object sender, EventArgs e)
        {
            TSSL_category.Text = "Search information";
        }

        private void TSB_CRefresh_MouseHover(object sender, EventArgs e)
        {
            TSSL_category.Text = "Refresh information";
        }

        private void TSB_CCancel_MouseHover(object sender, EventArgs e)
        {
            TSSL_category.Text = "Cancel Category form";
        }
        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------

        private void DGW_Categories_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Get_Current_Row_ID = e.RowIndex;
                TB_CId.Text = DGV_Categories.Rows[e.RowIndex].Cells["cid"].Value.ToString().Trim();
                TB_CName.Text = DGV_Categories.Rows[e.RowIndex].Cells["cname"].Value.ToString().Trim();
                TB_CCategorycode.Text = DGV_Categories.Rows[e.RowIndex].Cells["ccategoriescode"].Value.ToString().Trim();
                TB_CDate.Text = DGV_Categories.Rows[e.RowIndex].Cells["cdate"].Value.ToString().Trim();
                TB_CTime.Text = DGV_Categories.Rows[e.RowIndex].Cells["ctime"].Value.ToString().Trim();
                c_active = DGV_Categories.Rows[e.RowIndex].Cells["cactive"].Value.ToString().Trim();
                if (c_active == "1")
                { CB_Active.Checked = true; }
                else { CB_Active.Checked = false; }
            }catch (Exception EDGW_Categories) { Write_Exception.EWrite_Exception(EDGW_Categories); }


        }

        private void DGV_Categories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DGV_Categories.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void DGV_Categories_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGV_Categories.Columns[e.ColumnIndex].HeaderText == "ID")
            {
                DGV_Categories.Sort(DGV_Categories.Columns["cid"], ListSortDirection.Ascending);
            }
        }

        private void MenuBar_ST_TSMI_Click(object sender, EventArgs e)
        {
            if (menuBar_ST_TSMI.Checked == false)
            {
               TS_Categories.Visible = true;
                menuBar_ST_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_Categories.Visible = false;
                menuBar_ST_TSMI.CheckState = CheckState.Unchecked;
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
                string ett = "SELECT categorys_code FROM categories WHERE categorys_code ='" + TB_CCategorycode.Text.ToString().Trim() + "'";

                C_Connection.connection_table("open", categoriesTableAdapter.Connection);
                value_find = CExecuteScalar.execute_table(ref ett, categoriesTableAdapter.Connection);
                C_Connection.connection_table("close", categoriesTableAdapter.Connection);
             
            } catch (Exception EDGW_Categories) { Write_Exception.EWrite_Exception(EDGW_Categories); }
            return value_find;
        }

    }
}


/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :Questions.cs
 * 
 * Here Questions format form that can add,edit,delete,expot,import information from questions table.
 */

using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wproject22.Classes;
using Utilities.Classes;
using Wproject22.GUI_Search;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Wproject22.GUI
{
    public partial class Questions : Form
    {
        private string Which_TextBoxs_CL = string.Empty;
        private string Which_TextBoxs_QL = string.Empty;

        private string Which_TextBoxs_CLL = string.Empty;
        private string Which_TextBoxs_QCL = string.Empty;

        private string[] input_question = new string[9];
        private string c_active = string.Empty, c_has_set_sub = string.Empty, check_find = string.Empty;

        private int category_code = 2001;
        private int Get_Current_Row,Get_Current_Row_ID;
        
        private Boolean  DSubcategory=false,Edit_Check=false;
        FSE_Question FQ = null;
        public Questions()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            DGV_Questions.Columns["qcategory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Questions.Columns["qactive"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Questions.Columns["qanswerset"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Questions.Columns["qsubquestiongroup"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Questions.Columns["qhassubquestion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TSB_QDelete.Enabled = false;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Question_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.project22DataSet.categories);
            // TODO: This line of code loads data into the 'project22DataSet.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.project22DataSet.questions);

        }
        //---------------------------------------------------------------------------------
        // Menu Strip
        //---------------------------------------------------------------------------------
        private void Exit_MB_TSMI_Click(object sender, EventArgs e)
        {
            TSB_QCancel_Click(sender, e);
        }

        //---------------------------------------------------------------------------------
        // Tool Strip Meun Item
        //---------------------------------------------------------------------------------
        private void TSB_QNew_Click(object sender, EventArgs e)
        {
            try
            {
                check_find = check_information_mysql("");
                if (check_find == string.Empty)
                { }
                else
                {
                    MessageBox.Show("This question code is exist!");
                    return;
                }
            string Category = CBB_QCategory.SelectedItem.ToString();
            category_code = SGCategory_Code;
           
            DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Insert new Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dlgResult)
            {
                case DialogResult.Yes:
                    
                    SetGet_info(input_question);
                        ////Classes.C_DateTime CDT = new C_DateTime();
                        ////input_question[3] = CDT.SGDate;
                        ////input_question[4] = CDT.SGTime;
                        string ett = "INSERT INTO questions(category,set_question,help_information,answer_set,has_sub_question,sub_question_group,active)";
                        string tvo = " values(" + input_question[1] + ",'" + input_question[7] + "','" + input_question[8] + "','" 
                                                + input_question[2] + "','" + input_question[4] + "','" + input_question[5] + "','" 
                                                + input_question[3] + "');";
                        string tre = ett + tvo;

                        C_Connection.connection_table("open", questionsTableAdapter.Connection);
                        CExecuteScalar.execute_table(ref tre, questionsTableAdapter.Connection);
                        C_Connection.connection_table("close", questionsTableAdapter.Connection);
                        this.questionsTableAdapter.Fill(this.project22DataSet.questions);
                        DGV_Questions.FirstDisplayedScrollingRowIndex = DGV_Questions.SelectedRows[0].Index;


                        break;
                case DialogResult.No:
                    MessageBox.Show("Your information is not change !! ");
                    break;
            }
            }catch (Exception TSB_QNew) { Write_Exception.EWrite_Exception(TSB_QNew); }
        }

        private void TSB_QEdit_Click(object sender, EventArgs e)
        {
            try
            {   
            string Category = CBB_QCategory.SelectedItem.ToString();
            category_code = SGCategory_Code;
            DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Edit Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dlgResult)
            {
                case DialogResult.Yes:

                    Edit_Check = true;
                  //  SetGet_info(input_question);
                    //Classes.C_DateTime CDT = new C_DateTime();
                    //input_question[5] = CDT.SGTime;
                    //input_question[6] = CDT.SGTime;
                    SetGet_info(input_question);
                    Get_Current_Row_ID = int.Parse(input_question[0]);
                    string ett = "UPDATE questions set category ='" + input_question[1]
                                                 + "',set_question ='" + input_question[7] 
                                                 + "',active ='" + input_question[3] 
                                                 + "',help_information  ='" + input_question[8] 
                                                 + "',answer_set ='" + input_question[2] 
                                                 + "',has_sub_question ='" + input_question[4] 
                                                 + "',sub_question_group ='" + input_question[5]
                                                 + "'  where ID = '" + Get_Current_Row_ID + "'";

                        C_Connection.connection_table("open", questionsTableAdapter.Connection);
                        CExecuteScalar.execute_table(ref ett, questionsTableAdapter.Connection);
                        C_Connection.connection_table("close", questionsTableAdapter.Connection);
                        this.questionsTableAdapter.Fill(this.project22DataSet.questions);
                        questionsBindingSource.Position = Get_Current_Row;
                        break;
                case DialogResult.No:
                    MessageBox.Show("Your information is not change !! ");
                    break;
            }
            }
            catch (Exception TSB_QEdit) { Write_Exception.EWrite_Exception(TSB_QEdit); }
        }

        private void TSB_QDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen ?", "Delete Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dlgResult)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Underconstraction");
                    break;
                case DialogResult.No:
                    break;
            }
            }catch (Exception TSB_QDelete) { Write_Exception.EWrite_Exception(TSB_QDelete); }
        }

        private void TSB_QSearch_Click(object sender, EventArgs e)
        {
            try
            {
              //  TSB_QSearch.Enabled = false;
                FQ = new FSE_Question();
                Style.Form_Position.Form_On_Left(this, FQ);
                FQ.Show();
                FQ.Search_TextBox_Question += OnSearchCategoryQuestion_Clicked;
                FQ.Which_TextBox_Question += OnWhichTextBoxCategoryQuestion_Clicked;
                FQ.Which_Button_Question += OnSearchButtonQuestion_Clicked;
            }catch (Exception TSB_QSearch) { Write_Exception.EWrite_Exception(TSB_QSearch); }
        }

        private void TSB_QRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                questionsBindingSource.Filter = "";
                this.questionsTableAdapter.Fill(this.project22DataSet.questions);
            }
            catch (Exception TSB_QRefresh) { Write_Exception.EWrite_Exception(TSB_QRefresh); }
        }

        private void TSB_QCancel_Click(object sender, EventArgs e)
        {

            try
            {
                Close_search();
                this.Close();
            }
            catch (Exception E_) { Write_Exception.EWrite_Exception(E_); }

           
        }

        private void Question_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close_search();
        }

        private void TSB_Setname_Click(object sender, EventArgs e)
        {
            GUI.ASetName GSN = new GUI.ASetName();
            GSN.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBB_QCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception CBB_QCategory) { Write_Exception.EWrite_Exception(CBB_QCategory); }
        }

        //---------------------------------------------------------------------------------
        // Export
        //---------------------------------------------------------------------------------
        private void CSV_STQ_TSMI_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResult = MessageBox.Show("Do you want save informationen to CSV file ?", "Export Questions list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    C_Path cpath = new C_Path();
                    string path = cpath.Current_Paths();
                    path = path.Replace("\\", "\\\\");
                    string ett = "SELECT  'id','category','active','set_question','help_information','answer_set','has_sub_question','sub_question_group' UNION ALL SELECT * FROM questions INTO OUTFILE '"
                               + path + "\\\\" + cpath.Check_Path("CSV") + "\\\\" + cpath.Check_FileName("Questions") + ".csv' FIELDS TERMINATED BY ','; ";

                    C_Connection.connection_table("open", questionsTableAdapter.Connection);
                    CExecuteScalar.execute_table(ref ett, questionsTableAdapter.Connection);
                    C_Connection.connection_table("close", questionsTableAdapter.Connection);

                }
                else if (dlgResult == DialogResult.No)
                {
                    MessageBox.Show("Informaioner is Cancelled !! ");

                }
            }
            catch (Exception ETSB_CNew) { Write_Exception.EWrite_Exception(ETSB_CNew); }
        }
        private void XML_TS_TSMI_Click(object sender, EventArgs e)
        {
            //C_Connection.connection_table("open", questionsTableAdapter.Connection);
            ////CExecuteScalar.execute_table(ref tre, questionsTableAdapter.Connection);

            //const string strSql = "SELECT * FROM questions";

            //using (SqlCommand sqlComm = new SqlCommand(strSql, DataConn.Connect()) { CommandType = CommandType.Text })
            //{
            //    SqlDataAdapter da = new SqlDataAdapter(sqlComm);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    ds.Tables[0].WriteXml(@"C:\Temp\text.xml");
            //}
            //C_Connection.connection_table("close", questionsTableAdapter.Connection);
        }



        //---------------------------------------------------------------------------------
        // Import
        //---------------------------------------------------------------------------------



        //---------------------------------------------------------------------------------
        // Display information
        //---------------------------------------------------------------------------------

        private void TSB_QRefresh_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "That is refresh information.";
        }

        private void TSB_QSearch_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "That is use to search information.";
        }

        private void TSB_QEdit_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "That is use to edit information.";
        }

        private void TSB_QNew_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "That is use to add new information.";
        }

        private void TSB_QDelete_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "That is use to remove information.";
        }

        private void TSDDB_QFile_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "This is use to import and export information.";
        }

        private void TSB_QCancel_MouseHover(object sender, EventArgs e)
        {
            TSSL_Question.Text = "That use to exit.";
        }


        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_Questions_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if(Edit_Check==true)
                {
                    Edit_Check = false;
                }
                else
                {  Get_Current_Row = e.RowIndex;   }

                TB_QuestionID.Text = DGV_Questions.Rows[e.RowIndex].Cells["qid"].Value.ToString().Trim();
                TB_setanswer.Text = DGV_Questions.Rows[e.RowIndex].Cells["qanswerset"].Value.ToString().Trim();
              
                TB_subquestiongroup.Text = DGV_Questions.Rows[e.RowIndex].Cells["qsubquestiongroup"].Value.ToString().Trim();
                TB_QuestionText.Text = DGV_Questions.Rows[e.RowIndex].Cells["qsetquestion"].Value.ToString().Trim();
                TB_Helpinformation.Text = DGV_Questions.Rows[e.RowIndex].Cells["qhelpinformation"].Value.ToString().Trim();
                c_has_set_sub = DGV_Questions.Rows[e.RowIndex].Cells["qhassubquestion"].Value.ToString().Trim();
                switch (c_has_set_sub)
                {
                    case "1":
                        RB_Hasset_yes.Checked = true;
                        RB_Hasset_no.Checked = false;
                        break;
                    case "0":
                        RB_Hasset_no.Checked = true;
                        RB_Hasset_yes.Checked = false;
                        break;

                }


                c_active = DGV_Questions.Rows[e.RowIndex].Cells["qactive"].Value.ToString().Trim();
                if (c_active == "1")
                     {  CB_Display_Question.Checked = true;   }
                else {  CB_Display_Question.Checked = false;  }

                // DSubcategory = bool.Parse(DGV_Questions.Rows[e.RowIndex].Cells["q_show_subquestion_group"].Value.ToString().Trim());
                if (DSubcategory == true)
                     {  CB_DSubcategory.Checked = true;   }
                else {  CB_DSubcategory.Checked = false;  }

                 string category= DGV_Questions.Rows[e.RowIndex].Cells["qcategory"].Value.ToString().Trim();
                 CBB_QCategory.SelectedIndex = int.Parse(category);
            }
            catch (Exception DGV_Question_R) { Write_Exception.EWrite_Exception(DGV_Question_R); }
        }

        private void DGV_Questions_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGV_Questions.Columns[e.ColumnIndex].HeaderText == "ID")
            {
                DGV_Questions.Sort(DGV_Questions.Columns["qid"], ListSortDirection.Ascending);
            }
        }

        private void DGV_Questions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DGV_Questions.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        //---------------------------------------------------------------------------------
        // Search
        //---------------------------------------------------------------------------------
                                    
        private void OnSearchButtonQuestion_Clicked(object sender, EV_Button e)
        {
            try
            {
                TSB_QSearch.Enabled=  e.SGWhich_Name_Button;

            }
            catch (Exception OnSearchButtonQuestion) { Write_Exception.EWrite_Exception(OnSearchButtonQuestion); }
        }

        private void OnSearchCategoryQuestion_Clicked(object sender, EV_Question e)
        {
            try
            {
                switch (Which_TextBoxs_CLL)
                {
                    case "TB_QuestionCode":
                        questionsBindingSource.Filter = string.Format("convert(ID, 'System.String') Like '%{0}%' ", e.SGNA_TextBox_Question.Trim());
                        break;
                    case "TB_CategoryID":
                        questionsBindingSource.Filter = string.Format("convert(category, 'System.String') Like '%{0}%' ", e.SGNA_TextBox_Question.Trim());
                        break;
                    case "TB_QuestionText":
                        questionsBindingSource.Filter = "set_question LIKE '%" + e.SGNA_TextBox_Question.Trim() + "%'";
                        break;
                }
            }
            catch (Exception OnSearchCategoryQuestion) { Write_Exception.EWrite_Exception(OnSearchCategoryQuestion); }

        }

        private void OnWhichTextBoxCategoryQuestion_Clicked(object sender, EV_Question e)
        {
            try
            {
                Which_TextBoxs_CLL = e.SGWhich_TextBox_Question;
            }catch (Exception OnWhichTextBoxSubQuestion) { Write_Exception.EWrite_Exception(OnWhichTextBoxSubQuestion); }
        }

        

        //---------------------------------------------------------------------------------
        // Function
        //---------------------------------------------------------------------------------


        private int SGCategory_Code
        {
            get { return category_code; }

            set { category_code = value; }
        }


        private void menuBar_TSMI_Click(object sender, EventArgs e)
        {
            if (menuBar_TSMI.Checked == false)
            {
                TS_Questions.Visible = true;
                menuBar_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_Questions.Visible = false;
                menuBar_TSMI.CheckState = CheckState.Unchecked;
            }
        }

        public object DataConn { get; private set; }

        private void SetGet_info(string[] SGinput_question)
        {
            try
            {
                //int ind = CBB_QCategory.SelectedIndex;
                //CBB_QCategory.SelectedIndex = int.Parse(category);
                SGinput_question[0] = TB_QuestionID.Text.Trim();
                SGinput_question[1] = CBB_QCategory.SelectedIndex.ToString();
                SGinput_question[2] = TB_setanswer.Text.Trim();
                switch (CB_Display_Question.Checked)
                {
                    case true:
                        SGinput_question[3] = "1";
                        break;
                    case false:
                        SGinput_question[3] = "0";
                        break;
                }
                if (RB_Hasset_yes.Checked == true)
                {
                    SGinput_question[4] = "1";
                }
                else { SGinput_question[4] = "0"; }
                
                // SGinput_question[2] = TB_QuestionText.Text.Trim(); 


                SGinput_question[5] = TB_subquestiongroup.Text.Trim();
                SGinput_question[6] = TB_setquestion.Text.Trim();
                SGinput_question[7] = TB_QuestionText.Text.Trim();
                SGinput_question[8] = TB_Helpinformation.Text.Trim();
            }
            catch (Exception SetGet_info) { Write_Exception.EWrite_Exception(SetGet_info); }
        }

        private void Close_search()
        {
            if (Form.ActiveForm != FQ)
            {
              //  FQ.Close();
            }
        }

        private string check_information_mysql(string value_find)
        {
            try
            {
                string ett = "SELECT id FROM questions WHERE id ='" + TB_QuestionID.Text.Trim() + "'";

                C_Connection.connection_table("open", questionsTableAdapter.Connection);
                value_find = CExecuteScalar.execute_table(ref ett, questionsTableAdapter.Connection);
                C_Connection.connection_table("close", questionsTableAdapter.Connection);

            }
            catch (Exception EDGW_Categories) { Write_Exception.EWrite_Exception(EDGW_Categories); }
            return value_find;
        }
    }
}

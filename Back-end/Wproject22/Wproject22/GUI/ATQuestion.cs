/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :ATQuestion.cs
 * 
 * Here ATQuestion form that can add,edit,delete,expot,import information from input_question table.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wproject22.GUI_Search;
using Utilities.Classes;

namespace Wproject22.GUI
{
    public partial class ATQuestion : Form
    {
        private int AGet_Current_Row, Get_Current_Row;
        private string c_iactive = string.Empty;
        private string question_active = string.Empty,answer_active=string.Empty;
        private string Which_TextBoxs_CA = string.Empty;
        FSE_Answer SA = null;
        public ATQuestion()
        {
            InitializeComponent();
            DGV_Answer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Answer.Columns["id_question"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Answer.Columns["urc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Answer.Columns["ianswer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Answer.Columns["idate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Answer.Columns["itime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Answer.Columns["iactive"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGV_AQuestion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_AQuestion.Columns["atacategory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_AQuestion.Columns["ata_active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_AQuestion.Columns["answer_set"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_AQuestion.Columns["has_sub_question"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_AQuestion.Columns["sub_question_group"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TSB_ADelete.Enabled = false;
  
        }
              
        private void Iquestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.project22DataSet.categories);
            // TODO: This line of code loads data into the 'project22DataSet.question' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.project22DataSet.questions);
            // TODO: This line of code loads data into the 'project22DataSet.input_question' table. You can move, or remove it, as needed.
            this.input_questionTableAdapter.Fill(this.project22DataSet.input_question);

        }

        //---------------------------------------------------------------------------------
        // Button
        //---------------------------------------------------------------------------------
        private void Iquestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close_search();
        }

        private void TSB_ACancel_Click(object sender, EventArgs e)
        {
         //   Close_search();
            this.Close();
        }

        private void TSB_ANew_Click(object sender, EventArgs e)
        {

        }

        private void TSB_AEdit_Click(object sender, EventArgs e)
        {

        }

        private void TSB_ADelete_Click(object sender, EventArgs e)
        {

        }

        private void TSB_ASearch_Click(object sender, EventArgs e)
        {
            try
            {
                //  TSB_QSearch.Enabled = false;
                //FSE_Answer 
                SA = new FSE_Answer();
                Style.Form_Position.Form_On_Left(this, SA);
                SA.Show();
                SA.Search_TextBox_Answer += OnSearchAnswer_Clicked;
                SA.Which_TextBox_Answer  += OnWhichTextBoxAnswer_Clicked;
                //  SA.Which_Button_Question += OnSearchButtonQuestion_Clicked;
            }
            catch (Exception TSB_QSearch) { Write_Exception.EWrite_Exception(TSB_QSearch); }
        }

        private void TSB_ARefresh_Click(object sender, EventArgs e)
        {
            try
            {
                inputquestionBindingSource.Filter = "";
                this.input_questionTableAdapter.Fill(this.project22DataSet.input_question);
            }
            catch (Exception TSB_ARefresh) { Write_Exception.EWrite_Exception(TSB_ARefresh); }
        }

        //---------------------------------------------------------------------------------
        // Display information
        //---------------------------------------------------------------------------------
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iquestion_Load(sender, e);
        }

        private void TSB_ANew_MouseHover(object sender, EventArgs e)
        {
            TSSL_Answer.Text = "Input new answer information";
        }

        private void TSB_AEdit_MouseHover(object sender, EventArgs e)
        {
            TSSL_Answer.Text = "Edit answer information";
        }

        private void TSB_ADelete_MouseHover(object sender, EventArgs e)
        {
            TSSL_Answer.Text = "Delete information";
        }

        private void TSB_ASearch_MouseHover(object sender, EventArgs e)
        {
            TSSL_Answer.Text = "Search information";
        }

        private void TSB_ARefresh_MouseHover(object sender, EventArgs e)
        {
            TSSL_Answer.Text = "Refresh information";
        }

        private void TSB_ACancel_MouseHover(object sender, EventArgs e)
        {
            TSSL_Answer.Text = " Exit from answer form";
        }
        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------
        private void DGV_AQuestion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Get_Current_Row = e.RowIndex;
            string category = DGV_AQuestion.Rows[e.RowIndex].Cells["atacategory"].Value.ToString().Trim();
            TB_IQN.Text = DGV_AQuestion.Rows[e.RowIndex].Cells["ataid"].Value.ToString().Trim();
            TB_IQuestionText.Text = DGV_AQuestion.Rows[e.RowIndex].Cells["ata_set_question"].Value.ToString().Trim();
            question_active = DGV_AQuestion.Rows[e.RowIndex].Cells["ata_active"].Value.ToString().Trim();

            if (question_active == "1")
            { CB_IQuestion.Checked = true; }
            else { CB_IQuestion.Checked = false; }

            CBB_QCategory.SelectedIndex = int.Parse(category);

        }

        private void DGV_AQuestion_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DGV_AQuestion.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void DGV_Answer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(DGV_Answer.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void DGV_Answer_SelectionChanged(object sender, EventArgs e)
        {
            int Row_current_answer = 0;
            if (DGV_Answer.CurrentRow == null)
                return;

            string answer_id = Convert.ToString(DGV_Answer.Rows[AGet_Current_Row].Cells["id_question"].Value.ToString());
            foreach (DataGridViewRow Row_current_Aquestion in DGV_AQuestion.Rows)
            {
                string question_id = Convert.ToString(Row_current_Aquestion.Cells["ataid"].Value);
                if (answer_id == question_id)
                {
                    Row_current_answer = Row_current_Aquestion.Index;
                    questionsBindingSource.Position = Row_current_answer;
                }

            }
        }

        private void DGV_Answer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            AGet_Current_Row = e.RowIndex;
            TB_AQN.Text = DGV_Answer.Rows[e.RowIndex].Cells["ianswer"].Value.ToString().Trim();
            TB_URC.Text = DGV_Answer.Rows[e.RowIndex].Cells["urc"].Value.ToString().Trim();
            TB_QuestionID.Text = DGV_Answer.Rows[e.RowIndex].Cells["iid"].Value.ToString().Trim();
            TB_IDate.Text = DGV_Answer.Rows[e.RowIndex].Cells["idate"].Value.ToString().Trim();
            TB_ITime.Text = DGV_Answer.Rows[e.RowIndex].Cells["itime"].Value.ToString().Trim();
            c_iactive = DGV_Answer.Rows[e.RowIndex].Cells["iactive"].Value.ToString().Trim();
           

            if (c_iactive == "1")
            { CB_IAQuestion.Checked = true; }
            else { CB_IAQuestion.Checked = false; }

           
            if (DGV_AQuestion.Rows.Count > 0)
            {
                DGV_AQuestion.FirstDisplayedScrollingRowIndex = int.Parse(TB_AQN.Text);
            }
                
        }

        //---------------------------------------------------------------------------------
        // Search
        //---------------------------------------------------------------------------------

        private void OnSearchAnswer_Clicked(object sender, EV_Answer e)
        {
            try
            {
                switch (Which_TextBoxs_CA)
                {
                    case "TB_SAnswerID":
                        inputquestionBindingSource.Filter = string.Format("convert(ID, 'System.String') Like '%{0}%' ", e.SGNA_TextBox_Answer.Trim());
                        break;
                    case "TB_SA_URC":
                        inputquestionBindingSource.Filter = string.Format("convert(urc, 'System.String') Like '%{0}%' ", e.SGNA_TextBox_Answer.Trim());
                        break;
                    case "TB_SAQuestionID":
                        inputquestionBindingSource.Filter = string.Format("convert(id_question, 'System.String') Like '%{0}%' ", e.SGNA_TextBox_Answer.Trim());
                        break;
                    case "TB_SADate":
                        inputquestionBindingSource.Filter = "date LIKE '%" + e.SGNA_TextBox_Answer.Trim() + "%'";
                        break;
                    case "TB_SAQuestion":
                  //      questionsBindingSource.Filter = "question LIKE '%" + e.SGNA_TextBox_Answer.Trim() + "%'";
                        break;
                }
            }
            catch (Exception OnSearchAnswer) { Write_Exception.EWrite_Exception(OnSearchAnswer); }

        }



        private void menuBar_TS_TSMI_Click(object sender, EventArgs e)
        {
            if (menuBar_TS_TSMI.Checked == false)
            {
                TS_ATQuestion.Visible = true;
                menuBar_TS_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_ATQuestion.Visible = false;
                menuBar_TS_TSMI.CheckState = CheckState.Unchecked;
            }
        }

        private void OnWhichTextBoxAnswer_Clicked(object sender, EV_Answer e)
        {
            try
            {
                Which_TextBoxs_CA = e.SGWhich_TextBox_Answer;
            }
            catch (Exception OnWhichTextBoxSubQuestion) { Write_Exception.EWrite_Exception(OnWhichTextBoxSubQuestion); }
        }

        private void Close_search()
        {
            if (Form.ActiveForm != SA)
            {
           //    SA.Close();
            }
        }
    }
}

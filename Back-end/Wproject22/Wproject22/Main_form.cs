/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :Main_form.cs
 * 
 * 
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
using Utilities.Classes;
using Winform_PDFtoWORD;



namespace Wproject22
{
    public partial class Main_form : Form
    {
        private string Database_name = string.Empty;
        private string[] main_aai = new string[9];
        public Main_form()
        {
            InitializeComponent();
          //  TS_Main.Visible = false;
            TSMI_toolbars.Checked = false;
            testToolStripMenuItem.Visible = false;
            B_Result.Visible = false;
            toolStripButton1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.project22DataSet.users);
            // TODO: This line of code loads data into the 'project22DataSet.Answer_AI' table. You can move, or remove it, as needed.
            this.answer_AITableAdapter.Fill(this.project22DataSet.Answer_AI);
           Main_chart.Titles.Add("Sustainability Barometer");
            //---------------------------------------------------------------------------------
            // Datagridview
            //---------------------------------------------------------------------------------

            DGV_MainUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_MainUser.Columns["main_urc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_MainUser.Columns["main_date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         //   DGV_MainUser.Columns["main_time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_MainUser.Columns["main_active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //---------------------------------------------------------------------------------
            // Datagridview
            //---------------------------------------------------------------------------------
            DGV_Main_AnswerAI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_urc_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_active_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_social_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_socialflag_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_economical_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_economicalflag_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_Envirment_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_Envirmentflag_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_influence_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Main_AnswerAI.Columns["main_influenceflag_ai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Main_chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
          
        }

        //---------------------------------------------------------------------------------
        // Button
        //---------------------------------------------------------------------------------
        private void TSMI_Connection_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.DBConnection DBC = new GUI.DBConnection();
                //DBC.StartPosition = FormStartPosition.Manual;
                //DBC.Location = new Point(this.Left + this.Width, this.Top);
                ////    DBC.SG_MainConnection = Show_Table;
                //DBC.SG_Database_name = Database_name;
                if (DBC.ShowDialog() == DialogResult.OK)
                {
                    //  TSB_ListAlbum.Enabled = Show_Table;
                    Database_name = DBC.SG_Database_name;
                    // TSB_ListAlbum_Click(sender, e);
                    //  TSB_SlidShow.Enabled = true;

                }
                else
                {
                    //    TSB_ListAlbum.Enabled = Show_Table;
                }
            }
            catch (Exception NIE)
            {
                Write_Exception.EWrite_Exception(NIE);
            }
        }

        private void TSB_Connection_Click(object sender, EventArgs e)
        {
            try
            {
                TSMI_Connection_Click(sender, e);
            }
            catch (Exception NIE)
            {
                Write_Exception.EWrite_Exception(NIE);
            }
        }

        private void TSB_UserList_Click(object sender, EventArgs e)
        {
            GUI.Users GU = new GUI.Users();
            GU.Show();
        }

        private void TSB_Category_Click(object sender, EventArgs e)
        {
            GUI.Categories GC = new GUI.Categories();
            GC.Show();
        }

        private void TSB_MAnswer_Format_Click(object sender, EventArgs e)
        {
            TSMI_answerFormat_Click(sender, e);
        }

        private void TSB_Question_Click(object sender, EventArgs e)
        {
            TSMI_question_Click(sender, e);
        }

        private void TSB_AnswerQuestion_Click(object sender, EventArgs e)
        {
            TSMI_answerQuestion_Click(sender, e);
        }

        private void TSB_MResultAnswer_Click(object sender, EventArgs e)
        {
            GUI.RQAI GFRA = new GUI.RQAI();
            GFRA.Show();
        }

        private void TSB_Show_AI_Click(object sender, EventArgs e)
        {
            GUI.AIReport FAI = new GUI.AIReport();
            FAI.Show();
        }

        private void TSB_PdftoWord_Click(object sender, EventArgs e)
        {
            PDFtoWord PTW = new PDFtoWord();
            PTW.Show();
        }

        private void TSB_Test_AI_Click(object sender, EventArgs e)
        {
            Utilities.TestUnit UTU = new Utilities.TestUnit();
            UTU.Show();
        }

        private void TSMI_Category_Click(object sender, EventArgs e)
        {
            GUI.Categories GC = new GUI.Categories();
            GC.Show();
        }

        private void TSMI_category_Click_1(object sender, EventArgs e)
        {
            GUI.Categories cat = new GUI.Categories();
            cat.Show();
        }

        private void TSMI_question_Click(object sender, EventArgs e)
        {
            GUI.Questions que = new GUI.Questions();
            que.Show();
        }

        private void TSMI_answerFormat_Click(object sender, EventArgs e)
        {
            GUI.ASetName GSN = new GUI.ASetName();
            GSN.Show();
        }

        private void TSMI_answerQuestion_Click(object sender, EventArgs e)
        {
            GUI.ATQuestion iq = new GUI.ATQuestion();
            iq.Show();
        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Test ts = new GUI.Test();
            ts.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            GUI.Test GT = new GUI.Test();
            GT.Show();
        }
        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------
        private void DGV_MainUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string[] datetime;
            if (DGV_MainUser.Rows.Count > 0)
            {
                TB_MURC.Text = DGV_MainUser.Rows[e.RowIndex].Cells["main_urc"].Value.ToString().Trim();
                datetime = DGV_MainUser.Rows[e.RowIndex].Cells["main_date"].Value.ToString().Trim().Split(' ');
                TB_MUDate.Text = datetime[0];
                TB_MUTime.Text = datetime[1];
                //TB_MUDate.Text = DGV_MainUser.Rows[e.RowIndex].Cells["main_date"].Value.ToString().Trim();
                //TB_MUTime.Text = DGV_MainUser.Rows[e.RowIndex].Cells["main_time"].Value.ToString().Trim();
                string c_active = DGV_MainUser.Rows[e.RowIndex].Cells["main_active"].Value.ToString().Trim();

                if (c_active == "1")
                {
                    TB_MUActive.Text = "Active";
                    TB_MUActive.BackColor = Color.Green;
                    TB_MUActive.ForeColor = Color.White;
                }
                else
                {
                    TB_MUActive.Text = "Deactive";
                    TB_MUActive.BackColor = Color.Yellow;
                    TB_MUActive.ForeColor = Color.Black;
                }
            }

            string user_code = DGV_MainUser.Rows[e.RowIndex].Cells["main_urc"].Value.ToString().Trim();
            if (DGV_Main_AnswerAI.Rows.Count > 0)
            {
                var rows = DGV_Main_AnswerAI.Rows.OfType<DataGridViewRow>().Select(x => new { Value = x.Cells[0].Value.ToString(), Index = x.Index }).ToList();

                var indexs = rows.Where(w => w.Value == user_code).Select(s => s.Index).FirstOrDefault();
               // if (indexs==0)
               // {
               ////     Main_chart.Series["SIMS"].Points.Clear();
               // }
               // else
               // {
                    answerAIBindingSource.Position = indexs;
                //}
                
            }

        }

        private void DGV_Main_AnswerAI_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_MainUser.Rows.Count > 0)
            {
                 

                Main_chart.Series["SIMS"].Points.Clear();
                
                TB_Main_Social.Text = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_social_ai"].Value.ToString().Trim();
                show_chart(TB_Main_Social,0,"Social");
                TB_Main_Economical.Text = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_economical_ai"].Value.ToString().Trim();
                show_chart(TB_Main_Economical, 1, "Economical");
                TB_Main_Envirment.Text = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_Envirment_ai"].Value.ToString().Trim();
                show_chart(TB_Main_Envirment, 2, "Envirment");
                TB_Main_Influence.Text = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_influence_ai"].Value.ToString().Trim();
                show_chart(TB_Main_Influence, 3, "Influence");

                main_aai[0] = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_urc_ai"].Value.ToString().Trim();
                main_aai[1] = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_active_ai"].Value.ToString().Trim();

                main_aai[2] = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_socialflag_ai"].Value.ToString().Trim();
                show_color(TB_Main_Social);
                main_aai[3] = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_economicalflag_ai"].Value.ToString().Trim();
                show_color(TB_Main_Economical);
                main_aai[4] = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_Envirmentflag_ai"].Value.ToString().Trim();
                show_color(TB_Main_Envirment);
                main_aai[5] = DGV_Main_AnswerAI.Rows[e.RowIndex].Cells["main_influenceflag_ai"].Value.ToString().Trim();
                show_color(TB_Main_Influence);

            }
        }

        private void show_color(TextBox getName)
        {
            switch (int.Parse(getName.Text))
            {
                case 1:
                    getName.BackColor = Color.Red;
                    getName.ForeColor = Color.White;
                    break;
                case 2:
                    getName.BackColor = Color.Yellow;
                    getName.ForeColor = Color.Black;
                    break;
                case 3:
                    getName.BackColor = Color.LightGreen;
                    getName.ForeColor = Color.Black;
                    break;
                case 4:
                    getName.BackColor = Color.Green;
                    getName.ForeColor = Color.White;
                    break;
                default:
                    getName.BackColor = Color.Green;
                    getName.ForeColor = Color.White;
                    break;

            }

        }

        private void show_chart(TextBox get_Category,int _point,string name_Catecory)
        {
            string Values = get_Category.Text.Trim();
            Main_chart.Series["SIMS"].Points.Add(int.Parse(Values));
           
            switch(int.Parse(get_Category.Text.Trim()))
            {
                case 0:    // 0     
                    Main_chart.Series["SIMS"].Points[_point].Color = Color.Gray;
                    break;
                case 1:    // 1  red  
                    Main_chart.Series["SIMS"].Points[_point].Color = Color.Red;
                  //  Main_chart.Titles.Add("Not sustainability");
                    break;
                case 2:   // 2  yellow
                    Main_chart.Series["SIMS"].Points[_point].Color = Color.Yellow;
                    break;
                case 3:   // 3  LightGreen
                    Main_chart.Series["SIMS"].Points[_point].Color = Color.LightGreen;
                    break;
                case 4:  // 4  Green
                    Main_chart.Series["SIMS"].Points[_point].Color = Color.Green;
                    break;
                default:
                    Main_chart.Series["SIMS"].Points[_point].Color = Color.Green;
                    break;

            }
            Main_chart.Series["SIMS"].Points[_point].AxisLabel = ""+name_Catecory+"";
            Main_chart.Series["SIMS"].Points[_point].Label = "" + Values + "";
        }

        private void TSMI_About_Click(object sender, EventArgs e)
        {
            GUI.About GA = new GUI.About();
            GA.Show();
        }


        private void TSMI_toolbars_Click(object sender, EventArgs e)
        {
            // Main_ToolStrip.Visible = false;
            if (TSMI_toolbars.Checked == false)
            {
                TS_Main.Visible = true;
                TSMI_toolbars.CheckState = CheckState.Checked;
            }
            else
            {
                TS_Main.Visible = false;
                TSMI_toolbars.CheckState = CheckState.Unchecked;
            }
        }
    }
}

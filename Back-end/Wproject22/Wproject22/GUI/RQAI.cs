using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wproject22.GUI
{
    public partial class RQAI : Form
    {
        public RQAI()
        {
            InitializeComponent();
            DGV_SRAI_Result.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_urc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_social"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_socialflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_economical"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_economicalflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_envirment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_envirmentflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_influence"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SRAI_Result.Columns["sa_influenceflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TSB_SRQAIDelete.Enabled = false;
            TSB_SRQAISearch.Enabled = false;

        }

        private void GFRanswer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.project22DataSet.users);
            // TODO: This line of code loads data into the 'project22DataSet.Answer_AI' table. You can move, or remove it, as needed.
            this.answer_AITableAdapter.Fill(this.project22DataSet.Answer_AI);

        }

        private void TSB_QCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_ARAI_User_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string user_code = DGV_ARAI_User.Rows[e.RowIndex].Cells["user_urc"].Value.ToString().Trim();
            if (DGV_SRAI_Result.Rows.Count > 0)
            {
                var rows = DGV_SRAI_Result.Rows.OfType<DataGridViewRow>().Select(x => new { Value = x.Cells[1].Value.ToString(), Index = x.Index }).ToList();

                var indexs = rows.Where(w => w.Value == user_code).Select(s => s.Index).FirstOrDefault();
                answerAIBindingSource.Position = indexs;
            }

        }

        private void DGV_SRAI_Result_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_SRAI_Result.Rows.Count > 0)
            {
            Chart_AI.Series["Sustainability"].Points.Clear();

            string soc = DGV_SRAI_Result.Rows[e.RowIndex].Cells["sa_social"].Value.ToString().Trim();
              show_chart(soc, 0, "Social");

             string eco = DGV_SRAI_Result.Rows[e.RowIndex].Cells["sa_economical"].Value.ToString().Trim();
              show_chart(eco, 1, "Economical");

            string env = DGV_SRAI_Result.Rows[e.RowIndex].Cells["sa_envirment"].Value.ToString().Trim();
              show_chart(env, 2, "Envirment");

            string inf = DGV_SRAI_Result.Rows[e.RowIndex].Cells["sa_influence"].Value.ToString().Trim();
              show_chart(inf, 3, "Influence");
            }

        }

        private void show_chart(string get_Category, int _point, string name_Catecory)
        {
            string Values = get_Category.Trim();
            Chart_AI.Series["Sustainability"].Points.Add(int.Parse(Values));

            switch (int.Parse(get_Category.Trim()))
            {
                case 0:    // 0     
                    Chart_AI.Series["Sustainability"].Points[_point].Color = Color.Gray;
                    break;
                case 1:    // 1  red  
                    Chart_AI.Series["Sustainability"].Points[_point].Color = Color.Red;
                    break;
                case 2:   // 2  yellow
                    Chart_AI.Series["Sustainability"].Points[_point].Color = Color.Yellow;
                    break;
                case 3:   // 3  LightGreen
                    Chart_AI.Series["Sustainability"].Points[_point].Color = Color.LightGreen;
                    break;
                case 4:  // 4  Green
                    Chart_AI.Series["Sustainability"].Points[_point].Color = Color.Green;
                    break;
                default:
                    Chart_AI.Series["Sustainability"].Points[_point].Color = Color.Green;
                    break;

            }
            Chart_AI.Series["Sustainability"].Points[_point].AxisLabel = "" + name_Catecory + "";
            Chart_AI.Series["Sustainability"].Points[_point].Label = "" + Values + "";
        }

        private void MenuBar_TS_TSMI_Click(object sender, EventArgs e)
        {
            if (menuBar_TS_TSMI.Checked == false)
            {
                TS_SRQAI.Visible = true;
                menuBar_TS_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_SRQAI.Visible = false;
                menuBar_TS_TSMI.CheckState = CheckState.Unchecked;
            }
        }
    }
}

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
    public partial class AIReport : Form
    {
        public AIReport()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            DGV_SBAI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_urc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_social"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_socialflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_economical"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_economicalflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_envirnment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_envirnmentflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_influence"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_SBAI.Columns["sbai_influenceflag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TSB_SBAINew.Visible = false;
            TSB_SBAIDelete.Visible = false;
            TSB_SBAISearch.Enabled = false;
        }

        private void WFAI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.Answer_AI' table. You can move, or remove it, as needed.
            this.answer_AITableAdapter.Fill(this.project22DataSet.Answer_AI);
            //Chart_Social.Series["Social"].Points.AddXY("Social",5);
            //Chart_Economical.Series["Economical"].Points.AddXY("Economical", 5);
            //Chart_Envirment.Series["Envirment"].Points.AddXY("Envirment", 5);
            //Chart_Influence.Series["Influence"].Points.AddXY("Influence", 5);
            Chart_Social.Titles.Add("Social");
            Chart_Social.Series["Social"].Points.Add(4);
            Chart_Social.Series["Social"].Points[0].Color = Color.Green;
            Chart_Social.Series["Social"].Points[0].AxisLabel = "Social";
            Chart_Social.Series["Social"].Points[0].Label = "40 %";

            Chart_Social.Series["Social"].Points.Add(3);
            Chart_Social.Series["Social"].Points[1].Color = Color.LightGreen;
            Chart_Social.Series["Social"].Points[1].AxisLabel = "Social";
            Chart_Social.Series["Social"].Points[1].Label = "30 %";

            Chart_Social.Series["Social"].Points.Add(2);
            Chart_Social.Series["Social"].Points[2].Color = Color.Yellow;
            Chart_Social.Series["Social"].Points[2].AxisLabel = "Social";
            Chart_Social.Series["Social"].Points[2].Label = "20 %";

            Chart_Social.Series["Social"].Points.Add(1);
            Chart_Social.Series["Social"].Points[3].Color = Color.Red;
            Chart_Social.Series["Social"].Points[3].AxisLabel = "Social";
            Chart_Social.Series["Social"].Points[3].Label = "10 %";
            //--------------------------------------------------------------------
            Chart_Economical.Titles.Add("Economical");
            Chart_Economical.Series["Economical"].Points.Add(4);
            Chart_Economical.Series["Economical"].Points[0].Color = Color.Green;
            Chart_Economical.Series["Economical"].Points[0].AxisLabel = "Economical";
            Chart_Economical.Series["Economical"].Points[0].Label = "40 %";

            Chart_Economical.Series["Economical"].Points.Add(3);
            Chart_Economical.Series["Economical"].Points[1].Color = Color.LightGreen;
            Chart_Economical.Series["Economical"].Points[1].AxisLabel = "Economical";
            Chart_Economical.Series["Economical"].Points[1].Label = "30 %";

            Chart_Economical.Series["Economical"].Points.Add(2);
            Chart_Economical.Series["Economical"].Points[2].Color = Color.Yellow;
            Chart_Economical.Series["Economical"].Points[2].AxisLabel = "Economical";
            Chart_Economical.Series["Economical"].Points[2].Label = "20 %";

            Chart_Economical.Series["Economical"].Points.Add(1);
            Chart_Economical.Series["Economical"].Points[3].Color = Color.Red;
            Chart_Economical.Series["Economical"].Points[3].AxisLabel = "Economical";
            Chart_Economical.Series["Economical"].Points[3].Label = "10 %";

            //--------------------------------------------------------------------
            Chart_Envirment.Titles.Add("Envirnment");
            Chart_Envirment.Series["Envirment"].Points.Add(4);
            Chart_Envirment.Series["Envirment"].Points[0].Color = Color.Green;
            Chart_Envirment.Series["Envirment"].Points[0].AxisLabel = "Envirnment";
            Chart_Envirment.Series["Envirment"].Points[0].Label = "40 %";

            Chart_Envirment.Series["Envirment"].Points.Add(3);
            Chart_Envirment.Series["Envirment"].Points[1].Color = Color.LightGreen;
            Chart_Envirment.Series["Envirment"].Points[1].AxisLabel = "Envirnment";
            Chart_Envirment.Series["Envirment"].Points[1].Label = "30 %";

            Chart_Envirment.Series["Envirment"].Points.Add(2);
            Chart_Envirment.Series["Envirment"].Points[2].Color = Color.Yellow;
            Chart_Envirment.Series["Envirment"].Points[2].AxisLabel = "Envirnment";
            Chart_Envirment.Series["Envirment"].Points[2].Label = "20 %";

            Chart_Envirment.Series["Envirment"].Points.Add(1);
            Chart_Envirment.Series["Envirment"].Points[3].Color = Color.Red;
            Chart_Envirment.Series["Envirment"].Points[3].AxisLabel = "Envirnment";
            Chart_Envirment.Series["Envirment"].Points[3].Label = "10 %";
            //--------------------------------------------------------------------
            Chart_Influence.Titles.Add("Influence");
            Chart_Influence.Series["Influence"].Points.Add(4);
            Chart_Influence.Series["Influence"].Points[0].Color = Color.Green;
            Chart_Influence.Series["Influence"].Points[0].AxisLabel = "Influence";
            Chart_Influence.Series["Influence"].Points[0].Label = "40 %";

            Chart_Influence.Series["Influence"].Points.Add(3);
            Chart_Influence.Series["Influence"].Points[1].Color = Color.LightGreen;
            Chart_Influence.Series["Influence"].Points[1].AxisLabel = "Influence";
            Chart_Influence.Series["Influence"].Points[1].Label = "30 %";

            Chart_Influence.Series["Influence"].Points.Add(2);
            Chart_Influence.Series["Influence"].Points[2].Color = Color.Yellow;
            Chart_Influence.Series["Influence"].Points[2].AxisLabel = "Influence";
            Chart_Influence.Series["Influence"].Points[2].Label = "20 %";

            Chart_Influence.Series["Influence"].Points.Add(1);
            Chart_Influence.Series["Influence"].Points[3].Color = Color.Red;
            Chart_Influence.Series["Influence"].Points[3].AxisLabel = "Influence";
            Chart_Influence.Series["Influence"].Points[3].Label = "10 %";

        }

        private void TSB_AISearch_Click(object sender, EventArgs e)
        {
            GUI_Search.FSE_AnswerAI GFSEAI = new GUI_Search.FSE_AnswerAI();
            Style.Form_Position.Form_On_Left(this, GFSEAI);
            GFSEAI.Show();
        }

        private void TSB_ACancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBar_TS_TSMI_Click(object sender, EventArgs e)
        {
            if (menuBar_TS_TSMI.Checked == false)
            {
                TS_AIReport.Visible = true;
                menuBar_TS_TSMI.CheckState = CheckState.Checked;
            }
            else
            {
                TS_AIReport.Visible = false;
                menuBar_TS_TSMI.CheckState = CheckState.Unchecked;
            }
        }
    }
}

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

namespace Wproject22.GUI_Search
{
    public partial class FSE_Answer : Form
    {
        public event EventHandler<EV_Answer> Search_TextBox_Answer;
        public event EventHandler<EV_Answer> Which_TextBox_Answer;
        public FSE_Answer()
        {
            InitializeComponent();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public void OnChangeSearchB_Cancel(EV_Button e)
        //{
        //    try
        //    {
        //        Search_TextBox_Answer?.Invoke(this, e);
        //    }
        //    catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        //public void OnWhich_B_Cancel(EV_Button e)
        //{
        //    try
        //    {
        //        Which_TextBox_Answer?.Invoke(this, e);
        //    }
        //    catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void OnChangeSearchTB_Answer(EV_Answer e)
        {
            try
            {
                Search_TextBox_Answer?.Invoke(this, e);
            }
            catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void OnWhich_TextBox_Answer(EV_Answer e)
        {
            try
            {
                Which_TextBox_Answer?.Invoke(this, e);
            }catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        }

        private void TB_SAnswerID_TextChanged(object sender, EventArgs e)
        {
            EV_Answer TBSAnswerID = new EV_Answer(TB_SAnswerID);
            OnWhich_TextBox_Answer(TBSAnswerID);
            OnChangeSearchTB_Answer(TBSAnswerID);
        }

        private void TB_SA_URC_TextChanged(object sender, EventArgs e)
        {
            EV_Answer TBSA_URC = new EV_Answer(TB_SA_URC);
            OnWhich_TextBox_Answer(TBSA_URC);
            OnChangeSearchTB_Answer(TBSA_URC);
        }

        private void TB_SAQuestionID_TextChanged(object sender, EventArgs e)
        {
            EV_Answer TBSAQuestionID = new EV_Answer(TB_SAQuestionID);
            OnWhich_TextBox_Answer(TBSAQuestionID);
            OnChangeSearchTB_Answer(TBSAQuestionID);
        }

        private void TB_SADate_TextChanged(object sender, EventArgs e)
        {
            EV_Answer TBSADate = new EV_Answer(TB_SADate);
            OnWhich_TextBox_Answer(TBSADate);
            OnChangeSearchTB_Answer(TBSADate);
        }

        private void TB_SAQuestion_TextChanged(object sender, EventArgs e)
        {
            EV_Answer TBSAQuestion = new EV_Answer(TB_SAQuestion);
            OnWhich_TextBox_Answer(TBSAQuestion);
            OnChangeSearchTB_Answer(TBSAQuestion);
        }

    }
}

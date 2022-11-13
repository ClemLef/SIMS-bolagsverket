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
    public partial class FSE_Question : Form
    {
        public event EventHandler<EV_Question> Search_TextBox_Question;
        public event EventHandler<EV_Question> Which_TextBox_Question;

        public event EventHandler<EV_Button> Search_Button_Question;
        public event EventHandler<EV_Button> Which_Button_Question;

        public FSE_Question()
        {
            InitializeComponent();
            CB_IAQuestion.Enabled = false;
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            EV_Button Button_Cancel = new EV_Button(true, B_Cancel);
            OnWhich_B_Cancel(Button_Cancel);
            OnChangeSearchB_Cancel(Button_Cancel);
            this.Close();
        }
        public void OnChangeSearchB_Cancel(EV_Button e)
        {
            try
            {
                Search_Button_Question?.Invoke(this, e);
            }
            catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void OnWhich_B_Cancel(EV_Button e)
        {
            try
            {
                Which_Button_Question?.Invoke(this, e);
            }
            catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void OnChangeSearchTB_Question(EV_Question e)
        {
            try
            {
             Search_TextBox_Question?.Invoke(this, e);
            }catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void OnWhich_TextBox_Question(EV_Question e)
        {
            try
            {
             Which_TextBox_Question?.Invoke(this, e);
            }catch (Exception OnActiveLAButtonds) { Write_Exception.EWrite_Exception(OnActiveLAButtonds); }
        }
        private void TB_QuestionCode_TextChanged(object sender, EventArgs e)
        {
            EV_Question QuestionCode = new EV_Question(TB_QuestionCode);
            OnWhich_TextBox_Question(QuestionCode);
            OnChangeSearchTB_Question(QuestionCode);
        }
        private void TB_CategoryID_TextChanged(object sender, EventArgs e)
        {
            EV_Question CategoryID = new EV_Question(TB_CategoryID);
            OnWhich_TextBox_Question(CategoryID);
            OnChangeSearchTB_Question(CategoryID);
        }
        private void TB_QuestionText_TextChanged(object sender, EventArgs e)
        {
            EV_Question QuestionText = new EV_Question(TB_QuestionText);
            OnWhich_TextBox_Question(QuestionText);
            OnChangeSearchTB_Question(QuestionText);
        }

       
    }
}

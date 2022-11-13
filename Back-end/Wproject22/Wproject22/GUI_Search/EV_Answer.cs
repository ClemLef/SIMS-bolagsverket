using System;
using System.Windows.Forms;
using Utilities.Classes;

namespace Wproject22.GUI_Search
{
    public class EV_Answer : EventArgs
    {
        private string Search_TextBox_Answer;
        private string Name_TextBox_Answer;
        /// <summary>
        /// Set and get value 
        /// </summary>
        /// <param name="TBName"></param>
        public EV_Answer(TextBox TBName)
        {
            try
            {
                switch (TBName.Name)
                {
                    case "TB_SAnswerID":
                        SGNA_TextBox_Answer = TBName.Text.Trim();
                        SGWhich_TextBox_Answer = TBName.Name;
                        break;
                    case "TB_SA_URC":
                        SGNA_TextBox_Answer = TBName.Text.Trim();
                        SGWhich_TextBox_Answer = TBName.Name;
                        break;
                    case "TB_SAQuestionID":
                        SGNA_TextBox_Answer = TBName.Text.Trim();
                        SGWhich_TextBox_Answer = TBName.Name;
                        break;
                    case "TB_SADate":
                        SGNA_TextBox_Answer = TBName.Text.Trim();
                        SGWhich_TextBox_Answer = TBName.Name;
                        break;
                    case "TB_SAQuestion":
                        SGNA_TextBox_Answer = TBName.Text.Trim();
                        SGWhich_TextBox_Answer = TBName.Name;
                        break;
                }
            }
            catch (Exception TB) { Write_Exception.EWrite_Exception(TB); }

        }
        /// <summary>
        /// Set and Get Value
        /// </summary>
        public string SGNA_TextBox_Answer
        {
            get { return Search_TextBox_Answer; }
            set { Search_TextBox_Answer = value; }
        }
        /// <summary>
        /// Set and Get Value
        /// </summary>
        public string SGWhich_TextBox_Answer
        {
            get { return Name_TextBox_Answer; }
            set { Name_TextBox_Answer = value; }
        }
    }
}

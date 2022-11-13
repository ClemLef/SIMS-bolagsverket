using System;
using System.Windows.Forms;
using Utilities.Classes;

namespace Wproject22.GUI_Search
{
    public class EV_Question : EventArgs
    {
        /// <summary>
        /// Default Value
        /// </summary>
        private string Search_TextBox_Question;
        private string Name_TextBox_Question;
        /// <summary>
        /// Set and get value 
        /// </summary>
        /// <param name="TBName"></param>
        public EV_Question(TextBox TBName)
        {
            try
            {
                switch (TBName.Name)
                {
                    case "TB_QuestionCode":
                        SGNA_TextBox_Question = TBName.Text.Trim();
                        SGWhich_TextBox_Question = TBName.Name;
                        break;
                    case "TB_CategoryID":
                        SGNA_TextBox_Question = TBName.Text.Trim();
                        SGWhich_TextBox_Question = TBName.Name;
                        break;
                    case "TB_QuestionText":
                        SGNA_TextBox_Question = TBName.Text.Trim();
                        SGWhich_TextBox_Question = TBName.Name;
                        break;
                    //case "TB_Question":
                    //    SGNA_TextBox_Question = TBName.Text.Trim();
                    //    SGWhich_TextBox_Question = TBName.Name;
                    //    break;
                }
            }catch (Exception TB) { Write_Exception.EWrite_Exception(TB); }
            
        }
        /// <summary>
        /// Set and Get Value
        /// </summary>
        public string SGNA_TextBox_Question
        {
            get { return Search_TextBox_Question; }
            set { Search_TextBox_Question = value; }
        }
        /// <summary>
        /// Set and Get Value
        /// </summary>
        public string SGWhich_TextBox_Question
        {
            get { return Name_TextBox_Question; }
            set { Name_TextBox_Question = value; }
        }
    }
}

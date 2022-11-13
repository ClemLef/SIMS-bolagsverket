using System;
using System.Windows.Forms;
using Utilities.Classes;

namespace Wproject22.GUI_Search
{
    public  class EV_Button : EventArgs
    {
        /// <summary>
        /// Default Value
        /// </summary>
        private string Search_Button;
        private string Name_Button;
        private Boolean EN_TF;
        public EV_Button(Boolean get, Button Button_Name)
        {
            try
            {
                SGNA_Name_Button = Button_Name.Text.Trim();
                SGWhich_Name_Button = get;
           //     Button_Name.Enabled = true;
            }
            catch (Exception TB) { Write_Exception.EWrite_Exception(TB); }
        }
        /// <summary>
        /// Set and Get Value
        /// </summary>
        public string SGNA_Name_Button
        {
            get { return Search_Button; }
            set { Name_Button = value; }
        }
        /// <summary>
        /// Set and Get Value
        /// </summary>
        public Boolean SGWhich_Name_Button
        {
            get { return EN_TF; }
            set { EN_TF = value; }
        }
    }
}

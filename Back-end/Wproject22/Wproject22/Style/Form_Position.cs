using System;
using System.Windows.Forms;
using System.Drawing;

namespace Wproject22.Style
{
    class Form_Position
    {
        /// <summary>
        /// Set form on left of main form
        /// </summary>
        /// <param name="Main_Form"></param>
        /// <param name="FO_Left"></param>
        public static void Form_On_Left(Form Main_Form, Form FO_Left)
        {
            try
            {
                FO_Left.StartPosition = FormStartPosition.Manual;
                FO_Left.Location = new Point(Main_Form.Left + Main_Form.Width, Main_Form.Top);

            }
            catch { throw; }
        }
    }
}

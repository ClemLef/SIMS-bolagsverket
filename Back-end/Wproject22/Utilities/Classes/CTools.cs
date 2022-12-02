using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Utilities.Classes
{
    public class CTools
    {
        public static string error = string.Empty;

        /// <summary>
        ///  This method check value in TextBox
        /// </summary>
        /// <param name="ErrorP"></param>
        /// <param name="Get_TextBox"></param>
        public static bool Set_GetError(ErrorProvider ErrorP, TextBox Get_TextBox)
        {

            if (Get_TextBox.Text.Trim().Length == 0)
            {
                ErrorP.SetError(Get_TextBox, error_medd(0, error));
                return true;
            }
            ErrorP.SetError(Get_TextBox, "");

            switch (Get_TextBox.Name.ToString())
            {
                case "TB_CourseID":
                    Match TB_Str = Regex.Match(Get_TextBox.Text, @"^[a-zA-Z\d\såöäÅÖÄ-]*$");
                    if (!TB_Str.Success)
                    {
                        ErrorP.SetError(Get_TextBox, error_medd(1, error));
                        return true;
                    }
                    ErrorP.SetError(Get_TextBox, "");

                    break;

                case "TB_CourseName":

                    Match TB_Dis = Regex.Match(Get_TextBox.Text, @"^[a-zA-Z\d\såöäÅÖÄ+#-]*$");
                    if (!TB_Dis.Success)
                    {
                        ErrorP.SetError(Get_TextBox, error_medd(1, error));
                        return true;
                    }
                    ErrorP.SetError(Get_TextBox, "");
                    break;

                case "TB_ModuleName":

                    Match Quantity = Regex.Match(Get_TextBox.Text, @"^[a-zA-Z\d\såöäÅÖÄ;-]*$");
                    if (!Quantity.Success)
                    {
                        ErrorP.SetError(Get_TextBox, error_medd(1, error));
                        return true;
                    }
                    ErrorP.SetError(Get_TextBox, "");
                    break;

            }
            return false;
        }

        /// <summary>
        ///  This method show error message
        /// </summary>
        /// <param name="E"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        private static string error_medd(int E, string ps)
        {
            switch (E)
            {
                case 0:
                    ps = " Please write correct text.!!! ";
                    break;
                case 1:
                    ps = "Please write valid character. !!! ";
                    break;
                case 2:
                    ps = "Please write valid number. !!! ";
                    break;
            }
            return ps;
        }
        /// <summary>
        /// Change first character to upper
        /// </summary>
        /// <param name="FCTUpper"></param>
        /// <returns></returns>
        private static string FirstCharToUpper(string FCTUpper)
        {
            if (string.IsNullOrEmpty(FCTUpper))
                throw new ArgumentException("This is wrong!");
            return FCTUpper.First().ToString().ToUpper() + string.Join("", FCTUpper.Skip(1));

        }

    }
}

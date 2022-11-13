using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;

namespace Wproject22.Classes
{
    class CException
    {
        static StreamWriter sw_G = null;
        public static Boolean erorr_programs(ref Exception exs)
        {
            try
            {
                //----------------------------------------------------
                string MyConString = "server=localhost;User Id=root;password=100;Persist Security Info=True;database=project22";
                MySql.Data.MySqlClient.MySqlConnection connections = new MySql.Data.MySqlClient.MySqlConnection(MyConString);
                MySql.Data.MySqlClient.MySqlCommand commands = connections.CreateCommand();
                connections.Open();
                //----------------------------------------------------
                StackTrace st = new StackTrace(exs, true);
                StackFrame[] frames = st.GetFrames();

                FileInfo G_sw = new FileInfo(@"c:\\web\\AWerror.txt");
                if (!G_sw.Exists)
                {
                    sw_G = File.CreateText(@"c:\\web\\AWerror.txt"); sw_G.Close();
                }

                //--------------------------------------------------------------------
                using (StreamWriter fs = new StreamWriter(@"d:\\web\\AWerror.txt", true))
                {
                    foreach (StackFrame frame in frames)
                    {
                        string[] date_time = new string[2] { "" + DateTime.Now.ToString("yyyy/MM/dd") + "", "" + string.Format("{0:HH:mm:ss}", DateTime.Now) + "" };
                        fs.WriteLine("{0}:{1}({2},{3},{4},{5})", frame.GetFileName(), frame.GetMethod().Name, frame.GetFileLineNumber(), frame.GetFileColumnNumber() + ")", "[" + date_time[0] + "]", "[" + date_time[1] + "]");

                        string ett = "INSERT INTO `project22`.`web_erorr`(`ero_filename`,`ero_metod`,`ero_line`,`ero_columnNr`,`ero_datum`,`ero_tid`,`ero_comment`)";
                        string tvo = " values('" + Convert.ToString(frame.GetFileName()) + "','" + Convert.ToString(frame.GetMethod().Name) + "','" + frame.GetFileLineNumber() + "','" + frame.GetFileColumnNumber() + "','" + date_time[0] + "','" + date_time[1] + "','');";
                        commands.CommandText = ett + tvo;
                        commands.ExecuteNonQuery();
                    }

                    fs.Close();
                    connections.Close();
                }
                //-----------------------------------------------------------------------------------------------------
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}

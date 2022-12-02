/*
 * Malmö högskola
 * C# III
 * Assignment 3
 * Luctur:Farid Naisan & Stig-Bertil Gunnarsson
 * @author Ahmad Setoodeh
 * 2018-02-10
 * @version 1.0
 * Filnamn :Write_Exception.cs
 */
using System;
using System.IO;
using System.Windows.Forms;


namespace Utilities.Classes
{
    public class Write_Exception
    {
        /// <summary>
        /// default constractor
        /// </summary>
        public Write_Exception() { }
        /// <summary>
        ///  Write Exception in file
        /// </summary>
        /// <param name="WE"></param>
        public static void EWrite_Exception(Exception WE)
        {
            try
            {
                CPath EWE = new CPath();
                string Path_EW = EWE.Current_Paths() + "\\Logs";
                if (!Directory.Exists(Path_EW))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(Path_EW);
                }
                string filename = Path_EW + @"\project_error.txt";

                if (!File.Exists(filename))
                {
                    File.Create(filename).Dispose();
                }
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.WriteLine("Error Message: " + DateTime.Now + " :" + WE.Message);
                    sw.WriteLine("Stack Trace: " + DateTime.Now + " :" + WE.StackTrace + "/n");
                }
                MessageBox.Show("Error Message: " + WE.Message + "/n" + WE.StackTrace);
            }
            catch (IOException io)
            {
                MessageBox.Show(io.ToString());
            }
            catch (Exception WEX)
            {
                MessageBox.Show(WEX.ToString());
                //  EWrite_Exception(WEX);
            }
        }
    }
}

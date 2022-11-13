/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * 
 * Luctur: Magnus Eriksson
 * 
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :CPath.cs
 */
using System;
using System.Windows.Forms;
using System.IO;


namespace Wproject22.Classes
{
    public class C_Path
    {
        private string MPath = string.Empty;
        private string MFolder = string.Empty;

        /// <summary>
        ///  Default constractor for CPath
        /// </summary>
        public C_Path() { }

        public string Current_Paths()
        {
            string APath = Application.StartupPath;
            MPath = Path.GetFullPath(APath);
            return MPath;
        }
        //---------------------------------------------------------------
        /// <summary>
        /// Check each folder for save files
        /// </summary>
        /// <param name="Paths"></param>
        /// <returns></returns>
        public string Check_Path(string Paths)
        {
            if (!Directory.Exists(Paths))
            {
                Directory.CreateDirectory(Paths);
            }
            return Paths;
        }
        /// <summary>
        /// Get default path and return that
        /// </summary>
        /// <returns></returns>
        public string Default_Path()
        {
            SGMPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            SGMFolder = Path.GetDirectoryName(SGMPath);
            return SGMFolder;
        }
        //---------------------------------------------------------------
        /// <summary>
        ///  test to get information about file
        /// </summary>
        /// <param name="GFileName"></param>
        /// <returns></returns>
        public string Check_FileName(string GFileName)
        //public static string Check_FileName(string GFileName)
        {
            FileInfo fileInfo = new FileInfo(GFileName);
            if (!fileInfo.Exists)
            {
              //   GFileName = GFileName+fileInfo.CreationTime.ToString("yyyyMMddHHmmss");
                GFileName = GFileName + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
           //string Consol = (fileInfo.DirectoryName);
            //var fLastTime = fileInfo.LastWriteTime;
            return GFileName;
        }

        /// <summary>
        ///  Set and Get Destination for file
        /// </summary>
        public string SGMPath
        {
            get { return MPath; }

            set { MPath = value; }
        }
        /// <summary>
        ///  Set and Get for folder
        /// </summary>
        public string SGMFolder
        {
            get { return MFolder; }

            set { MFolder = value; }
        }
    }
}

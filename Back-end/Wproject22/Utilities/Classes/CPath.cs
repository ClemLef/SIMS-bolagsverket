/*
 * Malmö högskola
 * C# III
 * Assignment 3
 * Luctur:Farid Naisan & Stig-Bertil Gunnarsson
 * @author Ahmad Setoodeh
 * 2018-02-10
 * @version 1.0
 * Filnamn :CPath.cs
 */
using System;
using System.IO;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities.Classes
{
    public class CPath
    {
        private string MPath = string.Empty;
        private string MFolder = string.Empty;

        /// <summary>
        ///  Default constractor for CPath
        /// </summary>
        public CPath()
        {
        }

        public string Current_Paths()
        {
            try
            {
                string APath = Application.StartupPath;
                MPath = Path.GetFullPath(APath);

            }
            catch (Exception Current_Paths)
            { Write_Exception.EWrite_Exception(Current_Paths); }
            return MPath;
        }
        //---------------------------------------------------------------
        /// <summary>
        /// Check each folder for save files
        /// </summary>
        /// <param name="Paths"></param>
        /// <returns></returns>
        public static string Check_Path(string Paths)
        {
            try
            {
                if (!Directory.Exists(Paths))
                {
                    Directory.CreateDirectory(Paths);
                }
            }
            catch (Exception CheckPath)
            { Write_Exception.EWrite_Exception(CheckPath); }

            return Paths;
        }
        /// <summary>
        /// Get default path and return that
        /// </summary>
        /// <returns></returns>
        public string Default_Path()
        {
            try
            {
                SGMPath = System.Reflection.Assembly.GetEntryAssembly().Location;
                SGMFolder = Path.GetDirectoryName(SGMPath);
            }
            catch (Exception DefaultPath)
            { Write_Exception.EWrite_Exception(DefaultPath); }

            return SGMFolder;
        }
        //---------------------------------------------------------------
        /// <summary>
        ///  test to get information about file
        /// </summary>
        /// <param name="GFileName"></param>
        /// <returns></returns>
        public static string Check_FileName(string GFileName)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(GFileName);
                if (fileInfo.Exists)
                {
                    string CreateTime = fileInfo.CreationTime.ToString("yyyyMMddHHmmss");
                }
                string Consol = (fileInfo.DirectoryName);
                var fLastTime = fileInfo.LastWriteTime;
            }
            catch (Exception CheckFileName)
            { Write_Exception.EWrite_Exception(CheckFileName); }

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

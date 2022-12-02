using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Utilities.Classes
{
    class CExecuteScalar
    {
        public static string execute_table(ref string query, MySqlConnection CExe)
        {
            string valuestads = string.Empty;
            try
            {
                if (CExe.State != System.Data.ConnectionState.Open)
                    CExe.Open();

                MySqlCommand executes = new MySqlCommand(query, CExe);
                valuestads = Convert.ToString(executes.ExecuteScalar());

                return valuestads;
            }
            //------------------------------------------------------------------------
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // webprojects.AllClass.CException.erorr_programs(ref ex);
            }
            return valuestads;
        }

        public static MySqlDataReader reader_table(ref string query, MySqlConnection CExe)
        {
            MySqlDataReader value_reader = null;// new MySqlDataReader();
            
            try
            {
                if (CExe.State != System.Data.ConnectionState.Open)
                    CExe.Open();
               
                MySqlCommand MSC = new MySqlCommand(query, CExe);
                value_reader = MSC.ExecuteReader();

                return value_reader;
            }
            //------------------------------------------------------------------------
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // webprojects.AllClass.CException.erorr_programs(ref ex);
            }
            return value_reader;
        }
    }
}

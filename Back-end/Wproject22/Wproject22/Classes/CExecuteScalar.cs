using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wproject22.Classes
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
    }
}

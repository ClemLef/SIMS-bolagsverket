using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wproject22.Classes
{
    class C_Connection
    {
        public static Boolean connection_table(string open_close, MySql.Data.MySqlClient.MySqlConnection con)
        {
            try
            {
                //------------------------------------------------------------------------
                // om det ska bli öppet connection 
                //------------------------------------------------------------------------
                if (open_close == "open")
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }
                }
                //------------------------------------------------------------------------
                // om det ska stänga connection 
                //------------------------------------------------------------------------
                else
                {
                    if (con.State != System.Data.ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
                return true;
            }
            //------------------------------------------------------------------------
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


    }
}

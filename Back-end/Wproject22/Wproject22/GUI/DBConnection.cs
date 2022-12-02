using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Wproject22.GUI
{
    public partial class DBConnection : Form
    {
        private bool MainConnection = false;
        private string DB_Database_name = "project22";
        private bool mb_connecttestsuccessfull = false;
        private Timer timer = new Timer();
        private int counter = 5;
        
        public DBConnection()
        {
            InitializeComponent();
            WDatabas.SelectedIndex = 0;
            
        }


        private void B_TestConnection_Click(object sender, EventArgs e)
        {
            string button_str = string.Empty;
            if (B_TestConnection.Text.Length > 15)
            {
                button_str = B_TestConnection.Text.Substring(0, 12);// "Connected OK"; 
            }
            else
            {
                button_str = B_TestConnection.Text;

            }
            switch (button_str)
            {
                case "Test Connection":
                    B_TestConnection.Enabled = false;
                    _connected(""+ DB_Database_name + "");

                    break;
                case "Connected OK":
                    B_TestConnection.Enabled = true;
                    timer1.Stop();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
            }

        }
        private void DBConnection_Load(object sender, EventArgs e)
        {

            DB_Database_name = WDatabas.SelectedItem.ToString();
            this.MaximizeBox = false;
            string Connection_Server = (string)Properties.Settings.Default[""+ DB_Database_name + "ConnectionString"];

            if (!(Connection_Server.Equals(string.Empty) || Connection_Server == null))
            {
                _parseconnectstring(Connection_Server, ""+ DB_Database_name + "");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string User
        {
            get { return WUser.Text; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Server
        {
            get { return WServer.Text; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Passwrd
        {
            get { return WPassword.Text; }
        }
        //----------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Str_Con"></param>
        /// <param name="Web"></param>
        private void _parseconnectstring(string Str_Con, string Web)
        {

            string[] values = Str_Con.Split(';');


            for (int i = 0; i < values.Length; i++)
            {
                string paramname = string.Empty;
                string paramvalue = string.Empty;

                string[] connparams = values[i].Split('=');
                if (connparams.Length > 1)
                {
                    paramname = connparams[0].Trim();
                    paramvalue = connparams[1].Trim();
                }
                else
                {
                    paramname = connparams[0].Trim();
                    paramvalue = string.Empty;
                }

                switch (paramname.ToLower().Trim())
                {
                    case "server":
                        WServer.Text = paramvalue;
                        break;
                    case "user":
                    case "user id":
                        WUser.Text = paramvalue;
                        break;
                    case "password":
                        WPassword.Text = paramvalue;
                        break;
                    case "database":
                        WDatabas.Text = paramvalue;
                        break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="GWeb"></param>
        /// <returns></returns>
        private string _getconnectstring(string GWeb)
        {
            string Server_Str = string.Empty;
            if (WServer.Text == string.Empty || WUser.Text == string.Empty)
            {
                return string.Empty;
            }
            switch (GWeb)
            {
                case "project22":

                    Server_Str = "server=" + WServer.Text + ";User Id=" + WUser.Text + ";password=" + WPassword.Text + ";";
                    Server_Str += "Persist Security Info=True;";
                    if (WDatabas.SelectedItem != null || WDatabas.Text != string.Empty)
                    {
                        Server_Str += "database=" + WDatabas.Text;
                    }
                    break;
            }
            return Server_Str;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Web"></param>
        /// <returns></returns>
        private bool _connected(string Web)
        {
            mb_connecttestsuccessfull = false;

            try
            {
                string connectstring = _getconnectstring(Web);
                MySqlConnection con = new MySqlConnection(connectstring);
                con.Open();
                if (con.State != ConnectionState.Open)
                {
                    throw new Exception("Could not open connection. ConnectionState=" + con.State.ToString());
                }
                else
                {
                    mb_connecttestsuccessfull = true;
                }

                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", con);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    switch (Web)
                    {
                        case "project22":
                            WDatabas.Items.Add(reader.GetString(0));

                            break;
                    }
                }
                WDatabas.SelectedIndex = 1;
                reader.Close();
                reader.Dispose();
                con.Close();
                con.Dispose();
                MainConnection = mb_connecttestsuccessfull;
            }
            catch (Exception ex)
            {
                MessageBox.Show("[Function Erorr :" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]\n" + ex.Message);
                B_TestConnection.Enabled = true;
                SG_MainConnection = false;
                this.DialogResult = DialogResult.None;

            }
            finally
            {

                if (mb_connecttestsuccessfull)
                {
                    switch (Web)
                    {
                        case "project22":
                        //    B_TestConnection.Image = Properties.Resources.connect_icon24;
                            B_TestConnection.Text = "Connected OK";
                            B_TestConnection.Enabled = true;
                            SG_Database_name = WDatabas.Text;
                            timer.Interval = 10000;
                            timer.Tick += new EventHandler(Timer1_Tick);
                            timer.Start();
                            B_TestConnection.Text = "Connected OK (" + counter.ToString() + ")";

                            break;
                    }

                }
                else
                {
                    switch (Web)
                    {
                        case "project22":
                            B_TestConnection.Text = "Test connection";
                            break;
                    }

                }
            }
            return mb_connecttestsuccessfull;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool SG_MainConnection
        {
            get { return MainConnection; }
            set { MainConnection = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SG_Database_name
        {
            get { return DB_Database_name; }
            set { DB_Database_name = value; }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            B_TestConnection.Text = "Connected OK (" + counter.ToString() + ")";

        }
    }
}

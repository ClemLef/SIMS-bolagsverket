using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Classes;
using MySql.Data.MySqlClient;

namespace Utilities
{
    public partial class TestUnit : Form
    {
        private int end = 0;
        public static Random r = new Random();
        public TestUnit()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.project22DataSet1.users);
             // TODO: This line of code loads data into the 'project22DataSet.ai_result' table. You can move, or remove it, as needed.
            this.ai_resultTableAdapter.Fill(this.project22DataSet.ai_result);
            // TODO: This line of code loads data into the 'project22DataSet.result_question' table. You can move, or remove it, as needed.
            this.result_questionTableAdapter.Fill(this.project22DataSet.result_question);
 
        }
        private void B_CreateUsers_Click(object sender, EventArgs e)
        {
            end = int.Parse(TB_CreateUser.Text.Trim());
            int Min = 0;
            int Max = 9;
            for (int j = 0; j < end; j++)
            {
                C_DateTime CDT = new C_DateTime();
                Random randNum = new Random();
                int[] test2 = Enumerable.Repeat(0, 7).Select(i => randNum.Next(Min, Max)).ToArray();
                string myStringOutput = String.Join("", test2.Select(p => p.ToString()).ToArray());

                richTextBox1.Text += myStringOutput + "," + CDT.SGDate + "," + CDT.SGTime + "," + "1\n";

                string ett = "INSERT INTO users(urc,us_date,us_time,active)";
                string tvo = " values('" + myStringOutput + "','"
                                         + CDT.SGDate + "','"
                                         + CDT.SGTime + "','1');";
                string tre = ett + tvo;

                C_Connection.connection_table("open", usersTableAdapter.Connection);
                CExecuteScalar.execute_table(ref tre, usersTableAdapter.Connection);
                C_Connection.connection_table("close", usersTableAdapter.Connection);
                System.Threading.Thread.Sleep(50);
            }
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // count users in table
            //-------------------------------------------------------------------
            string get_user_count = "SELECT COUNT(id)FROM users; ";
            string count_users = string.Empty;
            C_Connection.connection_table("open", usersTableAdapter.Connection);
            count_users= CExecuteScalar.execute_table(ref get_user_count, usersTableAdapter.Connection);
            C_Connection.connection_table("close", usersTableAdapter.Connection);
            //-------------------------------------------------------------------
            string get_user_urc = "SELECT urc FROM users; ";
            MySqlDataReader users_urc = null;
            LinkedList<String> users_list = new LinkedList<String>();

            C_Connection.connection_table("open", usersTableAdapter.Connection);
            users_urc = CExecuteScalar.reader_table(ref get_user_urc, usersTableAdapter.Connection);
            while (users_urc.Read())
            {
                users_list.AddLast(users_urc[0].ToString());
            }
            C_Connection.connection_table("close", usersTableAdapter.Connection);

            end = int.Parse(count_users.Trim());
            int Min = 1;
            int Max = 5;
            C_Connection.connection_table("open", result_questionTableAdapter.Connection);
            foreach (string str_user in users_list)
            {
                C_DateTime CDT = new C_DateTime();
                Random randNum = new Random();
                int[] test2 = Enumerable.Repeat(0, 4).Select(i => randNum.Next(Min, Max)).ToArray();
                string myStringOutput = String.Join("','", test2.Select(p => p.ToString()).ToArray());

                richTextBox2.Text += str_user + "," + myStringOutput + "," + CDT.SGDate + "," + CDT.SGTime + "," + "1\n";

                string ett = "INSERT INTO result_question(urc,social,economical,envirment,influence,date,time,active)";
                string tvo = " values('"+str_user + "','" + myStringOutput + "','"
                                         + CDT.SGDate + "','"
                                         + CDT.SGTime + "','1');";
                string tre = ett + tvo;


                CExecuteScalar.execute_table(ref tre, result_questionTableAdapter.Connection);

                System.Threading.Thread.Sleep(50);
            }
            C_Connection.connection_table("close", result_questionTableAdapter.Connection);
        }

        private void B_AI_result_Click(object sender, EventArgs e)
        {
          //  Dictionary<string, string[]> Dic_ai = new Dictionary<string, string[]>();
            // count users in table
            //-------------------------------------------------------------------
            string get_result_questionr_count = "SELECT COUNT(id)FROM result_question; ";
            string count_result_question = string.Empty;
            C_Connection.connection_table("open", result_questionTableAdapter.Connection);
            count_result_question = CExecuteScalar.execute_table(ref get_result_questionr_count, result_questionTableAdapter.Connection);
            C_Connection.connection_table("close", result_questionTableAdapter.Connection);
            //-------------------------------------------------------------------

            string get_user_urc = "SELECT ID,urc,social,economical,envirment,influence FROM result_question; ";
            MySqlDataReader urc_result = null;
            LinkedList<String> result_list = new LinkedList<String>();

            C_Connection.connection_table("open", result_questionTableAdapter.Connection);
            urc_result = CExecuteScalar.reader_table(ref get_user_urc, result_questionTableAdapter.Connection);
            while (urc_result.Read())
            {
                result_list.AddLast(urc_result[0].ToString() + "," + urc_result[1].ToString() + ","
                                   + urc_result[2].ToString() + "," + urc_result[3].ToString() + ","
                                   + urc_result[4].ToString() + "," + urc_result[5].ToString() + "" );

                richTextBox1.Text += urc_result[0].ToString()+"," + urc_result[1].ToString() + "," 
                                   + urc_result[2].ToString() + "," + urc_result[3].ToString() + "," 
                                   + urc_result[4].ToString() + "," + urc_result[5].ToString() + "\n";
            }
            C_Connection.connection_table("close", result_questionTableAdapter.Connection);

            string[] str_re =new string[6];
            string[] str_flag = new string[6];
            C_Connection.connection_table("open", ai_resultTableAdapter.Connection);
            foreach (string str_result in result_list)
            {
                // str_flag = null;
                // string[] authorsList = str_result.Split(',');
                str_re = str_result.Split(',');
                for (int r= 0; r < 6;r++)
                {
                    if(r<2)
                    {
                        str_flag[r] =str_re[r];
                    }
                    else
                    {
                        str_flag[r] = Set_flag(str_re[r]);
                    }
                   
                }
                C_DateTime CDT = new C_DateTime();
                
                richTextBox2.Text += str_flag[0]+ ","+ str_flag[1] + "," + str_flag[2] + "," 
                                   + str_flag[3] + "," + str_flag[4] + "," + str_flag[5] + "," + CDT.SGDate + "," + CDT.SGTime + "," + "1\n";

                string ett = "INSERT INTO ai_result(urc,result_id,social_flag,economical_flag,envirment_flag,influence_flag,active,date,time)";
                string tvo = " values('" + str_flag[1] + "','" + int.Parse(str_flag[0]) + "','"  + str_flag[2] + "','" + str_flag[3] + "','" + str_flag[4] + "','" + str_flag[5] 
                                         + "','1','" + CDT.SGDate + "','" + CDT.SGTime + "');";
                string tre = ett + tvo;


               CExecuteScalar.execute_table(ref tre, ai_resultTableAdapter.Connection);

                System.Threading.Thread.Sleep(50);
            }
            C_Connection.connection_table("close",ai_resultTableAdapter.Connection);
        }

        private string Set_flag(string get_flag)
        {
            string _set = string.Empty;
            switch (get_flag)
            {
                case "0":
                    _set = "0";
                    break;
                case "1":
                    _set = "1";
                    break;
                case "2":
                    _set = "0";
                    break;
                case "3":
                    _set = "0";
                    break;
                case "4":
                    _set = "0";
                    break;

            }
            return _set;
        }
        private string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //creat a text box in desing mode and call it ASPxTextBox1
            if (textBox2.Text == "")
            {
                //  Response.Write("first enter you count number");
            }
            else
            {
                int number = Convert.ToInt32(textBox2.Text);
                List<int> available = new List<int>(number);
                for (int i = 1; i <= number; i++)
                    available.Add(i);
                List<int> result = new List<int>(number);
                while (available.Count > 0)
                {
                    int index = r.Next(available.Count);
                    result.Add(available[index]);
                    available.RemoveAt(index);
                }
                for (int i = 0; i < result.Count; i++)
                {
                    richTextBox1.Text += (result[i] + "\n");
                }
            }
        }

        protected int Pro_R(int min, int max)
        {
            //  Random r = new Random();
            return (r.Next(min, max));
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            int from1 = 1, to1 = 10;
            var ran = Enumerable.Range(from1, to1).OrderBy(x => Guid.NewGuid());
            foreach (int i in ran)
            {
                richTextBox1.Text += ran.ToString();
            }
            /////////////////
            List<int> listNumbers = new List<int>();
            int number;
            int j = 0;
            for (int i = from1; i < to1; i++)
            {
                do
                {
                    Random rand = new Random();
                    number = rand.Next(from1, to1);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
                richTextBox2.Text += listNumbers[j];
                j++;
            }
            richTextBox2.Text += "\n";
        }

    }
}

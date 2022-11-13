using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace ProjectTools
{
    public partial class Form_XML_JSON : Form
    {
        public Form_XML_JSON()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.project22DataSet.questions);
            // TODO: This line of code loads data into the 'project22DataSet.input_question' table. You can move, or remove it, as needed.
            this.input_questionTableAdapter.Fill(this.project22DataSet.input_question);
            // TODO: This line of code loads data into the 'project22DataSet.result_question' table. You can move, or remove it, as needed.
            this.result_questionTableAdapter.Fill(this.project22DataSet.result_question);
            // TODO: This line of code loads data into the 'project22DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.project22DataSet.users);

        }

        private void TSMI_JSON_Click(object sender, EventArgs e)
        {
          //  string json = JsonConvert.SerializeObject(table, new Newtonsoft.Json.Formatting());
        }

        private void TSMI_User_XML_Click(object sender, EventArgs e)
        {

            //Creating a Dictionary with Key and value both are string type
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            //Adding Elements to the Dictionary using Add Method of Dictionary class
            dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wproject22.GUI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project22DataSet.Answer_AI' table. You can move, or remove it, as needed.
            this.answer_AITableAdapter.Fill(this.project22DataSet.Answer_AI);
            // TODO: This line of code loads data into the 'project22DataSet.category' table. You can move, or remove it, as needed.
            //this.categoryTableAdapter.Fill(this.project22DataSet.category);
            // TODO: This line of code loads data into the 'project22DataSet.result_question' table. You can move, or remove it, as needed.
            // this.result_questionTableAdapter.Fill(this.project22DataSet.result_question);

        }

        

        //---------------------------------------------------------------------------------
        // Display information
        //---------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------
        // Datagridview
        //---------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------
        // Search
        //---------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------
        // Check information
        //---------------------------------------------------------------------------------


    }
}

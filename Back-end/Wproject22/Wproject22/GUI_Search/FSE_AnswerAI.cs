using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wproject22.GUI_Search
{
    public partial class FSE_AnswerAI : Form
    {
        public FSE_AnswerAI()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WQuestion
{
    
    public partial class Form1 : Form
    {
        private int[] su = new int[5];
        private int meddel = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox5.Text = "1";
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            int test = 0;
            su[0] =int.Parse(textBox1.Text.Trim());
            su[1] = int.Parse(textBox2.Text.Trim());
            su[2] = int.Parse(textBox3.Text.Trim());
            su[3] = int.Parse(textBox4.Text.Trim());
            su[4] = int.Parse(textBox5.Text.Trim());
            foreach (int x in su)
            {
                 test =test +x;

            }
             meddel = test / 5;
            switch (comboBox1.SelectedItem.ToString()){
                case "Social":
                    textBox6.Text = meddel.ToString();
                    break;
                case "Economical":
                    textBox7.Text = meddel.ToString();
                    break;
                case "Envirmental":
                    textBox8.Text = meddel.ToString();
                    break;
                case "Influence":
                    textBox9.Text = meddel.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }

        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = trackBar4.Value.ToString();
        }

        private void TrackBar5_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = trackBar5.Value.ToString();
        }
    }
}

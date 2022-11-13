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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }



        private void About_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            richTextBox1.SelectionFont = new Font("Tahoma", 12, FontStyle.Bold);

            //richTextBox1.Select(32, 6);
            //string str1 = "2022 - 10 - 28\n";
            ////richTextBox1.SelectionFont = new Font("Tahoma", 12, FontStyle.Italic);
            //richTextBox1.Text += @"{\rtf1\ansi \b" + str1 + "\b0" + str1 + "}";
            ////richTextBox1.Text +=  @"{\rtf1\ansi \b 2022-10-28\b0}";
            richTextBox1.Text += "2022-10-28\n";
            richTextBox1.Text += "Sustainability Barometer\n";
            richTextBox1.Text += " Wisam Orabi Alkhen\nMattias Lindblom \nLovisa Berglund\nClément Lefebvre\nAhmad Setoodeh\n";
            richTextBox1.Text += "Welcome to the sustainability barometer! \nThis program will let you assess the sustainability of your business idea.\n" +
                              "  The service is based on artificial intelligence AI and will help you determine on which areas you can improve and tips on\n" +
                              "  what to do in order to develop your business in a more sustainable way.";
         //   richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();


        }

        private void B_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Richtext 03: Set Bold, Italic and Underline Styles to the Selection.First get the Font name
        // from the selection and then apply the specific style.
        //private void btnBold_Click(object sender, EventArgs e)
        //{
        //    Font SelectedText_Font = RT.SelectionFont;
        //    if (SelectedText_Font != null)
        //        RT.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
        //}

        //private void btnItalic_Click(object sender, EventArgs e)
        //{
        //    Font SelectedText_Font = RT.SelectionFont;
        //    if (SelectedText_Font != null)
        //        RT.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
        //}

        //private void btnUnderline_Click(object sender, EventArgs e)
        //{
        //    Font SelectedText_Font = RT.SelectionFont;
        //    if (SelectedText_Font != null)
        //        RT.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
        //}
    }
}

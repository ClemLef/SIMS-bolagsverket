using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.apache.pdfbox.pdfviewer;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using Xceed.Words.NET;

namespace Winform_PDFtoWORD
{
    public partial class PDFtoWord : Form
    {
        public PDFtoWord()
        {
            InitializeComponent();
        }

        private void B_upload_pdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF files |*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                  TB_filepdf.Text = ofd.FileName;
                }
            }
        }

        private void B_convert_word_Click(object sender, EventArgs e)
        {
            PDDocument doc = PDDocument.load(TB_filepdf.Text);
            PDFTextStripper stripper = new PDFTextStripper();
            RTB_pdf_to_word.Text = (stripper.getText(doc));
            var docName = Path.GetFileNameWithoutExtension(TB_filepdf.Text) + ".docx";
            var worddoc = DocX.Create(docName);
            worddoc.InsertParagraph(RTB_pdf_to_word.Text);
            worddoc.Save();
        }

        private void B_search_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = RTB_pdf_to_word.Text.LastIndexOf(TB_Search.Text);

            RTB_pdf_to_word.SelectAll();
            RTB_pdf_to_word.SelectionBackColor = Color.White;
            while (start < end)
            {
                RTB_pdf_to_word.Find(TB_Search.Text, start, RTB_pdf_to_word.TextLength, RichTextBoxFinds.MatchCase);

                RTB_pdf_to_word.SelectionBackColor = Color.Yellow;

                start = RTB_pdf_to_word.Text.IndexOf(TB_Search.Text, start) + 1;
            }
        }
    }
}

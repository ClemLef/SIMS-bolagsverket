/*
 * Mittuniversitetet högskola
 * 2022 SIMS / Project based product development, 15 ECTS
 * Sustainability Barometer
 * Luctur: Magnus Eriksson
 * @authors Ahmad Setoodeh -  Wisam Orabi Alkhen – Mattias Lindblom – Lovisa Berglund – Clément Lefebvre 
 * 2022-11-02
 * @version 2.0
 * Filnamn :UserPrint.cs
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;


namespace Wproject22.Prints
{
    public class UserPrint
    {
        public UserPrint(PrintPageEventArgs PPEA, string OCustomer, string OCompany, string All_Items, string OM_Totals, string PI)
        {
            try
            {
                if (PI != "Apu")
                {
                    Image image = Image.FromFile(@"" + PI + "");

                    PPEA.Graphics.DrawImage(image, 50, 50, image.Width, image.Height);
                }
                PPEA.Graphics.DrawString("Date: " + DateTime.Now.ToString("yyyy/MM/dd"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 110));
                PPEA.Graphics.DrawString("Time: " + DateTime.Now.ToString("hh:mm:ss"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 130));

         //       PPEA.Graphics.DrawString("Invoice Number: " + OCustomer.Invoicenr.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 30));

                //  Font BFont = new Font(Resources.Code39, 14, FontStyle.Regular);


                PPEA.Graphics.DrawString("*7217747*", new Font("Bar-Code 39", 14, FontStyle.Regular), Brushes.Black, new Point(350, 70));

                PPEA.Graphics.DrawString("User List : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 110));
           
                PPEA.Graphics.DrawString("───────────────────────────────────────────────────────────────", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

                PPEA.Graphics.DrawString(" ID", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
                PPEA.Graphics.DrawString("User registration code ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 255));

                PPEA.Graphics.DrawString(" Date ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(280, 255));
                PPEA.Graphics.DrawString(" Time ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 255));
                PPEA.Graphics.DrawString("Active", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 255));
          
                PPEA.Graphics.DrawString("───────────────────────────────────────────────────────────────", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

                int yPos = 295;
            
                //---------------------------------
                PPEA.Graphics.DrawString("───────────────────────────────────────────────────────────────", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
    
                PPEA.Graphics.DrawString("───────────────────────────────────────────────────────────────", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 30));
             }
            catch // send Exception to main form
            {
                throw;
            }
        }

    }
}

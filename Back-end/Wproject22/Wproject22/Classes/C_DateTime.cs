using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wproject22.Classes
{
    
    public class C_DateTime
    {
        private string _Date;
        private string _Time;
        private string _DateTime;
        private string _FileDT;
        public C_DateTime()
        {
            _Date= DateTime.Now.ToString("yyyy-MM-dd");
            _Time = DateTime.Now.ToString("HH:mm:ss");
            _DateTime = DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss");
            _FileDT= DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss");
        }

        public string SGDate
        {
            get { return _Date; }

            set { _Date = value; }
        }
        public string SGTime
        {
            get { return _Time; }

            set { _Time = value; }
        }
        public string SGDateTime
        {
            get { return _DateTime; }

            set { _DateTime = value; }
        }
    }
}

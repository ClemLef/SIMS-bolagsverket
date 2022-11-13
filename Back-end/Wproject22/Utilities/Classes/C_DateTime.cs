using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Classes
{
    public class C_DateTime
    {
        private string _Date;
        private string _Time;
        public C_DateTime()
        {
            _Date = DateTime.Now.ToString("yyyy-MM-dd");
            _Time = DateTime.Now.ToString("HH:mm:ss");
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
    }
}

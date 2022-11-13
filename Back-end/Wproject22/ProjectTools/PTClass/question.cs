using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTools.PTClass
{
    public class question
    {
        internal Dictionary<string, object> GetDict(DataTable dt)
        {
            return dt.AsEnumerable()
              .ToDictionary<DataRow, string, object>(row => row.Field<string>(0),
                                        row => row.Field<object>(1));
        }
        public int ID { get; set; }
        public string _category { get; set; }
        public string _question { get; set; }
        public string _active { get; set; }
        public string _date { get; set; }
        public string _time { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjectTools.PTClass
{
    class Class1
    {
        /*
        public static string ListJson()
        {
            DataSet ds = new DataSet();

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=project22;password=100");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from STUDENTS", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);


            da.Fill(ds);

            List<students> studentDetails = new List<students>();
            studentDetails = ConvertDataTable<students>(ds.Tables[0]);

            //JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(studentDetails);

        }
        public class students
        {
            public string firstname { get; set; }
            public string surname { get; set; }

        }
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    public class CLS_TABLE
    {
        public string table_name { get; set; }
        public string column_name { get; set; }
        public string data_type { get; set; }
    }

    public class CLS_TABLE_EXT
    {
        public static List<CLS_TABLE> DataTableToList(DataTable dt)
        {
            List<CLS_TABLE> list = new List<CLS_TABLE>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new CLS_TABLE
                {
                    table_name = string.IsNullOrEmpty(row["table_name"].ToString()) ? "" : row["table_name"].ToString(),
                    column_name = string.IsNullOrEmpty(row["column_name"].ToString()) ? "" : row["column_name"].ToString(),
                    data_type = string.IsNullOrEmpty(row["data_type"].ToString()) ? "" : row["data_type"].ToString(),
                });
            }
            return list;
        }
    }
}

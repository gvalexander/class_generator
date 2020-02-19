
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerator
{
    public class OracleHelper
    {
        public static DataSet Query(string connectionString, string tablename)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM ALL_TAB_COLUMNS WHERE LOWER(TABLE_NAME) = LOWER('" + tablename + "') ORDER BY COLUMN_ID";
                ds = ExecuteQuery(connectionString, query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet GetTableNames(string connectionString, string type)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = $"SELECT * FROM USER_OBJECTS WHERE OBJECT_TYPE = '{type.ToUpper()}'";
                ds = ExecuteQuery(connectionString, query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static DataSet ExecuteQuery(string connectionString, string query)
        {
            DataSet ds = new DataSet();
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    OracleCommand cmd = new OracleCommand(query, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public static List<string> GetTNSList()
        {
            List<string> tnsList = new List<string>();
            try
            {
                string providerName = "Oracle.DataAccess.Client";
                DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
                if (factory.CanCreateDataSourceEnumerator)
                {
                    DbDataSourceEnumerator dsenum = factory.CreateDataSourceEnumerator();
                    DataTable dt = dsenum.GetDataSources();
                    foreach (DataRow row in dt.Rows)
                        tnsList.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tnsList;
        }

    }
}

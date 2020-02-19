using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassGenerator
{
    public partial class Generator : DevExpress.XtraEditors.XtraForm
    {
        public static string connectionString { get; set; }
        public Generator()
        {
            InitializeComponent();
            txtNamespace.Text = "DataAccessLayer";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDatasource.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtGeneratedText.Text = string.Empty;
            lblResult.Text = string.Empty;
            txtNamespace.Text = "DataAccessLayer";
            cbTableName.SelectedIndex = -1;
            cbTabView.SelectedIndex = -1;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                List<CLS_TABLE> columns = GetColumns();
                Generate(columns);
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error : " + ex.Message;
            }

        }
        private void cbTabView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Data Source = " + txtDatasource.Text.Trim() + "; User Id = " + txtUsername.Text.Trim() + "; Password = " + txtPassword.Text.Trim() + "; ";
                string type = cbTabView.SelectedItem.ToString();
                List<string> tableList = new List<string>();
                DataSet ds = OracleHelper.GetTableNames(connectionString, type.ToUpper());

                foreach (DataRow row in ds.Tables[0].Rows)
                    tableList.Add(row["OBJECT_NAME"].ToString());

                cbTableName.DataSource = tableList;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error : " + ex.Message;
            }
        }

        private List<CLS_TABLE> GetColumns()
        {
            connectionString = "Data Source = " + txtDatasource.Text.Trim() + "; User Id = " + txtUsername.Text.Trim() + "; Password = " + txtPassword.Text.Trim() + "; ";
            //string connectionString = ConfigurationManager.ConnectionStrings["dss"].ConnectionString;
            string tablename = cbTableName.SelectedItem.ToString().Trim();
            DataSet dataSet = OracleHelper.Query(connectionString, tablename);
            List<CLS_TABLE> columns = new List<CLS_TABLE>();
            columns = CLS_TABLE_EXT.DataTableToList(dataSet.Tables[0]);
            return columns;
        }

        private void Generate(List<CLS_TABLE> columns)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;"); newline(sb);
            sb.Append("using System.Collections.Generic;"); newline(sb);
            sb.Append("using System.Data;"); newline(sb);
            sb.Append("using System.Linq;"); newline(sb);
            sb.Append("using System.Text;"); newline(sb);
            sb.Append("using System.Threading.Tasks;"); newline(sb);
            newline(sb);

            sb.Append("namespace " + txtNamespace.Text.Trim()); newline(sb);
            sb.Append("{"); newline(sb);

            #region Class
            //class
            tab(sb); sb.Append("public class " + cbTableName.SelectedItem.ToString().Trim().ToUpper());
            tab(sb); sb.Append("{"); newline(sb);
            GenerateClassProperties(sb, columns);
            tab(sb); sb.Append("}"); newline(sb);
            //end class 
            #endregion
            newline(sb); newline(sb);
            #region Clas Ext
            //class  _EXT
            tab(sb); sb.Append("public class " + cbTableName.SelectedItem.ToString().Trim().ToUpper() + "_EXT {"); newline(sb);
            tab(sb); tab(sb); sb.Append("public static List<" + cbTableName.SelectedItem.ToString().Trim().ToUpper() + "> DataTableToList(DataTable dt) {"); newline(sb);
            tab(sb); tab(sb); tab(sb); sb.Append("var list = new List<" + cbTableName.SelectedItem.ToString().Trim().ToUpper() + ">();"); newline(sb);
            tab(sb); tab(sb); tab(sb); sb.Append("foreach (DataRow row in dt.Rows) {"); newline(sb);
            tab(sb); tab(sb); tab(sb); tab(sb); sb.Append("list.Add(new " + cbTableName.SelectedItem.ToString().Trim().ToUpper() + " {"); newline(sb);
            GenerateClassExtProperties(sb, columns);
            tab(sb); tab(sb); tab(sb); tab(sb); sb.Append("});"); newline(sb);
            tab(sb); tab(sb); tab(sb); sb.Append("}"); newline(sb);
            tab(sb); tab(sb); tab(sb); sb.Append("return list;"); newline(sb);
            tab(sb); tab(sb); sb.Append("}"); newline(sb);
            tab(sb); sb.Append("}"); newline(sb);
            //end class  _EXT 
            #endregion

            sb.Append("}");
            txtGeneratedText.Text = sb.ToString();
        }

        private void GenerateClassProperties(StringBuilder sb, List<CLS_TABLE> columns)
        {
            foreach (var column in columns)
            {
                tab(sb); tab(sb); tab(sb); tab(sb); tab(sb); tab(sb);
                sb.Append(" public " + GetDataType(column.data_type) + " " + column.column_name.ToLower() + " { get; set; }");
                newline(sb);
            }
        }

        private void GenerateClassExtProperties(StringBuilder sb, List<CLS_TABLE> columns)
        {
            foreach (var column in columns)
            {
                column.column_name = column.column_name.ToLower();
                tab(sb); tab(sb); tab(sb); tab(sb); tab(sb); tab(sb);
                switch (column.data_type)
                {
                    case "VARCHAR2":
                        sb.Append(column.column_name + "= string.IsNullOrEmpty(row[\"" + column.column_name + "\"].ToString()) ? \"\" : row[\"" + column.column_name + "\"].ToString(),");
                        break;
                    case "CHAR":
                        sb.Append(column.column_name + "= string.IsNullOrEmpty(row[\"" + column.column_name + "\"].ToString()) ? \"\" : row[\"" + column.column_name + "\"].ToString(),");
                        break;
                    case "DATE":
                        sb.Append(column.column_name + "= string.IsNullOrEmpty(row[\"" + column.column_name + "\"].ToString()) ? DateTime.Now : DateTime.Parse(row[\"" + column.column_name + "\"].ToString()),");
                        break;
                    case "NUMBER":
                        sb.Append(column.column_name + "= string.IsNullOrEmpty(row[\"" + column.column_name + "\"].ToString()) ? 0 : decimal.Parse(row[\"" + column.column_name + "\"].ToString()),");
                        break;
                }
                newline(sb);
            }
        }

        private void newline(StringBuilder sb)
        {
            sb.Append("\n");
        }

        private void tab(StringBuilder sb)
        {
            sb.Append("\t");
        }


        private string GetDataType(string _datatype)
        {
            switch (_datatype.ToUpper().Trim())
            {
                case "VARCHAR2": return "string";
                case "DATE": return "DateTime";
                case "NUMBER": return "decimal";
                case "CHAR": return "string";
                default: return "string";
            }
        }

     
    }
}

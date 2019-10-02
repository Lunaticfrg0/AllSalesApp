using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllSalesApp.Utilities
{
    class ComboxManager
    {
        public static void Manager(ref ComboBox comBox, String sql)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlCommand oCommand = new SqlCommand();
            oCommand.Connection = oConnection;
            oCommand.CommandType = System.Data.CommandType.Text;
            oCommand.CommandText = sql;
            SqlDataReader sqlDataReader = oCommand.ExecuteReader();

            try
            {

                while (sqlDataReader.Read())
                {
                    dic.Add(sqlDataReader[0].ToString(), sqlDataReader[1].ToString());
                    comBox.DataSource = new BindingSource(dic, null);
                    comBox.DisplayMember = "Key";
                    comBox.ValueMember = "Value";
                }
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
        }
    }
}

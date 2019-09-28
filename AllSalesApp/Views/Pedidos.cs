using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllSalesApp.Views
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            LoadProducts();
        }
        
        public void LoadProducts()
        {

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");
            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            try
            {
                string sql = @"SELECT NombreProducto, Precio
                                   FROM tblProductoD
                                   WHERE Inventario > 0";

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConnection;
                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql;
                SqlDataReader sqlDataReader = oCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(sqlDataReader[0].ToString());
                    lv.SubItems.Add(sqlDataReader[1].ToString());

                    PedidosListView.Items.Add(lv);
                }

                oConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            string connstring = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI";
            using (SqlConnection conexion = new SqlConnection(connstring))
            {
                string query = @"SELECT NombreProducto, Precio
                                 FROM tblProductoD
                                 WHERE Inventario > 0";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Add(chk);
                chk.HeaderText = "Agregar";
                chk.Name = "chk";
                
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
            }




        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PedidosListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

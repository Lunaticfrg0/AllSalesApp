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
        public int IDProductoHeader;
        public int IDVendedor;
        public int IDTienda;
        public Pedidos(int idvendedor, int idtienda)
        {
            InitializeComponent();
            ListarClientes();
            IDVendedor = idvendedor;
            IDTienda = idtienda;
            ObtenerIDHeader();
            LoadProducts();
        }
        public string connstring = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI";
        private void ListarClientes()
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("SELECT NombreCliente FROM tblCliente", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }
        public void ObtenerIDHeader()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int idph;
                var query0 = "SELECT TOP 1 IDProductoH FROM tblProductoH WHERE IDTienda=@idtienda";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@idtienda", IDTienda);
                    idph = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                IDProductoHeader = idph;
            }
        }
        private void LoadProducts()
        {
            dataGridView2.Visible = false;
            dataGridView2.Enabled = false;
            using (SqlConnection conexion = new SqlConnection(connstring))
            {
                string query = @"SELECT NombreProducto,Precio
                                 FROM tblProductoD
                                 WHERE Inventario > 0 AND IDProductoH = @productoH";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("@productoH", IDProductoHeader);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                //Columna tipo Checkbox
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Add(chk);
                chk.HeaderText = "Agregar";
                chk.Name = "chk";

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                //Columna Tipo Cantidad
                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Cantidad";
                col4.Name = "Cantidad";
                col4.DefaultCellStyle.NullValue = "1";
                dataGridView1.Columns.Add(col4);
                ColumnasNuevas();

            }
        }

        private void ColumnasNuevas()
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Producto";
            col1.Name = "Producto";
            col1.ReadOnly = true;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Precio";
            col2.Name = "Precio";
            col2.ReadOnly = true;

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "ITBIS";
            col3.Name = "ITBIS";
            col3.ReadOnly = true;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Cantidad";
            col4.Name = "Cantidad";
            col4.ReadOnly = true;

            dataGridView2.Columns.Add(col1);
            dataGridView2.Columns.Add(col2);
            dataGridView2.Columns.Add(col3);
            dataGridView2.Columns.Add(col4);

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
        }

        private void GenerateList()
        {

            dataGridView2.Enabled = true;
            dataGridView2.Visible = true;
            label3.Visible = true;
            CrearFacturabtn.Visible = true;
            CrearFacturabtn.Enabled = true;
            double sumatoria = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                bool isSelected = Convert.ToBoolean(row.Cells["chk"].FormattedValue);
                if (isSelected)
                {
                    double precio = Convert.ToDouble(row.Cells["Precio"].Value) * Convert.ToDouble(row.Cells["Cantidad"].FormattedValue);
                    double itbis = (precio) * Convert.ToDouble(0.18);
                    sumatoria += (precio + itbis);
                    dataGridView2.Rows.Add((row.Cells["NombreProducto"].Value).ToString(), precio.ToString(), itbis.ToString(), row.Cells["Cantidad"].FormattedValue);
                }
            }
            labelTot.Visible = true;
            labelNumeros.Enabled = true;
            labelNumeros.Text = sumatoria.ToString();
            labelNumeros.Visible = true;
        }


        

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Elige algun cliente en el buscador", "Cliente No Elegido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView2.Rows.Clear();
                GenerateList();
            }
        }

        private void CrearFacturabtn_Click(object sender, EventArgs e)
        {
            NuevaFactura();
            MessageBox.Show("Factura Creada Exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevaFactura()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                string NCliente = comboBox1.SelectedItem.ToString();
                int idcliente;
                var query0 = "SELECT TOP 1 IDCliente FROM tblCliente WHERE NombreCliente=@nombrecliente";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@nombrecliente", NCliente);
                    idcliente = (int)cmd.ExecuteScalar();
                    connection.Close();
                }

                int idpedidoh;

                //Se Crea el header
                string query1 = @"INSERT INTO tblPedidoH (IDVendedor,IDCliente,Fecha)
                                 VALUES (@idvendedor,@idcliente,@fecha)";

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@idvendedor", IDVendedor);
                    command.Parameters.AddWithValue("@idcliente", idcliente);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    connection.Close();
                }
                var obtencion = "SELECT TOP 1 IDPedidoH FROM tblPedidoH ORDER BY IDPedidoH DESC";

                using (var cmd = new SqlCommand(obtencion, connection))
                {
                    connection.Open();
                    idpedidoh = (int)cmd.ExecuteScalar();
                    connection.Close();
                }

                //Se crean los detalles;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    string NProducto = (row.Cells["Producto"].Value).ToString();
                    int idprodctod;
                    
                    var query2 = "SELECT TOP 1 IDProductoD FROM tblProductoD WHERE NombreProducto = @nombreproducto";
                    using (var cmd = new SqlCommand(query2, connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@nombreproducto", NProducto);
                        idprodctod = (int)cmd.ExecuteScalar();
                        connection.Close();
                    }
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    double itbis = Convert.ToDouble(row.Cells["ITBIS"].Value);

                    //Se Crea el detalle exacto
                    string query3 = @"INSERT INTO tblPedidoD (Cantidad, ITBIS, IDProductoD,IDPedidoH)
                                    VALUES (@cantidad,@itbis,@idproductod,@idpedidoh)";

                    using (SqlCommand command2 = new SqlCommand(query3, connection))
                    {

                        connection.Open();
                        command2.Parameters.AddWithValue("@cantidad", cantidad);
                        command2.Parameters.AddWithValue("@itbis", Convert.ToDecimal(itbis));
                        command2.Parameters.AddWithValue("@idproductod", idprodctod);
                        command2.Parameters.AddWithValue("@idpedidoh", idpedidoh);

                        int result = command2.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        connection.Close();

                    }
                }


            }
        }
    }
}

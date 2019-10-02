using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AllSalesApp.Views
{
    public partial class Factura : Form
    {
        public int IDProductoHeader;
        public int IDVendedor;
        public int IDTienda;
        public Factura(int idvendedor, int idtienda)
        {
            InitializeComponent();
            IDVendedor = idvendedor;
            IDTienda = idtienda;
            ObtenerIDHeader();
            CargarPedido();
            ListarClientes();
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
        public string connstring = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI";
        private void CargarPedido()
        {
            using (SqlConnection conexion = new SqlConnection(connstring))
            {
                string query = @"SELECT *
                                 FROM  dbo.tblPedidoH                    
                                 ORDER BY dbo.tblPedidoH.IDPedidoH";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFacturas.DataSource = dt;
            }
        }
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
                cboBuscar.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvFacturas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
    
        }

        public void DeleteFactura(int IDPedidoH)
        {   //Delete detalles
            using (SqlConnection conexion = new SqlConnection(connstring))
            {

                string sql = @"DELETE FROM tblPedidoD WHERE IDPedidoH = @IDPedidoH";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@IDPedidoH", IDPedidoH);

                try
                {
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();
                    cmd.ExecuteNonQuery();
                    Msg.Text = "Borrado satisfactoriamente..";
                }
                catch (Exception)
                {

                    Msg.Text = "Se ha producido un error";

                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
            //Delete header
            using (SqlConnection conexion = new SqlConnection(connstring))
            {

                string sql = @"DELETE FROM tblPedidoH WHERE IDPedidoH = @IDPedidoH";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@IDPedidoH", IDPedidoH);

                try
                {
                    if (conexion.State == ConnectionState.Closed)
                        conexion.Open();
                    cmd.ExecuteNonQuery();
                    Msg.Text = "Borrado satisfactoriamente..";
                }
                catch (Exception)
                {

                    Msg.Text = "Se ha producido un error";

                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
        }

        public int GetIDCliente(string woah)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int idcliente;
                var query0 = "SELECT TOP 1 IDCliente FROM tblCliente WHERE NombreCliente=@nombrecliente";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@nombrecliente", woah);
                    idcliente = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                return idcliente;
            }
        }
        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = dgvFacturas.DataSource as DataTable;
            if (dgvFacturas.Columns.Contains("IDCliente") == true)
            {
                dt.DefaultView.RowFilter = string.Format("IDCliente = '{0}'", GetIDCliente(cboBuscar.Text));
            }
            else{
                dt.DefaultView.RowFilter = string.Format("NombreCliente = '{0}'", cboBuscar.Text);
            }
            
        }
        private void DgvFacturas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(connstring))
            {
                string query = @"SELECT dbo.tblPedidoH.IDPedidoH, dbo.tblCliente.NombreCliente, dbo.tblTienda.NombreTienda, dbo.tblPedidoD.Cantidad, dbo.tblPedidoD.ITBIS, dbo.tblProductoD.NombreProducto, dbo.tblProductoD.Precio, dbo.tblTienda.Direccion, dbo.tblPedidoH.Fecha
                                 FROM  dbo.tblCliente INNER JOIN
                                 dbo.tblPedidoH ON dbo.tblCliente.IDCliente = dbo.tblPedidoH.IDCliente INNER JOIN
                                 dbo.tblVendedor ON dbo.tblPedidoH.IDVendedor = dbo.tblVendedor.IDVendedor INNER JOIN
                                 dbo.tblTienda ON dbo.tblVendedor.IDTienda = dbo.tblTienda.IDTienda INNER JOIN
                                 dbo.tblPedidoD ON dbo.tblPedidoH.IDPedidoH = dbo.tblPedidoD.IDPedidoH INNER JOIN
                                 dbo.tblProductoD ON dbo.tblPedidoD.IDProductoD = dbo.tblProductoD.IDProductoD
                                 ORDER BY dbo.tblPedidoH.IDPedidoH";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("@idpedidoh", IDProductoHeader);
                da.Fill(dt);
                dgvFacturas.DataSource = dt;
            }
            ReporteFactura rf = new ReporteFactura();
                
            string nombre;
            double total = 0;
            double precio;
            double itbis;

            nombre = dgvFacturas.Rows[e.RowIndex].Cells["NombreCliente"].Value.ToString();
            rf.lblCliente.Text = nombre;            
            nombre = dgvFacturas.Rows[e.RowIndex].Cells["NombreTienda"].Value.ToString();
            rf.lblVendedor.Text = nombre;
            nombre = dgvFacturas.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            rf.lblDireccion.Text = nombre;
            nombre = dgvFacturas.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();
            rf.lblNombreProducto.Text = nombre;
            nombre = dgvFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            rf.lblCantidad.Text = nombre;
            precio = Convert.ToDouble(dgvFacturas.Rows[e.RowIndex].Cells["Precio"].Value) * Convert.ToDouble(dgvFacturas.Rows[e.RowIndex].Cells["Cantidad"].Value);
            rf.lblPrecio.Text = Convert.ToString(precio);
            itbis = (precio) * Convert.ToDouble(0.18);
            rf.lblITBIS.Text = Convert.ToString(itbis);
            nombre = dgvFacturas.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            rf.lblFecha.Text = nombre;
            total += (precio + itbis);
            rf.lblTotal.Text = Convert.ToString(total);

            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                precio = Convert.ToDouble(row.Cells["Precio"].Value) * Convert.ToDouble(row.Cells["Cantidad"].Value);
                itbis = (precio) * Convert.ToDouble(0.18);
                total += (precio + itbis);
            }
            rf.Show();
        }

        private void DgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool Eliminar = dgvFacturas.Columns[e.ColumnIndex].Name.ToString() == "btnEliminar";
            if (Eliminar)
            {
                if (MessageBox.Show("Esta seguro de que desea eliminar", "Pedidos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteFactura(Convert.ToInt32(dgvFacturas.Rows[e.RowIndex].Cells["IDPedidoH"].Value.ToString()));
                    CargarPedido();
                }
            }
        }

        private void Factura_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using AllSalesApp.Views;
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

namespace AllSalesApp
{
    public partial class Menu : Form
    {
        public string connstring = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI";
        Pedidos pedidoform;
        CrearCliente clienteform;
        Catalogo catalogoform;
        Factura facturaform;
        BorrarCliente borrarcliente;
        ConfigurarCliente configcliente;

        public int idTienda;
        public int idVendedor;
        public Menu(int Vendedor)
        {
            InitializeComponent();
            idVendedor = Vendedor;
            idTienda = IDTienda(idVendedor);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int IDTienda(int idvendedor)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int idtienda;
                var query0 = "SELECT TOP 1 IDTienda FROM tblVendedor WHERE IDVendedor=@idvendedor";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@idvendedor", idvendedor);
                    idtienda = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                return idtienda;
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidoform = new Pedidos(idVendedor, idTienda);
            pedidoform.MdiParent = this;
            pedidoform.Show();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clienteform = new CrearCliente();
            clienteform.MdiParent = this;
            clienteform.Show();

        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalogoform = new Catalogo(idTienda);
            catalogoform.MdiParent = this;
            catalogoform.Show();
        }
        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facturaform = new Factura(idVendedor, idTienda);
            facturaform.MdiParent = this;
            facturaform.Show();
        }

        private void borrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarcliente = new BorrarCliente();
            borrarcliente.MdiParent = this;
            borrarcliente.Show();
        }

        private void configurarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configcliente = new ConfigurarCliente();
            configcliente.MdiParent = this;
            configcliente.Show();
        }
    }
}


using AllSalesApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllSalesApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos child = new Pedidos();
            child.MdiParent = this;
            child.Show();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCliente child = new CrearCliente();
            child.MdiParent = this;
            child.Show();
        }
    }
}

using AllSalesApp.Entities;
using AllSalesApp.Services;
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
    public partial class LogIn : Form
    {
        public string connstring = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI";
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        public string Cedula { get { return this.Cedulatxt.Text; } }
        public string Password { get { return this.Passwordtxt.Text; } }
        public void IDVendedor(string cedula)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int idvendedor;
                var query0 = "SELECT TOP 1 IDVendedor FROM tblVendedor WHERE Cedula=@cedula";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    idvendedor = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                Menu Menu = new Menu(idvendedor);
                Menu.Show();
            }
        }
        private void LogInbtn_Click(object sender, EventArgs e)
        {
            int acceso = 0;

            if ((Cedula == "Registro") && (Password == "GucciMustard"))
            { 
                acceso = 1;
            }

            if ((Cedula == "Shop") && (Password == "GucciMustard"))
            {
                acceso = 2;
            }

            if (acceso == 1) 
            {
                    CrearVendedor crearVendedor = new CrearVendedor();
                ClearTextBoxes();
                    crearVendedor.Show();
            }

            if (acceso == 2)
            {
                CrearTienda crearTienda = new CrearTienda();
                ClearTextBoxes();
                crearTienda.Show();
            }

            if (acceso == 0)
            {
                Arranca();
            }
        }
        private void Arranca()
        {
            using (LogInServices intento = new LogInServices())
            {
                LogInVendedor dato = new LogInVendedor();
                dato.Login = Cedula;
                dato.Password = Password;


                if (intento.ValidaLogIn(dato))
                {

                    Hide();
                    IDVendedor(dato.Login);

                }
                else
                {
                    MessageBox.Show("Acceso Denegado", "allSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}

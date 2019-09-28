using AllSalesApp.Entities;
using AllSalesApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllSalesApp.Views
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        public string Cedula { get { return this.Cedulatxt.Text; } }
        public string Password { get { return this.Passwordtxt.Text; } }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            using (LogInServices intento = new LogInServices())
            {
                LogInVendedor dato = new LogInVendedor();
                dato.Login = Cedula;
                dato.Password = Password;


                if (intento.ValidaLogIn(dato))
                {

                    Hide();
                    Menu Menu = new Menu();
                    Menu.Show();

                }
                else
                {
                    MessageBox.Show("Acceso Denegado", "allSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}

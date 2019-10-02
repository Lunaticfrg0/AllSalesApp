using AllSalesApp.Utilities;
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
    public partial class CrearTienda : Form
    {
        public string NombreTienda { get { return this.NombreTiendatxt.Text; } }
        public string Telefono { get { return this.TelefonoTiendatxt.Text; } }
        public string Provincia { get { return ProvinciacomboBox.SelectedItem.ToString(); } }
        public string PaginaWeb { get { return PaginaWebtxt.Text; } }
        public string Correo { get { return CorreoTiendatxt.Text; } }
        public string Direccion { get { return Sectortxt.Text + ", " + Calletxt.Text + ", " + Numerotxt.Text; } }
        
   
        public CrearTienda()
        {
            InitializeComponent();
            
        }

        public int GetIdFromName(string Name)
        {
            string[] tmp = Name.Split(',');
            string[] tmp2 = tmp[1].Split(']');
            return Int32.Parse(tmp2[0]);
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
        
        private void CrearTiendabtn_Click(object sender, EventArgs e)
        {

            if (NombreTiendatxt.Text == string.Empty ||
               TelefonoTiendatxt.Text == string.Empty || CorreoTiendatxt.Text == string.Empty || Sectortxt.Text == string.Empty
               || Calletxt.Text == string.Empty || Numerotxt.Text == string.Empty)

            {
                MessageBox.Show("Agregado Fallido, llenar todos los campos", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
      
            int Idprovincia = GetIdFromName(Provincia);

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlParameter paramNom = new SqlParameter("@NombreTienda", NombreTienda);
            SqlParameter paramTel = new SqlParameter("@Telefono", Telefono);
            SqlParameter paramDire = new SqlParameter("@Direccion", Direccion);
            SqlParameter paramWeb = new SqlParameter("@PaginaWeb", PaginaWeb);
            SqlParameter paramProv = new SqlParameter("@IdProvincia", Idprovincia);
            SqlParameter paramCorreo = new SqlParameter("@Correo", Correo);
            


            try
            {

                string sql = "INSERT INTO[dbo].[tblTienda]([NombreTienda],[TelefonoTienda],[Correo],[PaginaWeb]" +
                                                         ",[Direccion],[IDProvincia]) " +
                     "VALUES (@NombreTienda, @Telefono, @Correo,@PaginaWeb,@Direccion, @IdProvincia)";

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConnection;
                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add(paramNom);
                oCommand.Parameters.Add(paramTel);
                oCommand.Parameters.Add(paramCorreo);
                oCommand.Parameters.Add(paramWeb);
                oCommand.Parameters.Add(paramProv);
                oCommand.Parameters.Add(paramDire);
                oCommand.ExecuteNonQuery();
                MessageBox.Show("Agregado Exitoso", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oConnection.Close();
                ClearTextBoxes();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Agregado Fallido", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(EX.Message);

            }
        }

        private void CrearTienda_Load_1(object sender, EventArgs e)
        {
            ComboxManager.Manager(ref ProvinciacomboBox, "SELECT [NombreProvincia],[IDProvincia] FROM[AllSalesApp].[dbo].[tblProvincia]");
        }
    }
}
using AllSalesApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllSalesApp.Views
{
    public partial class CrearVendedor : Form
    {
        public CrearVendedor()
        {
            InitializeComponent();
        }
        public string NombreVendedor { get { return this.NombreVendedortxt.Text; } }
        public string ApellidoVendedor { get { return this.ApellidoVendedortxt.Text; } }
        public string NombreCompleto { get { return this.NombreVendedor + " " + ApellidoVendedor; } }
        public string Cedula { get { return this.CedulaVendedortxt.Text; } }
        public string Telefono { get { return this.TelefonoVendedortxt.Text; } }
        public string Correo { get { return this.CorreoVendedortxt.Text; } }
        public DateTime FechaVendedor { get { return DateTime.ParseExact(FechaVendedorPicker.Text, "yyyy-MM-dd", null); } }
        public string Provincia { get { return ProvinciacomboBox.SelectedItem.ToString(); } } 
        public string Direccion { get { return Sectortxt.Text + ", " + Calletxt.Text + ", " + Numerotxt.Text; } }
        public string TiendaV { get { return TiendaComboBox.SelectedItem.ToString(); } }
   


        private void CrearVendedor_Load(object sender, EventArgs e)
        {
            ComboxManager.Manager(ref ProvinciacomboBox, "SELECT [NombreProvincia],[IDProvincia] FROM[AllSalesApp].[dbo].[tblProvincia]");
            ComboxManager.Manager(ref TiendaComboBox, "SELECT [NombreTienda],[IDTienda] FROM[AllSalesApp].[dbo].[tblTienda]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = FechaVendedor;
            var age = GetAge(date);

            if (NombreVendedortxt.Text == string.Empty || ApellidoVendedortxt.Text == string.Empty || CedulaVendedortxt.Text == string.Empty ||
                TelefonoVendedortxt.Text == string.Empty || CorreoVendedortxt.Text == string.Empty || Sectortxt.Text == string.Empty
                || Calletxt.Text == string.Empty || Numerotxt.Text == string.Empty )

            {
                MessageBox.Show("Agregado Fallido llenar todos los campos", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (age<18)
            {
                MessageBox.Show("Fecha de nacimiento invalida", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int Idprovincia = GetIdFromName(Provincia);
            int IdTienda = GetIdFromName(TiendaV);

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlParameter paramNom = new SqlParameter("@NombreCompleto", NombreCompleto);
            SqlParameter paramCedu = new SqlParameter("@Cedula", Cedula);
            SqlParameter paramTel = new SqlParameter("@Telefono", Telefono);
            SqlParameter paramCorreo = new SqlParameter("@Correo", Correo);
            SqlParameter paramFecha = new SqlParameter("@FechaNacimiento", FechaVendedor);
            SqlParameter paramProv = new SqlParameter("@IdProvincia", Idprovincia);
            SqlParameter paramDire = new SqlParameter("@Direccion", Direccion);
            SqlParameter paramTienda = new SqlParameter("@IDTienda", IdTienda);
            SqlParameter paramPass = new SqlParameter("@Password", PasswordCreator(12));


            try
            {

                string sql = "INSERT INTO[dbo].[tblVendedor]([NombreVendedor],[Cedula],[FechaNacimiento],[Telefono],[Correo]" +
                    ",[Direccion],[IDProvincia],[IDTienda],[Password]) " +
                     "VALUES (@NombreCompleto, @Cedula,@FechaNacimiento, @Telefono, @Correo,@Direccion, @IdProvincia, @IDTienda, @Password)";

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConnection;
                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add(paramNom);
                oCommand.Parameters.Add(paramCedu);
                oCommand.Parameters.Add(paramTel);
                oCommand.Parameters.Add(paramCorreo);
                oCommand.Parameters.Add(paramFecha);
                oCommand.Parameters.Add(paramProv);
                oCommand.Parameters.Add(paramDire);
                oCommand.Parameters.Add(paramTienda);
                oCommand.Parameters.Add(paramPass);

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
        public int GetIdFromName(string Name)
        {
            string[] tmp = Name.Split(',');
            string[] tmp2 = tmp[1].Split(']');
            return Int32.Parse(tmp2[0]);
        }
        public string PasswordCreator(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public int GetAge(DateTime date)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - date.Year;
            if (date > today.AddYears(-age))
                age--;

            return age;
            
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

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
    public partial class ConfigurarCliente : Form
    {
        public string IDCliente { get { return IDClientecombox.SelectedItem.ToString(); } }
        public string NombreCliente { get { return this.NombreClientetxt.Text; } }
        public string Cedula { get { return this.Cedulatxt.Text; } }
        public string Telefono { get { return this.Telefonotxt.Text; } }
        public string Correo { get { return this.Correotxt.Text; } }
        public string Provincia { get { return ProvinciacomboBox.SelectedItem.ToString(); } }
        public string Direccion { get { return this.Direcciontxt.Text; } }
        public ConfigurarCliente()
        {
            InitializeComponent();
        }

        private void ConfigurarCliente_Load(object sender, EventArgs e)
        {
            ComboxManager.Manager(ref IDClientecombox, "SELECT [NombreCliente],[IDCliente] FROM[AllSalesApp].[dbo].[tblCliente]");
            ComboxManager.Manager(ref ProvinciacomboBox, "SELECT [NombreProvincia],[IDProvincia] FROM[AllSalesApp].[dbo].[tblProvincia]");
        }

        private void SearchCliente_Click(object sender, EventArgs e)
        {
          
            int IdCliente = GetIdFromName(IDCliente);

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlParameter paramID = new SqlParameter("@IDCliente", IdCliente);
            string sql = @"SELECT *
                            FROM tblCliente
                            INNER JOIN tblProvincia
                            ON tblCliente.IDProvincia = tblProvincia.IDProvincia
                            Where IDCliente = @IDCliente";

            SqlCommand oCommand = new SqlCommand();
            oCommand.Connection = oConnection;
            oCommand.CommandType = System.Data.CommandType.Text;
            oCommand.CommandText = sql;
            oCommand.Parameters.Add(paramID);

            SqlDataReader sqlDataReader = oCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                NombreClientetxt.Text = (sqlDataReader["NombreCliente"].ToString());
                Cedulatxt.Text = (sqlDataReader["Cedula"].ToString());
                Telefonotxt.Text = (sqlDataReader["Telefono"].ToString());
                Correotxt.Text = (sqlDataReader["Correo"].ToString());
               ProvinciacomboBox.Text = (sqlDataReader["NombreProvincia"].ToString());
                Direcciontxt.Text = (sqlDataReader["Direccion"].ToString());
                
            }
            oConnection.Close();
        }

        private void Actualizarbtn_Click(object sender, EventArgs e)
        {
           
            int Idprovincia = GetIdFromName(Provincia);
            int IdCliente = GetIdFromName(IDCliente);
            
            if (NombreClientetxt.Text == string.Empty || Cedulatxt.Text == string.Empty ||
                Telefonotxt.Text == string.Empty || Correotxt.Text == string.Empty || Direcciontxt.Text == string.Empty)

            {
                MessageBox.Show("Proceso de Actualizado Fallido llenar todos los campos", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlParameter paramNom = new SqlParameter("@NombreCliente", NombreCliente);
            SqlParameter paramCedu = new SqlParameter("@Cedula", Cedula);
            SqlParameter paramTel = new SqlParameter("@Telefono", Telefono);
            SqlParameter paramCorreo = new SqlParameter("@Correo", Correo);
            SqlParameter paramProv = new SqlParameter("@IdProvincia", Idprovincia);
            SqlParameter paramDire = new SqlParameter("@Direccion", Direccion);
            SqlParameter paramID = new SqlParameter("@IdCliente", IdCliente);

            try
            {

                string sql = @"UPDATE [dbo].[tblCliente]
                               SET [NombreCliente] = @NombreCliente
                                  ,[Cedula] = @Cedula
                                  ,[Telefono] = @Telefono
                                  ,[Correo] = @Correo
                                  ,[Direccion] = @Direccion
                                  ,[IDProvincia] = @IdProvincia
                             WHERE IDCliente=@IdCliente";

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConnection;
                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql;
                oCommand.Parameters.Add(paramNom);
                oCommand.Parameters.Add(paramCedu);
                oCommand.Parameters.Add(paramTel);
                oCommand.Parameters.Add(paramCorreo);
                oCommand.Parameters.Add(paramProv);
                oCommand.Parameters.Add(paramDire);
                oCommand.Parameters.Add(paramID);


                oCommand.ExecuteNonQuery();
                MessageBox.Show("Proceso de Actualizado Exitoso", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oConnection.Close();
                ClearTextBoxes();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Proceso de Actualizado Fallido", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(EX.Message);
            }
            
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
            public int GetIdFromName(string Name)
            {
                string[] tmp = Name.Split(',');
                string[] tmp2 = tmp[1].Split(']');
                return Int32.Parse(tmp2[0]);
            }

        private void IDClientecombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
    
}

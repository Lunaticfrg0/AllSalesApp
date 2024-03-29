﻿using AllSalesApp.Utilities;
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
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }
        
        
        public string Nombre { get { return this.NombreClientetxt.Text; } }
        public string Apellido { get { return this.ApellidoClientetxt.Text; } }
        public string NombreCliente { get { return this.Nombre + " " + Apellido; } }
        public string Cedula { get { return this.Cedulatxt.Text; } }
        public string Telefono { get { return this.Telefonotxt.Text; } }
        public string Correo { get { return this.Correotxt.Text; } }
        public string Provincia { get { return ProvinciacomboBox.SelectedItem.ToString(); } }
        public string Direccion { get { return Sectortxt.Text + ", " + Calletxt.Text + ", " + Numerotxt.Text; } }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            ComboxManager.Manager(ref ProvinciacomboBox, "SELECT [NombreProvincia],[IDProvincia] FROM[AllSalesApp].[dbo].[tblProvincia]");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tmp = Provincia.Split(',');
            string[] tmp2 = tmp[1].Split(']');
            int Idprovincia = Int32.Parse(tmp2[0]);
            if (NombreClientetxt.Text== string.Empty || ApellidoClientetxt.Text == string.Empty || Cedulatxt.Text == string.Empty || 
                Telefonotxt.Text == string.Empty || Correotxt.Text==string.Empty || Sectortxt.Text == string.Empty
                ||Calletxt.Text == string.Empty || Numerotxt.Text == string.Empty)
                
            {
                MessageBox.Show("Agregado Fallido llenar todos los campos", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


                try
                {

                    string sql = "INSERT INTO[dbo].[tblCliente] ([NombreCliente] ,[Cedula],[Telefono] ,[Correo] ,[IDProvincia], [Direccion] ) VALUES (@NombreCliente, @Cedula, @Telefono, @Correo, @IdProvincia, @Direccion)";

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



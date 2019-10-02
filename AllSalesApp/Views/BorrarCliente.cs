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
    public partial class BorrarCliente : Form
    {
        public string IDCliente { get { return IDClientecombox.SelectedItem.ToString(); } }
        public BorrarCliente()
        {
            InitializeComponent();
        }
        private void SearchCliente_Click(object sender, EventArgs e)
        {
            int IdCliente = GetIdFromName(IDCliente);

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS
                                                            ;Database=AllSalesApp;Integrated Security=SSPI");

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
                Provinciatxt.Text = (sqlDataReader["NombreProvincia"].ToString());
                Direcciontxt.Text = (sqlDataReader["Direccion"].ToString());
            }
            oConnection.Close();
        }
        private void Borrarbtn_Click(object sender, EventArgs e)
        {
            int IdCliente = GetIdFromName(IDCliente);

            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }

            SqlParameter paramID = new SqlParameter("@IdCliente", IdCliente);

            try
            {

                string sql = @" DELETE FROM[dbo].[tblCliente]
                               WHERE IDCliente=@IdCliente";

                SqlCommand oCommand = new SqlCommand();
                oCommand.Connection = oConnection;
                oCommand.CommandType = System.Data.CommandType.Text;
                oCommand.CommandText = sql; 
                oCommand.Parameters.Add(paramID);


                oCommand.ExecuteNonQuery();
                MessageBox.Show("Proceso de  Eliminacion Exitoso", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oConnection.Close();
                ComboxManager.Manager(ref IDClientecombox, "SELECT [NombreCliente],[IDCliente] FROM[AllSalesApp].[dbo].[tblCliente]");
                ClearTextBoxes();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Proceso de Eliminacion Fallido", "AllSalesApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(EX.Message);
            }

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

        private void BorrarCliente_Load_1(object sender, EventArgs e)
        {
            ComboxManager.Manager(ref IDClientecombox, "SELECT [NombreCliente],[IDCliente] FROM[AllSalesApp].[dbo].[tblCliente]");
        }

        private void IDClientecombox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}

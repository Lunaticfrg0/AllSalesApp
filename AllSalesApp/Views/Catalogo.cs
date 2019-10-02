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

    public partial class Catalogo : Form
    {
        public string connstring = @"Server=localhost;Data Source=LAPTOP-RS890769\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI";
        public int IDProductoHeader;
        public Catalogo(int idtienda)
        {
            InitializeComponent();
            ShowProductos(idtienda);
            ListarTipoProducto();
            ObtenerIDHeader(idtienda);
        }
        public int ObtenerIDHeader(int idtienda)
        {

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int idph;
                var query0 = "SELECT TOP 1 IDProductoH FROM tblProductoH WHERE IDTienda=@idtienda";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@idtienda", idtienda);
                    idph = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                IDProductoHeader = idph;
                return idph;
            }

        }
        public void ShowProductos(int idtienda)
        {
            using (SqlConnection conexion = new SqlConnection(connstring))
            {
                string query = @"SELECT IDProductoD,NombreProducto,Precio,NombreTipoProducto,Inventario
                                    FROM tblProductoD
                                    INNER JOIN tblTipoProducto 
                                    ON tblProductoD.IDTipoProducto = tblTipoProducto.IDTipoProducto
                                    WHERE IDProductoH = @idproductoh";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("@idproductoh", ObtenerIDHeader(idtienda));
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            }
        }

        public void ListarTipoProducto()
        {

            SqlDataReader dr;
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand("SELECT NombreTipoProducto FROM tblTipoProducto", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(0));
            }
            con.Close();
        }

        public int TipoProductoGet(string Jotaro)
        {

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int dio;
                var query0 = "SELECT TOP 1 IDTipoProducto FROM tblTipoProducto WHERE NombreTipoProducto=@ntipoproducto";

                using (var cmd = new SqlCommand(query0, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@ntipoproducto", Jotaro);
                    dio = (int)cmd.ExecuteScalar();
                    connection.Close();
                }
                return dio;
            }

        }

        //Crear Producto
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Llene todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    string query1 = @"INSERT INTO tblProductoD (NombreProducto,Precio,Inventario,IDProductoH,IDTipoProducto)
                                 VALUES (@nombreproducto,@precio,@inventario,@idproductoh,@idtipoproducto)";
                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@nombreproducto", textBox1.Text);
                        command.Parameters.AddWithValue("@precio", Convert.ToDecimal(textBox2.Text));
                        command.Parameters.AddWithValue("@inventario", Convert.ToInt32(textBox3.Text));
                        command.Parameters.AddWithValue("@idproductoh", IDProductoHeader);
                        command.Parameters.AddWithValue("@idtipoproducto", TipoProductoGet(comboBox1.Text));

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            Console.WriteLine("Error inserting data into Database!");
                        connection.Close();
                    }
                }
            
            MessageBox.Show("Producto Creado exitosamente", "Bendiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Actualizar Datos de los productos
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea aplicar los cambios?", "Aplicar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ApplyChanges();
            }
        }
            
        public void ApplyChanges()
        {
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand bruh;
            int i = 0;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                bruh = new SqlCommand(@"UPDATE tblProductoD 
                                                SET  Precio = @precio
                                                ,Inventario = @inventario
                                                WHERE IDProductoD = @id", connection);

                bruh.Parameters.AddWithValue("@precio", dataGridView1.Rows[i].Cells[2].Value.ToString());
                bruh.Parameters.AddWithValue("@inventario", dataGridView1.Rows[i].Cells[4].Value.ToString());
                bruh.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value.ToString());
                connection.Open();
                bruh.ExecuteNonQuery();
                connection.Close();
                i++;
            }
        }
     

        private void Catalogo_Load(object sender, EventArgs e)
        {

        }

        private void Titulo2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Yoconda
{
    public partial class Form1 : Form
    {
        static string conex = "server = DESKTOP-IQQ86GU; database = Yoconda; integrated security =true";
        SqlConnection conexion = new SqlConnection(conex);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("Select nombre_Producto from TProducto", conexion);
            conexion.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbx1.Items.Add(dr.GetString(0));
            }
            conexion.Close();

            conexion.Open();
            string cadena = "Select nombre_Producto,precio_Producto from TProducto";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter adpt = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adpt.Fill(tabla);
            dat.DataSource = tabla;
            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("si");
            conexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btn1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "Select nombre_Producto from TProducto where nombre_Producto  ='" + cmbx1.Text + "'" + "Select Cantidad2 From TProducto where Cantidad2 = '"+comboBox1.Text+"'";5
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter adpt = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adpt.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
    }


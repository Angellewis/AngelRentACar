using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelRentCar
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'angelRentCarDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.angelRentCarDataSet.Empleados);
        }

        private void btnnuevomarc_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditmarc_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "UPDATE Empleados SET Nombre='" + txtnombre.Text + "', Cedula='" + txtcedula.Text + "', Tanda='" + txttanda.Text + "', Comision='" + txtcomision.Text + "', Fecha_Ingreso='" + txtingreso.Text + "', Estado='" + comboBox2.Text + "' WHERE ID= '" + id + "';";

                SqlCommand cmd = new SqlCommand(str, conexion);

                cmd.ExecuteNonQuery();
                conexion.Close();
                limpiar();
                mostarDatos();
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron actualizar los datos"); }
        }

        private void btnborrarmarc_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "DELETE FROM Empleados WHERE ID = " + id + ";";

                SqlCommand cmd = new SqlCommand(str, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                limpiar();
                mostarDatos();
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron eliminar los datos"); }
        }

        private void btnguardmarc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text == "" || txtcedula.Text == "" || txtcomision.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Empleados (Nombre, Cedula, Tanda, Comision, Fecha_Ingreso, Estado) values " +
                            "(@nombre, @cedula, @tanda, @comision, @ingreso, @estado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("cedula", txtcedula.Text);
                    cmd.Parameters.AddWithValue("tanda", txttanda.Text);
                    cmd.Parameters.AddWithValue("comision", txtcomision.Text);
                    cmd.Parameters.AddWithValue("ingreso", txtingreso.Text);
                    cmd.Parameters.AddWithValue("estado", comboBox2.Text);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    limpiar();
                    mostarDatos();
                }
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron guardar los datos"); }
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtcedula.Text = "";
            txtcomision.Text = "";
            txtingreso.Text = "";
            comboBox2.SelectedItem = null;
            txttanda.Text = "";
        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Empleados;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            string enombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
            string ecedula = dataGridView1.SelectedRows[0].Cells["Cedula"].Value.ToString();
            string etanda = dataGridView1.SelectedRows[0].Cells["Tanda"].Value.ToString();
            string ecomision = dataGridView1.SelectedRows[0].Cells["Comision"].Value.ToString();
            string eingreso = dataGridView1.SelectedRows[0].Cells["Fecha"].Value.ToString();
            string eEstado = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();

            txtnombre.Text = enombre;
            txtcedula.Text = ecedula;
            txttanda.Text = etanda;
            txtcomision.Text = ecomision;
            txtingreso.Text = eingreso;
            comboBox2.Text = eEstado;
        }

        private void txtbusqueda1_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "Select * from Empleados where Nombre like '%" + txtbusqueda1.Text + "%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Empleados");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Empleados";
        }
    }
}

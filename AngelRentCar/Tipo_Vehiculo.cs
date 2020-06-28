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
    public partial class Tipo_Vehiculo : Form
    {
        public Tipo_Vehiculo()
        {
            InitializeComponent();
        }

        private void Tipo_Vehiculo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AngelRentCarDataSet.Tipo_Vehiculos' table. You can move, or remove it, as needed.
            this.tipo_VehiculosTableAdapter1.Fill(this.AngelRentCarDataSet.Tipo_Vehiculos);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipo_VehiculosTableAdapter1.Fill(this.AngelRentCarDataSet.Tipo_Vehiculos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnguartipo_Click(object sender, EventArgs e)
        {
            if (txtdesc.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Debe rellenar los campos");
            }
            else
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();
                string strSql = "insert into Tipo_Vehiculos (Descripcion, Estado) values " +
                        "(@descripcion, @estado)";

                SqlCommand cmd = new SqlCommand(strSql, conexion);
                cmd.Parameters.AddWithValue("descripcion", txtdesc.Text);
                cmd.Parameters.AddWithValue("estado", comboBox2.Text);
                cmd.ExecuteNonQuery();
                conexion.Close();
                limpiar();
                mostarDatos();
            }
        }

        private void limpiar()
        {
            txtdesc.Text = "";
            comboBox2.SelectedItem = null;
        }
        public DataTable obtenerTipos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Tipo_Vehiculos";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerTipos();
            dataGridView1.DataSource = dt;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "UPDATE Tipo_Vehiculos SET Descripcion='" + txtdesc.Text + "', Estado='" + comboBox2.Text + "' WHERE ID= '" + id + "';";

                SqlCommand cmd = new SqlCommand(str, conexion);

                cmd.ExecuteNonQuery();
                conexion.Close();
                limpiar();
                mostarDatos();
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron actualizar los datos"); }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();

            string str = "DELETE FROM Tipo_Vehiculos WHERE ID = " + id + ";";

            SqlCommand cmd = new SqlCommand(str, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            limpiar();
            mostarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            string eDescripcion = dataGridView1.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            string eEstado = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();

            txtdesc.Text = eDescripcion;
            comboBox2.Text = eEstado;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

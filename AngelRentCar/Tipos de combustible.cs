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
    public partial class Tipos_de_combustible : Form
    {
        public Tipos_de_combustible()
        {
            InitializeComponent();
        }

        private void Tipos_de_combustible_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AngelRentCarDataSet.Tipo_combustible' table. You can move, or remove it, as needed.
            this.tipo_combustibleTableAdapter.Fill(this.AngelRentCarDataSet.Tipo_combustible);

        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Tipo_combustible";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void btnnuevocomb_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditcomb_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "UPDATE Tipo_combustible SET Descripcion='" + txtdesccomb.Text + "', Estado='" + comboBox2.Text + "' WHERE ID= '" + id + "';";

                SqlCommand cmd = new SqlCommand(str, conexion);

                cmd.ExecuteNonQuery();
                conexion.Close();
                limpiar();
                mostarDatos();
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron actualizar los datos"); }
        }

        private void btnborrarcomb_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "DELETE FROM Tipo_combustible WHERE ID = " + id + ";";

                SqlCommand cmd = new SqlCommand(str, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                limpiar();
                mostarDatos();
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron eliminar los datos"); }
        }

        private void btnguardcomb_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdesccomb.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Tipo_combustible (Descripcion, Estado) values " +
                            "(@descripcion, @estado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("descripcion", txtdesccomb.Text);
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
            txtdesccomb.Text = "";
            comboBox2.SelectedItem = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eDescripcion = dataGridView1.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            string eEstado = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();

            txtdesccomb.Text = eDescripcion;
            comboBox2.Text = eEstado;
        }
    }
}

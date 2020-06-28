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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void btnnuevomarc_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditmarc_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["IDS"].Value.ToString();
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "UPDATE Marcas SET Descripcion='" + txtdescmarca.Text + "', Estado='" + comboBox2.Text + "' WHERE ID= '" + id + "';";

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
            try {
                string id = dataGridView1.SelectedRows[0].Cells["IDS"].Value.ToString();
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "DELETE FROM Marcas WHERE ID = " + id + ";";

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
            try {
                if (txtdescmarca.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Marcas (Descripcion, Estado) values " +
                            "(@descripcion, @estado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("descripcion", txtdescmarca.Text);
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
            txtdescmarca.Text = "";
            comboBox2.SelectedItem = null;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerdatos();
            dataGridView1.DataSource = dt;
        }
        public DataTable obtenerdatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Marcas";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'angelRentCarDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter1.Fill(this.angelRentCarDataSet1.Marcas);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string eID = dataGridView1.SelectedRows[0].Cells["IDS"].Value.ToString();
            string eDescripcion = dataGridView1.SelectedRows[0].Cells["desc"].Value.ToString();
            string eEstado = dataGridView1.SelectedRows[0].Cells["est"].Value.ToString();

            txtdescmarca.Text = eDescripcion;
            comboBox2.Text = eEstado;
        }
    }
}

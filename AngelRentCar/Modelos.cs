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
    public partial class Modelos : Form
    {
        public Modelos()
        {
            InitializeComponent();
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AngelRentCarDataSet.Modelos' table. You can move, or remove it, as needed.
            this.modelosTableAdapter.Fill(this.AngelRentCarDataSet.Modelos);
            llenarcombo();
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
                int idd;
                bool result = int.TryParse(comboBox1.SelectedValue.ToString(), out idd);
                string str = "UPDATE Modelos SET Descripcion='" + txtdescmodel.Text + "', Estado='" + comboBox2.Text + "', ID_Marca='" + idd +"' WHERE ID= '" + id + "';";

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

                string str = "DELETE FROM Modelos WHERE ID = " + id + ";";

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
                if (txtdescmodel.Text == "" || comboBox2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    int id;
                    bool result = int.TryParse(comboBox1.SelectedValue.ToString(), out id);
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Modelos (ID_Marca, Descripcion, Estado) values " +
                            "(@idmarca, @descripcion, @estado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("descripcion", txtdescmodel.Text);
                    cmd.Parameters.AddWithValue("estado", comboBox2.Text);
                    cmd.Parameters.AddWithValue("idmarca", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    limpiar();
                    mostarDatos();
                }
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron guardar los datos"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eIDmarca = dataGridView1.SelectedRows[0].Cells["ID_Marca"].Value.ToString();
            int id = Convert.ToInt32(eIDmarca);
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string str = "select Descripcion from Marcas where ID = @id;";
            SqlCommand cmd = new SqlCommand(str, conexion);
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader marca = cmd.ExecuteReader();
            if (marca.Read())
            {
                comboBox1.Text = marca["Descripcion"].ToString();
            }
            string eDescripcion = dataGridView1.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            string eEstado = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();

            txtdescmodel.Text = eDescripcion;
            comboBox2.Text = eEstado;
        }

        private void limpiar()
        { 
            txtdescmodel.Text = "";
            comboBox2.SelectedItem = null;
            comboBox1.Text = "Selecciona la marca"; 
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
            string strSql = "Select * from Modelos";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }

        private void llenarcombo()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select ID, Descripcion from Marcas where Estado = 'Activo';";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Descripcion"] = "Selecciona la marca";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.DataSource = dt;
        }
    }
}

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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'angelRentCarDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.angelRentCarDataSet.Usuarios);
            llenarcombo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarconfirm el = new eliminarconfirm();
            string eIDempleado = dataGridView1.SelectedRows[0].Cells["ID_empleado"].Value.ToString();
            int id = Convert.ToInt32(eIDempleado);
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string str = "SELECT e.Nombre FROM Empleados e INNER JOIN Usuarios u ON e.ID = u.ID_empleado;";
            SqlCommand cmd = new SqlCommand(str, conexion);
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader marca = cmd.ExecuteReader();
            if (marca.Read())
            {
                Comboempleado.Text = marca["Nombre"].ToString();
            }
            string eID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            string eusuario = dataGridView1.SelectedRows[0].Cells["usuario"].Value.ToString();
            string econtra = dataGridView1.SelectedRows[0].Cells["Contra"].Value.ToString();
            string etipo = dataGridView1.SelectedRows[0].Cells["Tipo_usuario"].Value.ToString();

            lblid.Hide();
            lblid.Text = eID;
            el.id = lblid.Text;
            txtusuario.Text = eusuario;
            txtcontra.Text = econtra;
            if (etipo == "admin")
            {
                comboBox1.Text = "Administrador";
            }
            else
            {
                comboBox1.Text = "Usuario";
            }
        }

        private void btnnuevomarc_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditmarc_Click(object sender, EventArgs e)
        {
            string rol;
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            try
            {
                int idd;
                bool result = int.TryParse(Comboempleado.SelectedValue.ToString(), out idd);
                if (comboBox1.Text == "Administrador") { rol = "admin"; } else { rol = "usuario"; }
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "UPDATE Usuarios SET usuario='" + txtusuario.Text + "', Contra='" + txtcontra.Text + "', Tipo_usuario='" + rol + "', ID_empleado='" + idd + "' WHERE ID= '" + id + "';";

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
            eliminarconfirm form2 = new eliminarconfirm();
            form2.id = lblid.Text;
            form2.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form2_FormClosed);

            form2.ShowDialog();
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mostarDatos();
            limpiar();
        }

        private void btnguardmarc_Click(object sender, EventArgs e)
        {
            string rol;
            try
            {
                if (txtusuario.Text == "" || txtcontra.Text == "" || Comboempleado.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    int id;
                    bool result = int.TryParse(Comboempleado.SelectedValue.ToString(), out id);
                    if (comboBox1.Text == "Administrador") { rol = "admin"; } else { rol = "usuario"; }
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Usuarios (usuario, Contra, Tipo_usuario, ID_empleado) values " +
                            "(@usuario, @contra, @tipo, @empleado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("usuario", txtusuario.Text);
                    cmd.Parameters.AddWithValue("contra", txtcontra.Text);
                    cmd.Parameters.AddWithValue("tipo", rol);
                    cmd.Parameters.AddWithValue("empleado", id);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    limpiar();
                    mostarDatos(); 
                }
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron guardar los datos"); } 
        }

        public void limpiar()
        {
            txtusuario.Text = "";
            txtcontra.Text = "";
            Comboempleado.Text = "Empleados";
            comboBox1.SelectedItem = null;
            lblid.Text = "";
        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Usuarios;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        public void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        public void loaddata()
        {
            mostarDatos();
            llenarcombo();
        }

        private void llenarcombo()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "SELECT e. ID, e.Nombre FROM Empleados e INNER JOIN Usuarios u ON e.ID = u.ID_empleado;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Empleados";
            dt.Rows.InsertAt(fila, 0);

            Comboempleado.ValueMember = "ID";
            Comboempleado.DisplayMember = "Nombre";
            Comboempleado.DataSource = dt;
        }

        private void txtbusqueda1_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "Select * from Usuarios where usuario like '%" + txtbusqueda1.Text + "%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Usuarios");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Usuarios";
        }
    }
}

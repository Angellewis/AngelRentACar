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
    public partial class Inspeccion : Form
    {
        public Inspeccion()
        {
            InitializeComponent();
        }

        
        private void btnnuevomarc_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditmarc_Click(object sender, EventArgs e)
        {
            try
            {
                string con2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion2 = new SqlConnection(con2);
                conexion2.Open();

                string strl = "select u.Tipo_usuario from Usuarios u INNER JOIN Empleados e ON e.ID = u.ID_empleado where e.Nombre = @nombre;";
                SqlCommand cmd2 = new SqlCommand(strl, conexion2);
                cmd2.Parameters.AddWithValue("nombre", txtxempleado.Text);

                SqlDataReader carro = cmd2.ExecuteReader();
                if (carro.Read())
                {
                    txtrol.Text = carro["Tipo_usuario"].ToString();
                }

                if (txtrol.Text == "admin")
                {
                    string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string str = "DELETE FROM Inspeccion WHERE ID = " + id + ";";

                    SqlCommand cmd = new SqlCommand(str, conexion);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    limpiar();
                    mostarDatos();
                }
                else
                {
                    MessageBox.Show("Solo los administradores pueden eliminar inspecciones.");
                }
            }
            catch (Exception p) { MessageBox.Show(" No se pudieron eliminar los datos"); }
        }

        private void btnguardmarc_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || combocli.Text == "" || comboveh.Text == "" || txtxempleado.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    
                    if (ralladura.Checked == true) { txtrallon.Text = "Si"; } else { txtrallon.Text = "No"; }
                    if (repuesto.Checked == true) { txtgoma.Text = "Si"; } else { txtgoma.Text = "No"; }
                    if (gato.Checked == true) { txtgato.Text = "Si"; } else { txtgato.Text = "No"; }
                    if (cristal.Checked == true) { txtxcristal.Text = "Si"; } else { txtxcristal.Text = "No"; }

                    int id, id2;
                    bool result = int.TryParse(comboveh.SelectedValue.ToString(), out id);
                    bool result2 = int.TryParse(combocli.SelectedValue.ToString(), out id2);

                    //ID de empleado.

                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string str = "Select ID from Empleados where Nombre = @nombre;";
                    SqlCommand cmd = new SqlCommand(str, conexion);
                    cmd.Parameters.AddWithValue("nombre", txtxempleado.Text);

                    SqlDataReader carro = cmd.ExecuteReader();
                    if (carro.Read())
                    {
                        txtnombreemp.Text = carro["ID"].ToString();
                    }
                    conexion.Close();
                    // ya lo consegui

                    string con2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion2 = new SqlConnection(con2);
                    conexion2.Open();
                    string strSql = "Insert into Inspeccion (Vehiculo, ID_Cliente, Ralladuras, Cant_Combustible, Goma_repuesto, Gato,Rotura_cristal, Estado_gomas, Fecha, Empleado_insp, Estado) " +
                        "values (@idvehi,@idclien,@rallon,@comb,@gomarep, @gato, @rotura, @estadogomas, @fecha, @empleado, @estado);";

                    SqlCommand cmd1 = new SqlCommand(strSql, conexion2);
                    cmd1.Parameters.AddWithValue("idvehi", id);
                    cmd1.Parameters.AddWithValue("idclien", id2);
                    cmd1.Parameters.AddWithValue("rallon", txtrallon.Text);
                    cmd1.Parameters.AddWithValue("comb", comboBox1.Text);
                    cmd1.Parameters.AddWithValue("gomarep", txtgoma.Text);
                    cmd1.Parameters.AddWithValue("gato", txtgato.Text);
                    cmd1.Parameters.AddWithValue("rotura", txtxcristal.Text);
                    cmd1.Parameters.AddWithValue("estadogomas", textBox3.Text);
                    cmd1.Parameters.AddWithValue("fecha", txtfecha.Text);
                    cmd1.Parameters.AddWithValue("empleado", Convert.ToInt32(txtnombreemp.Text));
                    cmd1.Parameters.AddWithValue("estado", comboBox2.Text);
                    cmd1.ExecuteNonQuery();
                    conexion2.Close();
                    limpiar();
                    mostarDatos();
                }
            }
            catch (Exception p) { MessageBox.Show(p.ToString()); }
        }

        private void Inspeccion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'angelRentCarDataSet.Inspeccion' table. You can move, or remove it, as needed.
            this.inspeccionTableAdapter.Fill(this.angelRentCarDataSet.Inspeccion);
            DateTime today = DateTime.Today;
            int start = 0;
            int length = 9;
            string hola = today.ToString();
            string h = hola.Substring(start, length);
            txtfecha.Text = h;
            txtrallon.Hide();
            txtgato.Hide();
            txtgoma.Hide();
            txtrol.Hide();
            txtxcristal.Hide();
            txtnombreemp.Hide();
            llenarveh();
            llenarcli();

        }

        private void llenarveh()
        {
                DataTable dt = new DataTable();
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();
                string strSql = "select ID, Descripcion, Estado from Vehiculo where Estado = 'Disponible';";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
                da.Fill(dt);
                conexion.Close();

                DataRow fila = dt.NewRow();
                fila["Descripcion"] = "Vehiculos";
                dt.Rows.InsertAt(fila, 0);

                comboveh.ValueMember = "ID";
                comboveh.DisplayMember = "Descripcion";
                comboveh.DataSource = dt;
        }
        private void llenarcli()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "select ID, Nombre, Estado from Clientes  where Estado = 'Activo';";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Clientes";
            dt.Rows.InsertAt(fila, 0);

            combocli.ValueMember = "ID";
            combocli.DisplayMember = "Nombre";
            combocli.DataSource = dt;
        }

        private void limpiar()
        {
            comboBox1.SelectedItem = null;
            combocli.Text = "Clientes";
            comboveh.Text = "Vehiculos";
            textBox3.Text = "";
            comboBox2.SelectedItem = null;
            ralladura.Checked = false;
            repuesto.Checked = false;
            gato.Checked = false;
            cristal.Checked = false;
        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Inspeccion";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }
    }
}

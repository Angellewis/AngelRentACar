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
    public partial class Renta : Form
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void Renta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'angelRentCarDataSet.Renta_Devolucion' table. You can move, or remove it, as needed.
            this.renta_DevolucionTableAdapter.Fill(this.angelRentCarDataSet.Renta_Devolucion);
            Inspeccion ip = new Inspeccion();
            ip.txtxempleado.Text = label1.Text;
            txtempleado.Text = label1.Text;
            llenarvehiculo();
            llenarcliente();
            textBox1.Hide();
            txtrol.Hide();
            label1.Hide();
            ip.ShowDialog();
            
        }

        private void btnnuevomarc_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnguardmarc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtempleado.Text == "" || txtmonto.Text == "" || combvehiculo.Text == "" || comboestado.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else if (dateTimePicker1.Value < dateTimePicker2.Value) { MessageBox.Show("La fecha de devolucion no puede ser menor a la fecha de renta"); }
                else
                {
                    //ID de empleado.

                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string str = "Select ID from Empleados where Nombre = @nombre;";
                    SqlCommand cmd = new SqlCommand(str, conexion);
                    cmd.Parameters.AddWithValue("nombre", txtempleado.Text);

                    SqlDataReader carro = cmd.ExecuteReader();
                    if (carro.Read())
                    {
                        textBox1.Text = carro["ID"].ToString();
                    }
                    conexion.Close();
                    // ya lo consegui

                    int id, id2;
                    bool result = int.TryParse(combvehiculo.SelectedValue.ToString(), out id);
                    bool result2 = int.TryParse(combcliente.SelectedValue.ToString(), out id2);
                    string con2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion2 = new SqlConnection(con2);
                    conexion2.Open();
                    string strSql = "Insert into Renta_Devolucion (ID_Empleado, ID_Vehiculo, ID_Cliente, Fecha_Renta, Fecha_devolucion, Monto_dia,Cant_dia, Comentario, Estado)" +
                        " values (@idempleado,@idvehiculo,@idcliente,@fechahoy, @fechadevo, @monto, @dias, @comment, @estado);";

                    string fecha1, fecha2;
                    fecha1 = dateTimePicker1.Text.ToString();
                    fecha2 = dateTimePicker2.Text.ToString();

                    SqlCommand cmd1 = new SqlCommand(strSql, conexion2);
                    cmd1.Parameters.AddWithValue("idempleado", Convert.ToInt32(textBox1.Text));
                    cmd1.Parameters.AddWithValue("idvehiculo", id);
                    cmd1.Parameters.AddWithValue("idcliente", id2);
                    cmd1.Parameters.AddWithValue("fechahoy", fecha2);
                    cmd1.Parameters.AddWithValue("fechadevo", fecha1);
                    cmd1.Parameters.AddWithValue("monto", txtmonto.Text);
                    cmd1.Parameters.AddWithValue("dias", numericUpDown1.Value.ToString());
                    cmd1.Parameters.AddWithValue("comment", txtcomentario.Text);
                    cmd1.Parameters.AddWithValue("estado", comboestado.Text);
                    cmd1.ExecuteNonQuery();
                    conexion2.Close();

                    string con3 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion3 = new SqlConnection(con3);
                    conexion3.Open();
                    string strl = "UPDATE Vehiculo set Estado = 'No disponible' where ID = @id;";

                    SqlCommand cmd2 = new SqlCommand(strl, conexion3);
                    cmd2.Parameters.AddWithValue("id", id);
                    cmd2.ExecuteNonQuery();
                    conexion3.Close();
                    limpiar();
                    mostarDatos();
                }
            }
            catch (Exception p) { MessageBox.Show("No se pudieron guardar los datos, intente mas tarde"); }
        }

        private void llenarvehiculo()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select ID, Descripcion from Vehiculo where Estado = 'Disponible';";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Descripcion"] = "Seleccione el vehiculo";
            dt.Rows.InsertAt(fila, 0);

            combvehiculo.ValueMember = "ID";
            combvehiculo.DisplayMember = "Descripcion";
            combvehiculo.DataSource = dt;
        }

        private void llenarcliente()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select ID, Nombre from Clientes;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Seleccione el cliente";
            dt.Rows.InsertAt(fila, 0);

            combcliente.ValueMember = "ID";
            combcliente.DisplayMember = "Nombre";
            combcliente.DataSource = dt;
        }

        private void limpiar()
        {
            
            combvehiculo.Text = "Seleccione el vehiculo";
            combcliente.Text = "Seleccione el cliente";
            txtcomentario.Text = "";
            txtmonto.Text = "";
            comboestado.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            numericUpDown1.Value = 0;
            txtcomentario.Text = "";
        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "select * from Renta_Devolucion;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string con2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion2 = new SqlConnection(con2);
                conexion2.Open();

                string strl = "select u.Tipo_usuario from Usuarios u INNER JOIN Empleados e ON e.ID = u.ID_empleado where e.Nombre = @nombre;";
                SqlCommand cmd2 = new SqlCommand(strl, conexion2);
                cmd2.Parameters.AddWithValue("nombre", txtempleado.Text);

                SqlDataReader carro = cmd2.ExecuteReader();
                if (carro.Read())
                {
                    txtrol.Text = carro["Tipo_usuario"].ToString();
                }

                if (txtrol.Text == "admin")
                {
                    string id = dataGridView1.SelectedRows[0].Cells["No_Renta"].Value.ToString();
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string str = "DELETE FROM Renta_Devolucion WHERE No_Renta = " + id + ";";

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
            catch (Exception p) { MessageBox.Show("No se pudieron eliminar los datos"); }
        }
    }
}

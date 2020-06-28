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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'angelRentCarDataSet.Renta_Devolucion' table. You can move, or remove it, as needed.
            //this.renta_DevolucionTableAdapter.Fill(this.angelRentCarDataSet.Renta_Devolucion);
            mostarDatos();
        }
        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "select r.No_Renta, e.Nombre as [Empleado], v.Descripcion as [Vehiculo], v.ID, c.Nombre as [Cliente], r.Fecha_Renta as [Fecha de renta], r.Fecha_devolucion as [Fecha de devolucion], r.Monto_dia as [Monto por dia], r.Cant_dia as [Cantidad de dias], r.Comentario, r.Estado from Renta_Devolucion r INNER JOIN Empleados e ON e.ID = R.ID_Empleado INNER JOIN Vehiculo v ON v.ID = r.ID_Vehiculo INNER JOIN Clientes c ON c.ID = r.ID_Cliente where r.Estado = 'Activa';";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void btndevolver_Click(object sender, EventArgs e)
        {
            try
            {
                string eID = dataGridView1.SelectedRows[0].Cells["No_Renta"].Value.ToString();
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();
                string str = "update Renta_Devolucion set Estado = 'Inactiva' where No_Renta = @id;";
                SqlCommand cmd = new SqlCommand(str, conexion);
                cmd.Parameters.AddWithValue("id", eID);
                cmd.ExecuteNonQuery();
                conexion.Close();

                string ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string con2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion2 = new SqlConnection(con2);
                conexion2.Open();
                string strl = "update Vehiculo set Estado = 'Disponible' where ID = @id2;" ;
                SqlCommand cmd2 = new SqlCommand(strl, conexion2);
                cmd2.Parameters.AddWithValue("id2", ID);
                cmd2.ExecuteNonQuery();
                mostarDatos();
                conexion2.Close();

                MessageBox.Show("Devolucion procesada correctamente!");
            }
            catch(Exception p) { MessageBox.Show(p.ToString()); }
        }
    }
}

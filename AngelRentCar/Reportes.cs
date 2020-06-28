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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            mostarDatos();
        }
        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "select r.No_Renta as [No. Renta], e.Nombre as [Empleado], v.Descripcion as [Vehiculo], c.Nombre as [Cliente], r.Fecha_Renta as [Fecha de renta], r.Fecha_devolucion as [Fecha de devolucion], r.Monto_dia as [Monto por dia], r.Cant_dia as [Cantidad de dias], r.Comentario, r.Estado from Renta_Devolucion r INNER JOIN Empleados e ON e.ID = R.ID_Empleado INNER JOIN Vehiculo v ON v.ID = r.ID_Vehiculo INNER JOIN Clientes c ON c.ID = r.ID_Cliente;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Rentas";

            for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
            {
                worksheet.Cells[1,i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i ++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Salida";
            saveFileDialoge.DefaultExt = ".xlsx"; 
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void txtbusqueda1_TextChanged(object sender, EventArgs e)
        {      

            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "select r.No_Renta, e.Nombre as [Empleado], v.Descripcion as [Vehiculo], c.Nombre as [Cliente], r.Fecha_Renta as [Fecha de renta], r.Fecha_devolucion as [Fecha de devolucion], r.Monto_dia as [Monto por dia], r.Cant_dia as [Cantidad de dias], r.Comentario, r.Estado from Renta_Devolucion r INNER JOIN Empleados e ON e.ID = R.ID_Empleado INNER JOIN Vehiculo v ON v.ID = r.ID_Vehiculo INNER JOIN Clientes c ON c.ID = r.ID_Cliente where c.Nombre like '%"+ txtbusqueda1.Text +"%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Renta_Devolucion");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Renta_Devolucion";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "select r.No_Renta, e.Nombre as [Empleado], v.Descripcion as [Vehiculo], c.Nombre as [Cliente], r.Fecha_Renta as [Fecha de renta], r.Fecha_devolucion as [Fecha de devolucion], r.Monto_dia as [Monto por dia], r.Cant_dia as [Cantidad de dias], r.Comentario, r.Estado from Renta_Devolucion r INNER JOIN Empleados e ON e.ID = R.ID_Empleado INNER JOIN Vehiculo v ON v.ID = r.ID_Vehiculo INNER JOIN Clientes c ON c.ID = r.ID_Cliente where r.Fecha_Renta like '%" + textBox1.Text + "%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Renta_Devolucion");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Renta_Devolucion";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "select r.No_Renta, e.Nombre as [Empleado], v.Descripcion as [Vehiculo], c.Nombre as [Cliente], r.Fecha_Renta as [Fecha de renta], r.Fecha_devolucion as [Fecha de devolucion], r.Monto_dia as [Monto por dia], r.Cant_dia as [Cantidad de dias], r.Comentario, r.Estado from Renta_Devolucion r INNER JOIN Empleados e ON e.ID = R.ID_Empleado INNER JOIN Vehiculo v ON v.ID = r.ID_Vehiculo INNER JOIN Clientes c ON c.ID = r.ID_Cliente where v.Descripcion like '%" + textBox2.Text + "%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Renta_Devolucion");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Renta_Devolucion";
        }
    }
}

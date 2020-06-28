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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            mostarDatos();
            llenartipoveh();
            llenarmarca();
            llenartipocomb();
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
                int idd, idd2, idd3, idd4;
                bool result = int.TryParse(Combtipoveh.SelectedValue.ToString(), out idd);
                bool result2 = int.TryParse(Combomarca.SelectedValue.ToString(), out idd2);
                bool result3 = int.TryParse(combomod.SelectedValue.ToString(), out idd3);
                bool result4 = int.TryParse(combocomb.SelectedValue.ToString(), out idd4);
                string str = "UPDATE Vehiculo SET Descripcion='" + txtdescveh.Text + "', No_Chasis='" + txtnocha.Text + "', No_Motor='" + txtxnomot.Text + "', No_Placa='" + txtnoplac.Text + "', Tipo_vehiculo='" + idd + "', Marca='" + idd2 + "', Modelo='" + idd3 + "', Tipo_Combustible='" + idd4 + "', Estado='" + comboBox2.Text + "' WHERE ID= '" + id + "';";

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

                string str = "DELETE FROM Vehiculo WHERE ID = " + id + ";";

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
                if (txtdescveh.Text == "" || comboBox2.Text == "" || txtnocha.Text == "" || txtnoplac.Text == "")
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else
                {
                    int id, id2, id3, id4;
                    bool result = int.TryParse(Combtipoveh.SelectedValue.ToString(), out id);
                    bool result2 = int.TryParse(Combomarca.SelectedValue.ToString(), out id2);
                    bool result3 = int.TryParse(combomod.SelectedValue.ToString(), out id3);
                    bool result4 = int.TryParse(combocomb.SelectedValue.ToString(), out id4);
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Vehiculo (Descripcion, No_Chasis, No_Motor, No_Placa, Tipo_vehiculo, Marca, Modelo, Tipo_Combustible, Estado) values " +
                            "(@descripcion, @chasis, @motor, @placa, @vehiculo, @marca, @modelo, @tipocomb, @estado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("descripcion", txtdescveh.Text);
                    cmd.Parameters.AddWithValue("chasis", txtnocha.Text);
                    cmd.Parameters.AddWithValue("motor", txtxnomot.Text);
                    cmd.Parameters.AddWithValue("placa", txtnoplac.Text);
                    cmd.Parameters.AddWithValue("vehiculo", id);
                    cmd.Parameters.AddWithValue("marca", id2);
                    cmd.Parameters.AddWithValue("modelo", id3);
                    cmd.Parameters.AddWithValue("tipocomb", id4);
                    cmd.Parameters.AddWithValue("estado", comboBox2.Text);
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
            string eID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            int id = Convert.ToInt32(eID);
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string str = "Select v.ID, v.Descripcion, v.No_Chasis as [No. Chasis], v.No_Motor as [No. Motor], v.No_Placa as [No. Placa], t.Descripcion as [Tipo de vehiculo], m.Descripcion as Marca, o.Descripcion as Modelo, c.Descripcion as [Tipo de combustible], v.Estado from Vehiculo v INNER JOIN Tipo_vehiculos t on v.Tipo_vehiculo = t.ID INNER JOIN Marcas m on v.Marca = m.ID INNER JOIN Modelos o on v.Modelo = o.ID INNER JOIN Tipo_combustible c on v.Tipo_Combustible = c.ID where v.ID = @id;";
            SqlCommand cmd = new SqlCommand(str,conexion);
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader carro = cmd.ExecuteReader();
            if (carro.Read())
            {
                txtdescveh.Text = carro["Descripcion"].ToString();
                txtnocha.Text = carro["No. Chasis"].ToString();
                txtxnomot.Text = carro["No. Motor"].ToString();
                txtnoplac.Text = carro["No. Placa"].ToString();
                Combtipoveh.Text = carro["Tipo de vehiculo"].ToString();
                Combomarca.Text = carro["Marca"].ToString();
                combomod.Text = carro["Modelo"].ToString();
                combocomb.Text = carro["Tipo de combustible"].ToString();
                comboBox2.Text = carro["Estado"].ToString();
            }
        }

        private void limpiar()
        {
            txtdescveh.Text = "";
            comboBox2.SelectedItem = null;
            Combomarca.Text = "Marcas";
            combomod.Text = "Modelos";
            txtnocha.Text = "";
            txtnoplac.Text = "";
            combocomb.Text = "Tipo de combustible";
            Combtipoveh.Text = "Tipo de vehiculo";
            txtxnomot.Text = "";
        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select v.ID, v.Descripcion, v.No_Chasis as [No. Chasis], v.No_Motor as [No. Motor], v.No_Placa as [No. Placa], t.Descripcion as [Tipo de vehiculo], m.Descripcion as Marca, o.Descripcion as Modelo, c.Descripcion as [Tipo de combustible], v.Estado from Vehiculo v INNER JOIN Tipo_vehiculos t on v.Tipo_vehiculo = t.ID INNER JOIN Marcas m on v.Marca = m.ID INNER JOIN Modelos o on v.Modelo = o.ID INNER JOIN Tipo_combustible c on v.Tipo_Combustible = c.ID; ";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void llenartipoveh()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select ID, Descripcion from Tipo_Vehiculos where Estado = 'Activo';";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Descripcion"] = "Tipo de vehiculo";
            dt.Rows.InsertAt(fila, 0);

            Combtipoveh.ValueMember = "ID";
            Combtipoveh.DisplayMember = "Descripcion";
            Combtipoveh.DataSource = dt;
        }
        private void llenarmarca()
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
            fila["Descripcion"] = "Marcas";
            dt.Rows.InsertAt(fila, 0);

            Combomarca.ValueMember = "ID";
            Combomarca.DisplayMember = "Descripcion";
            Combomarca.DataSource = dt;
        }
        private void llenarmodelo(string id_marca)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select ID, Descripcion from Modelos where Estado = 'Activo' AND ID_Marca = @id_marca;";
            SqlCommand cmd = new SqlCommand(strSql, conexion);
            cmd.Parameters.AddWithValue("id_marca", id_marca);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow dr = dt.NewRow();
            dr["Descripcion"] = "Modelos";
            dt.Rows.InsertAt(dr, 0);

            combomod.ValueMember = "ID";
            combomod.DisplayMember = "Descripcion";
            combomod.DataSource = dt;
        }
        private void llenartipocomb()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select ID, Descripcion from Tipo_combustible where Estado = 'Activo';";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Descripcion"] = "Tipo de combustible";
            dt.Rows.InsertAt(fila, 0);

            combocomb.ValueMember = "ID";
            combocomb.DisplayMember = "Descripcion";
            combocomb.DataSource = dt;
        }

        private void Combomarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combomarca.SelectedValue.ToString() != null)
            {
                string id_marca = Combomarca.SelectedValue.ToString();
                llenarmodelo(id_marca);
            }
        }

        private void txtbusqueda1_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "Select v.ID, v.Descripcion, v.No_Chasis as [No. Chasis], v.No_Motor as [No. Motor], v.No_Placa as [No. Placa], t.Descripcion as [Tipo de vehiculo], m.Descripcion as Marca, o.Descripcion as Modelo, c.Descripcion as [Tipo de combustible], v.Estado from Vehiculo v INNER JOIN Tipo_vehiculos t on v.Tipo_vehiculo = t.ID INNER JOIN Marcas m on v.Marca = m.ID INNER JOIN Modelos o on v.Modelo = o.ID INNER JOIN Tipo_combustible c on v.Tipo_Combustible = c.ID where v.Descripcion like '%" + txtbusqueda1.Text + "%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Vehiculo");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Vehiculo";
        }
    }
}

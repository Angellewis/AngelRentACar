using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelRentCar
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AngelRentCarDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.AngelRentCarDataSet.Clientes);

        }

        private void btnnuevomarc_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneditmarc_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            string persona;
            if (radioButton1.Checked == true)
            {
                persona = "Fisica";
            }
            else
            {
                persona = "Juridica";
            }
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "UPDATE Clientes SET Nombre='" + txtnombre.Text + "', Cedula='" + txtcedula.Text + "', No_Tarjeta='" + txtCR.Text + "', Limite_Cred='" + txtlimite.Text + "', Tipo_Persona='" + persona + "', Estado='" + comboBox2.Text + "' WHERE ID= '" + id + "';";

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

                string str = "DELETE FROM Clientes WHERE ID = " + id + ";";

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
            string persona;
            if (radioButton1.Checked == true)
            {
                persona = "Fisica";
            }
            else
            {
                persona = "Juridica";
            }
            try
            {
                if (txtnombre.Text == "" || txtcedula.Text == "" || txtCR.Text == "" || comboBox2.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Debe rellenar los campos");
                }
                else if (Convert.ToInt32(txtlimite.Text) < 0)
                {
                    MessageBox.Show("El limite de credito no puede ser negativo");
                } 
                else if (validaCedula(txtcedula.Text) == false)
                {
                    MessageBox.Show("Cedula no valida");
                }
                else
                {
                    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    SqlConnection conexion = new SqlConnection(con);
                    conexion.Open();
                    string strSql = "insert into Clientes (Nombre, Cedula, No_Tarjeta, Limite_Cred, Tipo_Persona, Estado) values " +
                            "(@nombre, @cedula, @tarjeta, @limite, @persona, @estado)";

                    SqlCommand cmd = new SqlCommand(strSql, conexion);
                    cmd.Parameters.AddWithValue("nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("cedula", txtcedula.Text);
                    cmd.Parameters.AddWithValue("tarjeta", txtCR.Text);
                    cmd.Parameters.AddWithValue("limite", txtlimite.Text);
                    cmd.Parameters.AddWithValue("persona", persona);
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
            txtnombre.Text = "";
            txtcedula.Text = "";
            txtCR.Text = "";
            txtlimite.Text = "";
            comboBox2.SelectedItem = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        public DataTable obtenerDatos()
        {
            DataTable dt = new DataTable();
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            conexion.Open();
            string strSql = "Select * from Clientes;";
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion);
            da.Fill(dt);
            return dt;
        }
        private void mostarDatos()
        {
            DataTable dt = obtenerDatos();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string eID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            string enombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
            string ecedula = dataGridView1.SelectedRows[0].Cells["Cedula"].Value.ToString();
            string etarjeta = dataGridView1.SelectedRows[0].Cells["No_Tarjeta"].Value.ToString();
            string elimite = dataGridView1.SelectedRows[0].Cells["Limite_Cred"].Value.ToString();
            string epersona = dataGridView1.SelectedRows[0].Cells["Tipo_Persona"].Value.ToString();
            string eEstado = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();

            txtnombre.Text = enombre;
            txtcedula.Text = ecedula;
            txtCR.Text = etarjeta;
            txtlimite.Text = elimite;
            comboBox2.Text = eEstado;

            if (epersona == "Fisica")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void txtbusqueda1_TextChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection conexion = new SqlConnection(con);
            string strl = "Select * from Clientes where Nombre like '%" + txtbusqueda1.Text + "%';";
            SqlDataAdapter ada = new SqlDataAdapter(strl, conexion);
            conexion.Open();

            DataSet dt = new DataSet();

            ada.Fill(dt, "Clientes");

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Clientes";
        }
        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
            {
                return false;
            }
            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                {
                    vnTotal += vCalculo;
                }
                else
                {
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
                } 
            }
            if (vnTotal % 10 == 0)
            {
                return true;
            }  
            else
            {
                return false;
            }
        }
    }
}

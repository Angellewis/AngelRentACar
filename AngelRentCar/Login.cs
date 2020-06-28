using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AngelRentCar
{
    public partial class Login : Form
    {
        Conexion con = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = ((Form1)this.MdiParent);
            Login lr = new Login();
            if (txtusuario.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Introduzca todos sus datos por favor");
            }
            else
            {
                logear(txtusuario.Text, txtpass.Text);
            }
        }
        
        public void logear(string usuario, string clave)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT e.Nombre, u.Tipo_usuario FROM Empleados e INNER JOIN Usuarios u ON e.ID = u.ID_empleado WHERE u.usuario = @usuario AND u.Contra = @clave;", conexion);
                cmd.Parameters.AddWithValue("usuario", txtusuario.Text);
                cmd.Parameters.AddWithValue("clave", txtpass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin" || dt.Rows[0][1].ToString() == "admin")
                    {
                        MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString());
                        string admin = dt.Rows[0][1].ToString();
                        Form1 fr = ((Form1)this.MdiParent);
                        this.Close();
                        fr.lblidempleado.Text = dt.Rows[0][0].ToString();
                        fr.menuStrip1.Show();
                        conexion.Close();

                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario" || dt.Rows[0][1].ToString() == "usuario")
                    {
                        MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString());
                        string user = dt.Rows[0][1].ToString();
                        Form1 fr = ((Form1)this.MdiParent);
                        this.Close();
                        fr.lblidempleado.Text = dt.Rows[0][0].ToString();
                        fr.menuStrip1.Show();
                        fr.usuariosToolStripMenuItem.Enabled = false;
                        conexion.Close();
                    }
                }
                else
                {
                    lblerror.Text = "DATOS ERRONEOS";
                }

            }
            catch (Exception a)
            {

            }
        } 
        
    }
}

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
    public partial class eliminarconfirm : Form
    {
        public eliminarconfirm()
        {
            InitializeComponent();
    }
        public string id;
        public void button1_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            try
                {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                SqlConnection conexion = new SqlConnection(con);
                conexion.Open();

                string str = "DELETE FROM Usuarios WHERE ID = " + id + ";";

                SqlCommand cmd = new SqlCommand(str, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                this.Close();
                }
                catch (Exception p) { MessageBox.Show(" No se pudieron eliminar los datos"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

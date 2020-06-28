using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelRentCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void login()
        {
            Login lg = new Login();
            lg.MdiParent = this;
            lg.Show();
        }
        public void menuPrincipal2()
        {
            Tipo_Vehiculo mp2 = new Tipo_Vehiculo();
            mp2.MdiParent = this;
            mp2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            lblidempleado.Hide();
            login();
        }

        private void tipoDeVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Vehiculo mp = new Tipo_Vehiculo();
            mp.MdiParent = this;
            mp.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas mc = new Marcas();
            mc.MdiParent = this;
            mc.Show();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelos mc = new Modelos();
            mc.MdiParent = this;
            mc.Show();
        }

        private void combustiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipos_de_combustible mc = new Tipos_de_combustible();
            mc.MdiParent = this;
            mc.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos mc = new Vehiculos();
            mc.MdiParent = this;
            mc.Show();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes mc = new Clientes();
            mc.MdiParent = this;
            mc.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados mp = new Empleados();
            mp.MdiParent = this;
            mp.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.MdiParent = this;
            us.Show();
        }

        private void rentaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renta rt = new Renta();
            rt.MdiParent = this;
            rt.label1.Text = lblidempleado.Text;
            rt.Show();
        }

        private void devolucionDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion dv = new Devolucion();
            dv.MdiParent = this;
            dv.Show();
        }

        private void reporteDeRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes rp = new Reportes();
            rp.MdiParent = this;
            rp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            usuariosToolStripMenuItem.Enabled = true;
            menuStrip1.Hide();
            lblidempleado.Hide();
            login();
        }
    }
}

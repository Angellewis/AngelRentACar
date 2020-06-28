namespace AngelRentCar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combustiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaYDevolucionDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentaDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblidempleado = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeVehiculosToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeEmpleadosToolStripMenuItem,
            this.rentaYDevolucionDeVehiculosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1663, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeVehiculosToolStripMenuItem
            // 
            this.gestionDeVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeVehiculoToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.combustiblesToolStripMenuItem,
            this.vehiculosToolStripMenuItem});
            this.gestionDeVehiculosToolStripMenuItem.Name = "gestionDeVehiculosToolStripMenuItem";
            this.gestionDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.gestionDeVehiculosToolStripMenuItem.Text = "Gestion de Vehiculos";
            // 
            // tipoDeVehiculoToolStripMenuItem
            // 
            this.tipoDeVehiculoToolStripMenuItem.Name = "tipoDeVehiculoToolStripMenuItem";
            this.tipoDeVehiculoToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.tipoDeVehiculoToolStripMenuItem.Text = "Tipo de vehiculo";
            this.tipoDeVehiculoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeVehiculoToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.marcaToolStripMenuItem.Text = "Marcas";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // combustiblesToolStripMenuItem
            // 
            this.combustiblesToolStripMenuItem.Name = "combustiblesToolStripMenuItem";
            this.combustiblesToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.combustiblesToolStripMenuItem.Text = "Combustibles";
            this.combustiblesToolStripMenuItem.Click += new System.EventHandler(this.combustiblesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rentaYDevolucionDeVehiculosToolStripMenuItem
            // 
            this.rentaYDevolucionDeVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentaDeVehiculosToolStripMenuItem,
            this.devolucionDeVehiculosToolStripMenuItem});
            this.rentaYDevolucionDeVehiculosToolStripMenuItem.Name = "rentaYDevolucionDeVehiculosToolStripMenuItem";
            this.rentaYDevolucionDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.rentaYDevolucionDeVehiculosToolStripMenuItem.Text = "Renta y Devolucion de vehiculos";
            // 
            // rentaDeVehiculosToolStripMenuItem
            // 
            this.rentaDeVehiculosToolStripMenuItem.Name = "rentaDeVehiculosToolStripMenuItem";
            this.rentaDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.rentaDeVehiculosToolStripMenuItem.Text = "Renta de vehiculos";
            this.rentaDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.rentaDeVehiculosToolStripMenuItem_Click);
            // 
            // devolucionDeVehiculosToolStripMenuItem
            // 
            this.devolucionDeVehiculosToolStripMenuItem.Name = "devolucionDeVehiculosToolStripMenuItem";
            this.devolucionDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.devolucionDeVehiculosToolStripMenuItem.Text = "Devolucion de vehiculos";
            this.devolucionDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.devolucionDeVehiculosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeRentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeRentasToolStripMenuItem
            // 
            this.reporteDeRentasToolStripMenuItem.Name = "reporteDeRentasToolStripMenuItem";
            this.reporteDeRentasToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.reporteDeRentasToolStripMenuItem.Text = "Reporte de rentas";
            this.reporteDeRentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeRentasToolStripMenuItem_Click);
            // 
            // lblidempleado
            // 
            this.lblidempleado.AutoSize = true;
            this.lblidempleado.Location = new System.Drawing.Point(24, 842);
            this.lblidempleado.Name = "lblidempleado";
            this.lblidempleado.Size = new System.Drawing.Size(0, 17);
            this.lblidempleado.TabIndex = 3;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 878);
            this.Controls.Add(this.lblidempleado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentCar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combustiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentaYDevolucionDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentaDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeRentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        public System.Windows.Forms.Label lblidempleado;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}


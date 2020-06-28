namespace AngelRentCar
{
    partial class Inspeccion
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
            this.components = new System.ComponentModel.Container();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnnuevomarc = new System.Windows.Forms.Button();
            this.btneditmarc = new System.Windows.Forms.Button();
            this.btnguardmarc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ralladuras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goma_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rotura_cristal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_gomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado_insp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspeccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtxempleado = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.repuesto = new System.Windows.Forms.CheckBox();
            this.gato = new System.Windows.Forms.CheckBox();
            this.cristal = new System.Windows.Forms.CheckBox();
            this.comboveh = new System.Windows.Forms.ComboBox();
            this.combocli = new System.Windows.Forms.ComboBox();
            this.ralladura = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inspeccionTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.InspeccionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxcristal = new System.Windows.Forms.TextBox();
            this.txtgato = new System.Windows.Forms.TextBox();
            this.txtgoma = new System.Windows.Forms.TextBox();
            this.txtrallon = new System.Windows.Forms.TextBox();
            this.txtnombreemp = new System.Windows.Forms.TextBox();
            this.txtrol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(214, 463);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 118;
            this.label10.Text = " Estado de gomas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 17);
            this.label9.TabIndex = 117;
            this.label9.Text = "Cant. de combustible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 115;
            this.label7.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Vehiculo";
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(459, 497);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 110;
            this.btnnuevomarc.Text = "Nueva";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(615, 495);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(153, 41);
            this.btneditmarc.TabIndex = 108;
            this.btneditmarc.Text = "Eliminar Transaccion";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(776, 495);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 107;
            this.btnguardmarc.Text = "Guardar Inspeccion";
            this.btnguardmarc.UseVisualStyleBackColor = true;
            this.btnguardmarc.Click += new System.EventHandler(this.btnguardmarc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Vehiculo,
            this.ID_Cliente,
            this.Ralladuras,
            this.combustible,
            this.Goma_repuesto,
            this.Gato2,
            this.Rotura_cristal,
            this.Estado_gomas,
            this.Fecha2,
            this.Empleado_insp,
            this.Estado});
            this.dataGridView1.DataSource = this.inspeccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(459, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 433);
            this.dataGridView1.TabIndex = 106;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Vehiculo
            // 
            this.Vehiculo.DataPropertyName = "Vehiculo";
            this.Vehiculo.HeaderText = "Vehiculo";
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.ReadOnly = true;
            this.Vehiculo.Width = 91;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.DataPropertyName = "ID_Cliente";
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Width = 101;
            // 
            // Ralladuras
            // 
            this.Ralladuras.DataPropertyName = "Ralladuras";
            this.Ralladuras.HeaderText = "Ralladuras";
            this.Ralladuras.Name = "Ralladuras";
            this.Ralladuras.ReadOnly = true;
            this.Ralladuras.Width = 105;
            // 
            // combustible
            // 
            this.combustible.DataPropertyName = "Cant_Combustible";
            this.combustible.HeaderText = "Cant_Combustible";
            this.combustible.Name = "combustible";
            this.combustible.ReadOnly = true;
            this.combustible.Width = 151;
            // 
            // Goma_repuesto
            // 
            this.Goma_repuesto.DataPropertyName = "Goma_repuesto";
            this.Goma_repuesto.HeaderText = "Goma_repuesto";
            this.Goma_repuesto.Name = "Goma_repuesto";
            this.Goma_repuesto.ReadOnly = true;
            this.Goma_repuesto.Width = 139;
            // 
            // Gato2
            // 
            this.Gato2.DataPropertyName = "Gato";
            this.Gato2.HeaderText = "Gato";
            this.Gato2.Name = "Gato2";
            this.Gato2.ReadOnly = true;
            this.Gato2.Width = 68;
            // 
            // Rotura_cristal
            // 
            this.Rotura_cristal.DataPropertyName = "Rotura_cristal";
            this.Rotura_cristal.HeaderText = "Rotura_cristal";
            this.Rotura_cristal.Name = "Rotura_cristal";
            this.Rotura_cristal.ReadOnly = true;
            this.Rotura_cristal.Width = 125;
            // 
            // Estado_gomas
            // 
            this.Estado_gomas.DataPropertyName = "Estado_gomas";
            this.Estado_gomas.HeaderText = "Estado_gomas";
            this.Estado_gomas.Name = "Estado_gomas";
            this.Estado_gomas.ReadOnly = true;
            this.Estado_gomas.Width = 131;
            // 
            // Fecha2
            // 
            this.Fecha2.DataPropertyName = "Fecha";
            this.Fecha2.HeaderText = "Fecha";
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.ReadOnly = true;
            this.Fecha2.Width = 76;
            // 
            // Empleado_insp
            // 
            this.Empleado_insp.DataPropertyName = "Empleado_insp";
            this.Empleado_insp.HeaderText = "Empleado_insp";
            this.Empleado_insp.Name = "Empleado_insp";
            this.Empleado_insp.ReadOnly = true;
            this.Empleado_insp.Width = 134;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 81;
            // 
            // inspeccionBindingSource
            // 
            this.inspeccionBindingSource.DataMember = "Inspeccion";
            this.inspeccionBindingSource.DataSource = this.angelRentCarDataSet;
            // 
            // angelRentCarDataSet
            // 
            this.angelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.angelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 124;
            this.label8.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 427);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 17);
            this.label11.TabIndex = 125;
            this.label11.Text = "Empleado de inspeccion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 466);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 126;
            this.label12.Text = "Estado";
            // 
            // txtxempleado
            // 
            this.txtxempleado.Enabled = false;
            this.txtxempleado.Location = new System.Drawing.Point(214, 422);
            this.txtxempleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtxempleado.Name = "txtxempleado";
            this.txtxempleado.Size = new System.Drawing.Size(237, 22);
            this.txtxempleado.TabIndex = 127;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(214, 376);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(237, 22);
            this.txtfecha.TabIndex = 128;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 337);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 22);
            this.textBox3.TabIndex = 129;
            // 
            // repuesto
            // 
            this.repuesto.AutoSize = true;
            this.repuesto.Location = new System.Drawing.Point(214, 239);
            this.repuesto.Name = "repuesto";
            this.repuesto.Size = new System.Drawing.Size(156, 21);
            this.repuesto.TabIndex = 130;
            this.repuesto.Text = "Goma de repuesto?";
            this.repuesto.UseVisualStyleBackColor = true;
            // 
            // gato
            // 
            this.gato.AutoSize = true;
            this.gato.Location = new System.Drawing.Point(214, 266);
            this.gato.Name = "gato";
            this.gato.Size = new System.Drawing.Size(69, 21);
            this.gato.TabIndex = 131;
            this.gato.Text = "Gato?";
            this.gato.UseVisualStyleBackColor = true;
            // 
            // cristal
            // 
            this.cristal.AutoSize = true;
            this.cristal.Location = new System.Drawing.Point(214, 293);
            this.cristal.Name = "cristal";
            this.cristal.Size = new System.Drawing.Size(149, 21);
            this.cristal.TabIndex = 132;
            this.cristal.Text = "Roturas de cristal?";
            this.cristal.UseVisualStyleBackColor = true;
            // 
            // comboveh
            // 
            this.comboveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboveh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboveh.FormattingEnabled = true;
            this.comboveh.Location = new System.Drawing.Point(214, 51);
            this.comboveh.Name = "comboveh";
            this.comboveh.Size = new System.Drawing.Size(237, 24);
            this.comboveh.TabIndex = 133;
            // 
            // combocli
            // 
            this.combocli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combocli.FormattingEnabled = true;
            this.combocli.Location = new System.Drawing.Point(214, 112);
            this.combocli.Name = "combocli";
            this.combocli.Size = new System.Drawing.Size(237, 24);
            this.combocli.TabIndex = 134;
            // 
            // ralladura
            // 
            this.ralladura.AutoSize = true;
            this.ralladura.Location = new System.Drawing.Point(214, 212);
            this.ralladura.Name = "ralladura";
            this.ralladura.Size = new System.Drawing.Size(106, 21);
            this.ralladura.TabIndex = 135;
            this.ralladura.Text = "Ralladuras?";
            this.ralladura.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1/4",
            "1/2",
            "3/4",
            "Lleno"});
            this.comboBox1.Location = new System.Drawing.Point(214, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 136;
            // 
            // inspeccionTableAdapter
            // 
            this.inspeccionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 137;
            // 
            // txtxcristal
            // 
            this.txtxcristal.Location = new System.Drawing.Point(671, 575);
            this.txtxcristal.Margin = new System.Windows.Forms.Padding(4);
            this.txtxcristal.Name = "txtxcristal";
            this.txtxcristal.Size = new System.Drawing.Size(88, 22);
            this.txtxcristal.TabIndex = 138;
            // 
            // txtgato
            // 
            this.txtgato.Location = new System.Drawing.Point(579, 575);
            this.txtgato.Margin = new System.Windows.Forms.Padding(4);
            this.txtgato.Name = "txtgato";
            this.txtgato.Size = new System.Drawing.Size(84, 22);
            this.txtgato.TabIndex = 139;
            // 
            // txtgoma
            // 
            this.txtgoma.Location = new System.Drawing.Point(499, 575);
            this.txtgoma.Margin = new System.Windows.Forms.Padding(4);
            this.txtgoma.Name = "txtgoma";
            this.txtgoma.Size = new System.Drawing.Size(72, 22);
            this.txtgoma.TabIndex = 140;
            // 
            // txtrallon
            // 
            this.txtrallon.Location = new System.Drawing.Point(416, 575);
            this.txtrallon.Margin = new System.Windows.Forms.Padding(4);
            this.txtrallon.Name = "txtrallon";
            this.txtrallon.Size = new System.Drawing.Size(75, 22);
            this.txtrallon.TabIndex = 141;
            // 
            // txtnombreemp
            // 
            this.txtnombreemp.Location = new System.Drawing.Point(767, 575);
            this.txtnombreemp.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreemp.Name = "txtnombreemp";
            this.txtnombreemp.Size = new System.Drawing.Size(88, 22);
            this.txtnombreemp.TabIndex = 142;
            // 
            // txtrol
            // 
            this.txtrol.Location = new System.Drawing.Point(862, 575);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(87, 22);
            this.txtrol.TabIndex = 143;
            // 
            // Inspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 610);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.txtnombreemp);
            this.Controls.Add(this.txtrallon);
            this.Controls.Add(this.txtgoma);
            this.Controls.Add(this.txtgato);
            this.Controls.Add(this.txtxcristal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ralladura);
            this.Controls.Add(this.combocli);
            this.Controls.Add(this.comboveh);
            this.Controls.Add(this.cristal);
            this.Controls.Add(this.gato);
            this.Controls.Add(this.repuesto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtxempleado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btneditmarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inspeccion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspeccion";
            this.Load += new System.EventHandler(this.Inspeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnnuevomarc;
        private System.Windows.Forms.Button btneditmarc;
        private System.Windows.Forms.Button btnguardmarc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox repuesto;
        private System.Windows.Forms.CheckBox gato;
        private System.Windows.Forms.CheckBox cristal;
        private System.Windows.Forms.ComboBox comboveh;
        private System.Windows.Forms.ComboBox combocli;
        private System.Windows.Forms.CheckBox ralladura;
        private System.Windows.Forms.ComboBox comboBox1;
        private AngelRentCarDataSet angelRentCarDataSet;
        private System.Windows.Forms.BindingSource inspeccionBindingSource;
        private AngelRentCarDataSetTableAdapters.InspeccionTableAdapter inspeccionTableAdapter;
        public System.Windows.Forms.TextBox txtxempleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ralladuras;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goma_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rotura_cristal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_gomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_insp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtxcristal;
        private System.Windows.Forms.TextBox txtgato;
        private System.Windows.Forms.TextBox txtgoma;
        private System.Windows.Forms.TextBox txtrallon;
        private System.Windows.Forms.TextBox txtnombreemp;
        private System.Windows.Forms.TextBox txtrol;
    }
}
namespace AngelRentCar
{
    partial class Empleados
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttanda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnuevomarc = new System.Windows.Forms.Button();
            this.btnborrarmarc = new System.Windows.Forms.Button();
            this.btneditmarc = new System.Windows.Forms.Button();
            this.btnguardmarc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empleadosTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.EmpleadosTableAdapter();
            this.txtingreso = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbusqueda1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 411);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 98;
            this.label9.Text = "Fecha de ingreso";
            // 
            // txttanda
            // 
            this.txttanda.Location = new System.Drawing.Point(189, 256);
            this.txttanda.Margin = new System.Windows.Forms.Padding(4);
            this.txttanda.Name = "txttanda";
            this.txttanda.Size = new System.Drawing.Size(237, 22);
            this.txttanda.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Tanda";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(189, 195);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(237, 22);
            this.txtcedula.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Cedula";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(189, 140);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(237, 22);
            this.txtnombre.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 92;
            this.label5.Text = "Nombre";
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(7, 497);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 91;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnborrarmarc
            // 
            this.btnborrarmarc.Location = new System.Drawing.Point(363, 497);
            this.btnborrarmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarmarc.Name = "btnborrarmarc";
            this.btnborrarmarc.Size = new System.Drawing.Size(148, 41);
            this.btnborrarmarc.TabIndex = 90;
            this.btnborrarmarc.Text = "Eliminar";
            this.btnborrarmarc.UseVisualStyleBackColor = true;
            this.btnborrarmarc.Click += new System.EventHandler(this.btnborrarmarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(189, 497);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(148, 41);
            this.btneditmarc.TabIndex = 89;
            this.btneditmarc.Text = "Editar Datos";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(189, 565);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 88;
            this.btnguardmarc.Text = "Guardar Empleado";
            this.btnguardmarc.UseVisualStyleBackColor = true;
            this.btnguardmarc.Click += new System.EventHandler(this.btnguardmarc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Cedula,
            this.Tanda,
            this.Comision,
            this.Fecha,
            this.Estado});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(519, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 433);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Tanda
            // 
            this.Tanda.DataPropertyName = "Tanda";
            this.Tanda.HeaderText = "Tanda";
            this.Tanda.Name = "Tanda";
            this.Tanda.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha_Ingreso";
            this.Fecha.HeaderText = "Fecha de ingreso";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.angelRentCarDataSet;
            // 
            // angelRentCarDataSet
            // 
            this.angelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.angelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Gestion de empleados";
            // 
            // txtcomision
            // 
            this.txtcomision.Location = new System.Drawing.Point(189, 308);
            this.txtcomision.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(237, 22);
            this.txtcomision.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Comision";
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // txtingreso
            // 
            this.txtingreso.Location = new System.Drawing.Point(189, 354);
            this.txtingreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(237, 22);
            this.txtingreso.TabIndex = 101;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(189, 408);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 25);
            this.label11.TabIndex = 104;
            this.label11.Text = "Busqueda por Nombre";
            // 
            // txtbusqueda1
            // 
            this.txtbusqueda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda1.Location = new System.Drawing.Point(514, 55);
            this.txtbusqueda1.Name = "txtbusqueda1";
            this.txtbusqueda1.Size = new System.Drawing.Size(416, 30);
            this.txtbusqueda1.TabIndex = 103;
            this.txtbusqueda1.TextChanged += new System.EventHandler(this.txtbusqueda1_TextChanged);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbusqueda1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttanda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btnborrarmarc);
            this.Controls.Add(this.btneditmarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 753);
            this.MinimizeBox = false;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttanda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnuevomarc;
        private System.Windows.Forms.Button btnborrarmarc;
        private System.Windows.Forms.Button btneditmarc;
        private System.Windows.Forms.Button btnguardmarc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label label2;
        private AngelRentCarDataSet angelRentCarDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private AngelRentCarDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtingreso;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbusqueda1;
    }
}
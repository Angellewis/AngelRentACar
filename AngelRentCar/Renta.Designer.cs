namespace AngelRentCar
{
    partial class Renta
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
            this.label1 = new System.Windows.Forms.Label();
            this.combcliente = new System.Windows.Forms.ComboBox();
            this.combvehiculo = new System.Windows.Forms.ComboBox();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnuevomarc = new System.Windows.Forms.Button();
            this.btnguardmarc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentaDevolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.renta_DevolucionTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.Renta_DevolucionTableAdapter();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.No_Renta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montodiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantdiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDevolucionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // combcliente
            // 
            this.combcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combcliente.FormattingEnabled = true;
            this.combcliente.Location = new System.Drawing.Point(154, 281);
            this.combcliente.Name = "combcliente";
            this.combcliente.Size = new System.Drawing.Size(237, 24);
            this.combcliente.TabIndex = 83;
            // 
            // combvehiculo
            // 
            this.combvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combvehiculo.FormattingEnabled = true;
            this.combvehiculo.Location = new System.Drawing.Point(154, 231);
            this.combvehiculo.Name = "combvehiculo";
            this.combvehiculo.Size = new System.Drawing.Size(237, 24);
            this.combvehiculo.TabIndex = 82;
            // 
            // comboestado
            // 
            this.comboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.comboestado.Location = new System.Drawing.Point(154, 589);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(237, 24);
            this.comboestado.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 592);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 80;
            this.label10.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 532);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Comentario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 467);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "Cantidad de dias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 421);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Monto x Dia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Fecha";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(154, 418);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(237, 22);
            this.txtmonto.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Vehiculo";
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(433, 613);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 70;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(745, 613);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 67;
            this.btnguardmarc.Text = "Rentar";
            this.btnguardmarc.UseVisualStyleBackColor = true;
            this.btnguardmarc.Click += new System.EventHandler(this.btnguardmarc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_Renta,
            this.iDEmpleadoDataGridViewTextBoxColumn,
            this.iDVehiculoDataGridViewTextBoxColumn,
            this.iDClienteDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn,
            this.montodiaDataGridViewTextBoxColumn,
            this.cantdiaDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentaDevolucionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(433, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 433);
            this.dataGridView1.TabIndex = 66;
            // 
            // rentaDevolucionBindingSource
            // 
            this.rentaDevolucionBindingSource.DataMember = "Renta_Devolucion";
            this.rentaDevolucionBindingSource.DataSource = this.angelRentCarDataSet;
            // 
            // angelRentCarDataSet
            // 
            this.angelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.angelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Rentas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Fecha de devolucion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Empleado";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(154, 509);
            this.txtcomentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(237, 62);
            this.txtcomentario.TabIndex = 62;
            // 
            // renta_DevolucionTableAdapter
            // 
            this.renta_DevolucionTableAdapter.ClearBeforeFill = true;
            // 
            // txtempleado
            // 
            this.txtempleado.Enabled = false;
            this.txtempleado.Location = new System.Drawing.Point(154, 178);
            this.txtempleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(237, 22);
            this.txtempleado.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 378);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(155, 330);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker2.TabIndex = 87;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 465);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(236, 22);
            this.numericUpDown1.TabIndex = 88;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 662);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 22);
            this.textBox1.TabIndex = 89;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(589, 613);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(148, 41);
            this.btneliminar.TabIndex = 90;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtrol
            // 
            this.txtrol.Location = new System.Drawing.Point(210, 662);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(93, 22);
            this.txtrol.TabIndex = 91;
            // 
            // No_Renta
            // 
            this.No_Renta.DataPropertyName = "No_Renta";
            this.No_Renta.HeaderText = "No_Renta";
            this.No_Renta.Name = "No_Renta";
            this.No_Renta.ReadOnly = true;
            this.No_Renta.Width = 101;
            // 
            // iDEmpleadoDataGridViewTextBoxColumn
            // 
            this.iDEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ID_Empleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.HeaderText = "ID_Empleado";
            this.iDEmpleadoDataGridViewTextBoxColumn.Name = "iDEmpleadoDataGridViewTextBoxColumn";
            this.iDEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEmpleadoDataGridViewTextBoxColumn.Width = 121;
            // 
            // iDVehiculoDataGridViewTextBoxColumn
            // 
            this.iDVehiculoDataGridViewTextBoxColumn.DataPropertyName = "ID_Vehiculo";
            this.iDVehiculoDataGridViewTextBoxColumn.HeaderText = "ID_Vehiculo";
            this.iDVehiculoDataGridViewTextBoxColumn.Name = "iDVehiculoDataGridViewTextBoxColumn";
            this.iDVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVehiculoDataGridViewTextBoxColumn.Width = 112;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID_Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDClienteDataGridViewTextBoxColumn.Width = 101;
            // 
            // fechaRentaDataGridViewTextBoxColumn
            // 
            this.fechaRentaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Renta";
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "Fecha_Renta";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            this.fechaRentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaRentaDataGridViewTextBoxColumn.Width = 122;
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "Fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            this.fechadevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechadevolucionDataGridViewTextBoxColumn.Width = 152;
            // 
            // montodiaDataGridViewTextBoxColumn
            // 
            this.montodiaDataGridViewTextBoxColumn.DataPropertyName = "Monto_dia";
            this.montodiaDataGridViewTextBoxColumn.HeaderText = "Monto_dia";
            this.montodiaDataGridViewTextBoxColumn.Name = "montodiaDataGridViewTextBoxColumn";
            this.montodiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.montodiaDataGridViewTextBoxColumn.Width = 103;
            // 
            // cantdiaDataGridViewTextBoxColumn
            // 
            this.cantdiaDataGridViewTextBoxColumn.DataPropertyName = "Cant_dia";
            this.cantdiaDataGridViewTextBoxColumn.HeaderText = "Cant_dia";
            this.cantdiaDataGridViewTextBoxColumn.Name = "cantdiaDataGridViewTextBoxColumn";
            this.cantdiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantdiaDataGridViewTextBoxColumn.Width = 93;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Width = 109;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 81;
            // 
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.combcliente);
            this.Controls.Add(this.combvehiculo);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1531, 753);
            this.MinimizeBox = false;
            this.Name = "Renta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renta";
            this.Load += new System.EventHandler(this.Renta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDevolucionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combcliente;
        private System.Windows.Forms.ComboBox combvehiculo;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnuevomarc;
        private System.Windows.Forms.Button btnguardmarc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcomentario;
        private AngelRentCarDataSet angelRentCarDataSet;
        private System.Windows.Forms.BindingSource rentaDevolucionBindingSource;
        private AngelRentCarDataSetTableAdapters.Renta_DevolucionTableAdapter renta_DevolucionTableAdapter;
        public System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montodiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantdiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}
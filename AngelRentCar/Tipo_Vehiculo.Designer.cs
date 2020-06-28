namespace AngelRentCar
{
    partial class Tipo_Vehiculo
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
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AngelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.btnguartipo = new System.Windows.Forms.Button();
            this.tipo_VehiculosTableAdapter1 = new AngelRentCar.AngelRentCarDataSetTableAdapters.Tipo_VehiculosTableAdapter();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tipoVehiculosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(171, 230);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(237, 94);
            this.txtdesc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gestion de Tipos de vehiculos";
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
            this.Descripcion,
            this.Estado});
            this.dataGridView1.DataSource = this.tipoVehiculosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(631, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 433);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // tipoVehiculosBindingSource
            // 
            this.tipoVehiculosBindingSource.DataMember = "Tipo_Vehiculos";
            this.tipoVehiculosBindingSource.DataSource = this.AngelRentCarDataSet;
            // 
            // AngelRentCarDataSet
            // 
            this.AngelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.AngelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnguartipo
            // 
            this.btnguartipo.Location = new System.Drawing.Point(223, 576);
            this.btnguartipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguartipo.Name = "btnguartipo";
            this.btnguartipo.Size = new System.Drawing.Size(148, 41);
            this.btnguartipo.TabIndex = 6;
            this.btnguartipo.Text = "Guardar Tipo";
            this.btnguartipo.UseVisualStyleBackColor = true;
            this.btnguartipo.Click += new System.EventHandler(this.btnguartipo_Click);
            // 
            // tipo_VehiculosTableAdapter1
            // 
            this.tipo_VehiculosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(223, 492);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(148, 41);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Editar Datos";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(397, 492);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(148, 41);
            this.btnborrar.TabIndex = 8;
            this.btnborrar.Text = "Eliminar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(41, 492);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(148, 41);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(171, 375);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 34;
            // 
            // Tipo_Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnguartipo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdesc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 753);
            this.MinimizeBox = false;
            this.Name = "Tipo_Vehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de vehiculos";
            this.Load += new System.EventHandler(this.Tipo_Vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoVehiculosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguartipo;
        private System.Windows.Forms.BindingSource tipoVehiculosBindingSource1;
        private AngelRentCarDataSetTableAdapters.Tipo_VehiculosTableAdapter tipo_VehiculosTableAdapter1;
        private System.Windows.Forms.BindingSource tipoVehiculosBindingSource;
        private AngelRentCarDataSet AngelRentCarDataSet;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
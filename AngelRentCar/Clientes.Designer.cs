namespace AngelRentCar
{
    partial class Clientes
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
            this.txtCR = new System.Windows.Forms.TextBox();
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
            this.No_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite_Cred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AngelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlimite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.clientesTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.ClientesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbusqueda1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 427);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 370);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Tipo de persona";
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(177, 257);
            this.txtCR.Margin = new System.Windows.Forms.Padding(4);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(237, 22);
            this.txtCR.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Tarjeta de CR";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(177, 198);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(237, 22);
            this.txtcedula.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Cedula";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(177, 143);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(237, 22);
            this.txtnombre.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Nombre";
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(21, 534);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 67;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnborrarmarc
            // 
            this.btnborrarmarc.Location = new System.Drawing.Point(377, 534);
            this.btnborrarmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarmarc.Name = "btnborrarmarc";
            this.btnborrarmarc.Size = new System.Drawing.Size(148, 41);
            this.btnborrarmarc.TabIndex = 66;
            this.btnborrarmarc.Text = "Eliminar";
            this.btnborrarmarc.UseVisualStyleBackColor = true;
            this.btnborrarmarc.Click += new System.EventHandler(this.btnborrarmarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(203, 534);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(148, 41);
            this.btneditmarc.TabIndex = 65;
            this.btneditmarc.Text = "Editar Datos";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(203, 602);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 64;
            this.btnguardmarc.Text = "Guardar Cliente";
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
            this.No_Tarjeta,
            this.Limite_Cred,
            this.Tipo_Persona,
            this.Estado});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(572, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 433);
            this.dataGridView1.TabIndex = 63;
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
            // No_Tarjeta
            // 
            this.No_Tarjeta.DataPropertyName = "No_Tarjeta";
            this.No_Tarjeta.HeaderText = "Tarjeta de credito";
            this.No_Tarjeta.Name = "No_Tarjeta";
            this.No_Tarjeta.ReadOnly = true;
            // 
            // Limite_Cred
            // 
            this.Limite_Cred.DataPropertyName = "Limite_Cred";
            this.Limite_Cred.HeaderText = "Limite de credito";
            this.Limite_Cred.Name = "Limite_Cred";
            this.Limite_Cred.ReadOnly = true;
            // 
            // Tipo_Persona
            // 
            this.Tipo_Persona.DataPropertyName = "Tipo_Persona";
            this.Tipo_Persona.HeaderText = "Tipo de persona";
            this.Tipo_Persona.Name = "Tipo_Persona";
            this.Tipo_Persona.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.AngelRentCarDataSet;
            // 
            // AngelRentCarDataSet
            // 
            this.AngelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.AngelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Gestion de clientes";
            // 
            // txtlimite
            // 
            this.txtlimite.Location = new System.Drawing.Point(177, 311);
            this.txtlimite.Margin = new System.Windows.Forms.Padding(4);
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(237, 22);
            this.txtlimite.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Limite de credito";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 21);
            this.radioButton1.TabIndex = 80;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fisica";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 25);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 21);
            this.radioButton2.TabIndex = 82;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Juridica";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(177, 343);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(239, 59);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(177, 424);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(567, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 25);
            this.label11.TabIndex = 86;
            this.label11.Text = "Busqueda por Nombre";
            // 
            // txtbusqueda1
            // 
            this.txtbusqueda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda1.Location = new System.Drawing.Point(567, 83);
            this.txtbusqueda1.Name = "txtbusqueda1";
            this.txtbusqueda1.Size = new System.Drawing.Size(416, 30);
            this.txtbusqueda1.TabIndex = 85;
            this.txtbusqueda1.TextChanged += new System.EventHandler(this.txtbusqueda1_TextChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 706);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbusqueda1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCR);
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
            this.Controls.Add(this.txtlimite);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1531, 753);
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCR;
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
        private System.Windows.Forms.TextBox txtlimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private AngelRentCarDataSet AngelRentCarDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private AngelRentCarDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite_Cred;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbusqueda1;
    }
}
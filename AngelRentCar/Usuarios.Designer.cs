namespace AngelRentCar
{
    partial class Usuarios
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnuevomarc = new System.Windows.Forms.Button();
            this.btnborrarmarc = new System.Windows.Forms.Button();
            this.btneditmarc = new System.Windows.Forms.Button();
            this.btnguardmarc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuariosTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.UsuariosTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.Comboempleado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbusqueda1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 114;
            this.label7.Text = "Tipo de usuario";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(196, 215);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(237, 22);
            this.txtcontra.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(196, 160);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(237, 22);
            this.txtusuario.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "Usuario";
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(13, 413);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 109;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnborrarmarc
            // 
            this.btnborrarmarc.Location = new System.Drawing.Point(369, 413);
            this.btnborrarmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarmarc.Name = "btnborrarmarc";
            this.btnborrarmarc.Size = new System.Drawing.Size(148, 41);
            this.btnborrarmarc.TabIndex = 108;
            this.btnborrarmarc.Text = "Eliminar";
            this.btnborrarmarc.UseVisualStyleBackColor = true;
            this.btnborrarmarc.Click += new System.EventHandler(this.btnborrarmarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(195, 413);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(148, 41);
            this.btneditmarc.TabIndex = 107;
            this.btneditmarc.Text = "Editar Datos";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(195, 481);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 106;
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
            this.usuario,
            this.Contra,
            this.tipo_usuario,
            this.ID_empleado});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(526, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 433);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // Contra
            // 
            this.Contra.DataPropertyName = "Contra";
            this.Contra.HeaderText = "Contraseña";
            this.Contra.Name = "Contra";
            this.Contra.ReadOnly = true;
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.DataPropertyName = "Tipo_usuario";
            this.tipo_usuario.HeaderText = "Tipo de usuario";
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.ReadOnly = true;
            // 
            // ID_empleado
            // 
            this.ID_empleado.DataPropertyName = "ID_empleado";
            this.ID_empleado.HeaderText = "ID de empleado";
            this.ID_empleado.Name = "ID_empleado";
            this.ID_empleado.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.angelRentCarDataSet;
            // 
            // angelRentCarDataSet
            // 
            this.angelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.angelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Gestion de usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Empleado";
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboBox1.Location = new System.Drawing.Point(195, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 118;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(29, 528);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 119;
            // 
            // Comboempleado
            // 
            this.Comboempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comboempleado.FormattingEnabled = true;
            this.Comboempleado.Location = new System.Drawing.Point(196, 333);
            this.Comboempleado.Name = "Comboempleado";
            this.Comboempleado.Size = new System.Drawing.Size(237, 24);
            this.Comboempleado.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(521, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 25);
            this.label11.TabIndex = 122;
            this.label11.Text = "Busqueda por Usuario";
            // 
            // txtbusqueda1
            // 
            this.txtbusqueda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda1.Location = new System.Drawing.Point(521, 74);
            this.txtbusqueda1.Name = "txtbusqueda1";
            this.txtbusqueda1.Size = new System.Drawing.Size(416, 30);
            this.txtbusqueda1.TabIndex = 121;
            this.txtbusqueda1.TextChanged += new System.EventHandler(this.txtbusqueda1_TextChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 601);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbusqueda1);
            this.Controls.Add(this.Comboempleado);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btnborrarmarc);
            this.Controls.Add(this.btneditmarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 648);
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnuevomarc;
        private System.Windows.Forms.Button btnborrarmarc;
        private System.Windows.Forms.Button btneditmarc;
        private System.Windows.Forms.Button btnguardmarc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AngelRentCarDataSet angelRentCarDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private AngelRentCarDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_empleado;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox Comboempleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbusqueda1;
    }
}
namespace AngelRentCar
{
    partial class Modelos
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
            this.btnnuevomarc = new System.Windows.Forms.Button();
            this.btnborrarmarc = new System.Windows.Forms.Button();
            this.btneditmarc = new System.Windows.Forms.Button();
            this.btnguardmarc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AngelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescmodel = new System.Windows.Forms.TextBox();
            this.modelosTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.ModelosTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(44, 497);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 29;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnborrarmarc
            // 
            this.btnborrarmarc.Location = new System.Drawing.Point(400, 497);
            this.btnborrarmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarmarc.Name = "btnborrarmarc";
            this.btnborrarmarc.Size = new System.Drawing.Size(148, 41);
            this.btnborrarmarc.TabIndex = 28;
            this.btnborrarmarc.Text = "Eliminar";
            this.btnborrarmarc.UseVisualStyleBackColor = true;
            this.btnborrarmarc.Click += new System.EventHandler(this.btnborrarmarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(225, 497);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(148, 41);
            this.btneditmarc.TabIndex = 27;
            this.btneditmarc.Text = "Editar Datos";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(225, 581);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 26;
            this.btnguardmarc.Text = "Guardar Modelo";
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
            this.ID_Marca,
            this.Descripcion,
            this.Estado});
            this.dataGridView1.DataSource = this.modelosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(633, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 433);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_Marca
            // 
            this.ID_Marca.DataPropertyName = "ID_Marca";
            this.ID_Marca.HeaderText = "Identificador de marca";
            this.ID_Marca.Name = "ID_Marca";
            this.ID_Marca.ReadOnly = true;
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
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.AngelRentCarDataSet;
            // 
            // AngelRentCarDataSet
            // 
            this.AngelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.AngelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gestion de modelos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descripcion";
            // 
            // txtdescmodel
            // 
            this.txtdescmodel.Location = new System.Drawing.Point(173, 188);
            this.txtdescmodel.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescmodel.Multiline = true;
            this.txtdescmodel.Name = "txtdescmodel";
            this.txtdescmodel.Size = new System.Drawing.Size(237, 94);
            this.txtdescmodel.TabIndex = 20;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Marca";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(173, 329);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // Modelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btnborrarmarc);
            this.Controls.Add(this.btneditmarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescmodel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 753);
            this.MinimizeBox = false;
            this.Name = "Modelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.Modelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnuevomarc;
        private System.Windows.Forms.Button btnborrarmarc;
        private System.Windows.Forms.Button btneditmarc;
        private System.Windows.Forms.Button btnguardmarc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescmodel;
        private AngelRentCarDataSet AngelRentCarDataSet;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private AngelRentCarDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
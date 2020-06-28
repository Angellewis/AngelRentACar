namespace AngelRentCar
{
    partial class Tipos_de_combustible
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
            this.btnnuevocomb = new System.Windows.Forms.Button();
            this.btnborrarcomb = new System.Windows.Forms.Button();
            this.btneditcomb = new System.Windows.Forms.Button();
            this.btnguardcomb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AngelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesccomb = new System.Windows.Forms.TextBox();
            this.tipo_combustibleTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.Tipo_combustibleTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipocombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnuevocomb
            // 
            this.btnnuevocomb.Location = new System.Drawing.Point(43, 458);
            this.btnnuevocomb.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevocomb.Name = "btnnuevocomb";
            this.btnnuevocomb.Size = new System.Drawing.Size(148, 41);
            this.btnnuevocomb.TabIndex = 41;
            this.btnnuevocomb.Text = "Nuevo";
            this.btnnuevocomb.UseVisualStyleBackColor = true;
            this.btnnuevocomb.Click += new System.EventHandler(this.btnnuevocomb_Click);
            // 
            // btnborrarcomb
            // 
            this.btnborrarcomb.Location = new System.Drawing.Point(399, 458);
            this.btnborrarcomb.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarcomb.Name = "btnborrarcomb";
            this.btnborrarcomb.Size = new System.Drawing.Size(148, 41);
            this.btnborrarcomb.TabIndex = 40;
            this.btnborrarcomb.Text = "Eliminar";
            this.btnborrarcomb.UseVisualStyleBackColor = true;
            this.btnborrarcomb.Click += new System.EventHandler(this.btnborrarcomb_Click);
            // 
            // btneditcomb
            // 
            this.btneditcomb.Location = new System.Drawing.Point(224, 458);
            this.btneditcomb.Margin = new System.Windows.Forms.Padding(4);
            this.btneditcomb.Name = "btneditcomb";
            this.btneditcomb.Size = new System.Drawing.Size(148, 41);
            this.btneditcomb.TabIndex = 39;
            this.btneditcomb.Text = "Editar Datos";
            this.btneditcomb.UseVisualStyleBackColor = true;
            this.btneditcomb.Click += new System.EventHandler(this.btneditcomb_Click);
            // 
            // btnguardcomb
            // 
            this.btnguardcomb.Location = new System.Drawing.Point(224, 556);
            this.btnguardcomb.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardcomb.Name = "btnguardcomb";
            this.btnguardcomb.Size = new System.Drawing.Size(148, 54);
            this.btnguardcomb.TabIndex = 38;
            this.btnguardcomb.Text = "Guardar Combustible";
            this.btnguardcomb.UseVisualStyleBackColor = true;
            this.btnguardcomb.Click += new System.EventHandler(this.btnguardcomb_Click);
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
            this.dataGridView1.DataSource = this.tipocombustibleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(633, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 433);
            this.dataGridView1.TabIndex = 37;
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
            // tipocombustibleBindingSource
            // 
            this.tipocombustibleBindingSource.DataMember = "Tipo_combustible";
            this.tipocombustibleBindingSource.DataSource = this.AngelRentCarDataSet;
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
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Gestion de Tipos de combustible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descripcion";
            // 
            // txtdesccomb
            // 
            this.txtdesccomb.Location = new System.Drawing.Point(173, 188);
            this.txtdesccomb.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesccomb.Multiline = true;
            this.txtdesccomb.Name = "txtdesccomb";
            this.txtdesccomb.Size = new System.Drawing.Size(237, 94);
            this.txtdesccomb.TabIndex = 32;
            // 
            // tipo_combustibleTableAdapter
            // 
            this.tipo_combustibleTableAdapter.ClearBeforeFill = true;
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
            this.comboBox2.TabIndex = 42;
            // 
            // Tipos_de_combustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnnuevocomb);
            this.Controls.Add(this.btnborrarcomb);
            this.Controls.Add(this.btneditcomb);
            this.Controls.Add(this.btnguardcomb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdesccomb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 753);
            this.MinimizeBox = false;
            this.Name = "Tipos_de_combustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos_de_combustible";
            this.Load += new System.EventHandler(this.Tipos_de_combustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipocombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnnuevocomb;
        private System.Windows.Forms.Button btnborrarcomb;
        private System.Windows.Forms.Button btneditcomb;
        private System.Windows.Forms.Button btnguardcomb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesccomb;
        private AngelRentCarDataSet AngelRentCarDataSet;
        private System.Windows.Forms.BindingSource tipocombustibleBindingSource;
        private AngelRentCarDataSetTableAdapters.Tipo_combustibleTableAdapter tipo_combustibleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
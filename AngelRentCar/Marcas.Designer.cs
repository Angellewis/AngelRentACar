namespace AngelRentCar
{
    partial class Marcas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescmarca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angelRentCarDataSet1 = new AngelRentCar.AngelRentCarDataSet();
            this.marcasTableAdapter1 = new AngelRentCar.AngelRentCarDataSetTableAdapters.MarcasTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(44, 506);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 19;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnborrarmarc
            // 
            this.btnborrarmarc.Location = new System.Drawing.Point(400, 506);
            this.btnborrarmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarmarc.Name = "btnborrarmarc";
            this.btnborrarmarc.Size = new System.Drawing.Size(148, 41);
            this.btnborrarmarc.TabIndex = 18;
            this.btnborrarmarc.Text = "Eliminar";
            this.btnborrarmarc.UseVisualStyleBackColor = true;
            this.btnborrarmarc.Click += new System.EventHandler(this.btnborrarmarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(225, 506);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(148, 41);
            this.btneditmarc.TabIndex = 17;
            this.btneditmarc.Text = "Editar Datos";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(225, 590);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 16;
            this.btnguardmarc.Text = "Guardar Marca";
            this.btnguardmarc.UseVisualStyleBackColor = true;
            this.btnguardmarc.Click += new System.EventHandler(this.btnguardmarc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gestion de marcas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripcion";
            // 
            // txtdescmarca
            // 
            this.txtdescmarca.Location = new System.Drawing.Point(173, 244);
            this.txtdescmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescmarca.Multiline = true;
            this.txtdescmarca.Name = "txtdescmarca";
            this.txtdescmarca.Size = new System.Drawing.Size(237, 94);
            this.txtdescmarca.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDS,
            this.desc,
            this.est});
            this.dataGridView1.DataSource = this.marcasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(618, 188);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 469);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // IDS
            // 
            this.IDS.DataPropertyName = "ID";
            this.IDS.HeaderText = "ID";
            this.IDS.Name = "IDS";
            this.IDS.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "Descripcion";
            this.desc.HeaderText = "Descripcion";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // est
            // 
            this.est.DataPropertyName = "Estado";
            this.est.HeaderText = "Estado";
            this.est.Name = "est";
            this.est.ReadOnly = true;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.angelRentCarDataSet1;
            // 
            // angelRentCarDataSet1
            // 
            this.angelRentCarDataSet1.DataSetName = "AngelRentCarDataSet";
            this.angelRentCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter1
            // 
            this.marcasTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox2.Location = new System.Drawing.Point(173, 388);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 33;
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btnborrarmarc);
            this.Controls.Add(this.btneditmarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescmarca);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 753);
            this.MinimizeBox = false;
            this.Name = "Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnuevomarc;
        private System.Windows.Forms.Button btnborrarmarc;
        private System.Windows.Forms.Button btneditmarc;
        private System.Windows.Forms.Button btnguardmarc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescmarca;
        private AngelRentCarDataSet AngelRentCarDataSet;
        private AngelRentCarDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AngelRentCarDataSet angelRentCarDataSet1;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private AngelRentCarDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn est;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
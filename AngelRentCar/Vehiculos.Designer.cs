namespace AngelRentCar
{
    partial class Vehiculos
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
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AngelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescveh = new System.Windows.Forms.TextBox();
            this.vehiculoTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.VehiculoTableAdapter();
            this.txtnocha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxnomot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnoplac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Combtipoveh = new System.Windows.Forms.ComboBox();
            this.Combomarca = new System.Windows.Forms.ComboBox();
            this.combomod = new System.Windows.Forms.ComboBox();
            this.combocomb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbusqueda1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngelRentCarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnuevomarc
            // 
            this.btnnuevomarc.Location = new System.Drawing.Point(51, 581);
            this.btnnuevomarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevomarc.Name = "btnnuevomarc";
            this.btnnuevomarc.Size = new System.Drawing.Size(148, 41);
            this.btnnuevomarc.TabIndex = 41;
            this.btnnuevomarc.Text = "Nuevo";
            this.btnnuevomarc.UseVisualStyleBackColor = true;
            this.btnnuevomarc.Click += new System.EventHandler(this.btnnuevomarc_Click);
            // 
            // btnborrarmarc
            // 
            this.btnborrarmarc.Location = new System.Drawing.Point(407, 581);
            this.btnborrarmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnborrarmarc.Name = "btnborrarmarc";
            this.btnborrarmarc.Size = new System.Drawing.Size(148, 41);
            this.btnborrarmarc.TabIndex = 40;
            this.btnborrarmarc.Text = "Eliminar";
            this.btnborrarmarc.UseVisualStyleBackColor = true;
            this.btnborrarmarc.Click += new System.EventHandler(this.btnborrarmarc_Click);
            // 
            // btneditmarc
            // 
            this.btneditmarc.Location = new System.Drawing.Point(232, 581);
            this.btneditmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btneditmarc.Name = "btneditmarc";
            this.btneditmarc.Size = new System.Drawing.Size(148, 41);
            this.btneditmarc.TabIndex = 39;
            this.btneditmarc.Text = "Editar Datos";
            this.btneditmarc.UseVisualStyleBackColor = true;
            this.btneditmarc.Click += new System.EventHandler(this.btneditmarc_Click);
            // 
            // btnguardmarc
            // 
            this.btnguardmarc.Location = new System.Drawing.Point(232, 649);
            this.btnguardmarc.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardmarc.Name = "btnguardmarc";
            this.btnguardmarc.Size = new System.Drawing.Size(148, 41);
            this.btnguardmarc.TabIndex = 38;
            this.btnguardmarc.Text = "Guardar Vehiculo";
            this.btnguardmarc.UseVisualStyleBackColor = true;
            this.btnguardmarc.Click += new System.EventHandler(this.btnguardmarc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 433);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "Vehiculo";
            this.vehiculoBindingSource.DataSource = this.AngelRentCarDataSet;
            // 
            // AngelRentCarDataSet
            // 
            this.AngelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.AngelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Gestion de vehiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tipo de vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descripcion";
            // 
            // txtdescveh
            // 
            this.txtdescveh.Location = new System.Drawing.Point(173, 92);
            this.txtdescveh.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescveh.Multiline = true;
            this.txtdescveh.Name = "txtdescveh";
            this.txtdescveh.Size = new System.Drawing.Size(237, 62);
            this.txtdescveh.TabIndex = 32;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // txtnocha
            // 
            this.txtnocha.Location = new System.Drawing.Point(173, 185);
            this.txtnocha.Margin = new System.Windows.Forms.Padding(4);
            this.txtnocha.Name = "txtnocha";
            this.txtnocha.Size = new System.Drawing.Size(237, 22);
            this.txtnocha.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "No. Chasis";
            // 
            // txtxnomot
            // 
            this.txtxnomot.Location = new System.Drawing.Point(173, 234);
            this.txtxnomot.Margin = new System.Windows.Forms.Padding(4);
            this.txtxnomot.Name = "txtxnomot";
            this.txtxnomot.Size = new System.Drawing.Size(237, 22);
            this.txtxnomot.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "No. Motor";
            // 
            // txtnoplac
            // 
            this.txtnoplac.Location = new System.Drawing.Point(173, 281);
            this.txtnoplac.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoplac.Name = "txtnoplac";
            this.txtnoplac.Size = new System.Drawing.Size(237, 22);
            this.txtnoplac.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "No. Placa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 421);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tipo de combustible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 511);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Estado";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.comboBox2.Location = new System.Drawing.Point(173, 508);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 24);
            this.comboBox2.TabIndex = 57;
            // 
            // Combtipoveh
            // 
            this.Combtipoveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combtipoveh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combtipoveh.FormattingEnabled = true;
            this.Combtipoveh.Location = new System.Drawing.Point(173, 329);
            this.Combtipoveh.Name = "Combtipoveh";
            this.Combtipoveh.Size = new System.Drawing.Size(237, 24);
            this.Combtipoveh.TabIndex = 58;
            // 
            // Combomarca
            // 
            this.Combomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combomarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combomarca.FormattingEnabled = true;
            this.Combomarca.Location = new System.Drawing.Point(173, 375);
            this.Combomarca.Name = "Combomarca";
            this.Combomarca.Size = new System.Drawing.Size(237, 24);
            this.Combomarca.TabIndex = 59;
            this.Combomarca.SelectedIndexChanged += new System.EventHandler(this.Combomarca_SelectedIndexChanged);
            // 
            // combomod
            // 
            this.combomod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combomod.FormattingEnabled = true;
            this.combomod.Location = new System.Drawing.Point(173, 418);
            this.combomod.Name = "combomod";
            this.combomod.Size = new System.Drawing.Size(237, 24);
            this.combomod.TabIndex = 60;
            // 
            // combocomb
            // 
            this.combocomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combocomb.FormattingEnabled = true;
            this.combocomb.Location = new System.Drawing.Point(173, 463);
            this.combocomb.Name = "combocomb";
            this.combocomb.Size = new System.Drawing.Size(237, 24);
            this.combocomb.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(586, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "Busqueda por Descripcion";
            // 
            // txtbusqueda1
            // 
            this.txtbusqueda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda1.Location = new System.Drawing.Point(586, 145);
            this.txtbusqueda1.Name = "txtbusqueda1";
            this.txtbusqueda1.Size = new System.Drawing.Size(416, 30);
            this.txtbusqueda1.TabIndex = 62;
            this.txtbusqueda1.TextChanged += new System.EventHandler(this.txtbusqueda1_TextChanged);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 706);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbusqueda1);
            this.Controls.Add(this.combocomb);
            this.Controls.Add(this.combomod);
            this.Controls.Add(this.Combomarca);
            this.Controls.Add(this.Combtipoveh);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnoplac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtxnomot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnocha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnnuevomarc);
            this.Controls.Add(this.btnborrarmarc);
            this.Controls.Add(this.btneditmarc);
            this.Controls.Add(this.btnguardmarc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescveh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1531, 753);
            this.MinimizeBox = false;
            this.Name = "Vehiculos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtdescveh;
        private AngelRentCarDataSet AngelRentCarDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private AngelRentCarDataSetTableAdapters.VehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.TextBox txtnocha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtxnomot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnoplac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox Combtipoveh;
        private System.Windows.Forms.ComboBox Combomarca;
        private System.Windows.Forms.ComboBox combomod;
        private System.Windows.Forms.ComboBox combocomb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbusqueda1;
    }
}
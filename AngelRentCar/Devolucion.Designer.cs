namespace AngelRentCar
{
    partial class Devolucion
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
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btndevolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.angelRentCarDataSet = new AngelRentCar.AngelRentCarDataSet();
            this.rentaDevolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.renta_DevolucionTableAdapter = new AngelRentCar.AngelRentCarDataSetTableAdapters.Renta_DevolucionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDevolucionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboestado
            // 
            this.comboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.comboestado.Location = new System.Drawing.Point(195, 715);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(237, 24);
            this.comboestado.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 718);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 105;
            this.label10.Text = "Estado";
            // 
            // btndevolver
            // 
            this.btndevolver.Location = new System.Drawing.Point(1045, 249);
            this.btndevolver.Margin = new System.Windows.Forms.Padding(4);
            this.btndevolver.Name = "btndevolver";
            this.btndevolver.Size = new System.Drawing.Size(185, 101);
            this.btndevolver.TabIndex = 96;
            this.btndevolver.Text = "Procesar devolucion";
            this.btndevolver.UseVisualStyleBackColor = true;
            this.btndevolver.Click += new System.EventHandler(this.btndevolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 433);
            this.dataGridView1.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Devoluciones";
            // 
            // angelRentCarDataSet
            // 
            this.angelRentCarDataSet.DataSetName = "AngelRentCarDataSet";
            this.angelRentCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentaDevolucionBindingSource
            // 
            this.rentaDevolucionBindingSource.DataMember = "Renta_Devolucion";
            this.rentaDevolucionBindingSource.DataSource = this.angelRentCarDataSet;
            // 
            // renta_DevolucionTableAdapter
            // 
            this.renta_DevolucionTableAdapter.ClearBeforeFill = true;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 706);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btndevolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1373, 753);
            this.MinimizeBox = false;
            this.Name = "Devolucion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angelRentCarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDevolucionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btndevolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private AngelRentCarDataSet angelRentCarDataSet;
        private System.Windows.Forms.BindingSource rentaDevolucionBindingSource;
        private AngelRentCarDataSetTableAdapters.Renta_DevolucionTableAdapter renta_DevolucionTableAdapter;
    }
}
namespace InterfazGrafica.InterfazFactura
{
    partial class FormFacturacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridViewF = new System.Windows.Forms.DataGridView();
            this.dataGridViewLD = new System.Windows.Forms.DataGridView();
            this.lbFacturas = new System.Windows.Forms.Label();
            this.lbLineas = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula del cliente:";
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(143, 48);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 20);
            this.tbCedula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rango de fechas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "----";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(386, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(386, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(633, 48);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 39);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(633, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 39);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // dataGridViewF
            // 
            this.dataGridViewF.AllowUserToAddRows = false;
            this.dataGridViewF.AllowUserToDeleteRows = false;
            this.dataGridViewF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.Location = new System.Drawing.Point(46, 123);
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.ReadOnly = true;
            this.dataGridViewF.Size = new System.Drawing.Size(336, 139);
            this.dataGridViewF.TabIndex = 19;
            // 
            // dataGridViewLD
            // 
            this.dataGridViewLD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLD.Location = new System.Drawing.Point(46, 304);
            this.dataGridViewLD.Name = "dataGridViewLD";
            this.dataGridViewLD.Size = new System.Drawing.Size(336, 147);
            this.dataGridViewLD.TabIndex = 20;
            // 
            // lbFacturas
            // 
            this.lbFacturas.AutoSize = true;
            this.lbFacturas.Location = new System.Drawing.Point(46, 99);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(100, 13);
            this.lbFacturas.TabIndex = 21;
            this.lbFacturas.Text = "Historial de facturas";
            // 
            // lbLineas
            // 
            this.lbLineas.AutoSize = true;
            this.lbLineas.Location = new System.Drawing.Point(49, 285);
            this.lbLineas.Name = "lbLineas";
            this.lbLineas.Size = new System.Drawing.Size(89, 13);
            this.lbLineas.TabIndex = 22;
            this.lbLineas.Text = "Lineas de factura";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(425, 438);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(79, 13);
            this.lbTotal.TabIndex = 23;
            this.lbTotal.Text = "Total facturado";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(520, 431);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 24;
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbLineas);
            this.Controls.Add(this.lbFacturas);
            this.Controls.Add(this.dataGridViewLD);
            this.Controls.Add(this.dataGridViewF);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.label1);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridViewF;
        private System.Windows.Forms.DataGridView dataGridViewLD;
        private System.Windows.Forms.Label lbFacturas;
        private System.Windows.Forms.Label lbLineas;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbTotal;
    }
}
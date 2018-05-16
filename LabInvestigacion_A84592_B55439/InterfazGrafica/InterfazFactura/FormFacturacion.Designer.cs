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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula del cliente:";
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(181, 63);
            this.tbCedula.Margin = new System.Windows.Forms.Padding(4);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(247, 24);
            this.tbCedula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rango de fechas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "----";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(636, 207);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 24);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(636, 306);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(321, 27);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Silver;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(828, 373);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 40);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Silver;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(839, 556);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 34);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // dataGridViewF
            // 
            this.dataGridViewF.AllowUserToAddRows = false;
            this.dataGridViewF.AllowUserToDeleteRows = false;
            this.dataGridViewF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.Location = new System.Drawing.Point(61, 161);
            this.dataGridViewF.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.ReadOnly = true;
            this.dataGridViewF.Size = new System.Drawing.Size(448, 182);
            this.dataGridViewF.TabIndex = 19;
            // 
            // dataGridViewLD
            // 
            this.dataGridViewLD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLD.Location = new System.Drawing.Point(61, 398);
            this.dataGridViewLD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLD.Name = "dataGridViewLD";
            this.dataGridViewLD.Size = new System.Drawing.Size(448, 192);
            this.dataGridViewLD.TabIndex = 20;
            // 
            // lbFacturas
            // 
            this.lbFacturas.AutoSize = true;
            this.lbFacturas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturas.Location = new System.Drawing.Point(61, 129);
            this.lbFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(127, 17);
            this.lbFacturas.TabIndex = 21;
            this.lbFacturas.Text = "Historial de facturas";
            // 
            // lbLineas
            // 
            this.lbLineas.AutoSize = true;
            this.lbLineas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineas.Location = new System.Drawing.Point(65, 373);
            this.lbLineas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLineas.Name = "lbLineas";
            this.lbLineas.Size = new System.Drawing.Size(109, 17);
            this.lbLineas.TabIndex = 22;
            this.lbLineas.Text = "Lineas de factura";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(517, 573);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(99, 17);
            this.lbTotal.TabIndex = 23;
            this.lbTotal.Text = "Total facturado";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(624, 566);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(132, 24);
            this.tbTotal.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(461, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Facturación";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 622);
            this.Controls.Add(this.label4);
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
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
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
        private System.Windows.Forms.Label label4;
    }
}
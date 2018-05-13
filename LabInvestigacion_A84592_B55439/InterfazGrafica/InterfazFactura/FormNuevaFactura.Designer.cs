namespace InterfazGrafica.InterfazFactura
{
    partial class FormNuevaFactura
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
            this.lbID = new System.Windows.Forms.Label();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbCodigoP = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCodigoP = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.tbFactura = new System.Windows.Forms.TextBox();
            this.lbFactura = new System.Windows.Forms.Label();
            this.lbRequisito = new System.Windows.Forms.Label();
            this.lbNumeroLinea = new System.Windows.Forms.Label();
            this.tbNumeroLinea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Factura";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(68, 74);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(97, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Seleccionar cliente";
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(171, 67);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 20);
            this.tbCedula.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 84);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(290, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lbCodigoP
            // 
            this.lbCodigoP.AutoSize = true;
            this.lbCodigoP.Location = new System.Drawing.Point(577, 306);
            this.lbCodigoP.Name = "lbCodigoP";
            this.lbCodigoP.Size = new System.Drawing.Size(102, 13);
            this.lbCodigoP.TabIndex = 7;
            this.lbCodigoP.Text = "Codigo del producto";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(574, 224);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(121, 13);
            this.lbDetalle.TabIndex = 8;
            this.lbDetalle.Text = "Agregar linea de detalle:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(574, 382);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 9;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(574, 343);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 10;
            this.lbPrecio.Text = "Precio";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(828, 372);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(114, 23);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "Agregar detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(68, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(430, 150);
            this.dataGridView2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lineas de detalle";
            // 
            // tbCodigoP
            // 
            this.tbCodigoP.Location = new System.Drawing.Point(692, 299);
            this.tbCodigoP.Name = "tbCodigoP";
            this.tbCodigoP.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoP.TabIndex = 16;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(692, 336);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 17;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(692, 375);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 18;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(577, 426);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(187, 23);
            this.btnCrearFactura.TabIndex = 13;
            this.btnCrearFactura.Text = "Crear factura y salir ";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // tbFactura
            // 
            this.tbFactura.Location = new System.Drawing.Point(692, 149);
            this.tbFactura.Name = "tbFactura";
            this.tbFactura.Size = new System.Drawing.Size(100, 20);
            this.tbFactura.TabIndex = 11;
            // 
            // lbFactura
            // 
            this.lbFactura.AutoSize = true;
            this.lbFactura.Location = new System.Drawing.Point(574, 152);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(98, 13);
            this.lbFactura.TabIndex = 6;
            this.lbFactura.Text = "Numero de Factura";
            // 
            // lbRequisito
            // 
            this.lbRequisito.AutoSize = true;
            this.lbRequisito.Location = new System.Drawing.Point(570, 111);
            this.lbRequisito.Name = "lbRequisito";
            this.lbRequisito.Size = new System.Drawing.Size(194, 13);
            this.lbRequisito.TabIndex = 5;
            this.lbRequisito.Text = "Rellene los siguientes datos obligatorios";
            // 
            // lbNumeroLinea
            // 
            this.lbNumeroLinea.AutoSize = true;
            this.lbNumeroLinea.Location = new System.Drawing.Point(577, 262);
            this.lbNumeroLinea.Name = "lbNumeroLinea";
            this.lbNumeroLinea.Size = new System.Drawing.Size(88, 13);
            this.lbNumeroLinea.TabIndex = 19;
            this.lbNumeroLinea.Text = "Numero de Linea";
            // 
            // tbNumeroLinea
            // 
            this.tbNumeroLinea.Location = new System.Drawing.Point(692, 262);
            this.tbNumeroLinea.Name = "tbNumeroLinea";
            this.tbNumeroLinea.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroLinea.TabIndex = 20;
            // 
            // FormNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 503);
            this.Controls.Add(this.tbNumeroLinea);
            this.Controls.Add(this.lbNumeroLinea);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCodigoP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.tbFactura);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.lbCodigoP);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.lbRequisito);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Name = "FormNuevaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbCodigoP;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCodigoP;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.TextBox tbFactura;
        private System.Windows.Forms.Label lbFactura;
        private System.Windows.Forms.Label lbRequisito;
        private System.Windows.Forms.Label lbNumeroLinea;
        private System.Windows.Forms.TextBox tbNumeroLinea;
    }
}
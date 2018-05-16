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
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbCodigoP = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dataGridViewD = new System.Windows.Forms.DataGridView();
            this.FacturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaDetalleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Factura";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(38, 74);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(115, 16);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Cedula del cliente";
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(159, 74);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(100, 22);
            this.tbCedula.TabIndex = 2;
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.AllowUserToAddRows = false;
            this.dataGridViewC.AllowUserToDeleteRows = false;
            this.dataGridViewC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.Location = new System.Drawing.Point(41, 111);
            this.dataGridViewC.Name = "dataGridViewC";
            this.dataGridViewC.ReadOnly = true;
            this.dataGridViewC.Size = new System.Drawing.Size(474, 89);
            this.dataGridViewC.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(290, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Verificar cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lbCodigoP
            // 
            this.lbCodigoP.AutoSize = true;
            this.lbCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoP.Location = new System.Drawing.Point(574, 254);
            this.lbCodigoP.Name = "lbCodigoP";
            this.lbCodigoP.Size = new System.Drawing.Size(130, 16);
            this.lbCodigoP.TabIndex = 7;
            this.lbCodigoP.Text = "Código del producto";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(574, 354);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(62, 16);
            this.lbCantidad.TabIndex = 9;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(574, 303);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(47, 16);
            this.lbPrecio.TabIndex = 10;
            this.lbPrecio.Text = "Precio";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(663, 401);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(187, 39);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "Agregar detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // dataGridViewD
            // 
            this.dataGridViewD.AllowUserToAddRows = false;
            this.dataGridViewD.AllowUserToDeleteRows = false;
            this.dataGridViewD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacturaId,
            this.LineaDetalleId,
            this.ProductoId,
            this.Precio,
            this.Cantidad});
            this.dataGridViewD.Location = new System.Drawing.Point(41, 245);
            this.dataGridViewD.Name = "dataGridViewD";
            this.dataGridViewD.ReadOnly = true;
            this.dataGridViewD.Size = new System.Drawing.Size(474, 150);
            this.dataGridViewD.TabIndex = 14;
            // 
            // FacturaId
            // 
            this.FacturaId.Frozen = true;
            this.FacturaId.HeaderText = "# Factura";
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.ReadOnly = true;
            this.FacturaId.Width = 80;
            // 
            // LineaDetalleId
            // 
            this.LineaDetalleId.Frozen = true;
            this.LineaDetalleId.HeaderText = "# Linea de detalle";
            this.LineaDetalleId.Name = "LineaDetalleId";
            this.LineaDetalleId.ReadOnly = true;
            // 
            // ProductoId
            // 
            this.ProductoId.Frozen = true;
            this.ProductoId.HeaderText = "Codigo de Producto";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lineas de detalle";
            // 
            // tbCodigoP
            // 
            this.tbCodigoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoP.Location = new System.Drawing.Point(703, 251);
            this.tbCodigoP.Name = "tbCodigoP";
            this.tbCodigoP.Size = new System.Drawing.Size(100, 22);
            this.tbCodigoP.TabIndex = 16;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(703, 303);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 22);
            this.tbPrecio.TabIndex = 17;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(703, 354);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 22);
            this.tbCantidad.TabIndex = 18;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.Silver;
            this.btnCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.Location = new System.Drawing.Point(663, 446);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(187, 34);
            this.btnCrearFactura.TabIndex = 13;
            this.btnCrearFactura.Text = "Crear factura y salir ";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.BtnCrearFactura_Click);
            // 
            // tbFactura
            // 
            this.tbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFactura.Location = new System.Drawing.Point(703, 149);
            this.tbFactura.Name = "tbFactura";
            this.tbFactura.Size = new System.Drawing.Size(100, 22);
            this.tbFactura.TabIndex = 11;
            // 
            // lbFactura
            // 
            this.lbFactura.AutoSize = true;
            this.lbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactura.Location = new System.Drawing.Point(574, 152);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(123, 16);
            this.lbFactura.TabIndex = 6;
            this.lbFactura.Text = "Número de Factura";
            // 
            // lbRequisito
            // 
            this.lbRequisito.AutoSize = true;
            this.lbRequisito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequisito.Location = new System.Drawing.Point(570, 111);
            this.lbRequisito.Name = "lbRequisito";
            this.lbRequisito.Size = new System.Drawing.Size(251, 16);
            this.lbRequisito.TabIndex = 5;
            this.lbRequisito.Text = "Rellene los siguientes datos obligatorios";
            // 
            // lbNumeroLinea
            // 
            this.lbNumeroLinea.AutoSize = true;
            this.lbNumeroLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroLinea.Location = new System.Drawing.Point(574, 205);
            this.lbNumeroLinea.Name = "lbNumeroLinea";
            this.lbNumeroLinea.Size = new System.Drawing.Size(111, 16);
            this.lbNumeroLinea.TabIndex = 19;
            this.lbNumeroLinea.Text = "Número de Linea";
            // 
            // tbNumeroLinea
            // 
            this.tbNumeroLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroLinea.Location = new System.Drawing.Point(703, 199);
            this.tbNumeroLinea.Name = "tbNumeroLinea";
            this.tbNumeroLinea.Size = new System.Drawing.Size(100, 22);
            this.tbNumeroLinea.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(881, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 34);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(290, 410);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(60, 16);
            this.lbSubTotal.TabIndex = 22;
            this.lbSubTotal.Text = "Sub total";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(382, 404);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(133, 22);
            this.tbSubTotal.TabIndex = 23;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Silver;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(825, 145);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 24;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Silver;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(423, 67);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(92, 23);
            this.btnSeleccionar.TabIndex = 25;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // FormNuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(996, 503);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbNumeroLinea);
            this.Controls.Add(this.lbNumeroLinea);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCodigoP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewD);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.tbFactura);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbCodigoP);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.lbRequisito);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormNuevaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbCodigoP;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dataGridViewD;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaDetalleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}
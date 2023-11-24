namespace VentaClientesForm
{
    partial class MainFormVentas
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
            this.ProductosBox = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbPrecioTotal = new System.Windows.Forms.Label();
            this.lbMargenValorIVA = new System.Windows.Forms.Label();
            this.lbMargenPorcentajeIVA = new System.Windows.Forms.Label();
            this.lbMargenValorAdicional = new System.Windows.Forms.Label();
            this.lbMargenPorcentajeAdi = new System.Windows.Forms.Label();
            this.lbCostoTotal = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbCPP = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtMargenValorIVA = new System.Windows.Forms.TextBox();
            this.txtMargenPorcentajeIVA = new System.Windows.Forms.TextBox();
            this.txtMargenValorAdicional = new System.Windows.Forms.TextBox();
            this.txtMargenPorcentajeaAdi = new System.Windows.Forms.TextBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCPP = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.GrillaDeVentas = new System.Windows.Forms.GroupBox();
            this.lbMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ProductoGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotalGrilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.ProductosBox.SuspendLayout();
            this.GrillaDeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosBox
            // 
            this.ProductosBox.Controls.Add(this.btnSalir);
            this.ProductosBox.Controls.Add(this.btnLimpiar);
            this.ProductosBox.Controls.Add(this.btnQuitar);
            this.ProductosBox.Controls.Add(this.btnAgregar);
            this.ProductosBox.Controls.Add(this.lbPrecioTotal);
            this.ProductosBox.Controls.Add(this.lbMargenValorIVA);
            this.ProductosBox.Controls.Add(this.lbMargenPorcentajeIVA);
            this.ProductosBox.Controls.Add(this.lbMargenValorAdicional);
            this.ProductosBox.Controls.Add(this.lbMargenPorcentajeAdi);
            this.ProductosBox.Controls.Add(this.lbCostoTotal);
            this.ProductosBox.Controls.Add(this.lbCantidad);
            this.ProductosBox.Controls.Add(this.lbCPP);
            this.ProductosBox.Controls.Add(this.lbDescripcion);
            this.ProductosBox.Controls.Add(this.txtPrecioTotal);
            this.ProductosBox.Controls.Add(this.txtMargenValorIVA);
            this.ProductosBox.Controls.Add(this.txtMargenPorcentajeIVA);
            this.ProductosBox.Controls.Add(this.txtMargenValorAdicional);
            this.ProductosBox.Controls.Add(this.txtMargenPorcentajeaAdi);
            this.ProductosBox.Controls.Add(this.txtCostoTotal);
            this.ProductosBox.Controls.Add(this.txtCantidad);
            this.ProductosBox.Controls.Add(this.txtCPP);
            this.ProductosBox.Controls.Add(this.txtDescripcion);
            this.ProductosBox.Controls.Add(this.lbCodigo);
            this.ProductosBox.Controls.Add(this.txtCodigoBarras);
            this.ProductosBox.Location = new System.Drawing.Point(12, 12);
            this.ProductosBox.Name = "ProductosBox";
            this.ProductosBox.Size = new System.Drawing.Size(738, 234);
            this.ProductosBox.TabIndex = 4;
            this.ProductosBox.TabStop = false;
            this.ProductosBox.Text = "Productos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(470, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(367, 186);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(268, 186);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 21;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(169, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbPrecioTotal
            // 
            this.lbPrecioTotal.AutoSize = true;
            this.lbPrecioTotal.Location = new System.Drawing.Point(441, 135);
            this.lbPrecioTotal.Name = "lbPrecioTotal";
            this.lbPrecioTotal.Size = new System.Drawing.Size(93, 13);
            this.lbPrecioTotal.TabIndex = 19;
            this.lbPrecioTotal.Text = "PrecioTotalCliente";
            // 
            // lbMargenValorIVA
            // 
            this.lbMargenValorIVA.AutoSize = true;
            this.lbMargenValorIVA.Location = new System.Drawing.Point(441, 83);
            this.lbMargenValorIVA.Name = "lbMargenValorIVA";
            this.lbMargenValorIVA.Size = new System.Drawing.Size(84, 13);
            this.lbMargenValorIVA.TabIndex = 18;
            this.lbMargenValorIVA.Text = "MargenValorIVA";
            // 
            // lbMargenPorcentajeIVA
            // 
            this.lbMargenPorcentajeIVA.AutoSize = true;
            this.lbMargenPorcentajeIVA.Location = new System.Drawing.Point(441, 109);
            this.lbMargenPorcentajeIVA.Name = "lbMargenPorcentajeIVA";
            this.lbMargenPorcentajeIVA.Size = new System.Drawing.Size(68, 13);
            this.lbMargenPorcentajeIVA.TabIndex = 17;
            this.lbMargenPorcentajeIVA.Text = "MargenIVA%";
            // 
            // lbMargenValorAdicional
            // 
            this.lbMargenValorAdicional.AutoSize = true;
            this.lbMargenValorAdicional.Location = new System.Drawing.Point(441, 31);
            this.lbMargenValorAdicional.Name = "lbMargenValorAdicional";
            this.lbMargenValorAdicional.Size = new System.Drawing.Size(110, 13);
            this.lbMargenValorAdicional.TabIndex = 16;
            this.lbMargenValorAdicional.Text = "MargenValorAdicional";
            // 
            // lbMargenPorcentajeAdi
            // 
            this.lbMargenPorcentajeAdi.AutoSize = true;
            this.lbMargenPorcentajeAdi.Location = new System.Drawing.Point(441, 57);
            this.lbMargenPorcentajeAdi.Name = "lbMargenPorcentajeAdi";
            this.lbMargenPorcentajeAdi.Size = new System.Drawing.Size(94, 13);
            this.lbMargenPorcentajeAdi.TabIndex = 15;
            this.lbMargenPorcentajeAdi.Text = "MargenAdicional%";
            // 
            // lbCostoTotal
            // 
            this.lbCostoTotal.AutoSize = true;
            this.lbCostoTotal.Location = new System.Drawing.Point(26, 135);
            this.lbCostoTotal.Name = "lbCostoTotal";
            this.lbCostoTotal.Size = new System.Drawing.Size(58, 13);
            this.lbCostoTotal.TabIndex = 14;
            this.lbCostoTotal.Text = "CostoTotal";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(26, 109);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 13;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbCPP
            // 
            this.lbCPP.AutoSize = true;
            this.lbCPP.Location = new System.Drawing.Point(26, 83);
            this.lbCPP.Name = "lbCPP";
            this.lbCPP.Size = new System.Drawing.Size(28, 13);
            this.lbCPP.TabIndex = 12;
            this.lbCPP.Text = "CPP";
            this.lbCPP.Click += new System.EventHandler(this.lbCostoUnitario_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(26, 57);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 11;
            this.lbDescripcion.Text = "Descripción";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(562, 132);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(151, 20);
            this.txtPrecioTotal.TabIndex = 10;
            this.txtPrecioTotal.TextChanged += new System.EventHandler(this.txtPrecioTotal_TextChanged);
            // 
            // txtMargenValorIVA
            // 
            this.txtMargenValorIVA.Location = new System.Drawing.Point(562, 80);
            this.txtMargenValorIVA.Name = "txtMargenValorIVA";
            this.txtMargenValorIVA.ReadOnly = true;
            this.txtMargenValorIVA.Size = new System.Drawing.Size(151, 20);
            this.txtMargenValorIVA.TabIndex = 9;
            // 
            // txtMargenPorcentajeIVA
            // 
            this.txtMargenPorcentajeIVA.Location = new System.Drawing.Point(562, 106);
            this.txtMargenPorcentajeIVA.Name = "txtMargenPorcentajeIVA";
            this.txtMargenPorcentajeIVA.Size = new System.Drawing.Size(151, 20);
            this.txtMargenPorcentajeIVA.TabIndex = 8;
            this.txtMargenPorcentajeIVA.TextChanged += new System.EventHandler(this.txtMargenPorcentajeIVA_TextChanged);
            // 
            // txtMargenValorAdicional
            // 
            this.txtMargenValorAdicional.Location = new System.Drawing.Point(562, 28);
            this.txtMargenValorAdicional.Name = "txtMargenValorAdicional";
            this.txtMargenValorAdicional.ReadOnly = true;
            this.txtMargenValorAdicional.Size = new System.Drawing.Size(151, 20);
            this.txtMargenValorAdicional.TabIndex = 7;
            // 
            // txtMargenPorcentajeaAdi
            // 
            this.txtMargenPorcentajeaAdi.Location = new System.Drawing.Point(562, 54);
            this.txtMargenPorcentajeaAdi.Name = "txtMargenPorcentajeaAdi";
            this.txtMargenPorcentajeaAdi.Size = new System.Drawing.Size(151, 20);
            this.txtMargenPorcentajeaAdi.TabIndex = 6;
            this.txtMargenPorcentajeaAdi.TextChanged += new System.EventHandler(this.txtMargenPorcentajeAdi_TextChanged);
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(95, 132);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.ReadOnly = true;
            this.txtCostoTotal.Size = new System.Drawing.Size(151, 20);
            this.txtCostoTotal.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(95, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(151, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtCPP
            // 
            this.txtCPP.Location = new System.Drawing.Point(95, 80);
            this.txtCPP.Name = "txtCPP";
            this.txtCPP.ReadOnly = true;
            this.txtCPP.Size = new System.Drawing.Size(151, 20);
            this.txtCPP.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(314, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(26, 31);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Codigo";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(95, 28);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(314, 20);
            this.txtCodigoBarras.TabIndex = 0;
            this.txtCodigoBarras.TextChanged += new System.EventHandler(this.txtCodigoBarras_TextChanged);
            // 
            // GrillaDeVentas
            // 
            this.GrillaDeVentas.Controls.Add(this.btnExcel);
            this.GrillaDeVentas.Controls.Add(this.lbMontoTotal);
            this.GrillaDeVentas.Controls.Add(this.txtMontoTotal);
            this.GrillaDeVentas.Controls.Add(this.dgvVentas);
            this.GrillaDeVentas.Location = new System.Drawing.Point(12, 252);
            this.GrillaDeVentas.Name = "GrillaDeVentas";
            this.GrillaDeVentas.Size = new System.Drawing.Size(738, 233);
            this.GrillaDeVentas.TabIndex = 3;
            this.GrillaDeVentas.TabStop = false;
            this.GrillaDeVentas.Text = "Grilla de Ventas";
            // 
            // lbMontoTotal
            // 
            this.lbMontoTotal.AutoSize = true;
            this.lbMontoTotal.Location = new System.Drawing.Point(447, 199);
            this.lbMontoTotal.Name = "lbMontoTotal";
            this.lbMontoTotal.Size = new System.Drawing.Size(89, 13);
            this.lbMontoTotal.TabIndex = 2;
            this.lbMontoTotal.Text = "MontoTotalPagar";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(542, 196);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(151, 20);
            this.txtMontoTotal.TabIndex = 1;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoGrilla,
            this.CantidadGrilla,
            this.PrecioTotalGrilla});
            this.dgvVentas.Location = new System.Drawing.Point(50, 19);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(643, 171);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // ProductoGrilla
            // 
            this.ProductoGrilla.HeaderText = "Producto";
            this.ProductoGrilla.Name = "ProductoGrilla";
            this.ProductoGrilla.ReadOnly = true;
            this.ProductoGrilla.Width = 400;
            // 
            // CantidadGrilla
            // 
            this.CantidadGrilla.HeaderText = "Cantidad";
            this.CantidadGrilla.Name = "CantidadGrilla";
            this.CantidadGrilla.ReadOnly = true;
            // 
            // PrecioTotalGrilla
            // 
            this.PrecioTotalGrilla.HeaderText = "PrecioTotal";
            this.PrecioTotalGrilla.Name = "PrecioTotalGrilla";
            this.PrecioTotalGrilla.ReadOnly = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(50, 196);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(111, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 497);
            this.Controls.Add(this.ProductosBox);
            this.Controls.Add(this.GrillaDeVentas);
            this.Name = "MainFormVentas";
            this.Text = "MainFormVentas";
            this.Load += new System.EventHandler(this.MainFormVentas_Load);
            this.ProductosBox.ResumeLayout(false);
            this.ProductosBox.PerformLayout();
            this.GrillaDeVentas.ResumeLayout(false);
            this.GrillaDeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductosBox;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbPrecioTotal;
        private System.Windows.Forms.Label lbMargenValorIVA;
        private System.Windows.Forms.Label lbMargenPorcentajeIVA;
        private System.Windows.Forms.Label lbMargenValorAdicional;
        private System.Windows.Forms.Label lbMargenPorcentajeAdi;
        private System.Windows.Forms.Label lbCostoTotal;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbCPP;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtMargenValorIVA;
        private System.Windows.Forms.TextBox txtMargenPorcentajeIVA;
        private System.Windows.Forms.TextBox txtMargenValorAdicional;
        private System.Windows.Forms.TextBox txtMargenPorcentajeaAdi;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCPP;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.GroupBox GrillaDeVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lbMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotalGrilla;
        private System.Windows.Forms.Button btnExcel;
    }
}


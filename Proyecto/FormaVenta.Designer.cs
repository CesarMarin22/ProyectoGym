namespace Proyecto
{
     partial class FormaVenta
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
               this.botonEliminar = new System.Windows.Forms.Button();
               this.botonAgregar = new System.Windows.Forms.Button();
               this.botonVolver = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.numericCantidad = new System.Windows.Forms.NumericUpDown();
               this.botonAgregarProducto = new System.Windows.Forms.Button();
               this.botonQuitarProducto = new System.Windows.Forms.Button();
               this.label4 = new System.Windows.Forms.Label();
               this.comboProducto = new System.Windows.Forms.ComboBox();
               this.listaProductos = new System.Windows.Forms.ListView();
               this.label5 = new System.Windows.Forms.Label();
               this.dataGridVenta = new System.Windows.Forms.DataGridView();
               this.textoTotal = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.textoNombre = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.textoClave = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.textoFecha = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
               this.SuspendLayout();
               // 
               // botonEliminar
               // 
               this.botonEliminar.Location = new System.Drawing.Point(395, 266);
               this.botonEliminar.Name = "botonEliminar";
               this.botonEliminar.Size = new System.Drawing.Size(375, 34);
               this.botonEliminar.TabIndex = 12;
               this.botonEliminar.Text = "Cancelar venta";
               this.botonEliminar.UseVisualStyleBackColor = true;
               this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
               // 
               // botonAgregar
               // 
               this.botonAgregar.Location = new System.Drawing.Point(12, 266);
               this.botonAgregar.Name = "botonAgregar";
               this.botonAgregar.Size = new System.Drawing.Size(375, 34);
               this.botonAgregar.TabIndex = 10;
               this.botonAgregar.Text = "Cerrar venta";
               this.botonAgregar.UseVisualStyleBackColor = true;
               this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
               // 
               // botonVolver
               // 
               this.botonVolver.BackgroundImage = global::Proyecto.Properties.Resources.volver;
               this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.botonVolver.Location = new System.Drawing.Point(12, 12);
               this.botonVolver.Name = "botonVolver";
               this.botonVolver.Size = new System.Drawing.Size(50, 50);
               this.botonVolver.TabIndex = 9;
               this.botonVolver.UseVisualStyleBackColor = true;
               this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Location = new System.Drawing.Point(13, 69);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(51, 17);
               this.label1.TabIndex = 14;
               this.label1.Text = "Fecha:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Location = new System.Drawing.Point(577, 101);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(68, 17);
               this.label3.TabIndex = 18;
               this.label3.Text = "Cantidad:";
               // 
               // numericCantidad
               // 
               this.numericCantidad.Location = new System.Drawing.Point(651, 99);
               this.numericCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
               this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
               this.numericCantidad.Name = "numericCantidad";
               this.numericCantidad.Size = new System.Drawing.Size(82, 22);
               this.numericCantidad.TabIndex = 17;
               this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
               // 
               // botonAgregarProducto
               // 
               this.botonAgregarProducto.Location = new System.Drawing.Point(733, 99);
               this.botonAgregarProducto.Name = "botonAgregarProducto";
               this.botonAgregarProducto.Size = new System.Drawing.Size(36, 23);
               this.botonAgregarProducto.TabIndex = 19;
               this.botonAgregarProducto.Text = "+";
               this.botonAgregarProducto.UseVisualStyleBackColor = true;
               this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
               // 
               // botonQuitarProducto
               // 
               this.botonQuitarProducto.Location = new System.Drawing.Point(651, 158);
               this.botonQuitarProducto.Name = "botonQuitarProducto";
               this.botonQuitarProducto.Size = new System.Drawing.Size(31, 23);
               this.botonQuitarProducto.TabIndex = 19;
               this.botonQuitarProducto.Text = "-";
               this.botonQuitarProducto.UseVisualStyleBackColor = true;
               this.botonQuitarProducto.Click += new System.EventHandler(this.botonQuitarProducto_Click);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.Transparent;
               this.label4.Location = new System.Drawing.Point(12, 101);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(69, 17);
               this.label4.TabIndex = 20;
               this.label4.Text = "Producto:";
               // 
               // comboProducto
               // 
               this.comboProducto.FormattingEnabled = true;
               this.comboProducto.Location = new System.Drawing.Point(88, 99);
               this.comboProducto.Name = "comboProducto";
               this.comboProducto.Size = new System.Drawing.Size(483, 24);
               this.comboProducto.TabIndex = 16;
               // 
               // listaProductos
               // 
               this.listaProductos.FullRowSelect = true;
               this.listaProductos.GridLines = true;
               this.listaProductos.Location = new System.Drawing.Point(12, 158);
               this.listaProductos.MultiSelect = false;
               this.listaProductos.Name = "listaProductos";
               this.listaProductos.Size = new System.Drawing.Size(633, 97);
               this.listaProductos.TabIndex = 21;
               this.listaProductos.UseCompatibleStateImageBehavior = false;
               this.listaProductos.View = System.Windows.Forms.View.Details;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.BackColor = System.Drawing.Color.Transparent;
               this.label5.Location = new System.Drawing.Point(13, 135);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(125, 17);
               this.label5.TabIndex = 22;
               this.label5.Text = "Carrito de compra:";
               // 
               // dataGridVenta
               // 
               this.dataGridVenta.AllowUserToAddRows = false;
               this.dataGridVenta.AllowUserToDeleteRows = false;
               this.dataGridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridVenta.Location = new System.Drawing.Point(12, 307);
               this.dataGridVenta.MultiSelect = false;
               this.dataGridVenta.Name = "dataGridVenta";
               this.dataGridVenta.ReadOnly = true;
               this.dataGridVenta.RowTemplate.Height = 24;
               this.dataGridVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridVenta.Size = new System.Drawing.Size(758, 200);
               this.dataGridVenta.TabIndex = 23;
               this.dataGridVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenta_CellClick);
               // 
               // textoTotal
               // 
               this.textoTotal.Location = new System.Drawing.Point(667, 232);
               this.textoTotal.Name = "textoTotal";
               this.textoTotal.ReadOnly = true;
               this.textoTotal.Size = new System.Drawing.Size(102, 22);
               this.textoTotal.TabIndex = 24;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.Transparent;
               this.label6.Location = new System.Drawing.Point(652, 209);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(44, 17);
               this.label6.TabIndex = 25;
               this.label6.Text = "Total:";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.Transparent;
               this.label7.Location = new System.Drawing.Point(648, 235);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(16, 17);
               this.label7.TabIndex = 26;
               this.label7.Text = "$";
               // 
               // textoNombre
               // 
               this.textoNombre.Location = new System.Drawing.Point(496, 66);
               this.textoNombre.Name = "textoNombre";
               this.textoNombre.ReadOnly = true;
               this.textoNombre.Size = new System.Drawing.Size(273, 22);
               this.textoNombre.TabIndex = 36;
               this.textoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Location = new System.Drawing.Point(427, 66);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(62, 17);
               this.label2.TabIndex = 35;
               this.label2.Text = "Nombre:";
               // 
               // textoClave
               // 
               this.textoClave.Location = new System.Drawing.Point(301, 66);
               this.textoClave.Name = "textoClave";
               this.textoClave.Size = new System.Drawing.Size(120, 22);
               this.textoClave.TabIndex = 34;
               this.textoClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textoClave.TextChanged += new System.EventHandler(this.textoClave_TextChanged);
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.BackColor = System.Drawing.Color.Transparent;
               this.label8.Location = new System.Drawing.Point(210, 66);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(84, 17);
               this.label8.TabIndex = 33;
               this.label8.Text = "Clave socio:";
               // 
               // textoFecha
               // 
               this.textoFecha.Location = new System.Drawing.Point(70, 66);
               this.textoFecha.Name = "textoFecha";
               this.textoFecha.ReadOnly = true;
               this.textoFecha.Size = new System.Drawing.Size(134, 22);
               this.textoFecha.TabIndex = 37;
               this.textoFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // FormaVenta
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(782, 519);
               this.Controls.Add(this.textoFecha);
               this.Controls.Add(this.textoNombre);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.textoClave);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.textoTotal);
               this.Controls.Add(this.dataGridVenta);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.listaProductos);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.botonQuitarProducto);
               this.Controls.Add(this.botonAgregarProducto);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.numericCantidad);
               this.Controls.Add(this.comboProducto);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.botonEliminar);
               this.Controls.Add(this.botonAgregar);
               this.Controls.Add(this.botonVolver);
               this.DoubleBuffered = true;
               this.Name = "FormaVenta";
               this.Text = "Ventas";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaVenta_FormClosing);
               ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button botonEliminar;
          private System.Windows.Forms.Button botonAgregar;
          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.NumericUpDown numericCantidad;
          private System.Windows.Forms.Button botonAgregarProducto;
          private System.Windows.Forms.Button botonQuitarProducto;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.ComboBox comboProducto;
          private System.Windows.Forms.ListView listaProductos;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.DataGridView dataGridVenta;
          private System.Windows.Forms.TextBox textoTotal;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.TextBox textoNombre;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textoClave;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textoFecha;
     }
}
namespace Proyecto
{
     partial class FormaProducto
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
               this.botonVolver = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.textoNombre = new System.Windows.Forms.TextBox();
               this.numericPrecio = new System.Windows.Forms.NumericUpDown();
               this.label2 = new System.Windows.Forms.Label();
               this.numericCantidad = new System.Windows.Forms.NumericUpDown();
               this.label3 = new System.Windows.Forms.Label();
               this.botonAgregar = new System.Windows.Forms.Button();
               this.botonModificar = new System.Windows.Forms.Button();
               this.botonEliminar = new System.Windows.Forms.Button();
               this.dataGridProducto = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
               this.SuspendLayout();
               // 
               // botonVolver
               // 
               this.botonVolver.BackgroundImage = global::Proyecto.Properties.Resources.volver;
               this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.botonVolver.Location = new System.Drawing.Point(13, 14);
               this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonVolver.Name = "botonVolver";
               this.botonVolver.Size = new System.Drawing.Size(51, 50);
               this.botonVolver.TabIndex = 1;
               this.botonVolver.UseVisualStyleBackColor = true;
               this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Location = new System.Drawing.Point(12, 75);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(62, 17);
               this.label1.TabIndex = 2;
               this.label1.Text = "Nombre:";
               // 
               // textoNombre
               // 
               this.textoNombre.Location = new System.Drawing.Point(81, 75);
               this.textoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoNombre.Name = "textoNombre";
               this.textoNombre.Size = new System.Drawing.Size(335, 22);
               this.textoNombre.TabIndex = 3;
               // 
               // numericPrecio
               // 
               this.numericPrecio.DecimalPlaces = 2;
               this.numericPrecio.Location = new System.Drawing.Point(651, 75);
               this.numericPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.numericPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
               this.numericPrecio.Name = "numericPrecio";
               this.numericPrecio.Size = new System.Drawing.Size(120, 22);
               this.numericPrecio.TabIndex = 4;
               this.numericPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Location = new System.Drawing.Point(580, 75);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(64, 17);
               this.label2.TabIndex = 5;
               this.label2.Text = "Precio: $";
               // 
               // numericCantidad
               // 
               this.numericCantidad.Location = new System.Drawing.Point(493, 75);
               this.numericCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
               this.numericCantidad.Size = new System.Drawing.Size(83, 22);
               this.numericCantidad.TabIndex = 4;
               this.numericCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Location = new System.Drawing.Point(421, 75);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(68, 17);
               this.label3.TabIndex = 5;
               this.label3.Text = "Cantidad:";
               // 
               // botonAgregar
               // 
               this.botonAgregar.Location = new System.Drawing.Point(13, 108);
               this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonAgregar.Name = "botonAgregar";
               this.botonAgregar.Size = new System.Drawing.Size(253, 34);
               this.botonAgregar.TabIndex = 6;
               this.botonAgregar.Text = "+ Agregar";
               this.botonAgregar.UseVisualStyleBackColor = true;
               this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
               // 
               // botonModificar
               // 
               this.botonModificar.Location = new System.Drawing.Point(265, 108);
               this.botonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonModificar.Name = "botonModificar";
               this.botonModificar.Size = new System.Drawing.Size(253, 34);
               this.botonModificar.TabIndex = 7;
               this.botonModificar.Text = "* Modificar";
               this.botonModificar.UseVisualStyleBackColor = true;
               this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
               // 
               // botonEliminar
               // 
               this.botonEliminar.Location = new System.Drawing.Point(517, 108);
               this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonEliminar.Name = "botonEliminar";
               this.botonEliminar.Size = new System.Drawing.Size(253, 34);
               this.botonEliminar.TabIndex = 8;
               this.botonEliminar.Text = "- Eliminar";
               this.botonEliminar.UseVisualStyleBackColor = true;
               this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
               // 
               // dataGridProducto
               // 
               this.dataGridProducto.AllowUserToAddRows = false;
               this.dataGridProducto.AllowUserToDeleteRows = false;
               this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridProducto.Location = new System.Drawing.Point(12, 148);
               this.dataGridProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridProducto.MultiSelect = false;
               this.dataGridProducto.Name = "dataGridProducto";
               this.dataGridProducto.ReadOnly = true;
               this.dataGridProducto.RowTemplate.Height = 24;
               this.dataGridProducto.Size = new System.Drawing.Size(757, 199);
               this.dataGridProducto.TabIndex = 24;
               this.dataGridProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducto_CellClick);
               // 
               // FormaProducto
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(781, 359);
               this.Controls.Add(this.dataGridProducto);
               this.Controls.Add(this.botonEliminar);
               this.Controls.Add(this.botonModificar);
               this.Controls.Add(this.botonAgregar);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.numericCantidad);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.numericPrecio);
               this.Controls.Add(this.textoNombre);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.botonVolver);
               this.DoubleBuffered = true;
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "FormaProducto";
               this.Text = "Productos";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaProducto_FormClosing);
               this.Load += new System.EventHandler(this.FormaProducto_Load);
               ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textoNombre;
          private System.Windows.Forms.NumericUpDown numericPrecio;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.NumericUpDown numericCantidad;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Button botonAgregar;
          private System.Windows.Forms.Button botonModificar;
          private System.Windows.Forms.Button botonEliminar;
          private System.Windows.Forms.DataGridView dataGridProducto;

     }
}
namespace Proyecto
{
     partial class FormaSocio
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
            this.dataGridSocio = new System.Windows.Forms.DataGridView();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textoClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericPeso = new System.Windows.Forms.NumericUpDown();
            this.numericEstatura = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textoOcupacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textoVigencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstatura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSocio
            // 
            this.dataGridSocio.AllowUserToAddRows = false;
            this.dataGridSocio.AllowUserToDeleteRows = false;
            this.dataGridSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSocio.Location = new System.Drawing.Point(8, 162);
            this.dataGridSocio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSocio.MultiSelect = false;
            this.dataGridSocio.Name = "dataGridSocio";
            this.dataGridSocio.ReadOnly = true;
            this.dataGridSocio.RowTemplate.Height = 24;
            this.dataGridSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSocio.Size = new System.Drawing.Size(568, 162);
            this.dataGridSocio.TabIndex = 28;
            this.dataGridSocio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSocio_CellClick);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(386, 128);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(190, 28);
            this.botonEliminar.TabIndex = 27;
            this.botonEliminar.Text = "- Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(197, 128);
            this.botonModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(190, 28);
            this.botonModificar.TabIndex = 26;
            this.botonModificar.Text = "* Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(8, 128);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(190, 28);
            this.botonAgregar.TabIndex = 25;
            this.botonAgregar.Text = "+ Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackgroundImage = global::Proyecto.Properties.Resources.volver;
            this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVolver.Location = new System.Drawing.Point(9, 10);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(38, 41);
            this.botonVolver.TabIndex = 24;
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Clave socio:";
            // 
            // textoClave
            // 
            this.textoClave.Location = new System.Drawing.Point(80, 56);
            this.textoClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoClave.Name = "textoClave";
            this.textoClave.ReadOnly = true;
            this.textoClave.Size = new System.Drawing.Size(91, 20);
            this.textoClave.TabIndex = 30;
            this.textoClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(174, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(226, 56);
            this.textoNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(225, 20);
            this.textoNombre.TabIndex = 32;
            this.textoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Dirección:";
            // 
            // textoDireccion
            // 
            this.textoDireccion.Location = new System.Drawing.Point(69, 79);
            this.textoDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(348, 20);
            this.textoDireccion.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(454, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(420, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estatura:";
            // 
            // numericPeso
            // 
            this.numericPeso.DecimalPlaces = 3;
            this.numericPeso.Location = new System.Drawing.Point(493, 56);
            this.numericPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericPeso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPeso.Name = "numericPeso";
            this.numericPeso.Size = new System.Drawing.Size(64, 20);
            this.numericPeso.TabIndex = 37;
            this.numericPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericEstatura
            // 
            this.numericEstatura.DecimalPlaces = 2;
            this.numericEstatura.Location = new System.Drawing.Point(473, 78);
            this.numericEstatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericEstatura.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericEstatura.Name = "numericEstatura";
            this.numericEstatura.Size = new System.Drawing.Size(76, 20);
            this.numericEstatura.TabIndex = 38;
            this.numericEstatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(558, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(554, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Ocupación:";
            // 
            // textoOcupacion
            // 
            this.textoOcupacion.Location = new System.Drawing.Point(77, 102);
            this.textoOcupacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoOcupacion.Name = "textoOcupacion";
            this.textoOcupacion.Size = new System.Drawing.Size(206, 20);
            this.textoOcupacion.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(287, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Vigencia:";
            // 
            // textoVigencia
            // 
            this.textoVigencia.Location = new System.Drawing.Point(341, 102);
            this.textoVigencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoVigencia.Name = "textoVigencia";
            this.textoVigencia.ReadOnly = true;
            this.textoVigencia.Size = new System.Drawing.Size(128, 20);
            this.textoVigencia.TabIndex = 30;
            this.textoVigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 335);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textoOcupacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericEstatura);
            this.Controls.Add(this.numericPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textoDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoVigencia);
            this.Controls.Add(this.textoClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSocio);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonVolver);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaSocio";
            this.Text = "Socios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaSocio_FormClosing);
            this.Load += new System.EventHandler(this.FormaSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridSocio;
          private System.Windows.Forms.Button botonEliminar;
          private System.Windows.Forms.Button botonModificar;
          private System.Windows.Forms.Button botonAgregar;
          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textoClave;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textoNombre;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textoDireccion;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.NumericUpDown numericPeso;
          private System.Windows.Forms.NumericUpDown numericEstatura;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textoOcupacion;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.TextBox textoVigencia;
     }
}
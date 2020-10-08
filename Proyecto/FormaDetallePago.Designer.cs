namespace Proyecto
{
     partial class FormaDetallePago
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
               this.dataGridDetalle = new System.Windows.Forms.DataGridView();
               this.botonAgregar = new System.Windows.Forms.Button();
               this.botonVolver = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
               this.label1 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.comboTipo = new System.Windows.Forms.ComboBox();
               this.textoNombre = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.textoClave = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.textoMonto = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridDetalle
               // 
               this.dataGridDetalle.AllowUserToAddRows = false;
               this.dataGridDetalle.AllowUserToDeleteRows = false;
               this.dataGridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
               this.dataGridDetalle.Location = new System.Drawing.Point(13, 172);
               this.dataGridDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridDetalle.MultiSelect = false;
               this.dataGridDetalle.Name = "dataGridDetalle";
               this.dataGridDetalle.ReadOnly = true;
               this.dataGridDetalle.RowTemplate.Height = 24;
               this.dataGridDetalle.Size = new System.Drawing.Size(757, 199);
               this.dataGridDetalle.TabIndex = 38;
               // 
               // botonAgregar
               // 
               this.botonAgregar.Location = new System.Drawing.Point(13, 130);
               this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonAgregar.Name = "botonAgregar";
               this.botonAgregar.Size = new System.Drawing.Size(375, 34);
               this.botonAgregar.TabIndex = 35;
               this.botonAgregar.Text = "+ Agregar";
               this.botonAgregar.UseVisualStyleBackColor = true;
               this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
               // 
               // botonVolver
               // 
               this.botonVolver.BackgroundImage = global::Proyecto.Properties.Resources.volver;
               this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.botonVolver.Location = new System.Drawing.Point(13, 14);
               this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonVolver.Name = "botonVolver";
               this.botonVolver.Size = new System.Drawing.Size(51, 50);
               this.botonVolver.TabIndex = 34;
               this.botonVolver.UseVisualStyleBackColor = true;
               this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Location = new System.Drawing.Point(585, 71);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(51, 17);
               this.label2.TabIndex = 43;
               this.label2.Text = "Fecha:";
               // 
               // dateTimePickerFecha
               // 
               this.dateTimePickerFecha.Enabled = false;
               this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dateTimePickerFecha.Location = new System.Drawing.Point(643, 71);
               this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dateTimePickerFecha.Name = "dateTimePickerFecha";
               this.dateTimePickerFecha.Size = new System.Drawing.Size(128, 22);
               this.dateTimePickerFecha.TabIndex = 42;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Location = new System.Drawing.Point(13, 103);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(63, 17);
               this.label1.TabIndex = 44;
               this.label1.Text = "Monto: $";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.Transparent;
               this.label4.Location = new System.Drawing.Point(192, 103);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(40, 17);
               this.label4.TabIndex = 46;
               this.label4.Text = "Tipo:";
               // 
               // comboTipo
               // 
               this.comboTipo.FormattingEnabled = true;
               this.comboTipo.Location = new System.Drawing.Point(239, 102);
               this.comboTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboTipo.Name = "comboTipo";
               this.comboTipo.Size = new System.Drawing.Size(236, 24);
               this.comboTipo.TabIndex = 47;
               this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
               // 
               // textoNombre
               // 
               this.textoNombre.Location = new System.Drawing.Point(301, 71);
               this.textoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoNombre.Name = "textoNombre";
               this.textoNombre.ReadOnly = true;
               this.textoNombre.Size = new System.Drawing.Size(273, 22);
               this.textoNombre.TabIndex = 51;
               this.textoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Location = new System.Drawing.Point(233, 71);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(62, 17);
               this.label3.TabIndex = 50;
               this.label3.Text = "Nombre:";
               // 
               // textoClave
               // 
               this.textoClave.Location = new System.Drawing.Point(107, 71);
               this.textoClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoClave.Name = "textoClave";
               this.textoClave.Size = new System.Drawing.Size(120, 22);
               this.textoClave.TabIndex = 49;
               this.textoClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textoClave.TextChanged += new System.EventHandler(this.textoClave_TextChanged);
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.BackColor = System.Drawing.Color.Transparent;
               this.label8.Location = new System.Drawing.Point(16, 71);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(84, 17);
               this.label8.TabIndex = 48;
               this.label8.Text = "Clave socio:";
               // 
               // textoMonto
               // 
               this.textoMonto.Location = new System.Drawing.Point(83, 103);
               this.textoMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoMonto.Name = "textoMonto";
               this.textoMonto.ReadOnly = true;
               this.textoMonto.Size = new System.Drawing.Size(104, 22);
               this.textoMonto.TabIndex = 49;
               this.textoMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // FormaDetallePago
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(781, 383);
               this.Controls.Add(this.textoNombre);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textoMonto);
               this.Controls.Add(this.textoClave);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.comboTipo);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.dateTimePickerFecha);
               this.Controls.Add(this.dataGridDetalle);
               this.Controls.Add(this.botonAgregar);
               this.Controls.Add(this.botonVolver);
               this.DoubleBuffered = true;
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "FormaDetallePago";
               this.Text = "Detalles de pago";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaDetallePago_FormClosing);
               this.Load += new System.EventHandler(this.FormaDetallePago_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalle)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridDetalle;
          private System.Windows.Forms.Button botonAgregar;
          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.ComboBox comboTipo;
          private System.Windows.Forms.TextBox textoNombre;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textoClave;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textoMonto;
     }
}
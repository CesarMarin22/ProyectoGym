namespace Proyecto
{
     partial class FormaBitacora
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridBitacora = new System.Windows.Forms.DataGridView();
            this.botonSalida = new System.Windows.Forms.Button();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textoHEntrada = new System.Windows.Forms.TextBox();
            this.textoHSalida = new System.Windows.Forms.TextBox();
            this.fechaActual = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridEntrada = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(439, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hora entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(203, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hora salida:";
            // 
            // dataGridBitacora
            // 
            this.dataGridBitacora.AllowUserToAddRows = false;
            this.dataGridBitacora.AllowUserToDeleteRows = false;
            this.dataGridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBitacora.Location = new System.Drawing.Point(9, 240);
            this.dataGridBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridBitacora.Name = "dataGridBitacora";
            this.dataGridBitacora.ReadOnly = true;
            this.dataGridBitacora.RowTemplate.Height = 24;
            this.dataGridBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBitacora.Size = new System.Drawing.Size(568, 167);
            this.dataGridBitacora.TabIndex = 33;
            this.dataGridBitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBitacora_CellClick);
            this.dataGridBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBitacora_CellContentClick);
            // 
            // botonSalida
            // 
            this.botonSalida.Location = new System.Drawing.Point(296, 106);
            this.botonSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonSalida.Name = "botonSalida";
            this.botonSalida.Size = new System.Drawing.Size(281, 28);
            this.botonSalida.TabIndex = 32;
            this.botonSalida.Text = "Marcar Salida ->";
            this.botonSalida.UseVisualStyleBackColor = true;
            this.botonSalida.Click += new System.EventHandler(this.botonSalida_Click);
            // 
            // botonEntrar
            // 
            this.botonEntrar.Location = new System.Drawing.Point(9, 106);
            this.botonEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(281, 28);
            this.botonEntrar.TabIndex = 30;
            this.botonEntrar.Text = "-> Marcar Entrada";
            this.botonEntrar.UseVisualStyleBackColor = true;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackgroundImage = global::Proyecto.Properties.Resources.volver;
            this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonVolver.Location = new System.Drawing.Point(9, 10);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(38, 41);
            this.botonVolver.TabIndex = 25;
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(226, 54);
            this.textoNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.ReadOnly = true;
            this.textoNombre.Size = new System.Drawing.Size(206, 20);
            this.textoNombre.TabIndex = 40;
            this.textoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(174, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nombre:";
            // 
            // textoClave
            // 
            this.textoClave.Location = new System.Drawing.Point(80, 54);
            this.textoClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoClave.Name = "textoClave";
            this.textoClave.Size = new System.Drawing.Size(91, 20);
            this.textoClave.TabIndex = 38;
            this.textoClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoClave.TextChanged += new System.EventHandler(this.textoClave_TextChanged);
            this.textoClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textoClave_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(11, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Clave socio:";
            // 
            // textoHEntrada
            // 
            this.textoHEntrada.Location = new System.Drawing.Point(86, 80);
            this.textoHEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoHEntrada.Name = "textoHEntrada";
            this.textoHEntrada.ReadOnly = true;
            this.textoHEntrada.Size = new System.Drawing.Size(114, 20);
            this.textoHEntrada.TabIndex = 38;
            this.textoHEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoHSalida
            // 
            this.textoHSalida.Location = new System.Drawing.Point(271, 80);
            this.textoHSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textoHSalida.Name = "textoHSalida";
            this.textoHSalida.ReadOnly = true;
            this.textoHSalida.Size = new System.Drawing.Size(114, 20);
            this.textoHSalida.TabIndex = 38;
            this.textoHSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fechaActual
            // 
            this.fechaActual.Location = new System.Drawing.Point(482, 54);
            this.fechaActual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaActual.Name = "fechaActual";
            this.fechaActual.ReadOnly = true;
            this.fechaActual.Size = new System.Drawing.Size(97, 20);
            this.fechaActual.TabIndex = 38;
            this.fechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridEntrada
            // 
            this.dataGridEntrada.AllowUserToAddRows = false;
            this.dataGridEntrada.AllowUserToDeleteRows = false;
            this.dataGridEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntrada.Location = new System.Drawing.Point(9, 136);
            this.dataGridEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridEntrada.MultiSelect = false;
            this.dataGridEntrada.Name = "dataGridEntrada";
            this.dataGridEntrada.ReadOnly = true;
            this.dataGridEntrada.RowTemplate.Height = 24;
            this.dataGridEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEntrada.Size = new System.Drawing.Size(568, 100);
            this.dataGridEntrada.TabIndex = 41;
            this.dataGridEntrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEntrada_CellClick);
            // 
            // FormaBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 416);
            this.Controls.Add(this.dataGridEntrada);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoHSalida);
            this.Controls.Add(this.fechaActual);
            this.Controls.Add(this.textoHEntrada);
            this.Controls.Add(this.textoClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridBitacora);
            this.Controls.Add(this.botonSalida);
            this.Controls.Add(this.botonEntrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonVolver);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaBitacora";
            this.Text = "Bitacora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaBitacora_FormClosing);
            this.Load += new System.EventHandler(this.FormaBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.DataGridView dataGridBitacora;
          private System.Windows.Forms.Button botonSalida;
          private System.Windows.Forms.Button botonEntrar;
          private System.Windows.Forms.TextBox textoNombre;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox textoClave;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.TextBox textoHEntrada;
          private System.Windows.Forms.TextBox textoHSalida;
          private System.Windows.Forms.TextBox fechaActual;
          private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.DataGridView dataGridEntrada;
     }
}
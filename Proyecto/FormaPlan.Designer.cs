namespace Proyecto
{
     partial class FormaPlan
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
               this.comboPlan = new System.Windows.Forms.ComboBox();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.dataGridRutina = new System.Windows.Forms.DataGridView();
               this.botonEliminarRutina = new System.Windows.Forms.Button();
               this.botonModificarRutina = new System.Windows.Forms.Button();
               this.botonAgregarRutina = new System.Windows.Forms.Button();
               this.textoDescripcion = new System.Windows.Forms.TextBox();
               this.textoNombreRutina = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.numericDuracion = new System.Windows.Forms.NumericUpDown();
               this.dataGridEjercicio = new System.Windows.Forms.DataGridView();
               this.botonEliminarEjercicio = new System.Windows.Forms.Button();
               this.botonModificarEjercicio = new System.Windows.Forms.Button();
               this.botonAgregarEjercicio = new System.Windows.Forms.Button();
               this.textoNombreEjercicio = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridRutina)).BeginInit();
               this.groupBox2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.numericDuracion)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridEjercicio)).BeginInit();
               this.SuspendLayout();
               // 
               // botonVolver
               // 
               this.botonVolver.BackgroundImage = global::Proyecto.Properties.Resources.volver;
               this.botonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.botonVolver.Location = new System.Drawing.Point(12, 12);
               this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonVolver.Name = "botonVolver";
               this.botonVolver.Size = new System.Drawing.Size(51, 50);
               this.botonVolver.TabIndex = 26;
               this.botonVolver.UseVisualStyleBackColor = true;
               this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Transparent;
               this.label1.Location = new System.Drawing.Point(68, 39);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(143, 17);
               this.label1.TabIndex = 27;
               this.label1.Text = "Plan de alimentación:";
               // 
               // comboPlan
               // 
               this.comboPlan.FormattingEnabled = true;
               this.comboPlan.Location = new System.Drawing.Point(219, 36);
               this.comboPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboPlan.Name = "comboPlan";
               this.comboPlan.Size = new System.Drawing.Size(271, 24);
               this.comboPlan.TabIndex = 28;
               this.comboPlan.SelectedIndexChanged += new System.EventHandler(this.comboPlan_SelectedIndexChanged);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.Transparent;
               this.groupBox1.Controls.Add(this.dataGridRutina);
               this.groupBox1.Controls.Add(this.botonEliminarRutina);
               this.groupBox1.Controls.Add(this.botonModificarRutina);
               this.groupBox1.Controls.Add(this.botonAgregarRutina);
               this.groupBox1.Controls.Add(this.textoDescripcion);
               this.groupBox1.Controls.Add(this.textoNombreRutina);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Location = new System.Drawing.Point(11, 68);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.groupBox1.Size = new System.Drawing.Size(759, 256);
               this.groupBox1.TabIndex = 29;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Rutinas";
               // 
               // dataGridRutina
               // 
               this.dataGridRutina.AllowUserToAddRows = false;
               this.dataGridRutina.AllowUserToDeleteRows = false;
               this.dataGridRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridRutina.Location = new System.Drawing.Point(5, 117);
               this.dataGridRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridRutina.MultiSelect = false;
               this.dataGridRutina.Name = "dataGridRutina";
               this.dataGridRutina.ReadOnly = true;
               this.dataGridRutina.RowTemplate.Height = 24;
               this.dataGridRutina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridRutina.Size = new System.Drawing.Size(747, 133);
               this.dataGridRutina.TabIndex = 37;
               this.dataGridRutina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRutina_CellClick);
               // 
               // botonEliminarRutina
               // 
               this.botonEliminarRutina.Location = new System.Drawing.Point(504, 76);
               this.botonEliminarRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonEliminarRutina.Name = "botonEliminarRutina";
               this.botonEliminarRutina.Size = new System.Drawing.Size(249, 34);
               this.botonEliminarRutina.TabIndex = 36;
               this.botonEliminarRutina.Text = "- Eliminar";
               this.botonEliminarRutina.UseVisualStyleBackColor = true;
               this.botonEliminarRutina.Click += new System.EventHandler(this.botonEliminarRutina_Click);
               // 
               // botonModificarRutina
               // 
               this.botonModificarRutina.Location = new System.Drawing.Point(252, 76);
               this.botonModificarRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonModificarRutina.Name = "botonModificarRutina";
               this.botonModificarRutina.Size = new System.Drawing.Size(253, 34);
               this.botonModificarRutina.TabIndex = 35;
               this.botonModificarRutina.Text = "* Modificar";
               this.botonModificarRutina.UseVisualStyleBackColor = true;
               this.botonModificarRutina.Click += new System.EventHandler(this.botonModificarRutina_Click);
               // 
               // botonAgregarRutina
               // 
               this.botonAgregarRutina.Location = new System.Drawing.Point(5, 76);
               this.botonAgregarRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonAgregarRutina.Name = "botonAgregarRutina";
               this.botonAgregarRutina.Size = new System.Drawing.Size(247, 34);
               this.botonAgregarRutina.TabIndex = 34;
               this.botonAgregarRutina.Text = "+ Agregar";
               this.botonAgregarRutina.UseVisualStyleBackColor = true;
               this.botonAgregarRutina.Click += new System.EventHandler(this.botonAgregarRutina_Click);
               // 
               // textoDescripcion
               // 
               this.textoDescripcion.Location = new System.Drawing.Point(325, 18);
               this.textoDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoDescripcion.Multiline = true;
               this.textoDescripcion.Name = "textoDescripcion";
               this.textoDescripcion.Size = new System.Drawing.Size(427, 50);
               this.textoDescripcion.TabIndex = 1;
               // 
               // textoNombreRutina
               // 
               this.textoNombreRutina.Location = new System.Drawing.Point(75, 18);
               this.textoNombreRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoNombreRutina.Name = "textoNombreRutina";
               this.textoNombreRutina.Size = new System.Drawing.Size(153, 22);
               this.textoNombreRutina.TabIndex = 1;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.BackColor = System.Drawing.Color.Transparent;
               this.label4.Location = new System.Drawing.Point(235, 22);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(86, 17);
               this.label4.TabIndex = 0;
               this.label4.Text = "Descripción:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Location = new System.Drawing.Point(7, 22);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(62, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Nombre:";
               // 
               // groupBox2
               // 
               this.groupBox2.BackColor = System.Drawing.Color.Transparent;
               this.groupBox2.Controls.Add(this.numericDuracion);
               this.groupBox2.Controls.Add(this.dataGridEjercicio);
               this.groupBox2.Controls.Add(this.botonEliminarEjercicio);
               this.groupBox2.Controls.Add(this.botonModificarEjercicio);
               this.groupBox2.Controls.Add(this.botonAgregarEjercicio);
               this.groupBox2.Controls.Add(this.textoNombreEjercicio);
               this.groupBox2.Controls.Add(this.label3);
               this.groupBox2.Controls.Add(this.label6);
               this.groupBox2.Controls.Add(this.label7);
               this.groupBox2.Location = new System.Drawing.Point(11, 330);
               this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.groupBox2.Size = new System.Drawing.Size(759, 194);
               this.groupBox2.TabIndex = 29;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Ejercicios";
               // 
               // numericDuracion
               // 
               this.numericDuracion.Location = new System.Drawing.Point(87, 46);
               this.numericDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.numericDuracion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
               this.numericDuracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
               this.numericDuracion.Name = "numericDuracion";
               this.numericDuracion.Size = new System.Drawing.Size(69, 22);
               this.numericDuracion.TabIndex = 38;
               this.numericDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.numericDuracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
               // 
               // dataGridEjercicio
               // 
               this.dataGridEjercicio.AllowUserToAddRows = false;
               this.dataGridEjercicio.AllowUserToDeleteRows = false;
               this.dataGridEjercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridEjercicio.Location = new System.Drawing.Point(235, 53);
               this.dataGridEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridEjercicio.MultiSelect = false;
               this.dataGridEjercicio.Name = "dataGridEjercicio";
               this.dataGridEjercicio.ReadOnly = true;
               this.dataGridEjercicio.RowTemplate.Height = 24;
               this.dataGridEjercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridEjercicio.Size = new System.Drawing.Size(517, 133);
               this.dataGridEjercicio.TabIndex = 37;
               this.dataGridEjercicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEjercicio_CellClick);
               // 
               // botonEliminarEjercicio
               // 
               this.botonEliminarEjercicio.Location = new System.Drawing.Point(580, 14);
               this.botonEliminarEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonEliminarEjercicio.Name = "botonEliminarEjercicio";
               this.botonEliminarEjercicio.Size = new System.Drawing.Size(172, 34);
               this.botonEliminarEjercicio.TabIndex = 36;
               this.botonEliminarEjercicio.Text = "- Eliminar";
               this.botonEliminarEjercicio.UseVisualStyleBackColor = true;
               this.botonEliminarEjercicio.Click += new System.EventHandler(this.botonEliminarEjercicio_Click);
               // 
               // botonModificarEjercicio
               // 
               this.botonModificarEjercicio.Location = new System.Drawing.Point(408, 14);
               this.botonModificarEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonModificarEjercicio.Name = "botonModificarEjercicio";
               this.botonModificarEjercicio.Size = new System.Drawing.Size(172, 34);
               this.botonModificarEjercicio.TabIndex = 35;
               this.botonModificarEjercicio.Text = "* Modificar";
               this.botonModificarEjercicio.UseVisualStyleBackColor = true;
               this.botonModificarEjercicio.Click += new System.EventHandler(this.botonModificarEjercicio_Click);
               // 
               // botonAgregarEjercicio
               // 
               this.botonAgregarEjercicio.Location = new System.Drawing.Point(236, 14);
               this.botonAgregarEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonAgregarEjercicio.Name = "botonAgregarEjercicio";
               this.botonAgregarEjercicio.Size = new System.Drawing.Size(172, 34);
               this.botonAgregarEjercicio.TabIndex = 34;
               this.botonAgregarEjercicio.Text = "+ Agregar";
               this.botonAgregarEjercicio.UseVisualStyleBackColor = true;
               this.botonAgregarEjercicio.Click += new System.EventHandler(this.botonAgregarEjercicio_Click);
               // 
               // textoNombreEjercicio
               // 
               this.textoNombreEjercicio.Location = new System.Drawing.Point(75, 18);
               this.textoNombreEjercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textoNombreEjercicio.Name = "textoNombreEjercicio";
               this.textoNombreEjercicio.Size = new System.Drawing.Size(152, 22);
               this.textoNombreEjercicio.TabIndex = 1;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.BackColor = System.Drawing.Color.Transparent;
               this.label3.Location = new System.Drawing.Point(157, 48);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(41, 17);
               this.label3.TabIndex = 0;
               this.label3.Text = "Mins.";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.BackColor = System.Drawing.Color.Transparent;
               this.label6.Location = new System.Drawing.Point(7, 48);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(69, 17);
               this.label6.TabIndex = 0;
               this.label6.Text = "Duración:";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.BackColor = System.Drawing.Color.Transparent;
               this.label7.Location = new System.Drawing.Point(7, 22);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(62, 17);
               this.label7.TabIndex = 0;
               this.label7.Text = "Nombre:";
               // 
               // FormaPlan
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(781, 524);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.comboPlan);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.botonVolver);
               this.DoubleBuffered = true;
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "FormaPlan";
               this.Text = "Planes y rutinas";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaPlan_FormClosing);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridRutina)).EndInit();
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.numericDuracion)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridEjercicio)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox comboPlan;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.TextBox textoNombreRutina;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox textoDescripcion;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.DataGridView dataGridRutina;
          private System.Windows.Forms.Button botonEliminarRutina;
          private System.Windows.Forms.Button botonModificarRutina;
          private System.Windows.Forms.Button botonAgregarRutina;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.DataGridView dataGridEjercicio;
          private System.Windows.Forms.Button botonEliminarEjercicio;
          private System.Windows.Forms.Button botonModificarEjercicio;
          private System.Windows.Forms.Button botonAgregarEjercicio;
          private System.Windows.Forms.TextBox textoNombreEjercicio;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.NumericUpDown numericDuracion;
          private System.Windows.Forms.Label label3;
     }
}
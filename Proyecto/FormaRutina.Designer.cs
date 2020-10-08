namespace Proyecto
{
     partial class FormaRutina
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
               this.comboSocio = new System.Windows.Forms.ComboBox();
               this.label2 = new System.Windows.Forms.Label();
               this.comboRutina = new System.Windows.Forms.ComboBox();
               this.dataGridRutina = new System.Windows.Forms.DataGridView();
               this.botonEliminar = new System.Windows.Forms.Button();
               this.botonAgregar = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridRutina)).BeginInit();
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
               this.label1.Location = new System.Drawing.Point(13, 69);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(51, 17);
               this.label1.TabIndex = 27;
               this.label1.Text = "Socio: ";
               // 
               // comboSocio
               // 
               this.comboSocio.FormattingEnabled = true;
               this.comboSocio.Location = new System.Drawing.Point(71, 69);
               this.comboSocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboSocio.Name = "comboSocio";
               this.comboSocio.Size = new System.Drawing.Size(316, 24);
               this.comboSocio.TabIndex = 28;
               this.comboSocio.SelectedValueChanged += new System.EventHandler(this.comboSocio_SelectedValueChanged);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.BackColor = System.Drawing.Color.Transparent;
               this.label2.Location = new System.Drawing.Point(393, 71);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(53, 17);
               this.label2.TabIndex = 29;
               this.label2.Text = "Rutina:";
               // 
               // comboRutina
               // 
               this.comboRutina.FormattingEnabled = true;
               this.comboRutina.Location = new System.Drawing.Point(452, 69);
               this.comboRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboRutina.Name = "comboRutina";
               this.comboRutina.Size = new System.Drawing.Size(319, 24);
               this.comboRutina.TabIndex = 30;
               // 
               // dataGridRutina
               // 
               this.dataGridRutina.AllowUserToAddRows = false;
               this.dataGridRutina.AllowUserToDeleteRows = false;
               this.dataGridRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridRutina.Location = new System.Drawing.Point(12, 142);
               this.dataGridRutina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridRutina.MultiSelect = false;
               this.dataGridRutina.Name = "dataGridRutina";
               this.dataGridRutina.ReadOnly = true;
               this.dataGridRutina.RowTemplate.Height = 24;
               this.dataGridRutina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridRutina.Size = new System.Drawing.Size(757, 199);
               this.dataGridRutina.TabIndex = 37;
               // 
               // botonEliminar
               // 
               this.botonEliminar.Location = new System.Drawing.Point(394, 101);
               this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonEliminar.Name = "botonEliminar";
               this.botonEliminar.Size = new System.Drawing.Size(375, 34);
               this.botonEliminar.TabIndex = 36;
               this.botonEliminar.Text = "- Eliminar";
               this.botonEliminar.UseVisualStyleBackColor = true;
               this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
               // 
               // botonAgregar
               // 
               this.botonAgregar.Location = new System.Drawing.Point(12, 101);
               this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.botonAgregar.Name = "botonAgregar";
               this.botonAgregar.Size = new System.Drawing.Size(375, 34);
               this.botonAgregar.TabIndex = 34;
               this.botonAgregar.Text = "+ Agregar";
               this.botonAgregar.UseVisualStyleBackColor = true;
               this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
               // 
               // FormaRutina
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Proyecto.Properties.Resources.fondo;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(781, 354);
               this.Controls.Add(this.dataGridRutina);
               this.Controls.Add(this.botonEliminar);
               this.Controls.Add(this.botonAgregar);
               this.Controls.Add(this.comboRutina);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.comboSocio);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.botonVolver);
               this.DoubleBuffered = true;
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "FormaRutina";
               this.Text = "Rutinas y socios";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormaRutina_FormClosing);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridRutina)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button botonVolver;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox comboSocio;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.ComboBox comboRutina;
          private System.Windows.Forms.DataGridView dataGridRutina;
          private System.Windows.Forms.Button botonEliminar;
          private System.Windows.Forms.Button botonAgregar;
     }
}
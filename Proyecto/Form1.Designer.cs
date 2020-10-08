namespace Proyecto
{
     partial class FormaPrincipal
     {
          /// <summary>
          /// Variable del diseñador requerida.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Limpiar los recursos que se estén utilizando.
          /// </summary>
          /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Código generado por el Diseñador de Windows Forms

          /// <summary>
          /// Método necesario para admitir el Diseñador. No se puede modificar
          /// el contenido del método con el editor de código.
          /// </summary>
          private void InitializeComponent()
          {
               this.botonProducto = new System.Windows.Forms.Button();
               this.botonVenta = new System.Windows.Forms.Button();
               this.botonSocio = new System.Windows.Forms.Button();
               this.botonBitacora = new System.Windows.Forms.Button();
               this.botonDetallePago = new System.Windows.Forms.Button();
               this.botonPlan = new System.Windows.Forms.Button();
               this.botonRutina = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // botonProducto
               // 
               this.botonProducto.Location = new System.Drawing.Point(464, 12);
               this.botonProducto.Name = "botonProducto";
               this.botonProducto.Size = new System.Drawing.Size(137, 43);
               this.botonProducto.TabIndex = 0;
               this.botonProducto.Text = "Productos";
               this.botonProducto.UseVisualStyleBackColor = true;
               this.botonProducto.Click += new System.EventHandler(this.botonProducto_Click);
               // 
               // botonVenta
               // 
               this.botonVenta.Location = new System.Drawing.Point(607, 61);
               this.botonVenta.Name = "botonVenta";
               this.botonVenta.Size = new System.Drawing.Size(137, 43);
               this.botonVenta.TabIndex = 0;
               this.botonVenta.Text = "Ventas";
               this.botonVenta.UseVisualStyleBackColor = true;
               this.botonVenta.Click += new System.EventHandler(this.botonVenta_Click);
               // 
               // botonSocio
               // 
               this.botonSocio.Location = new System.Drawing.Point(35, 61);
               this.botonSocio.Name = "botonSocio";
               this.botonSocio.Size = new System.Drawing.Size(137, 43);
               this.botonSocio.TabIndex = 0;
               this.botonSocio.Text = "Socios";
               this.botonSocio.UseVisualStyleBackColor = true;
               this.botonSocio.Click += new System.EventHandler(this.botonSocio_Click);
               // 
               // botonBitacora
               // 
               this.botonBitacora.Location = new System.Drawing.Point(35, 12);
               this.botonBitacora.Name = "botonBitacora";
               this.botonBitacora.Size = new System.Drawing.Size(137, 43);
               this.botonBitacora.TabIndex = 0;
               this.botonBitacora.Text = "Bitácora";
               this.botonBitacora.UseVisualStyleBackColor = true;
               this.botonBitacora.Click += new System.EventHandler(this.botonBitacora_Click);
               // 
               // botonDetallePago
               // 
               this.botonDetallePago.Location = new System.Drawing.Point(178, 12);
               this.botonDetallePago.Name = "botonDetallePago";
               this.botonDetallePago.Size = new System.Drawing.Size(137, 43);
               this.botonDetallePago.TabIndex = 0;
               this.botonDetallePago.Text = "Detalles de pago";
               this.botonDetallePago.UseVisualStyleBackColor = true;
               this.botonDetallePago.Click += new System.EventHandler(this.botonDetallePago_Click);
               // 
               // botonPlan
               // 
               this.botonPlan.Location = new System.Drawing.Point(321, 12);
               this.botonPlan.Name = "botonPlan";
               this.botonPlan.Size = new System.Drawing.Size(137, 43);
               this.botonPlan.TabIndex = 0;
               this.botonPlan.Text = "Plan y rutinas";
               this.botonPlan.UseVisualStyleBackColor = true;
               this.botonPlan.Click += new System.EventHandler(this.botonPlan_Click);
               // 
               // botonRutina
               // 
               this.botonRutina.Location = new System.Drawing.Point(607, 12);
               this.botonRutina.Name = "botonRutina";
               this.botonRutina.Size = new System.Drawing.Size(137, 43);
               this.botonRutina.TabIndex = 0;
               this.botonRutina.Text = "Rutinas y socios";
               this.botonRutina.UseVisualStyleBackColor = true;
               this.botonRutina.Click += new System.EventHandler(this.botonRutina_Click);
               // 
               // FormaPrincipal
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Proyecto.Properties.Resources.fondop;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(782, 553);
               this.Controls.Add(this.botonDetallePago);
               this.Controls.Add(this.botonRutina);
               this.Controls.Add(this.botonPlan);
               this.Controls.Add(this.botonBitacora);
               this.Controls.Add(this.botonSocio);
               this.Controls.Add(this.botonVenta);
               this.Controls.Add(this.botonProducto);
               this.DoubleBuffered = true;
               this.Name = "FormaPrincipal";
               this.Text = "Principal";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button botonProducto;
          private System.Windows.Forms.Button botonVenta;
          private System.Windows.Forms.Button botonSocio;
          private System.Windows.Forms.Button botonBitacora;
          private System.Windows.Forms.Button botonDetallePago;
          private System.Windows.Forms.Button botonPlan;
          private System.Windows.Forms.Button botonRutina;
     }
}


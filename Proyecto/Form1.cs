using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
     public partial class FormaPrincipal : Form
     {
          private FormaProducto formaProducto;
          private FormaVenta formaVenta;
          private FormaSocio formaSocio;
          private FormaBitacora formaBitacora;
          private FormaDetallePago formaDetallePago;
          private FormaRutina formaRutina;
          private FormaPlan formaPlan;
        public DataGridView bitaco = null;

          public FormaPrincipal()
          {
               InitializeComponent();
          }

          private void botonProducto_Click(object sender, EventArgs e)
          {
               formaProducto = new FormaProducto(this);
               formaProducto.Show();
               this.Hide();
          }

          private void botonVenta_Click(object sender, EventArgs e)
          {
               formaVenta = new FormaVenta(this);
               formaVenta.Show();
               this.Hide();
          }

          private void botonSocio_Click(object sender, EventArgs e)
          {
               formaSocio = new FormaSocio(this);
               formaSocio.Show();
               this.Hide();
          }

          private void botonBitacora_Click(object sender, EventArgs e)
          {
               formaBitacora = new FormaBitacora(this);
               formaBitacora.Show();
               this.Hide();
          }

          private void botonDetallePago_Click(object sender, EventArgs e)
          {
               formaDetallePago = new FormaDetallePago(this);
               formaDetallePago.Show();
               this.Hide();
          }

          private void botonPlan_Click(object sender, EventArgs e)
          {
               formaPlan = new FormaPlan(this);
               formaPlan.Show();
               this.Hide();
          }

          private void botonRutina_Click(object sender, EventArgs e)
          {
               formaRutina = new FormaRutina(this);
               formaRutina.Show();
               this.Hide();
          }
     }
}

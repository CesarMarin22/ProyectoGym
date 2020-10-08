using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregadas
using System.Data.SqlClient;

namespace Proyecto
{
     public partial class FormaDetallePago : Form
     {
          private FormaPrincipal inicio;
          conexion c;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        SqlCommand cmd; //comando
        DataGridView dgv;
        SqlDataReader dr;

        public FormaDetallePago(FormaPrincipal fp)
          {
               InitializeComponent();
               inicio = fp;
            cargaComboTipo();
            botonAgregar.Enabled = false; //evitar mandar datos nulos
            cargarDatos();
            
        }

          private void botonVolver_Click(object sender, EventArgs e)
          {
            c.cerrarConexion();
            this.Close();
          }

          private void FormaDetallePago_FormClosing(object sender, FormClosingEventArgs e)
          {
            c.cerrarConexion();
               inicio.Show();
          }

        //inicia el combobox del tipo de pago
        private void cargaComboTipo()
        {
            comboTipo.Items.Add("dia");
            comboTipo.Items.Add("semana");
            comboTipo.Items.Add("mes");

            comboTipo.SelectedIndex = 0;
        }

        private void FormaDetallePago_Load(object sender, EventArgs e)
        {
            c = new conexion();
        }

        //buscar socios al teclear id
        private void textoClave_TextChanged(object sender, EventArgs e)
        {
            if(textoClave.Text == "")
            {
                textoNombre.Text = "";
                botonAgregar.Enabled = false;//evitar mandar datos nulos
                return;
            }
                
            c = new conexion();
            try
            {
                textoNombre.Text = "";
                cmd = new SqlCommand("SELECT nombre_Socio FROM GENERAL.T_SOCIO WHERE id_Socio = " + textoClave.Text, c.regresaConexion());
                //cmd.ExecuteNonQuery();

                 dr = cmd.ExecuteReader();

                

                if (dr.Read())
                {
                    textoNombre.Text = (Convert.ToString(dr["nombre_Socio"]));
                    botonAgregar.Enabled = true;//evitar mandar datos nulos
                }
                else
                {
                    botonAgregar.Enabled = false;//evitar mandar datos nulos
                }

                


            }
            catch (Exception ex)
            {
                botonAgregar.Enabled = false;//evitar mandar datos nulos
                //MessageBox.Show("no funciona");
            }
            c.cerrarConexion();
        }

        //carga los datos al data
        public void cargarDatos()
        {
            c = new conexion();
            try
            {
                da = new SqlDataAdapter("SELECT id_Pago AS NumPago, monto AS Monto, fecha AS Fecha, tipo_Pago AS Tipo, id_Socio AS NumSocio FROM GENERAL.T_DETALLE_PAGOS", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                dataGridDetalle.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar");
            }

            c.cerrarConexion();
        }

        //actualiza el costo del pago por el tipo de subscripcion
        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboTipo.SelectedItem.ToString())
            {
                case "dia":
                    {
                        textoMonto.Text = "$30";
                        break;
                    }

                case "semana":
                    {
                        textoMonto.Text = "$100";
                        break;
                    }

                case "mes":
                    {
                        textoMonto.Text = "$300";
                        break;
                    }
            }
        }

        //insertar un nuevo valor
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            c = new conexion();
            try
            {
                textoMonto.Text = textoMonto.Text.Remove(0, 1); // quitar el $ 
                string sq = "INSERT INTO GENERAL.T_DETALLE_PAGOS VALUES (" + textoMonto.Text + ", GETDATE()," + "'" + comboTipo.SelectedItem + "'," + textoClave.Text + ")";
                cmd = new SqlCommand(sq, c.regresaConexion());
                cmd.ExecuteNonQuery();
                textoMonto.Text.Insert(0, "$"); //agrega el $
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error de insercion");
            }
            c.cerrarConexion();
        }

        
    }
}

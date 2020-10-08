using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto
{
     public partial class FormaBitacora : Form
     {
          private FormaPrincipal inicio;
          conexion c;
          SqlDataAdapter da; //select
          DataTable dt; //datos a tabla
          SqlCommand cmd; //comando
          DataGridView dgv;
          SqlDataReader dr;
          int seleccionado_Entrada;

          public FormaBitacora(FormaPrincipal fp)
          {
               InitializeComponent();
               inicio = fp;
               botonEntrar.Enabled = false;
               cargarDatos();
               fechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd");
               textoHEntrada.Text = DateTime.Now.ToString("hh:mm");
               textoHSalida.Text = DateTime.Now.ToString("hh:mm");
               timer1.Interval = 5000;
               timer1.Enabled = true;
               
            if(inicio.bitaco != null)
            {
                dataGridEntrada.Columns.Add("id_Socio", "ID Socio");
                dataGridEntrada.Columns.Add("fecha", "Fecha");
                dataGridEntrada.Columns.Add("horaEntrada", "Hora Entrada");
                obtenerData();

            }
            else
            {
                dataGridEntrada.Columns.Add("id_Socio", "ID Socio");
                dataGridEntrada.Columns.Add("fecha", "Fecha");
                dataGridEntrada.Columns.Add("horaEntrada", "Hora Entrada");
            }
            
          }

        private void pasarData()
        {
            inicio.bitaco.Columns.Add("id_Socio", "ID Socio");
            inicio.bitaco.Columns.Add("fecha", "Fecha");
            inicio.bitaco.Columns.Add("horaEntrada", "Hora Entrada");
            for (int i = 0; i < dataGridEntrada.RowCount;i++)
            {
                inicio.bitaco.Rows.Add(dataGridEntrada.Rows[i].Cells[0].Value.ToString(), dataGridEntrada.Rows[i].Cells[1].Value.ToString(), dataGridEntrada.Rows[i].Cells[2].Value.ToString());
            }
        }

        private void obtenerData()
        {
            for (int i = 0; i < inicio.bitaco.RowCount -1; i++)
            {
                dataGridEntrada.Rows.Add(inicio.bitaco.Rows[i].Cells[0].Value.ToString(), inicio.bitaco.Rows[i].Cells[1].Value.ToString(), inicio.bitaco.Rows[i].Cells[2].Value.ToString());
            }
        }

          private void botonVolver_Click(object sender, EventArgs e)
          {
            inicio.bitaco = new DataGridView();
            pasarData();
               c.cerrarConexion();
               this.Close();
          }

          private void FormaBitacora_FormClosing(object sender, FormClosingEventArgs e)
          {
            inicio.bitaco = new DataGridView();
            pasarData();
            c.cerrarConexion();
               inicio.Show();
          }

          private void textoClave_KeyDown(object sender, KeyEventArgs e)
          {

          }

          private void dataGridBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          public void cargarDatos()
          {
               c = new conexion();
               try
               {
                    da = new SqlDataAdapter("SELECT id_Socio, fecha, horaEntrada, horaSalida FROM GENERAL.T_BITACORA", c.regresaConexion());
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridBitacora.DataSource = dt;
               }
               catch (Exception ex)
               {
                    MessageBox.Show("No se pudo actualizar");
               }
               c.cerrarConexion();
          }

          private void textoClave_TextChanged(object sender, EventArgs e)
          {
               if (textoClave.Text == "")
               {
                    textoNombre.Text = "";
                    botonEntrar.Enabled = false;
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
                         botonEntrar.Enabled = true;//evitar mandar datos nulos
                    }
                    else
                    {
                         botonEntrar.Enabled = false;//evitar mandar datos nulos
                    }




               }
               catch (Exception ex)
               {
                    botonEntrar.Enabled = false;//evitar mandar datos nulos
                    //MessageBox.Show("no funciona");
               }
               c.cerrarConexion();
          }

          private void botonEntrar_Click(object sender, EventArgs e)
          {
               if(textoNombre.Text != "")
               {
                   if (Vigencia_Socio(textoClave.Text) == true)
                   {
                        dataGridEntrada.Rows.Add(textoClave.Text, fechaActual.Text, textoHEntrada.Text);
                   }
               }
          }

          private bool Vigencia_Socio(String clave_Socio)
          {
              bool resp = false;
              c = new conexion();
               try
               {
                    string sq = "SELECT S.vigencia FROM GENERAL.T_SOCIO AS S WHERE S.id_Socio = " + clave_Socio + ";";
                    cmd = new SqlCommand(sq, c.regresaConexion());
                    SqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        DateTime t = read.GetDateTime(0);
                        if (DateTime.Compare(DateTime.Now, t) <= 0)
                            resp = true;
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("No se pudo actualizar");
               }
               c.cerrarConexion();

               return resp;
          }

          private void FormaBitacora_Load(object sender, EventArgs e)
          {
               c = new conexion();
          }

          private void botonSalida_Click(object sender, EventArgs e)
          {
               if (dataGridEntrada.SelectedRows.Count > 0)
               {
                    c = new conexion();
                    try
                    {
                        string sq = "INSERT INTO GENERAL.T_BITACORA (id_Socio, fecha, horaEntrada, horaSalida) VALUES (" + int.Parse(dataGridEntrada.CurrentRow.Cells[0].Value.ToString()) + ", '" + fechaActual.Text + "', '" + dataGridEntrada.CurrentRow.Cells[2].Value.ToString() + "', '" + DateTime.Now.ToString("hh:mm") + "')";
                         cmd = new SqlCommand(sq, c.regresaConexion());
                         cmd.ExecuteNonQuery();
                         cargarDatos();

                         dataGridEntrada.Rows.RemoveAt(seleccionado_Entrada);
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("error de insercion. Error: " + ex);
                    }
                    c.cerrarConexion();
               }
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               fechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd");
               textoHEntrada.Text = DateTime.Now.ToString("hh:mm");
               textoHSalida.Text = DateTime.Now.ToString("hh:mm");
          }

          private void dataGridEntrada_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              seleccionado_Entrada = e.RowIndex;

              dataGridEntrada.Rows[e.RowIndex].Selected = true;
              textoClave.Text = dataGridEntrada.CurrentRow.Cells[0].Value.ToString();
              fechaActual.Text = dataGridEntrada.CurrentRow.Cells[1].Value.ToString();
              textoHEntrada.Text = DateTime.Parse(dataGridEntrada.CurrentRow.Cells[2].Value.ToString()).ToString("hh:mm");
          }

          private void dataGridBitacora_CellClick(object sender, DataGridViewCellEventArgs e)
          {
          }
     }
}
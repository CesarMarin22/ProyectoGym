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
     public partial class FormaSocio : Form
     {
          private FormaPrincipal inicio;
          private SqlCommand cmd;
          private SqlDataAdapter adaptador;
          private conexion c;
          private DataTable tabla;

          public FormaSocio(FormaPrincipal fp)
          {
               InitializeComponent();
               inicio = fp;
               textoVigencia.Text = DateTime.Now.ToString("yyyy-MM-dd");
               MuestraDatos(dataGridSocio);
          }

          private void botonVolver_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormaSocio_FormClosing(object sender, FormClosingEventArgs e)
          {
               inicio.Show();
          }

          private void botonAgregar_Click(object sender, EventArgs e)
          {
              try
              {
                  c = new conexion();
                  cmd = new SqlCommand("INSERT INTO GENERAL.T_SOCIO(nombre_Socio, direccion_Socio, peso_Socio, altura_Socio, ocupacion_Socio, vigencia) VALUES('" + textoNombre.Text + "','" + textoDireccion.Text + "', " + numericPeso.Text.Replace(",", ".") + ", " + numericEstatura.Text.Replace(",", ".") + ",'" + textoOcupacion.Text + "','" + textoVigencia.Text + "')", c.regresaConexion());
                  cmd.ExecuteNonQuery();
                  c.cerrarConexion();
                  MessageBox.Show("Socio insertado");
                  MuestraDatos(dataGridSocio);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se pudo insertar" + ex.ToString());
                  c.cerrarConexion();
              }
          }
          public void MuestraDatos(DataGridView d)
          {
              try
              {
                  c = new conexion();
                  adaptador = new SqlDataAdapter("SELECT * FROM GENERAL.T_SOCIO", c.regresaConexion());
                  tabla = new DataTable();
                  adaptador.Fill(tabla);
                  d.DataSource = tabla;
                  c.cerrarConexion();
              }
              catch (Exception e)
              {
                  MessageBox.Show("No se pudo consultar datos " + e.ToString());
                  c.cerrarConexion();
              }
          }

          private void dataGridSocio_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
          {
                dataGridSocio.Rows[e.RowIndex].Selected = true;
                textoClave.Text = dataGridSocio.CurrentRow.Cells[0].Value.ToString();
                textoNombre.Text = dataGridSocio.CurrentRow.Cells[1].Value.ToString();
                textoDireccion.Text = dataGridSocio.CurrentRow.Cells[2].Value.ToString();
                numericPeso.Text = dataGridSocio.CurrentRow.Cells[3].Value.ToString().Replace(".", ",");
                numericEstatura.Text = dataGridSocio.CurrentRow.Cells[4].Value.ToString().Replace(".", ",");
                textoOcupacion.Text = dataGridSocio.CurrentRow.Cells[5].Value.ToString();
                //textoVigencia.Text = dataGridSocio.CurrentRow.Cells[6].Value.ToString();
                textoVigencia.Text = DateTime.Parse(dataGridSocio.CurrentRow.Cells[6].Value.ToString()).ToString("yyyy-MM-dd");
          }

          private void botonModificar_Click(object sender, EventArgs e)
          {
              try
              {
                  c = new conexion();
                  cmd = new SqlCommand("UPDATE GENERAL.T_SOCIO SET nombre_Socio = '" + textoNombre.Text + 
                                                                "', direccion_Socio = '" + textoDireccion.Text +
                                                                "', peso_Socio = " + numericPeso.Value.ToString().Replace(",", ".") +
                                                                ", altura_Socio = " + numericEstatura.Value.ToString().Replace(",", ".") +
                                                                ", ocupacion_Socio = '" + textoOcupacion.Text +
                                                                "', vigencia = '" + textoVigencia.Text + 
                                                                "' WHERE id_Socio = " + textoClave.Text + ";", c.regresaConexion());
                  cmd.ExecuteNonQuery();
                  c.cerrarConexion();
                  MessageBox.Show("Socio modificado");
                  MuestraDatos(dataGridSocio);
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se pudo modificar" + ex.ToString());
                  c.cerrarConexion();
              }
          }

          private void botonEliminar_Click(object sender, EventArgs e)
          {
              try
              {
                  c = new conexion();
                  cmd = new SqlCommand("DELETE FROM GENERAL.T_SOCIO WHERE id_Socio = " + textoClave.Text, c.regresaConexion());
                  cmd.ExecuteNonQuery();
                  c.cerrarConexion();
                  MuestraDatos(dataGridSocio); 
                  MessageBox.Show("Socio Eliminado");
                  textoClave.Text = "";
                  textoDireccion.Text = "";
                  textoNombre.Text = "";
                  textoOcupacion.Text = "";
                  textoVigencia.Text = "";
                  numericEstatura.Value = 0;
                  numericPeso.Value = 0;
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se pudo eliminar datos " + ex.ToString());
                  c.cerrarConexion();
              }
          }

          private void FormaSocio_Load(object sender, EventArgs e)
          {

          }
     }
}

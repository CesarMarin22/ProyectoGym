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
     public partial class FormaProducto : Form
     {
          private FormaPrincipal inicio;
          SqlCommand cmd;
          SqlDataAdapter adaptador;
          conexion c;
          DataTable tabla;

          public FormaProducto(FormaPrincipal fp)
          {
               InitializeComponent();
               inicio = fp;
               MuestraDatos(dataGridProducto);
               this.DoubleBuffered = true;
          }

          private void botonVolver_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormaProducto_FormClosing(object sender, FormClosingEventArgs e)
          {
               inicio.Show();
          }

          private void FormaProducto_Load(object sender, EventArgs e)
          {

          }

          private void botonAgregar_Click(object sender, EventArgs e)
          {
              bool existe = false;
              try
              {
                  if(dataGridProducto.RowCount==0)
                  {
                      c = new conexion();
                      cmd = new SqlCommand("INSERT INTO VENTAS.T_PRODUCTOS(nombre_Producto, precio_Producto, cantidad_Producto) VALUES('" + textoNombre.Text + "', " + numericPrecio.Text.Replace(",", ".") + ", " + numericCantidad.Text.Replace(",", ".") + ")", c.regresaConexion());
                      cmd.ExecuteNonQuery();
                      c.cerrarConexion();
                      MessageBox.Show("Producto insertado");
                      textoNombre.Text = "";
                      numericCantidad.Value = 0;
                      numericPrecio.Value = 0;
                  }
                  else 
                  { 
                      for (int i = 0; i < dataGridProducto.RowCount; i++)
                      {
                          //  dataGridProducto.Columns[3];
                          if (dataGridProducto.Rows[i].Cells[1].Value.ToString() == textoNombre.Text)
                          {
                              existe = true;
                          }
                      }
                      if (existe == false)
                      {
                          c = new conexion();
                          cmd = new SqlCommand("INSERT INTO VENTAS.T_PRODUCTOS(nombre_Producto, precio_Producto, cantidad_Producto) VALUES('" + textoNombre.Text + "', " + numericPrecio.Text.Replace(",", ".") + ", " + numericCantidad.Text.Replace(",", ".") + ")", c.regresaConexion());
                          cmd.ExecuteNonQuery();
                          c.cerrarConexion();
                          MessageBox.Show("Producto insertado");
                          textoNombre.Text = "";
                          numericCantidad.Value = 0;
                          numericPrecio.Value = 0;
                      }
                      else
                          MessageBox.Show("Nombre del producto existente");
                  }
                  
                  
                  MuestraDatos(dataGridProducto);
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
                         adaptador = new SqlDataAdapter("SELECT * FROM VENTAS.T_PRODUCTOS", c.regresaConexion());
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

          private void dataGridProducto_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
          {
              dataGridProducto.Rows[e.RowIndex].Selected = true;
              textoNombre.Text = dataGridProducto.CurrentRow.Cells[1].Value.ToString();
              numericPrecio.Text = dataGridProducto.CurrentRow.Cells[2].Value.ToString().Replace(".", ",");
              numericCantidad.Text = dataGridProducto.CurrentRow.Cells[3].Value.ToString().Replace(".", ",");
          }

          private void botonModificar_Click(object sender, EventArgs e)
          {
              try
              {
                  c = new conexion();
                  cmd = new SqlCommand("UPDATE VENTAS.T_PRODUCTOS SET nombre_Producto = '" + textoNombre.Text +
                                                                "', precio_Producto = " + numericPrecio.Value.ToString().Replace(",", ".") +
                                                                ", cantidad_Producto = " + numericCantidad.Value.ToString().Replace(",", ".") +
                                                                 " WHERE id_Producto = " + dataGridProducto.CurrentRow.Cells[0].Value.ToString() + ";", c.regresaConexion());
                  cmd.ExecuteNonQuery();
                  c.cerrarConexion();
                  MessageBox.Show("Producto modificado");
                  MuestraDatos(dataGridProducto);
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
                  cmd = new SqlCommand("DELETE FROM VENTAS.T_PRODUCTOS WHERE id_Producto = " + dataGridProducto.CurrentRow.Cells[0].Value.ToString(), c.regresaConexion());
                  cmd.ExecuteNonQuery();
                  c.cerrarConexion();
                  MuestraDatos(dataGridProducto);
                  MessageBox.Show("Producto Eliminado");
                  textoNombre.Text = "";
                  numericCantidad.Value = 0;
                  numericPrecio.Value = 0;

              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se pudo eliminar datos " + ex.ToString());
                  c.cerrarConexion();
              }
          }


     }
}

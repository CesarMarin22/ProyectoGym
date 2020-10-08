using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregadas
using System.Data.SqlClient;

namespace Proyecto
{
     public partial class FormaVenta : Form
     {
          private FormaPrincipal inicio;
          private SqlCommand cmd;
          private SqlDataAdapter adaptador;
          private conexion c;
          private DataTable tabla;

          public FormaVenta(FormaPrincipal fp)
          {
               InitializeComponent();
               this.DoubleBuffered = true;
               inicio = fp;
               textoFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
               MuestraProductos();
               MuestraVentas();
               FormatoCarrito();
               textoTotal.Text = "" + string.Format("{0:0.00}", 0);
          }

          public void MuestraProductos()
          {
               comboProducto.Items.Clear();
               try
               {
                    c = new conexion();
                    adaptador = new SqlDataAdapter("SELECT * FROM VENTAS.T_PRODUCTOS", c.regresaConexion());
                    tabla = new DataTable();
                    adaptador.Fill(tabla);
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                         comboProducto.Items.Add(tabla.Rows[i][0] + " - " + tabla.Rows[i][1] + " - $" + string.Format("{0:0.00}", tabla.Rows[i][2]));
                    }
                    c.cerrarConexion();
                    if (comboProducto.Items.Count > 0)
                         comboProducto.SelectedIndex = 0;
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Error al consultar datos de Productos. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.cerrarConexion();
               }
          }

          public void MuestraVentas()
          {
               try
               {
                    c = new conexion();
                    adaptador = new SqlDataAdapter("SELECT * FROM VENTAS.T_VENTAS", c.regresaConexion());
                    tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridVenta.DataSource = tabla;
                    c.cerrarConexion();
               }
               catch(Exception ex)
               {
                    MessageBox.Show("Error al consultar datos de Ventas. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    c.cerrarConexion();
               }
          }

          public void FormatoCarrito()
          {
               listaProductos.Clear();
               listaProductos.Columns.Add("ID");
               listaProductos.Columns.Add("Nombre");
               listaProductos.Columns.Add("Precio");
               listaProductos.Columns.Add("Cantidad");
               listaProductos.Columns.Add("Subtotal");
               AjustarCarrito();
          }

          public void AjustarCarrito()
          {
               for (int i = 0; i < listaProductos.Columns.Count; i++)
               {
                    listaProductos.Columns[i].Width = listaProductos.Width / 5;
                    listaProductos.Columns[i].TextAlign = HorizontalAlignment.Center;
               }
          }

          public bool VerificaClave()
          {
               bool esNumero = true;
               string aux = textoClave.Text;
               foreach(char c in aux)
               {
                    if(char.IsDigit(c) == false)
                    {
                         esNumero = false;
                         break;
                    }
               }
               return esNumero;
          }

          public bool BuscaProducto(int id)
          {
               bool encontrado = false;
               for (int i = 0; i < listaProductos.Items.Count; i++)
               {
                    if(listaProductos.Items[i].Text == id.ToString())
                    {
                         encontrado = true;
                         break;
                    }
               }
               return encontrado;
          }

          public void CalculaTotal()
          {
               float total = 0;
               for (int i = 0; i < listaProductos.Items.Count; i++)
               {
                    total = total + float.Parse(listaProductos.Items[i].SubItems[2].Text) * float.Parse(listaProductos.Items[i].SubItems[3].Text);
               }
               textoTotal.Text = "" + string.Format("{0:0.00}", total);
          }

          public void CargaDetallesVenta(int idV)
          {
               c = new conexion();
               for (int i = 0; i < listaProductos.Items.Count; i++)
               {
                    try
                    {
                         cmd = new SqlCommand("INSERT INTO VENTAS.T_DETALLE_VENTAS(id_Venta, id_Producto, cantidad, subtotal) VALUES(" + idV + ", " + listaProductos.Items[i].SubItems[0].Text + ", " + listaProductos.Items[i].SubItems[3].Text + ", " + (float.Parse(listaProductos.Items[i].SubItems[2].Text) * float.Parse(listaProductos.Items[i].SubItems[3].Text)) + ")", c.regresaConexion());
                         cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                         MessageBox.Show("No se pudo insertar el detalle. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
               c.cerrarConexion();
               MuestraVentas();
          }

          public void CargaCarrito(int idV)
          {
               DataTable aux;
               FormatoCarrito();
               try
               {
                    c = new conexion();
                    adaptador = new SqlDataAdapter("SELECT id_Producto, cantidad FROM VENTAS.T_DETALLE_VENTAS WHERE id_Venta = " + idV, c.regresaConexion());
                    tabla = new DataTable();
                    adaptador.Fill(tabla);
                    c.cerrarConexion();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                         c = new conexion();
                         adaptador = new SqlDataAdapter("SELECT * FROM VENTAS.T_PRODUCTOS WHERE id_Producto = " + tabla.Rows[i][0], c.regresaConexion());
                         aux = new DataTable();
                         adaptador.Fill(aux);
                         ListViewItem l = new ListViewItem(aux.Rows[0][0].ToString());
                         l.SubItems.Add(aux.Rows[0][1].ToString());
                         l.SubItems.Add("" + string.Format("{0:0.00}", aux.Rows[0][2]));
                         l.SubItems.Add(tabla.Rows[i][1].ToString());
                         l.SubItems.Add("" + string.Format("{0:0.00}", float.Parse(aux.Rows[0][2].ToString()) * float.Parse(tabla.Rows[i][1].ToString())));
                         listaProductos.Items.Add(l);
                         c.cerrarConexion();
                         CalculaTotal();
                    }
               }
               catch(Exception ex)
               {
                    MessageBox.Show("No se ha podiddo leer el detalle de venta Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void botonVolver_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormaVenta_FormClosing(object sender, FormClosingEventArgs e)
          {
               inicio.Show();
          }

          private void textoClave_TextChanged(object sender, EventArgs e)
          {
               if(string.IsNullOrWhiteSpace(textoClave.Text) == false)
               {
                    textoNombre.Text = "";
                    if(VerificaClave() == true)
                    {
                         try
                         {
                              c = new conexion();
                              cmd = new SqlCommand("SELECT nombre_Socio FROM GENERAL.T_SOCIO WHERE id_Socio = " + int.Parse(textoClave.Text), c.regresaConexion());
                              SqlDataReader r = cmd.ExecuteReader();
                              while(r.Read())
                              {
                                   textoNombre.Text = r.GetString(0);
                              }
                              if(textoNombre.Text == "")
                                   MessageBox.Show("Socio no encontrado.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         catch(Exception ex)
                         {
                              MessageBox.Show("Error al consultar datos del Socio. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              c.cerrarConexion();
                         }
                    }
                    else
                    {
                         MessageBox.Show("La clave es numérica, no puede contener otros caracteres", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
               }
               else
               {
                    if(textoClave.Text != "")
                         MessageBox.Show("La clave está vacía o sólo contiene espacios en blanco", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
          }

          private void botonAgregarProducto_Click(object sender, EventArgs e)
          {
               if(comboProducto.SelectedIndex >= 0 && numericCantidad.Value > 0)
               {
                    int id = int.Parse(comboProducto.Items[comboProducto.SelectedIndex].ToString().Substring(0, comboProducto.Items[comboProducto.SelectedIndex].ToString().IndexOf(' ')));
                    if (BuscaProducto(id) == false)
                    {
                         try
                         {
                              c = new conexion();
                              adaptador = new SqlDataAdapter("SELECT * FROM VENTAS.T_PRODUCTOS WHERE id_Producto = " + id, c.regresaConexion());
                              tabla = new DataTable();
                              adaptador.Fill(tabla);
                              if (int.Parse(tabla.Rows[0][3].ToString()) >= numericCantidad.Value)
                              {
                                   ListViewItem l = new ListViewItem(tabla.Rows[0][0].ToString());
                                   l.SubItems.Add(tabla.Rows[0][1].ToString());
                                   l.SubItems.Add("" + string.Format("{0:0.00}", tabla.Rows[0][2]));
                                   l.SubItems.Add(numericCantidad.Value.ToString());
                                   l.SubItems.Add("" + string.Format("{0:0.00}", float.Parse(tabla.Rows[0][2].ToString()) * float.Parse(numericCantidad.Value.ToString())));
                                   listaProductos.Items.Add(l);
                                   c.cerrarConexion();
                                   CalculaTotal();
                              }
                              else
                              {
                                   MessageBox.Show("Las existencias del producto seleccionado no cubren la cantidad solicitada. Quedan: " + tabla.Rows[0][3].ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              }
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show("Error al consultar datos de Productos. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              c.cerrarConexion();
                         }
                    }
                    else
                    {
                         MessageBox.Show("El producto ya se encuentra en el carrito. Para hacer cambios deberás quitarlo de este y volverlo a agregar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
               }
               else
               {
                    MessageBox.Show("No se ha seleccionado un producto o su cantidad es 0", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
          }

          private void botonQuitarProducto_Click(object sender, EventArgs e)
          {
               if (listaProductos.SelectedItems.Count > 0)
               {
                    listaProductos.Items.Remove(listaProductos.SelectedItems[0]);
                    CalculaTotal();
               }
               else
               {
                    MessageBox.Show("Seleccione el producto a retirar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
          }

          private void botonAgregar_Click(object sender, EventArgs e)
          {
               if(textoNombre.Text != "")
               {
                    if(float.Parse(textoTotal.Text) > 0)
                    {
                         try
                         {
                              int id;
                              textoFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                              c = new conexion();
                              cmd = new SqlCommand("INSERT INTO VENTAS.T_VENTAS(fecha, total, id_Socio) VALUES('" + textoFecha.Text + "', " + 0 + ", " + textoClave.Text + ")", c.regresaConexion());
                              cmd.ExecuteNonQuery();
                              c.cerrarConexion();
                              adaptador = new SqlDataAdapter("SELECT id_Venta FROM VENTAS.T_VENTAS", c.regresaConexion());
                              tabla = new DataTable();
                              adaptador.Fill(tabla);
                              id = int.Parse(tabla.Rows[tabla.Rows.Count - 1][0].ToString());
                              c.cerrarConexion();
                              MuestraVentas();
                              CargaDetallesVenta(id);
                              listaProductos.Clear();
                              textoClave.Text = "";
                              numericCantidad.Value = 1;
                              textoNombre.Text = "";
                         }
                         catch(Exception ex)
                         {
                              MessageBox.Show("No se pudo registrar la venta. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                    else
                         MessageBox.Show("Seleccione al menos un producto", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                    MessageBox.Show("Especifique un socio válido para continuar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
          }

          private void dataGridVenta_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               /*int idV = int.Parse(dataGridVenta.CurrentRow.Cells[0].Value.ToString());
               textoFecha.Text = DateTime.Parse(dataGridVenta.CurrentRow.Cells[1].Value.ToString()).ToString("yyyy-MM-dd");
               textoClave.Text = dataGridVenta.CurrentRow.Cells[3].Value.ToString();
               CargaCarrito(idV);
               CalculaTotal();*/
          }

          private void botonEliminar_Click(object sender, EventArgs e)
          {
               if(dataGridVenta.SelectedRows.Count > 0)
               {
                    int idV = int.Parse(dataGridVenta.CurrentRow.Cells[0].Value.ToString());
                    try
                    {
                         c = new conexion();
                         cmd = new SqlCommand("DELETE FROM VENTAS.T_DETALLE_VENTAS WHERE id_Venta = " + idV, c.regresaConexion());
                         cmd.ExecuteNonQuery();
                         cmd = new SqlCommand("DELETE FROM VENTAS.T_VENTAS WHERE id_Venta = " + idV, c.regresaConexion());
                         cmd.ExecuteNonQuery();
                         MuestraVentas();
                         FormatoCarrito();
                    }
                    catch(Exception ex)
                    {
                         MessageBox.Show("No se pudo eliminar. Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
               else
               {
                    MessageBox.Show("Selecciona la venta que quieres Cancelar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
          }
     }
}

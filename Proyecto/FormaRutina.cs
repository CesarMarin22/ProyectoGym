using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto
{
     public partial class FormaRutina : Form
     {
          private FormaPrincipal inicio;
          SqlCommand cmd;
          SqlDataAdapter adaptador;
          conexion c;
          DataTable dt;
          DataSet ds;
          SqlDataReader dr;
          int cont = 0;
          public FormaRutina(FormaPrincipal fp)
          {
               InitializeComponent();
               inicio = fp;
               cargarSocio();
               cargarRutinasCompletas();
               cont++;
          }

          public void cargarRutinas()
          {
              string idSocio = comboSocio.Text;
              List<string> idRutinas = new List<string>();
              c = new conexion();
              try
              {
                  cmd = new SqlCommand("SELECT * FROM RUTINAS.T_RUTINAXSOCIO WHERE id_Socio = " + idSocio + "", c.regresaConexion());
                  dr = cmd.ExecuteReader();
                  if (dr.HasRows)
                  {
                      while (dr.Read())
                      {
                          idRutinas.Add(dr["id_Rutina"].ToString());
                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se cargaron las rutinas");
              }
              c.cerrarConexion();

              //..........................................................//
              c = new conexion();
              dt = new DataTable();
              for (int i = 0; i < idRutinas.Count; i++)
              {
                  try
                  {
                      adaptador = new SqlDataAdapter("SELECT * FROM RUTINAS.T_RUTINAS WHERE id_Rutina = '" + idRutinas.ElementAt(i) + "'", c.regresaConexion());
                      adaptador.Fill(dt);
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("No se pudo actualizar");
                  }
              }
              dataGridRutina.DataSource = dt;
              c.cerrarConexion();
          }

          public void cargarRutinasCompletas()
          {
              ds = new DataSet();
              c = new conexion();
              try
              {
                  adaptador = new SqlDataAdapter("SELECT id_Rutina,nombre_Rutina FROM RUTINAS.T_RUTINAS ", c.regresaConexion());
                  adaptador.Fill(ds);

                  for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    comboRutina.Items.Add(ds.Tables[0].Rows[i][0].ToString() + ".-" + "  " + ds.Tables[0].Rows[i][1].ToString());
                
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se cargaron las rutinas", ex.ToString());
              }
              c.cerrarConexion();
          }

         public void cargarSocio()
         {
              ds = new DataSet();
              c = new conexion();
              try
              {
                  adaptador = new SqlDataAdapter("SELECT id_Socio FROM GENERAL.T_SOCIO ", c.regresaConexion());
                  adaptador.Fill(ds);
                  comboSocio.DataSource = ds.Tables[0].DefaultView;
                  comboSocio.ValueMember = "id_Socio";
              }
              catch (Exception ex)
              {
                  MessageBox.Show("No se cargo el socio");
              }
              
         }

          private void botonVolver_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormaRutina_FormClosing(object sender, FormClosingEventArgs e)
          {
               inicio.Show();
          }

          private void comboSocio_SelectedValueChanged(object sender, EventArgs e)
          {
              if(cont >0)
                cargarRutinas();
          }

          private void botonAgregar_Click(object sender, EventArgs e)
          {
              string idSocio = comboSocio.Text;
              string idRutina = comboRutina.Text.Split('.')[0];
              c = new conexion();
              try
              {
                  string sq = "INSERT INTO RUTINAS.T_RUTINAXSOCIO VALUES ('" + idRutina + "','" + idSocio + "')";
                  cmd = new SqlCommand(sq, c.regresaConexion());
                  cmd.ExecuteNonQuery();
              }
              catch(Exception ex)
              {
                  MessageBox.Show("No se inserto la rutina");
              }
              c.cerrarConexion();
              cargarRutinas();
          }

          private void botonEliminar_Click(object sender, EventArgs e)
          {
              string idSocio = comboSocio.Text;
              string idRutina = comboRutina.Text.Split('.')[0];
              c = new conexion();
              try
              {
                  string sq = "DELETE FROM RUTINAS.T_RUTINAXSOCIO WHERE id_Rutina = '" + idRutina + "' AND  id_Socio = '" + idSocio + "'";
                  cmd = new SqlCommand(sq, c.regresaConexion());
                  cmd.ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al eliminar" );
              }
              c.cerrarConexion();
              cargarRutinas();
          }

          private void botonModificar_Click(object sender, EventArgs e)
          {
              string idSocio = comboSocio.Text;
              string idRutina = comboRutina.Text.Split('.')[0];
              c = new conexion();
              try
              {
                  string sq = "UPDATE RUTINAS.T_RUTINAXSOCIO SET id_Rutina = " + idRutina + " WHERE id_Rutina = " + dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[0].Value.ToString()+ " AND id_Socio = " + idSocio ;
                  cmd = new SqlCommand(sq, c.regresaConexion());
                  cmd.ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al modificar rutina", ex.ToString());
              }
              c.cerrarConexion();
              cargarRutinas();
          }
     }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//nuevas
using System.Data.SqlClient;

namespace Proyecto
{
     public partial class FormaPlan : Form
     {
          private FormaPrincipal inicio;
        conexion c;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        SqlCommand cmd; //comando
        DataGridView dgv;
        SqlDataReader dr;

        public FormaPlan(FormaPrincipal fp)
          {
               InitializeComponent();
               inicio = fp;
            cargaComboPlan();
            cargarDatosRutina();
            
          }

          private void botonVolver_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormaPlan_FormClosing(object sender, FormClosingEventArgs e)
          {
               inicio.Show();
          }

        //carga el combo de plan de alimentacion
        private void cargaComboPlan()
        {
            comboPlan.Items.Add("subir");
            comboPlan.Items.Add("bajar");
            comboPlan.Items.Add("marcar");
            comboPlan.Items.Add("competir");

            comboPlan.SelectedIndex = 0;
        }

        //carga la tabla de rutinas
        public void cargarDatosRutina()
        {
            string idplan = "";
            c = new conexion();
            try
            {
                cmd = new SqlCommand("SELECT id_Plan FROM RUTINAS.T_PLAN WHERE tipo_Plan = '" + comboPlan.SelectedItem + "'", c.regresaConexion());
                //cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();



                if (dr.Read())
                {
                    idplan = (Convert.ToString(dr["id_Plan"]));

                }
                else
                {
                    c.cerrarConexion();
                    return;
                }
                c.cerrarConexion();

                c = new conexion();

                da = new SqlDataAdapter("SELECT id_Rutina AS Rutina, nombre_Rutina AS Nombre, descripcion AS Descripción FROM RUTINAS.T_RUTINAS WHERE id_Plan = " + idplan, c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                dataGridRutina.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar. Error: " + ex);
            }

            c.cerrarConexion();
        }

        //agregar una rutina
        private void botonAgregarRutina_Click(object sender, EventArgs e)
        {
            string idplan = "";
            c = new conexion();
            try
            {
                ///////
                cmd = new SqlCommand("SELECT id_Plan FROM RUTINAS.T_PLAN WHERE tipo_Plan = '" + comboPlan.SelectedItem + "'", c.regresaConexion());
                //cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();



                if (dr.Read())
                {
                    idplan = (Convert.ToString(dr["id_Plan"]));
                    
                }else
                {
                    c.cerrarConexion();
                    return;
                }

                //////
                c = new conexion();
                string sq = "INSERT INTO RUTINAS.T_RUTINAS VALUES ('" + textoNombreRutina.Text + "','" + textoDescripcion.Text + "'," + idplan + ")";
                cmd = new SqlCommand(sq, c.regresaConexion());
                cmd.ExecuteNonQuery();

                cargarDatosRutina();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            c.cerrarConexion();
            dataGridEjercicio.DataSource = null;
            textoDescripcion.Text = textoNombreRutina.Text = "";
        }

        private void comboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            textoDescripcion.Text = "";
            textoNombreRutina.Text = "";
            textoNombreEjercicio.Text = "";
            numericDuracion.Value = 0;
            cargarDatosRutina();
            dataGridEjercicio.DataSource = null;
        }

        //modificar rutina
        private void botonModificarRutina_Click(object sender, EventArgs e)
        {
            c = new conexion();
            try
            {
                string sq = "UPDATE RUTINAS.T_RUTINAS SET nombre_Rutina = '" + textoNombreRutina.Text + "', descripcion = '" + textoDescripcion.Text + "' WHERE id_Rutina = " + dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[0].Value.ToString();
                cmd = new SqlCommand(sq, c.regresaConexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            c.cerrarConexion();
            cargarDatosRutina();
        }

        //agrega los textos de la celdas a los textbox correspondientes
        private void actualizaRutinaBox()
        {
            textoNombreRutina.Text = dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[1].Value.ToString();
            textoDescripcion.Text = dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[2].Value.ToString();
            
        }

        //actualiza los textbox cuando da clic en la celda
        private void dataGridRutina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizaRutinaBox();
            cargarDatosEjercicio();
            textoNombreEjercicio.Text = "";
            numericDuracion.Value = 0;
        }

        //eliminar una rutina
        private void botonEliminarRutina_Click(object sender, EventArgs e)
        {
            c = new conexion();
            try
            {
                string sq = "DELETE FROM RUTINAS.T_RUTINAS WHERE id_Rutina = " + dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[0].Value.ToString();
                cmd = new SqlCommand(sq, c.regresaConexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            c.cerrarConexion();
            cargarDatosRutina();
        }

        //agregar ejercicio a una rutina
        private void botonAgregarEjercicio_Click(object sender, EventArgs e)
        {
            if (numericDuracion.Value == 0) //valida que la duración del ejercicio sea mayor a 0
            {
                MessageBox.Show("Duración invalida");
                
            }
            else
            {


                string idRutina = "";
                c = new conexion();
                try
                {
                    cmd = new SqlCommand("SELECT id_Rutina FROM RUTINAS.T_RUTINAS WHERE id_Rutina = '" + dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[0].Value.ToString() + "'", c.regresaConexion());
                    //cmd.ExecuteNonQuery();

                    dr = cmd.ExecuteReader();



                    if (dr.Read())
                    {
                        idRutina = (Convert.ToString(dr["id_Rutina"]));

                    }
                    else
                    {
                        c.cerrarConexion();
                        return;
                    }
                    c.cerrarConexion();

                    //////
                    c = new conexion();
                    string sq = "INSERT INTO RUTINAS.T_EJERCICIOS VALUES ('" + textoNombreEjercicio.Text + "'," + numericDuracion.Value + "," + idRutina + ")";
                    cmd = new SqlCommand(sq, c.regresaConexion());
                    cmd.ExecuteNonQuery();

                    cargarDatosEjercicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
                c.cerrarConexion();

                textoNombreEjercicio.Text = "";
                numericDuracion.Value = 0;
            }
        }

        //carga datos de ejericcios
        public void cargarDatosEjercicio()
        {
            string idRutina = "";
            c = new conexion();
            try
            {
                cmd = new SqlCommand("SELECT id_Rutina FROM RUTINAS.T_RUTINAS WHERE id_Rutina = '" + dataGridRutina.Rows[dataGridRutina.CurrentRow.Index].Cells[0].Value.ToString() + "'", c.regresaConexion());
                //cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();



                if (dr.Read())
                {
                    idRutina = (Convert.ToString(dr["id_Rutina"]));

                }
                else
                {
                    c.cerrarConexion();
                    return;
                }
                c.cerrarConexion();

                c = new conexion();

                da = new SqlDataAdapter("SELECT id_Ejercicio AS Ejercicio, nombre_Ejercicio AS Nombre, duracion AS Duración FROM RUTINAS.T_EJERCICIOS WHERE id_Rutina = " + idRutina, c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                dataGridEjercicio.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            c.cerrarConexion();

        }

        //modifica un ejericio
        private void botonModificarEjercicio_Click(object sender, EventArgs e)
        {
            c = new conexion();
            try
            {
                string sq = "UPDATE RUTINAS.T_EJERCICIOS SET nombre_Ejercicio = '" + textoNombreEjercicio.Text + "', duracion = " + numericDuracion.Value + " WHERE id_Ejercicio = " + dataGridEjercicio.Rows[dataGridEjercicio.CurrentRow.Index].Cells[0].Value.ToString(); ;
                cmd = new SqlCommand(sq, c.regresaConexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            c.cerrarConexion();
            cargarDatosEjercicio();

            textoNombreEjercicio.Text = "";
            numericDuracion.Value = 0;

        }

        private void actualizaEjercicioBox()
        {
            textoNombreEjercicio.Text = dataGridEjercicio.Rows[dataGridEjercicio.CurrentRow.Index].Cells[1].Value.ToString();
            numericDuracion.Value = int.Parse(dataGridEjercicio.Rows[dataGridEjercicio.CurrentRow.Index].Cells[2].Value.ToString());
        }

        //clic a una celda de ejericicio
        private void dataGridEjercicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizaEjercicioBox();
        }

        //elimina un ejercicio
        private void botonEliminarEjercicio_Click(object sender, EventArgs e)
        {
            c = new conexion();
            try
            {
                string sq = "DELETE FROM RUTINAS.T_EJERCICIOS WHERE id_Ejercicio = " + dataGridEjercicio.Rows[dataGridEjercicio.CurrentRow.Index].Cells[0].Value.ToString();
                cmd = new SqlCommand(sq, c.regresaConexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            c.cerrarConexion();
            cargarDatosEjercicio();
            textoNombreEjercicio.Text = "";
            numericDuracion.Value = 0;
        }
    }
}

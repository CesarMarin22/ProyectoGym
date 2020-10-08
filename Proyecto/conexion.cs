using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregadas
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto
{
     public class conexion
     {
          private SqlConnection cn; //conexion
          private SqlCommand cmd; //comando
          
          //para crear y conectar
          public conexion()
          {
               try
               {
                    cn = new SqlConnection("Data Source=.;Initial Catalog=proyectoFissicGym; Integrated Security=True");
                    //cn = new SqlConnection("Data Source=MARIE;Initial Catalog=proyectoFissicGym; Integrated Security=True");

                    cn.Open();

                    //quitar esto, solo es para ver si si entró
                    //MessageBox.Show("Abierto");

               }
               catch (Exception ex)
               {
                    MessageBox.Show("No se pudo abrir. Error: " + ex);
               }
          }

          //termina la coneccion
          public void cerrarConexion()
          {
               cn.Close();
          }

          public SqlConnection regresaConexion()
          {
               return cn;
          }
     }
}

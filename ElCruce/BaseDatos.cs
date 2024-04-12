using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCruce
{
    static class BaseDatos
    {
        /* static SqlConnection conn = new SqlConnection();

         static private bool Conectar()
         {
             try
             {
                 conn.ConnectionString = @"Data Source=DESKTOP-4TMTBKD;Initial Catalog=TransporteElCruce;Integrated Security=True";
                 conn.Open();
                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
         }

         static private void Desconectar()
         {
             conn.Close();
         }

         static public DataTable Buscar(string CadenaSQL)
         {
             DataTable dt = new DataTable();
             try
             {
                 Conectar();
                 SqlDataAdapter da = new SqlDataAdapter(CadenaSQL, conn);
                 da.Fill(dt);
             }
             catch (Exception)
             {
                 return null;
             }
             finally
             {
                 Desconectar();
             }
             return dt;
         }

         static public bool EjecutarConsulta(string CadenaSQL)
         {
             bool Correcto;
             try
             {
                 Conectar();
                 SqlDataAdapter da = new SqlDataAdapter(CadenaSQL, conn);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 Correcto = true;
             }
             catch
             {
                 Correcto = false;
             }
             finally
             {
                 Desconectar();
             }
             return Correcto;
         } */

        private static string connectionString = @"Data Source=DESKTOP-4TMTBKD;Initial Catalog=TransporteElCruce;Integrated Security=True";

        public static DataTable Buscar(string consultaSql, SqlParameter[] parametros = null)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                DataTable tabla = new DataTable();
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    // Puedes registrar o manejar la excepción según sea necesario
                    Console.WriteLine("Error al ejecutar consulta: " + ex.Message);
                    throw; // Propaga la excepción para que pueda ser manejada en un nivel superior
                }
                return tabla;
            }
        }

        public static bool EjecutarConsulta(string consultaSql, SqlParameter[] parametros = null)
        {
            bool exito = false;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        comando.ExecuteNonQuery();
                        exito = true;
                    }
                }
                catch (Exception ex)
                {
                    // Puedes registrar o manejar la excepción según sea necesario
                    Console.WriteLine("Error al ejecutar consulta: " + ex.Message);
                    throw; // Propaga la excepción para que pueda ser manejada en un nivel superior
                }
            }
            return exito;
        }
    }
}

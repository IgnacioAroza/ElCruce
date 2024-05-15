using System.Data;
using System.Data.SqlClient;

namespace ElCruce
{
    static class BaseDatos
    {
        private static string nombreDispositivo = Environment.MachineName;
        private static string connectionString = $"Data Source={nombreDispositivo};Initial Catalog=TransporteElCruce;Integrated Security=True";

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
                    Console.WriteLine("Error al ejecutar consulta: " + ex.Message);
                    throw;
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
                    Console.WriteLine("Error al ejecutar consulta: " + ex.Message);
                }
            }
            return exito;
        }
    }
}

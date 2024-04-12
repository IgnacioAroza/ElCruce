using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCruce.Entities
{
    internal class GasOil
    {
        #region Atributos
        private int id;
        private DateTime date;
        private decimal price;
        #endregion

        #region Propiedades
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        #endregion

        #region Constructor
        public GasOil() { }
        public GasOil(DateTime pDate, decimal pPrice)
        {
            date = pDate;
            price = pPrice;
        }
        #endregion

        #region Metodos
        public bool Nuevo()
        {
            try
            {
                string Consulta = "INSERT INTO Combustible (date, price) VALUES (@Fecha, @Precio)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Fecha", date),
                    new SqlParameter("@Precio", price)
                };
                return BaseDatos.EjecutarConsulta(Consulta, parametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al agregar valor del combustible: " + ex.Message);
                return false;
            }
        }
        public bool Modificar()
        {
            try
            {
                string Consulta = "UPDATE Combustible SET date = @Fecha, price = @Precio WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Fecha", date),
                    new SqlParameter("@Precio", price),
                    new SqlParameter("@Id", id)
                };
                return BaseDatos.EjecutarConsulta(Consulta, parametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al modificar valor del combustible: " + ex.Message);
                return false;
            }
        }
        static public bool Eliminar(int idSeleccionado)
        {
            try
            {
                string Consulta = "DELETE FROM Combustible WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", idSeleccionado)
                };
                return BaseDatos.EjecutarConsulta(Consulta, parametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al eliminar valor del combustible: " + ex.Message);
                return false;
            }
        }
        static public DataTable BuscarTodo()
        {
            try
            {
                return BaseDatos.Buscar("SELECT Combustible.id AS ID, Combustible.date AS Fecha, Combustible.price AS Precio FROM Combustible");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar todos los valores del combustible" + ex.Message);
                return null;
            }
        }
        static public DataTable BuscarXId(int idBuscado)
        {
            try
            {
                string Consulta = "SELECT Combustible.date AS Fecha, Combustible.price AS Precio FROM Combustible WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", idBuscado)
                };
                return BaseDatos.Buscar(Consulta, parametros);
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error al buscar por Id el valor", ex.Message);
                return null;
            }
        }
        public static DataTable BuscarXFecha(DateTime date) 
        {
            try
            {
                string Consulta = "SELECT Combustible.date AS Fecha, Combustible.price AS Precio FROM Combustible WHERE Combustible.date = @Fecha";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Fecha", date)
                };
                return BaseDatos.Buscar(Consulta, parametros);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar por fecha el valor del combustible" + ex.Message);
                return null;
            }
        }
        #endregion
    }
}

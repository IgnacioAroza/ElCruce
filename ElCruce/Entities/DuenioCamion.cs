using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ElCruce.Entities
{
    internal class DuenioCamion
    {
        #region Atributos
        private int id;
        private string name;
        private string lastname;
        private string CUIT;
        private string CBU;
        #endregion

        #region Propiedades
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        #endregion

        #region Constructor
        public DuenioCamion()
        {

        }
        public DuenioCamion(string pName, string pLastname, string pCUIT, string pCBU)
        {
            name = pName;
            lastname = pLastname;
            CUIT = pCUIT;
            CBU = pCBU;
        }
        #endregion

        #region Metodos
        public bool Nuevo()
        {
            try
            {
                string consulta = "INSERT INTO truckOwner (name, lastname, CUIT, CBU) VALUES (@Nombre, @Apellido, @CUIT, @CBU)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nombre", name),
                    new SqlParameter("@Apellido", lastname),
                    new SqlParameter("@CUIT", CUIT),
                    new SqlParameter("@CBU", CBU)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar dueño de camión: " + ex.Message);
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                string consulta = "UPDATE truckOwner SET name = @Nombre, lastname = @Apellido, CUIT = @CUIT, CBU = @CBU WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nombre", name),
                    new SqlParameter("@Apellido", lastname),
                    new SqlParameter("@CUIT", CUIT),
                    new SqlParameter("@CBU", CBU),
                    new SqlParameter("@Id", id)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar dueño de camión: " + ex.Message);
                return false;
            }
        }

        static public bool Eliminar(int idSeleccionado)
        {
            try
            {
                string consulta = "DELETE FROM truckOwner WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", idSeleccionado)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar dueño de camión: " + ex.Message);
                return false;
            }
        }

        static public DataTable BuscarTodo()
        {
            try
            {
                return BaseDatos.Buscar("SELECT truckOwner.id as ID, truckOwner.name AS Nombre, truckOwner.lastname AS Apellido, truckOwner.CUIT AS CUIT, truckOwner.CBU AS CBUAlias FROM truckOwner");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar dueños de camión: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXId(int id)
        {
            try
            {
                string consulta = "SELECT truckOwner.name AS Nombre, truckOwner.lastname AS Apellido, truckOwner.CUIT AS CUIT, truckOwner.CBU AS CBUAlias FROM truckOwner WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", id)
                };
                return BaseDatos.Buscar(consulta, parametros);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al buscar por ID el Dueño, {ex.Message}");
                return null;
            }
        }

        public static DataTable BuscarXNombre(string name)
        {
            try
            {
                string consulta = "SELECT truckOwner.id as ID, truckOwner.name AS Nombre, truckOwner.lastname AS Apellido, truckOwner.CUIT AS CUIT, truckOwner.CBU AS CBUAlias FROM truckOwner WHERE truckOwner.name LIKE '%" + name + "%'";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar dueños de camión por nombre: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXApellido(string lastname)
        {
            try
            {
                string consulta = "SELECT truckOwner.id as ID, truckOwner.name AS Nombre, truckOwner.lastname AS Apellido, truckOwner.CUIT AS CUIT, truckOwner.CBU AS CBUAlias FROM truckOwner WHERE truckOwner.lastname LIKE '%" + lastname + "%'";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar dueños de camión por apellido: " + ex.Message);
                return null;
            }
        }
        #endregion
    }
}

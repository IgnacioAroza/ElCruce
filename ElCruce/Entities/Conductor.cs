using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCruce.Entities
{
    internal class Conductor
    {
        #region Atributos
        private int id;
        private string name;
        private string lastname;
        private string CUIL;
        private string patent;
        private string chassis;
        private string coupled;
        private int truckOwnerId;
        #endregion

        #region Propiedades
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public int trcukOwnerId
        {
            set { id = value; }
            get { return truckOwnerId; }
        }
        #endregion

        #region Constructor
        public Conductor() { }
        public Conductor(string pName, string pLastname, string pCUIL, string pPatent, string pChassis, string pCoupled, int pTruckOwnerId)
        {
            name = pName;
            lastname = pLastname;
            CUIL = pCUIL;
            patent = pPatent;
            chassis = pChassis;
            coupled = pCoupled;
            truckOwnerId = pTruckOwnerId;
        }
        #endregion

        #region Metodos
        public bool Nuevo()
        {
            try
            {
                string consulta = "INSERT INTO Driver (name, lastname, CUIL, patent, chassis, coupled, truckOwnerId) VALUES (@Nombre, @Apellido, @CUIL, @Patente, @Chasis, @Acoplado, @TruckOwnerId)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nombre", name),
                    new SqlParameter("@Apellido", lastname),
                    new SqlParameter("@CUIL", CUIL),
                    new SqlParameter("@Patente", patent),
                    new SqlParameter("@Chasis", chassis),
                    new SqlParameter("@Acoplado", coupled),
                    new SqlParameter("@TruckOwnerId", truckOwnerId)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar conductor: " + ex.Message);
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                string consulta = "UPDATE Driver SET name = @Nombre, lastname = @Apellido, CUIL = @CUIL, patent = @Patente, chassis = @Chasis, coupled = @Acoplado, truckOwnerId = @TruckOwnerId WHERE id = @Id;";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nombre", name),
                    new SqlParameter("@Apellido", lastname),
                    new SqlParameter("@CUIL", CUIL),
                    new SqlParameter("@Patente", patent),
                    new SqlParameter("@Chasis", chassis),
                    new SqlParameter("@Acoplado", coupled),
                    new SqlParameter("@TruckOwnerId", truckOwnerId),
                    new SqlParameter("@Id", id)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar conductor: " + ex.Message);
                return false;
            }
        }

        static public bool Eliminar(int idSeleccionado)
        {
            try
            {
                string consulta = "DELETE FROM Driver WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", idSeleccionado)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar conductor: " + ex.Message);
                return false;
            }
        }

        static public DataTable BuscarTodo()
        {
            try
            {
                return BaseDatos.Buscar("SELECT Driver.id AS Id, Driver.name AS Nombre, Driver.lastname AS Apellido, Driver.CUIL AS CUIL,Driver.patent AS Patente, Driver.chassis AS Chasis, Driver.coupled AS Acoplado, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Driver INNER JOIN truckOwner ON Driver.truckOwnerId = truckOwner.id;");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar todos los conductores: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXId(int id) 
        {
            try
            {
                string consulta = "SELECT Driver.name AS Nombre, Driver.lastname AS Apellido, Driver.CUIL AS CUIL, Driver.patent AS Patente, Driver.chassis AS Chasis, Driver.coupled AS Acoplado, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Driver INNER JOIN truckOwner ON Driver.truckOwnerId = truckOwner.id WHERE Driver.id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", id)
                };
                return BaseDatos.Buscar(consulta, parametros);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al buscar por Id al conductor", ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXNombre(string nombreBuscado)
        {
            try
            {
                string consulta = "SELECT Driver.Id AS Id, Driver.name AS Nombre, Driver.lastname AS Apellido, Driver.CUIL AS CUIL, Driver.patent AS Patente, Driver.chassis AS Chasis, Driver.coupled AS Acoplado, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Driver INNER JOIN truckOwner ON Driver.truckOwnerId = truckOwner.id WHERE Driver.name LIKE '%" + nombreBuscado + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar conductores por nombre: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXApellido(string apellidoBuscado)
        {
            try
            {
                string consulta = "SELECT Driver.Id AS Id, Driver.name AS Nombre, Driver.lastname AS Apellido, Driver.CUIL AS CUIL, Driver.patent AS Patente, Driver.chassis AS Chasis, Driver.coupled AS Acoplado, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Driver INNER JOIN truckOwner ON Driver.truckOwnerId = truckOwner.id WHERE Driver.lastname LIKE '%" + apellidoBuscado + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar conductores por apellido: " + ex.Message);
                return null;
            }
        }

        static public DataTable BuscarXCUIL(string xCUIL)
        {
            try
            {
                string consulta = "SELECT Driver.Id AS Id, Driver.name AS Nombre, Driver.lastname AS Apellido, Driver.CUIL AS CUIL, Driver.patent AS Patente, Driver.chassis AS Chasis, Driver.coupled AS Acoplado, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Driver INNER JOIN truckOwner ON Driver.truckOwnerId = truckOwner.id WHERE Driver.CUIL LIKE '%" + xCUIL + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar conductores por CUIL: " + ex.Message);
                return null;
            }
        }
        static public int ObtenerOwnerId(int conductorId)
        {
            try
            {
                string consulta = "SELECT truckOwnerId FROM driver WHERE id = @ConductorId";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@ConductorId", conductorId)
                };
                object result = BaseDatos.EjecutarConsulta(consulta, parametros);
                if(result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el Id del dueño del camion", ex.Message);
                return -1;
            }
        }
        #endregion
    }
}

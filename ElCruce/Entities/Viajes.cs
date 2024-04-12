﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCruce.Entities
{
    internal class Viajes
    {
        #region Atributos
        private int id;
        private DateTime date;
        private string origin;
        private string destination;
        private decimal cashAdvance;
        private decimal fuelAdvance;
        private decimal liquidNumberProduct;
        private decimal importeLiquidacion;
        private decimal fee;
        private int driverId;
        private int truckOwnerId;
        #endregion

        #region Contructor
        public Viajes() { }
        public Viajes(DateTime pDate, string pOrigin, string pDestination, decimal pCashAdvance, decimal pFuelAdvance, decimal pLiquidNumberProduct, decimal pImporteLiquidacion, decimal pFee, int pDriverId, int pTruckOwnerId)
        {
            date = pDate;
            origin = pOrigin;
            destination = pDestination;
            cashAdvance = pCashAdvance;
            fuelAdvance = pFuelAdvance;
            liquidNumberProduct = pImporteLiquidacion;
            importeLiquidacion = pImporteLiquidacion;
            fee = pFee;
            driverId = pDriverId;
            truckOwnerId = pTruckOwnerId;
        }
        #endregion

        #region Metodos
        public bool Nuevo()
        {
            try
            {
                string consulta = "INSERT INTO Viajes (date, origin, destination, cashAdvance, fuelAdvance, liquidNumberProduct, importeLiquidacion, fee, driverId, truckOwnerId) VALUES (@Fecha, @Origen, @Destino, @AdelantoEfectivo, @AdelantoCombustible, @NumeroLiquidoProducto, @ImporteLiquidacion, @Tarifa, @IdChofer, @IdDuenio)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Fecha", date),
                    new SqlParameter("@Origen", origin),
                    new SqlParameter("@Destino", destination),
                    new SqlParameter("@AdelantoEfectivo", cashAdvance),
                    new SqlParameter("@AdelantoCombustible", fuelAdvance),
                    new SqlParameter("@NumeroLiquidoProducto", liquidNumberProduct),
                    new SqlParameter("@ImporteLiquidacion", importeLiquidacion),
                    new SqlParameter("@Tarifa", fee),
                    new SqlParameter("@IdChofer", driverId),
                    new SqlParameter("@IdDuenio", truckOwnerId)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar viaje: " + ex.Message);
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                string consulta = "UPDATE Viaje SET date = @Fecha, origin = @Origen, destination = @Destino, cashAdvance = @AdelantoEfectivo, fuelAdvance = @AdelantoCombustible, liquidNumberProduct = @NumeroLiquidoProducto, importeLiquidacion = @ImporteLiquidacion, fee = @Tarifa, driverId = @IdChofer, truckOwnerId = @IdDuenio WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Fecha", date),
                    new SqlParameter("@Origen", origin),
                    new SqlParameter("@Destino", destination),
                    new SqlParameter("@AdelantoEfectivo", cashAdvance),
                    new SqlParameter("@AdelantoCombustible", fuelAdvance),
                    new SqlParameter("@NumeroLiquidoProducto", liquidNumberProduct),
                    new SqlParameter("@ImporteLiquidacion", importeLiquidacion),
                    new SqlParameter("@Tarifa", fee),
                    new SqlParameter("@IdChofer", driverId),
                    new SqlParameter("@IdDuenio", truckOwnerId),
                    new SqlParameter("@Id", id)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar viaje: " + ex.Message);
                return false;
            }
        }

        static public bool Eliminar(int idSeleccionado)
        {
            try
            {
                string consulta = "DELETE FROM Viaje WHERE id = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Id", idSeleccionado)
                };
                return BaseDatos.EjecutarConsulta(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar viaje: " + ex.Message);
                return false;
            }
        }

        static public DataTable BuscarTodo()
        {
            try
            {
                return BaseDatos.Buscar("SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id;");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar todos los viaje: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXNombreChofer(string name)
        {
            try
            {
                string consulta = "SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id WHERE Driver.name LIKE '%" + name + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar viajes por nombre de chofer: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXApellidoChofer(string lastname)
        {
            try
            {
                string consulta = "SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id WHERE Driver.lastname LIKE '%" + lastname + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar viaje por apellido de chofer: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXNombreDuenio(string name)
        {
            try
            {
                string consulta = "SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id WHERE truckOwner.name LIKE '%" + name + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar viajes por nombre de dueño: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXApellidoDuenio(string lastname)
        {
            try
            {
                string consulta = "SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id WHERE truckOwner.lastname LIKE '%" + lastname + "%';";
                return BaseDatos.Buscar(consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar viajes por apellido de dueño: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXFecha(DateTime fecha)
        {
            try
            {
                string consulta = "SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id WHERE Viaje.date = @Fecha;";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Fecha", fecha)
                };
                return BaseDatos.Buscar(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar viajes por fecha: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarXLiquidoProducto(decimal number)
        {
            try
            {
                string consulta = "SELECT Viaje.date AS Fecha, Viaje.origin AS Viaje, Viaje.destination AS Destino, Viaje.cashAdvance AS AdelantoEfectivo, Viaje.fuelAdvance AS AdelantoCombustible, Viaje.liquidNumberProduct AS NumeroLiquidoProducto, Viaje.importeLiquidacion AS ImporteLiquidacion, Viaje.fee AS Tarifa, Driver.name AS NombreChofer, Driver.lastname AS ApellidoChofer, truckOwner.name AS NombreDueño, truckOwner.lastname AS ApellidoDueño FROM Viaje INNER JOIN Driver ON Viaje.driverId = Driver.id INNER JOIN truckOwner ON Viaje.truckOwnerId = truckOwner.id WHERE Viaje.liquidNumberProduct = @NumeroLiquidoProducto;";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumeroLiquidoProducto", number)
                };
                return BaseDatos.Buscar(consulta, parametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar viajes por número de líquido producto: " + ex.Message);
                return null;
            }
        }
        #endregion
    }
}
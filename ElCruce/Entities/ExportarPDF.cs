using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ElCruce.Entities
{
    internal class ExportarPDF
    {
        public static void ExportarViaje(DataRow filaViaje)
        {
            // Obtener nombre y apellido del dueño
            string nombreDueño = filaViaje["NombreDueño"].ToString();
            string apellidoDueño = filaViaje["ApellidoDueño"].ToString();
            string nombreApellidoDueño = $"{nombreDueño}, {apellidoDueño}";

            // Obtener la fecha del viaje
            DateTime fecha = Convert.ToDateTime(filaViaje["Fecha"]);
            string fechaFormateada = fecha.ToString("yyyy-MM-dd");

            // Nombre del archivo y ruta de la carpeta
            string nombreBase = "Viaje-";
            string nombreArchivo = $"{nombreBase}{fechaFormateada}-{nombreApellidoDueño}.pdf";

            string rutaCarpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaCompleta = Path.Combine(rutaCarpetaDocumentos, "ArchivosPDF");
            string rutaArchivo = Path.Combine(rutaCompleta, nombreArchivo);

            // Crear directorio si no existe
            Directory.CreateDirectory(rutaCompleta);

            // Crear documento PDF
            Document doc = new Document();
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.SetMargins (50f, 50f, 50f, 50f);
                doc.Open();

                // Agregar logo
                string nombreImagen = "TransporteElCruce.jpeg";
                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", nombreImagen);
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaImagen);
                logo.ScaleAbsolute(70f, 70f);
                logo.SetAbsolutePosition(doc.Left, doc.Top - 50f);
                doc.Add(logo);

                // Agregar título
                Paragraph titulo = new Paragraph("Reporte de Viaje", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18f, iTextSharp.text.Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20f;
                doc.Add(titulo);

                // Obtener datos del chofer
                string nombreChofer = filaViaje["NombreChofer"].ToString();
                string apellidoChofer = filaViaje["ApellidoChofer"].ToString();
                string nombreApellidoChofer = $"{nombreChofer}, {apellidoChofer}";
                string cuilChofer = filaViaje["CUILChofer"].ToString();
                string patente = filaViaje["Patente"].ToString();
                string chasis = filaViaje["Chasis"].ToString();
                string acoplado = filaViaje["Acoplado"].ToString();

                // Obtener CUIT y CBU del dueño
                string cuitDueño = filaViaje["CUITDueño"].ToString();
                string cbuDueño = filaViaje["CBUAliasDueño"].ToString();

                // Datos liquido producto
                int nroLiquid = Convert.ToInt32(filaViaje["NumeroLiquidoProducto"]);

                // Calcular descuentos e importe total
                decimal descuentos = Convert.ToDecimal(filaViaje["AdelantoEfectivo"]) + Convert.ToDecimal(filaViaje["AdelantoCombustible"]);
                decimal importeInicial = Convert.ToDecimal(filaViaje["ImporteLiquidacion"]);
                decimal importeTotal = importeInicial - descuentos;

                // Crear el texto con los datos del dueño
                string datos =      $"Fecha del viaje: {fechaFormateada}\n" +
                                    $"Dueño: {nombreApellidoDueño}\n" +
                                    $"CUIT del Dueño: {cuitDueño}\n" +
                                    $"CBU del Dueño: {cbuDueño}\n\n" +
                                    $"Chofer: {nombreApellidoChofer}\n" +
                                    $"CUIL Chofer: {cuilChofer}\n" +
                                    $"Patente: {patente}\n" +
                                    $"Chasis: {chasis}\n" +
                                    $"Acoplado: {acoplado}\n\n" +
                                    $"N° Liquido Producto: {nroLiquid}\n" +
                                    $"Importe Liquidación: ${importeInicial}\n" +
                                    $"Descuentos: ${descuentos}\n" +
                                    $"Importe Total: ${importeTotal}\n" +
                                    $"Tipo de pago: ";

                Paragraph datosParrafo = new Paragraph(datos);
                datosParrafo.IndentationLeft = 50f;
                datosParrafo.SpacingBefore = 20f;
                doc.Add(datosParrafo);

                doc.Add(new Paragraph("\n\n\n\n"));

                string datosReplica = $"Fecha del viaje: {fechaFormateada}\n" +
                                    $"Dueño: {nombreApellidoDueño}\n" +
                                    $"CUIT del Dueño: {cuitDueño}\n" +
                                    $"CBU del Dueño: {cbuDueño}\n\n" +
                                    $"Chofer: {nombreApellidoChofer}\n" +
                                    $"CUIL Chofer: {cuilChofer}\n" +
                                    $"Patente: {patente}\n" +
                                    $"Chasis: {chasis}\n" +
                                    $"Acoplado: {acoplado}\n\n" +
                                    $"N° Liquido Producto: {nroLiquid}\n" +
                                    $"Importe Liquidación: ${importeInicial}\n" +
                                    $"Descuentos: ${descuentos}\n" +
                                    $"Importe Total: ${importeTotal}\n" +
                                    $"Tipo de pago: ";

                Paragraph datosReplicados = new Paragraph(datosReplica);
                datosReplicados.IndentationLeft = 50f;
                doc.Add(datosReplicados);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al exportar PDF: " + ex.Message);
                throw ex;
            }
            finally 
            { 
                doc.Close();
            }
        }
    }
}

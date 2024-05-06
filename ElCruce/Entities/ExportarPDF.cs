using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCruce.Entities
{
    internal class ExportarPDF
    {
        private static int contador = 1;
        public static void ExportarViaje(DataRow filaViaje)
        {
            // Nombre del archivo y ruta de la carpeta
            string nombreBase = "ViajeExportado";
            string nombreArchivo = $"{nombreBase}{contador}.pdf";
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
                doc.Open();

                // Agregar título
                Paragraph titulo = new Paragraph("Reporte de Viaje", new Font(Font.FontFamily.HELVETICA, 18f, Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                // Crear una tabla con una fila y siete columnas
                PdfPTable tabla = new PdfPTable(7);
                tabla.AddCell(new PdfPCell(new Phrase("Dueño")));
                tabla.AddCell(new PdfPCell(new Phrase("N° Liquido Producto")));
                tabla.AddCell(new PdfPCell(new Phrase("Adelanto Efectivo")));
                tabla.AddCell(new PdfPCell(new Phrase("Adelanto Combustible")));
                tabla.AddCell(new PdfPCell(new Phrase("Importe Inicial")));
                tabla.AddCell(new PdfPCell(new Phrase("Descuentos")));
                tabla.AddCell(new PdfPCell(new Phrase("Importe Total")));

                // Agregar datos de la fila seleccionada a la tabla
                tabla.AddCell(new PdfPCell(new Phrase(filaViaje["NombreDueño"].ToString() + ", " + filaViaje["ApellidoDueño"].ToString())));
                tabla.AddCell(new PdfPCell(new Phrase(filaViaje["NumeroLiquidoProducto"].ToString())));
                tabla.AddCell(new PdfPCell(new Phrase(filaViaje["AdelantoEfectivo"].ToString())));
                tabla.AddCell(new PdfPCell(new Phrase(filaViaje["AdelantoCombustible"].ToString())));
                tabla.AddCell(new PdfPCell(new Phrase(filaViaje["ImporteLiquidacion"].ToString())));

                // Calcular descuentos e importe total
                decimal importeInicial = Convert.ToDecimal(filaViaje["ImporteLiquidacion"]);
                decimal descuentos = Convert.ToDecimal(filaViaje["ImporteLiquidacion"]) + Convert.ToDecimal(filaViaje["AdelantoCombustible"]);
                decimal importeTotal = importeInicial - descuentos;

                tabla.AddCell(new PdfPCell(new Phrase(descuentos.ToString())));
                tabla.AddCell(new PdfPCell(new Phrase(importeTotal.ToString())));

                //Agregar tabla al documento
                doc.Add(tabla);
                contador++;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al exportar PDF: " + ex.Message);
                throw ex;
            }
            finally { doc.Close(); }
        }
    }
}

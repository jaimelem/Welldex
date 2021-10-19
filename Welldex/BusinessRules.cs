using System;
using System.Linq;
using System.Collections.Generic;

using Welldex.Models;
using Welldex.Data;

namespace Welldex
{
    public class BusinessRules { 
        private DbFake data = new DbFake();
        public void CrearImportacion(Importacion importacion)
        {
            data.DatosImportacion.Add(importacion);
            Console.WriteLine("Registro exitoso");
        }

        public void CrearExportacion(Exportacion exportacion)
        {
            data.DatosExportacion.Add(exportacion);
            Console.WriteLine("Registro exitoso");
        }

        public void CambiarFechaYStatus(int indiceOperacion, DateTime fecha, string status, string tipoOperacion)
        {
            if (tipoOperacion.Equals("Exportacion"))
            {
                data.DatosExportacion[indiceOperacion].FechaZarpe = fecha;
                data.DatosExportacion[indiceOperacion].Operacion.Status = status;

                Console.WriteLine("Fecha y status actualizados");
            }
            else
            {
                data.DatosImportacion[indiceOperacion].FechaArribo = fecha;
                data.DatosImportacion[indiceOperacion].Operacion.Status = status;

                Console.WriteLine("Fecha y status actualizados");
            }
        }
    }
}

using System.Collections.Generic;

using Welldex.Models;

namespace Welldex.Data
{
    public class DbFake
    {
        public List<Exportacion> DatosExportacion { get; set; }
        public List<Importacion> DatosImportacion { get; set; }

        public DbFake()
        {
            DatosExportacion = new List<Exportacion>();
            DatosImportacion = new List<Importacion>();
        }
    }
}

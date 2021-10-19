using System;
using System.Collections.Generic;
using System.Text;

namespace Welldex.Models
{
    public class Importacion
    {
        public int Indice { get; set; }
        public DateTime? FechaArribo { get; set; }
        public string PaisOrigen { get; set; }
        public OperacionAduanera Operacion { get; set; }
    }
}

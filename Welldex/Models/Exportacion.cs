using System;
using System.Collections.Generic;
using System.Text;

namespace Welldex.Models
{
    public class Exportacion
    {
        public int Indice { get; set; }
        public DateTime? FechaZarpe { get; set; }
        public string PaisDestino { get; set; }
        public OperacionAduanera Operacion { get; set; }
    }
}
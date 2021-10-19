using System;
using System.Collections.Generic;
using System.Text;

namespace Welldex.Models
{
    public class OperacionAduanera
    {
        public string Referencia { get; set; }
        public string Pedimiento { get; set; }
        public string Cliente { get; set; }
        public string Aduana { get; set; }
        public string Patente { get; set; }
        public Contenedor MercanciaContenizada { get; set; }
        public CargaSuelta MercanciaCargaSuelta { get; set; }
        public string TipoOperacion { get; set; }
        public string Status { get; set; }  
    }
}

using System;
using Welldex.Models;

namespace Welldex
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessRules = new BusinessRules();
            var contenedores = 1;

            Console.WriteLine("Tipo de operación: Exportación/Importación");
            string tipoOperacion = Console.ReadLine();

            if (tipoOperacion.Equals("Exportación"))
            {
                for (int i=1;i<=contenedores;i++)
                {
                    CargaSuelta MercanciaCargaSuelta = null;
                    Contenedor MercanciaContenizada = null;


                    Console.WriteLine("País destino:");
                    string paisDestino = Console.ReadLine();

                    Console.WriteLine("Referencia:");
                    string Referencia = Console.ReadLine();

                    Console.WriteLine("Pedimiento:");
                    string Pedimiento = Console.ReadLine();

                    Console.WriteLine("Cliente:");
                    string Cliente = Console.ReadLine();

                    Console.WriteLine("Aduana:");
                    string Aduana = Console.ReadLine();

                    Console.WriteLine("Patente:");
                    string Patente = Console.ReadLine();

                    Console.WriteLine("Tipo de mercancia: Carga suelta/Carga contenerizada");
                    string TipoCarga = Console.ReadLine();

                    if (TipoCarga.Equals("Carga contenerizada"))
                    {
                        Console.WriteLine("Numero de Contenedor:");
                        string NumContenedor = Console.ReadLine();

                        Console.WriteLine("Tipo de Contenedor:");
                        string TipoContenedor = Console.ReadLine();

                        Console.WriteLine("Dimensiones:");
                        string Dimensiones = Console.ReadLine();

                        Console.WriteLine("Fecha Descarga:");
                        string FechaDescargo = Console.ReadLine();

                        MercanciaContenizada = new Contenedor
                        {
                            NumeroContenedor = NumContenedor,
                            Tipo = TipoContenedor,
                            Dimensiones = Dimensiones,
                            FechaDescargo = DateTime.Parse(FechaDescargo)
                        };
                    }
                    else
                    {
                        Console.WriteLine("Descripción:");
                        string Descripcion = Console.ReadLine();

                        Console.WriteLine("Cantidad:");
                        string Cantidad = Console.ReadLine();

                        MercanciaCargaSuelta = new CargaSuelta
                        {
                            Descripcion = Descripcion,
                            Cantidad = int.Parse(Cantidad),
                        };
                    }

                    businessRules.CrearExportacion(new Exportacion
                    {
                        Indice = i,
                        FechaZarpe = null,
                        PaisDestino = paisDestino,
                        Operacion = new OperacionAduanera
                        {
                            Referencia = Referencia,
                            Pedimiento = Pedimiento,
                            Cliente = Cliente,
                            Aduana = Aduana,
                            Patente = Patente,
                            MercanciaCargaSuelta = MercanciaCargaSuelta,
                            MercanciaContenizada = MercanciaContenizada,
                            TipoOperacion = "Exportacion",
                            Status = i == contenedores ? "Descargo" : "ETD"
                        }
                    });
                }
            }
            else
            {
                for (int i = 1; i <= contenedores; i++)
                {
                    CargaSuelta MercanciaCargaSuelta = null;
                    Contenedor MercanciaContenizada = null;


                    Console.WriteLine("País origen:");
                    string PaisOrigen = Console.ReadLine();

                    Console.WriteLine("Referencia:");
                    string Referencia = Console.ReadLine();

                    Console.WriteLine("Pedimiento:");
                    string Pedimiento = Console.ReadLine();

                    Console.WriteLine("Cliente:");
                    string Cliente = Console.ReadLine();

                    Console.WriteLine("Aduana:");
                    string Aduana = Console.ReadLine();

                    Console.WriteLine("Patente:");
                    string Patente = Console.ReadLine();

                    Console.WriteLine("Tipo de mercancia: Carga suelta/Carga contenerizada");
                    string TipoCarga = Console.ReadLine();

                    if (TipoCarga.Equals("Carga contenerizada"))
                    {
                        Console.WriteLine("Numero de Contenedor:");
                        string NumContenedor = Console.ReadLine();

                        Console.WriteLine("Tipo de Contenedor:");
                        string TipoContenedor = Console.ReadLine();

                        Console.WriteLine("Dimensiones:");
                        string Dimensiones = Console.ReadLine();

                        Console.WriteLine("Fecha Descarga:");
                        string FechaDescargo = Console.ReadLine();

                        MercanciaContenizada = new Contenedor
                        {
                            NumeroContenedor = NumContenedor,
                            Tipo = TipoContenedor,
                            Dimensiones = Dimensiones,
                            FechaDescargo = DateTime.Parse(FechaDescargo)
                        };
                    }
                    else
                    {
                        Console.WriteLine("Descripción:");
                        string Descripcion = Console.ReadLine();

                        Console.WriteLine("Cantidad:");
                        string Cantidad = Console.ReadLine();

                        MercanciaCargaSuelta = new CargaSuelta
                        {
                            Descripcion = Descripcion,
                            Cantidad = int.Parse(Cantidad),
                        };
                    }

                    businessRules.CrearImportacion(new Importacion
                    {
                        Indice = i,
                        FechaArribo = null,
                        PaisOrigen = PaisOrigen,
                        Operacion = new OperacionAduanera
                        {
                            Referencia = Referencia,
                            Pedimiento = Pedimiento,
                            Cliente = Cliente,
                            Aduana = Aduana,
                            Patente = Patente,
                            MercanciaCargaSuelta = MercanciaCargaSuelta,
                            MercanciaContenizada = MercanciaContenizada,
                            TipoOperacion = "Importacion",
                            Status = i == contenedores ? "Descargo" : "ETA en Espera"
                        }
                    });
                }
            }

            Console.WriteLine("¿Desea actualizar la fecha y el estatus de alguna operación?: si/no");
            string opcion = Console.ReadLine();

            if (opcion.Equals("si"))
            {
                Console.WriteLine("Indice Operación:");
                string indice = Console.ReadLine();

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine();

                Console.WriteLine("Status:");
                string status = Console.ReadLine();

                Console.WriteLine("Tipo operación: Exportacion/Importacion");
                string operacion = Console.ReadLine();

                businessRules.CambiarFechaYStatus(int.Parse(indice), DateTime.Parse(fecha), status, operacion);
            }
        }
    }
}

using EjercicioViviendas.Clases;
using EjercicioViviendas.Entidades;

namespace EjercicioViviendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------Pregunta 1------------------------------");
            Console.WriteLine("------------Sacar por pantalla un listado de los municipios------------------------------");
            Console.WriteLine();
            List<Municipio> listaPoblaciones = Municipio.GetPoblaciones();
            foreach (Municipio municipio in listaPoblaciones)
            {
                Console.WriteLine(municipio.Nombre)
;            }
            Console.WriteLine();

            Console.WriteLine("----------------------------Pregunta 2------------------------------");
            Console.WriteLine("----------Sacar un listado de pisos y el municipio al que pertenecen------------------------------");
            Console.WriteLine();

            MetodoPisos nuevoMetodoPisos = new MetodoPisos();

            List<PisoExtendido> listaPisos = nuevoMetodoPisos.GetPisosJoin(1,
                                                                           10);

            foreach (PisoExtendido piso in listaPisos)
            {
                Console.WriteLine($"EL {piso.NombrePiso} con {piso.Tamaño} m2, en un planta {piso.NumeroPlanta}, que tiene {piso.NumeroHabitaciones} habitaciones, {piso.NumeroBaños} baños y ubicado en la provincia de {piso.NombrePoblacion}");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------Pregunta 3------------------------------");
            Console.WriteLine("------------Sacar un listado de Adosados y el municipio al que pertenecen------------------------------");
            Console.WriteLine();
            MetodoAdosados nuevoMetodoAdosados = new MetodoAdosados();

            List<AdosadoExtendido> listaAdosados = nuevoMetodoAdosados.GetAdosadosJoin(1,
                                                                           10);

            foreach (AdosadoExtendido adosado in listaAdosados)
            {
                Console.WriteLine($"EL {adosado.NombreAdosado} con {adosado.Tamaño} m2, que tiene {adosado.NumeroHabitaciones} habitaciones, {adosado.NumeroBaños} baños, {(adosado.Piscina ? "con" : "sin")} piscina y ubicado en la provincia de {adosado.NombrePoblacion}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 4------------------------------");
            Console.WriteLine("-----------Sacar un listado de pisos filtrando por nombre de Municipio -> Cadiz------------------------------");
            Console.WriteLine();

            MetodoPisos nuevoMetodoPisosCadiz = new MetodoPisos();

            List<PisoExtendido> listaPisosCadiz = nuevoMetodoPisosCadiz.GetPisosJoin(1,
                                                                           10,
                                                                           "Cádiz");

            foreach (PisoExtendido piso in listaPisosCadiz)
            {
                Console.WriteLine($"EL {piso.NombrePiso} con {piso.Tamaño} m2, en un planta {piso.NumeroPlanta}, que tiene {piso.NumeroHabitaciones} habitaciones, {piso.NumeroBaños} baños y ubicado en la provincia de {piso.NombrePoblacion}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 5------------------------------");
            Console.WriteLine("-----------Sacar un listado de adosados filtrando por nombre de Municipio -> Cadiz------------------------------");
            Console.WriteLine();

            MetodoAdosados nuevoMetodoAdosadosCadiz = new MetodoAdosados();

            List<AdosadoExtendido> listaAdosadosCadiz = nuevoMetodoAdosadosCadiz.GetAdosadosJoin(1,
                                                                           10,
                                                                           "Cádiz");

            foreach (AdosadoExtendido adosado in listaAdosadosCadiz)
            {
                Console.WriteLine($"EL {adosado.NombreAdosado} con {adosado.Tamaño} m2,  que tiene {adosado.NumeroHabitaciones} habitaciones, {adosado.NumeroBaños} baños, {(adosado.Piscina ? "con" : "sin")} piscinay ubicado en la provincia de {adosado.NombrePoblacion}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 6------------------------------");
            Console.WriteLine("-----------Sacar un listado de pisos que tengan 3 o mas habitaciones------------------------------");
            Console.WriteLine();

            var queryHabitaciones =
                from Phab in listaPisos
                where Phab.NumeroHabitaciones > 3
                select new PisoExtendido
                {
                    NombrePiso = Phab.NombrePiso,
                    Tamaño = Phab.Tamaño,
                    NumeroHabitaciones = Phab.NumeroHabitaciones,
                    NumeroBaños = Phab.NumeroBaños,
                    NumeroPlanta = Phab.NumeroPlanta,
                    NombrePoblacion = Phab.NombrePoblacion,

                };
            List<PisoExtendido> listaPisos3hab = queryHabitaciones.ToList();

            foreach (PisoExtendido Phab in listaPisos3hab)
            {
                Console.WriteLine($"EL {Phab.NombrePiso} con {Phab.Tamaño} m2, en un planta {Phab.NumeroPlanta}, que tiene {Phab.NumeroHabitaciones} habitaciones, {Phab.NumeroBaños} baños y ubicado en la provincia de {Phab.NombrePoblacion}");

            }

            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 7------------------------------");
            Console.WriteLine("-----------Sacar un listado de adosados que tengan 4 o mas habitaciones------------------------------");
            Console.WriteLine();

            var queryAdosadosHabitaciones =
                from Ahab in listaAdosados
                where Ahab.NumeroHabitaciones > 4
                select new AdosadoExtendido
                {
                    NombreAdosado = Ahab.NombreAdosado,
                    Tamaño = Ahab.Tamaño,
                    NumeroHabitaciones = Ahab.NumeroHabitaciones,
                    NumeroBaños = Ahab.NumeroBaños,
                    Piscina = Ahab.Piscina,
                    NombrePoblacion = Ahab.NombrePoblacion,

                };
            List<AdosadoExtendido> listaAdosados4hab = queryAdosadosHabitaciones.ToList();

            foreach (AdosadoExtendido Ahab in listaAdosados4hab)
            {
                Console.WriteLine($"EL {Ahab.NombreAdosado} con {Ahab.Tamaño} m2, que tiene {Ahab.NumeroHabitaciones} habitaciones, {Ahab.NumeroBaños} baños, {(Ahab.Piscina ? "con" : "sin")} piscina y ubicado en la provincia de {Ahab.NombrePoblacion}");

            }

            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 8------------------------------");
            Console.WriteLine("------------Sacar un listado de Adosados que tengan piscina------------------------------");
            Console.WriteLine();

            var queryAdosadosPiscina =
                from APiscina in listaAdosados
                where APiscina.Piscina == true
                select new AdosadoExtendido
                {
                    NombreAdosado = APiscina.NombreAdosado,
                    Tamaño = APiscina.Tamaño,
                    NumeroHabitaciones = APiscina.NumeroHabitaciones,
                    NumeroBaños = APiscina.NumeroBaños,
                    Piscina = APiscina.Piscina,
                    NombrePoblacion = APiscina.NombrePoblacion,

                };
            List<AdosadoExtendido> listaAdosadosPiscina = queryAdosadosPiscina.ToList();

            foreach (AdosadoExtendido APiscina in listaAdosadosPiscina)
            {
                Console.WriteLine($"EL {APiscina.NombreAdosado} con {APiscina.Tamaño} m2, que tiene {APiscina.NumeroHabitaciones} habitaciones, {APiscina.NumeroBaños} baños, {(APiscina.Piscina ? "con" : "sin")} piscina y ubicado en la provincia de {APiscina.NombrePoblacion}");

            }

            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 9------------------------------");
            Console.WriteLine("------------Sacar un listado de pisos que tengan 105 o mas metros cuadrados------------------------------");
            Console.WriteLine();

            var queryPisosm2=
                from Pm2 in listaPisos
                where Pm2.Tamaño >= 105
                select new PisoExtendido
                {
                    NombrePiso = Pm2.NombrePiso,
                    Tamaño = Pm2.Tamaño,
                    NumeroHabitaciones = Pm2.NumeroHabitaciones,
                    NumeroBaños = Pm2.NumeroBaños,
                    NumeroPlanta = Pm2.NumeroPlanta,
                    NombrePoblacion = Pm2.NombrePoblacion,

                };
            List<PisoExtendido> listaPisos105 = queryPisosm2.ToList();

            foreach (PisoExtendido Pm2 in listaPisos105)
            {
                Console.WriteLine($"EL {Pm2.NombrePiso} con {Pm2.Tamaño} m2, en un planta {Pm2.NumeroPlanta}, que tiene {Pm2.NumeroHabitaciones} habitaciones,{Pm2.NumeroBaños} baños  y ubicado en la provincia de {Pm2.NombrePoblacion}");

            }
            Console.WriteLine();
            Console.WriteLine("----------------------------Pregunta 10------------------------------");
            Console.WriteLine("------------Sacar un listado de Adosados que tengan 170 o mas metros cuadrados------------------------------");
            Console.WriteLine();

            var queryAdosadosm2 =
                from Am2 in listaAdosados
                where Am2.Tamaño >= 170
                select new AdosadoExtendido
                {
                    NombreAdosado = Am2.NombreAdosado,
                    Tamaño = Am2.Tamaño,
                    NumeroHabitaciones = Am2.NumeroHabitaciones,
                    NumeroBaños = Am2.NumeroBaños,
                    Piscina = Am2.Piscina,
                    NombrePoblacion = Am2.NombrePoblacion,

                };
            List<AdosadoExtendido> listaAdosados170 = queryAdosadosm2.ToList();

            foreach (AdosadoExtendido Am2 in listaAdosados170)
            {
                Console.WriteLine($"EL {Am2.NombreAdosado} con {Am2.Tamaño} m2, que tiene {Am2.NumeroHabitaciones} habitaciones, {Am2.NumeroBaños} baños, {(Am2.Piscina ? "con" : "sin")} piscina y ubicado en la provincia de {Am2.NombrePoblacion}");

            }
        }
    }
}

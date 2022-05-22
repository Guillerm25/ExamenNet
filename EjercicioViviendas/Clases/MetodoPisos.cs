using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioViviendas.Entidades;
using EjercicioViviendas.Interfaces;

namespace EjercicioViviendas.Clases
{
    public class MetodoPisos : IMetodoPisos
    {

        public List<PisoExtendido> GetPisosJoin(int pagina,
                                                int numeroRegistros,
                                                string? filtroPoblacion = null)


        {
            List<Piso> listaPisos = Piso.GetPisos();
            List<Municipio> listaPoblaciones = Municipio.GetPoblaciones();

            //Query
            var query =
                from pis in listaPisos
                join pob in listaPoblaciones on pis.MunicipioId equals pob.Id


                where (filtroPoblacion == null || pob.Nombre == filtroPoblacion)

                select new PisoExtendido
                {
                    NombrePiso = pis.Nombre,
                    Tamaño = pis.Tamaño,
                    NumeroBaños = pis.NumeroBaños,
                    NumeroHabitaciones = pis.NumeroHabitaciones,
                    NumeroPlanta = pis.NumeroPlanta,
                    NombrePoblacion = pob.Nombre
                };
            int skip = (pagina - 1) * numeroRegistros;

            List<PisoExtendido> pisos = query.Skip(skip).Take(numeroRegistros).ToList();

            return pisos;
        }
    }
}

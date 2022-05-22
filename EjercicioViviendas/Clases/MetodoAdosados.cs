using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioViviendas.Entidades;
using EjercicioViviendas.Interfaces;

namespace EjercicioViviendas.Clases
{
    public class MetodoAdosados : IMetodoAdosados
    {

        public List<AdosadoExtendido> GetAdosadosJoin(int pagina,
                                                int numeroRegistros,
                                                string? filtroPoblacion = null)


        {
            List<Adosado> listaAdosados = Adosado.GetAdosados();
            List<Municipio> listaPoblaciones = Municipio.GetPoblaciones();

            //Query
            var query =
                from ado in listaAdosados
                join pob in listaPoblaciones on ado.MunicipioId equals pob.Id


                where (filtroPoblacion == null || pob.Nombre == filtroPoblacion)

                select new AdosadoExtendido
                {
                    NombreAdosado = ado.Nombre,
                    Tamaño = ado.Tamaño,
                    NumeroBaños = ado.NumeroBaños,
                    NumeroHabitaciones = ado.NumeroHabitaciones,
                    Piscina = ado.Piscina,
                    NombrePoblacion = pob.Nombre
                };
            int skip = (pagina - 1) * numeroRegistros;

            List<AdosadoExtendido> adosados = query.Skip(skip).Take(numeroRegistros).ToList();

            return adosados;
        }
    }
}

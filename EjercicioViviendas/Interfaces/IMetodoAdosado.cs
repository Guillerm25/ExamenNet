using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioViviendas.Entidades;


namespace EjercicioViviendas.Interfaces
{
    public interface IMetodoAdosados
    {
        List<AdosadoExtendido> GetAdosadosJoin(int pagina,
                                         int numeroRegistros,
                                         string? filtroPoblacion = null);


    }
}


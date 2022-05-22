using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioViviendas.Entidades
{
    public class Vivienda
    {
        public int id { get; set; }

        public string Nombre { get; set; }
        public int Tamaño { get; set; }
        public int NumeroHabitaciones { get; set; }
        public int NumeroBaños { get; set; }

        public int MunicipioId { get; set; }
    }
}

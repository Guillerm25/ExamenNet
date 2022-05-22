using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioViviendas.Entidades
{
    public class Piso : Vivienda
    {
        public int NumeroPlanta { get; set; }

        public static List<Piso> GetPisos()
        {
            return new List<Piso>
            {
                new Piso
                {

                    Nombre = "Piso1",
                    Tamaño = 90,
                    NumeroHabitaciones = 2,
                    NumeroBaños = 2,
                    NumeroPlanta = 2,
                    MunicipioId = 1
                },
                new Piso
                {
                    Nombre = "Piso2",
                    Tamaño = 105,
                    NumeroHabitaciones = 4,
                    NumeroBaños = 2,
                    NumeroPlanta = 1,
                    MunicipioId = 2
                },
                new Piso
                {
                    Nombre = "Piso3",
                    Tamaño = 85,
                    NumeroHabitaciones = 3,
                    NumeroBaños = 2,
                    NumeroPlanta = 3,
                    MunicipioId = 3
                },
                new Piso
                {
                    Nombre = "Piso4",
                    Tamaño = 150,
                    NumeroHabitaciones = 5,
                    NumeroBaños = 2,
                    NumeroPlanta = 4,
                    MunicipioId = 4
                }
            };
        }    } 
}

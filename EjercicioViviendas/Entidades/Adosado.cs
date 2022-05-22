using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioViviendas.Entidades
{
    public class Adosado : Vivienda
    {
        public bool Piscina { get; set; }
    
    public static List<Adosado> GetAdosados()
    {
            return new List<Adosado>
            {
                new Adosado
                {
                    Nombre = "Adosado1",
                    Tamaño = 160,
                    NumeroHabitaciones = 3,
                    NumeroBaños = 3,
                    Piscina = true,
                    MunicipioId = 1
                },
                new Adosado
                {
                    Nombre = "Adosado2",
                    Tamaño = 170,
                    NumeroHabitaciones = 4,
                    NumeroBaños = 2,
                    Piscina = false,
                    MunicipioId = 2
                },new Adosado
                {
                    Nombre = "Adosado3",
                    Tamaño = 180,
                    NumeroHabitaciones = 5,
                    NumeroBaños = 3,
                    Piscina = true,
                    MunicipioId = 3
                },new Adosado
                {
                    Nombre = "Adosado4",
                    Tamaño = 190,
                    NumeroHabitaciones = 5,
                    NumeroBaños = 2,
                    Piscina = false,
                    MunicipioId = 4
                },
            };
    }
} 
    }

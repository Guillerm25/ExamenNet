using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioViviendas.Entidades
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static List<Municipio> GetPoblaciones()
        {
            return new List<Municipio>
            {
                new Municipio
                {
                    Id = 1,
                    Nombre = "Cádiz"
                },
                 new Municipio
                {
                    Id = 2,
                    Nombre = "Málaga"
                },
                  new Municipio
                {
                    Id = 3,
                    Nombre = "Sevilla"
                },
                   new Municipio
                {
                    Id = 4,
                    Nombre = "Almería"
                }

            };
        }
    }
}
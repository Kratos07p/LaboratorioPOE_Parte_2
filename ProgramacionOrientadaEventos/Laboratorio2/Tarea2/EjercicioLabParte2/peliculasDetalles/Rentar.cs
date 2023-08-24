using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peliculasDetalles
{
    public class Rentar : Pelicula
    {
        public string Usuario { get; set; }
        public DateTime FechaLimite { get; set; }
    }
}

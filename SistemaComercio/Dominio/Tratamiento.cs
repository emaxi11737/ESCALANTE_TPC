using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tratamiento
    {
        public string numeroTratamiento { get; set; }
        public int cantidadPallets { get; set; }
        public int cantidadCajones { get; set; }
        public decimal cantidadmaderaAcomodacion { get; set; }
        public DateTime fecha { get; set; }
        public bool activo { get; set; }
    }
}

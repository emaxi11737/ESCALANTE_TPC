using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class  Certificado
    {
        public string numeroCertificado { get; set; }
        public string tipo { get; set; }
        public string codigo { get; set; }
        public double cantidadTotal { get; set; }
        public double cantidadEntregada { get; set; }
        public string numeroTratamiento { get; set; }   
        public DateTime fecha { get; set; }
        public Remito remito { get; set; }
        public bool activo { get; set; }

    }
}

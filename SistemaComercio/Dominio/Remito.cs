using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Remito
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public string numeroRemito { get; set; }
        public List<Detalle> detalles { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
        public bool activo { get; set; }
    }
}

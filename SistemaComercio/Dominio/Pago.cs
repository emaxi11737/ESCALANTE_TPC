using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pago
    {
        public DateTime fecha { get; set; }
        public long id { get; set; }
        public List<facturaVenta> facturaVenta { get; set; }
        public Cliente cliente { get; set; }
        public bool activo { get; set; }
    }
}

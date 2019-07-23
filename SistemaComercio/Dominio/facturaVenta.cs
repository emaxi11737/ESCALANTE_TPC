using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class facturaVenta : Factura
    {
        public Remito remito { get; set; }
        public Cliente cliente { get; set; }
        public decimal importeNeto { get; set; }
        public decimal importeIVA { get; set; }
        public decimal importeBruto { get; set; }
        public decimal importenoGravado { get; set; }
      

    }
}

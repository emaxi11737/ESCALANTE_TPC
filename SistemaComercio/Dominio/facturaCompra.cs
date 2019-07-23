using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class facturaCompra : Factura
    {
        Proveedor proveedor;
        public float importenoGravado { get; set; }
        public float importeGravado { get; set; }
        public float importeIVA21 { get; set; }
        public float importeIVA10 { get; set; }
        public float importeIVA27 { get; set; }
        public float importeIVA3 { get; set; }
        public float importeRetenciones { get; set; }
        public float importePercepciones { get; set; }
        public float importeBruto { get; set; }
      
    }
}

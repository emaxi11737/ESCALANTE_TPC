using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public int id { get; set; }
        public string numeroFactura { get; set; }
        public DateTime fechaFactura { get; set; }
        public List<Detalle> detalles { get; set; }
        public Remito remito { get; set; }
        public bool activo { get; set; }
        public string tipoComprobante { get; set; }
        public string estado { get; set; }
        public int condicionPago { get; set; }
    }
}

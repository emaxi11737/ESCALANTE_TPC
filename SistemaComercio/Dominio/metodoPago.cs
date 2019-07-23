using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class metodoPago
    {
        public long id { get; set; }
        public decimal importe { get; set; }
        public DateTime fechaPago { get; set; }
        public Cliente cliente { get; set; }
        public string tipo { get; set; }
    }
}

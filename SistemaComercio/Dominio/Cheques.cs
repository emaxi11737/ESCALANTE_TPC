using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cheque : metodoPago
    {
        public string num { get; set; }
        public string localidad { get; set; }
        public string cuitComprobante { get; set; }
        public string banco { get; set; }
    }
}

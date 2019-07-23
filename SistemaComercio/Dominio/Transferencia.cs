using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Transferencia:metodoPago
    {
        public string Banco { get; set; }
        public string numeroTransferencia { get; set; }
    }
}

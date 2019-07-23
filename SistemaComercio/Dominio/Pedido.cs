using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Pedido
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public DateTime fechaPedido { get; set; }
        public DateTime fechaListo { get; set; }
        public bool activo { get; set; }
    }
}

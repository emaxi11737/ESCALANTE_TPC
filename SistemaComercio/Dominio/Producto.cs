using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        private Categoria categoria { get; set; }
        public bool estado { get; set; }
        public decimal stockMinimo { get; set; }
        public bool activo { get; set; }
        public override string ToString()
        {
            return descripcion;
        }
    }
}

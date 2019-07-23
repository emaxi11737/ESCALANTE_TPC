using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Detalle
    {
        public int id { get; set; }
        public Producto producto { get; set; }
        public int cantidadVendida { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal precioParcial { get; set; }
        public string numeroRemito { get; set; }
        public string numeroCertificado { get; set; }
        public bool activo { get; set; }
    }
}

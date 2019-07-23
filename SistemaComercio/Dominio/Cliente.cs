using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string mail { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
        public string telefono { get; set; }
        public string condicionIVA { get; set; }
        public string condicionPago { get; set; }
        public bool activo = true;
        public override string ToString()
        {
            return nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {

        public bool activo { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string tipo { get; set; }
        public int id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialI.Entidades
{
    internal class Venta
    {
        public int id { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        
        public double precioProducto { get; set; }
        public int cantidadProducto { get; set; }


    }
}

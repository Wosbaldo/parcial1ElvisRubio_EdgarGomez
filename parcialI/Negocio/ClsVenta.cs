using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialI.Negocio
{
    internal class ClsVenta
    {
        public string cobro(double precioProducto, int cantidad)
        {
            int descuento = 10;
            
            double calculoVenta = precioProducto * cantidad;

            if (calculoVenta >= 50)
            {
                double precioOriginal = calculoVenta;
                double precioConDescuento =  calculoVenta - descuento;
                return $"Precio Original ${Math.Round(precioOriginal,2)} y Precion con descuento ${Math.Round(precioConDescuento,2)}";
            }

            return $"Precio que debe pagar ${calculoVenta}";
        } 
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using parcialI.Entidades;
using parcialI.Negocio;

namespace parcialI
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            Usuario user = new Usuario();
            Venta venta = new Venta();

            ClsUsuario Clsuser = new ClsUsuario();
            ClsVenta ClsVenta = new ClsVenta();

            {
                Console.WriteLine("Ingrese su usuario: ");
                string usuario = user.usuario = (Console.ReadLine());
                
                Console.WriteLine("Escriba su contraseña: ");
                int pass = user.pass = int.Parse(Console.ReadLine());

                bool verificacion = Clsuser.acceso(usuario.ToLower(), pass);

                if (verificacion)
                {
                    Console.WriteLine("SU USUARIO Y CONTRASEÑA SON CORRECTOS:");
                    
                    Console.WriteLine("NOMBRE DEL PRODUCTO: ");
                    string nombreProducto = venta.nombreProducto = (Console.ReadLine());

                    Console.WriteLine("DESCRIPCIÓN DEL PRODUCTO: ");
                    string descripcionProducto = venta.descripcionProducto = (Console.ReadLine());

                    Console.WriteLine("PRECIO DEL PRODUCTO: ");
                    double precioProducto = venta.precioProducto = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("CANTIDAD DEL PRODUCTO: ");
                    int cantidadProducto = venta.cantidadProducto = int.Parse(Console.ReadLine());

                    string msg = ClsVenta.cobro(precioProducto, cantidadProducto);

                    Console.WriteLine($"NOMBRE DEL PRODUCTO: {nombreProducto} \n DESCRIPCIÓN DEL PRODUCTO: {descripcionProducto} \n PRECIO DEL PRODUCTO: ${precioProducto} \n CANTIDAD DEL PRODUCTO: ${cantidadProducto} \n TOTAL A PAGAR {msg}");

                }
                else
                {
                    Console.WriteLine("SU USUARIO Y CONTRASEÑA NO SON CORRECTOS: ");
                }





            }


        }


    }
}

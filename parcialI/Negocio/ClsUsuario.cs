using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcialI.Entidades;


namespace parcialI.Negocio
{
    internal class ClsUsuario
    {
        internal static void accesoo(Usuario usua)
        {
        
        }

        public bool acceso(string usuario, int pass)
        {
    
            if (usuario == "super" && pass == 123)
            {
                return true;
            }

            return false;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_2017_0826.BLL
{
    class Utilidades
    {
        public static int ToInt(string cadena)
        {
            int valor = 0;

            int.TryParse(cadena, out valor);

            return valor;
        }

        public static bool esToInt(string cadena)
        {
            bool paso = Int32.TryParse(cadena, out int valor);

            return paso;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02.Namespace01
{
    public class Classe02
    {
        public static void MetodoPublico()
        {
            Console.Write("Método Público - Classe 02");
        }
        internal static void MetodoInternal()
        {
            Console.Write("Método Internal - Classe 02");
        }
        protected static void MetodoProtegido()
        {
            Console.Write("Método Protegido - Classe 02");
        }

        private static void MetodoPrivado()
        {
            Console.Write("Método Privado - Classe 02");
        }
    }
}

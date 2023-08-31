using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02
{
    public class Classe01
    {
        public static void MetodoPublico()
        {
            Console.Write("Método Público - Classe 01");
        }
        internal static void MetodoInternal()
        {
            Console.Write("Método Internal - Classe 01");
        }
        protected static void MetodoProtegido()
        {
            Console.Write("Método Protegido - Classe 01");
        }

        private static void MetodoPrivado()
        {
            Console.Write("Método Privado - Classe 01");
        }
    }
}

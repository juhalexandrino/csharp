using Metodos_02.Namespace01;

namespace Metodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoInternal();
            MetodoProtegido();
            MetodoPrivado();

            Classe01.MetodoPublico();     // todas as classes podem acessar esse método
            Classe01.MetodoInternal();   //  método acessado apenas por classes do mesmo projeto
        //  Classe01.MetodoProtegido();      método acessado apenas por herança
       //   Classe01.MetodoPrivado();        método exclusivo da classe em que foi criado

            Classe02.MetodoPublico();
            Classe02.MetodoInternal();
        }

        public static void MetodoPublico()
        {
            Console.Write("Método Público - Classe Program");
        }
        internal static void MetodoInternal()
        {
            Console.Write("Método Internal - Classe Program");
        }
        protected static void MetodoProtegido()
        {
            Console.Write("Método Protegido - Classe Program");
        }

        private static void MetodoPrivado()
        {
            Console.Write("Método Privado - Classe Program");
        }
    }
}
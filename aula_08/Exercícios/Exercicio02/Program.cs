using Exercicio03.Model;
using Exercicio03.Namespace02;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++ Vendedores +++++++++");
            Vendedor vendedor = new Vendedor(01, "Rui", true, 5500, 5, 20);
            Vendedor vendedor2 = new Vendedor(02, "Célia", false, 7500, 15, 0);

            vendedor.Visualizar();
            Console.WriteLine();
            vendedor2.Visualizar();

            Console.WriteLine("\n\n+++++++++++ Gerentes +++++++++++");
            Gerente gerente = new Gerente(01, "Hugo", false, 10000, 10, "Financeiro");
            Gerente gerente2 = new Gerente(02, "Gisele", true, 16000, 16, "Comercial");

            gerente.Visualizar();
            Console.WriteLine();
            gerente2.Visualizar();

        }
    }
}
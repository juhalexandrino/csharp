using Exercicio03.Namespace02;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1, "Rui", "Gerente", 8700, 7);
            Funcionario funcionario2 = new Funcionario(2, "Carmem", "Secretária", 3500, 5);

            funcionario.Visualizar();
            Console.WriteLine("");
            funcionario2.Visualizar();
        }
    }
}
using Exercicio01.Model;
using Exercicio01.Namespace01;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++ Pessoa Jurídica +++++++++++");
            PessoaJuridica juridica = new PessoaJuridica(01, "BrincandoLivre", "brincandolivre@email.com", "11 1234-5678", "Rua de Pedra, 011", "Fabiana Silva");
            PessoaJuridica juridica2 = new PessoaJuridica(02, "Studio Unhas&Make", "studiounhasemake@email.com", "22 9876-54321", "Rua de Tijolo, 220", "Clara Oliveira");

            juridica.Visualizar();
            Console.WriteLine();
            juridica2.Visualizar();

            Console.WriteLine("\n\n+++++++++++ Pessoa Fisíca +++++++++++");
            PessoaFisica fisica = new PessoaFisica(01, "Leonardo", "leonardo@email.com", "33 2468-9513", "Rua de Cimento, 123", 6);
            PessoaFisica fisica2 = new PessoaFisica(02, "Eduardo", "eduardo@email.com", "44 9753-4682", "Rua de Concreto, 321", 8);
            
            fisica.Visualizar();
            Console.WriteLine();
            fisica2.Visualizar();
        }
    }
}
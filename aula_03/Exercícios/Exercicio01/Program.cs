namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, soma;

            Console.WriteLine("Digite um número para A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número para B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número para C: ");
            c = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            if (soma < c)
                Console.WriteLine("A soma de A + B é menor do que C.");

            else if (soma > c)
                Console.WriteLine("A soma de A + B é maior do que C.");
            
            else
                Console.WriteLine("A soma de A + B é igual a C.");

        }
    }
}
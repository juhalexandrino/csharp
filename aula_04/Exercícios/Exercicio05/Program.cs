namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0, soma = 0;

            do{
                Console.Write("Digite um número: ");
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros > 0)
                    soma = soma + numeros;

            } while (numeros != 0);

            Console.WriteLine($"A soma dos números positivos é {soma}.");
        }
    }
}
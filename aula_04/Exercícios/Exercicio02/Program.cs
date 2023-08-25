namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeros = 0, pares = 0, impares = 0;

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros % 2 == 0)
                    pares++;

                else
                    impares++;
            }

            Console.WriteLine($"Total de números pares: {pares}");
            Console.WriteLine($"Total de números ímpares: {impares}");
        }
    }
}
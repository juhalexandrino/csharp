namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0 && numero > 0)
                Console.WriteLine($"\nO número {numero} é par e positivo!");

            else if (numero % 2 == 0 && numero < 0)
                Console.WriteLine($"\nO número {numero} é par e negativo!");

            else if (numero % 2 != 0 && numero > 0)
                Console.WriteLine($"\nO número {numero} é ímpar e positivo!");

            else if (numero % 2 != 0 && numero < 0)
                Console.WriteLine($"\nO número {numero} é ímpar e negativo!");

            else
                Console.WriteLine("\nO número digitado foi 0.");
        }
    }
}
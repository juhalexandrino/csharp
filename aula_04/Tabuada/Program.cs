namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //o contador começa em 1 e até chegar a ser maior ou igual a 10, +1 é incrementado.
            for (int contador = 1; contador <= 10; contador++)
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }
    }
}
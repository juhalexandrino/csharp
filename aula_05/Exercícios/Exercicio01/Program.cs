namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 6, 7, 8, 4, 3, 9, 10, 5, 1 };
            int numeroUsuario;

            foreach (int elemento in numeros){
                Console.Write($"[{elemento}]");
            }

            Console.WriteLine();

            Console.Write("\nDigite o número que você deseja saber a posição: ");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            if (numeroUsuario > 0 && numeroUsuario <= 10)
            {
                Console.Write($"\nO número {numeroUsuario} está localizado na posição {Array.IndexOf(numeros, numeroUsuario)}.");
            }
            else
            {
                Console.WriteLine($"O número {numeroUsuario} não foi encontrado!");
            }
        }
    }
}
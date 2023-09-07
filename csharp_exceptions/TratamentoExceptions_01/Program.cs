using System.Runtime.ConstrainedExecution;

namespace TratamentoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            bool loop = true;

            do
            {
                try
                {
                    Console.Write("Digite o 1º número: ");
                    numero1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o 2º número: ");
                    numero2 = Convert.ToInt32(Console.ReadLine());

                    divide(numero1, numero2);

                    loop = false;
                }
                catch (FormatException e)
                {
                    //Console.Error.Write($"Exceção: {e}  ");
                    Console.Error.WriteLine("Digite valores inteiros!");

                }
                catch (DivideByZeroException e)
                {
                    //Console.Error.Write($"Exceção: {e}  ");
                    Console.Error.Write("Digite valores inteiros positivos!");

                }
                finally
                {
                    Console.WriteLine("\nSempre serei executado!");
                }
            }while (loop);

            Console.WriteLine("Finalizou com sucesso!");
        }

        public static void divide(int dividendo, int divisor)
        {
            Console.WriteLine("Divisão = " + (dividendo / divisor));
        }

    }
}
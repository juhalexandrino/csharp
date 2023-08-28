namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, numeros;

            Console.WriteLine("Insira um intervalo e descubra quais números são divisivéis por 3 ou 5!");
            Console.Write("\nDigite o primeiro número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero < segundoNumero) {

                for (numeros = primeiroNumero; numeros <= segundoNumero; numeros++ ) {
                    if (numeros % 3 == 0 && numeros % 5 == 0)
                        Console.WriteLine($"\nO número {numeros} é múltiplo de 3 e 5.");
                }
            
            }else
                Console.WriteLine("\nIntervalo inválido! O primeiro número deve ser menor que o segundo.");

        }
    }
}
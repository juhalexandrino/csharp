namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Os resultados das operações são: ");
            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            if (numero2 > 0)
                Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2));
            else
                Console.WriteLine("Não é possível dividir por zero.");

            Console.WriteLine($"{numero1} ^ {numero2} é " + Math.Pow(numero1, 2));
            Console.WriteLine($"Raiz quadrada de {numero1} é " + Math.Sqrt((numero1)));
        }
    }
}

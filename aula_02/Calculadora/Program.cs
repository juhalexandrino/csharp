namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
<<<<<<< HEAD

=======
>>>>>>> e25b8b5c9c6ea46ac27e91f0ffd654e5d9614beb
            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Os resultados das operações são: ");
            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2));
            Console.WriteLine("O resultado dessa divisão em número decimal é " + Math.Round((numero1 / numero2), 2));
            Console.WriteLine($"{numero1} ^ {numero2} é " + Math.Pow(numero1, 2));
            Console.WriteLine($"Raiz quadrada de {numero1} é " + Math.Sqrt((numero1)));
        }
    }
}

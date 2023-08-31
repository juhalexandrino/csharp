using Metodos_02.Namespace01;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());
            
            divisao = Dividir(numero1, numero2);

            Console.WriteLine("\nOs resultados das operações são: ");
            Console.WriteLine($"{numero1} + {numero2} = " + Somar(numero1, numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + Subtrair(numero1, numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + Multiplicar(numero1, numero2));                  
            Console.WriteLine(divisao == 0 ? "Não é possível dividir por zero." : $"{numero1} / {numero2} = ");                  
            Console.WriteLine($"{numero1} ^ {numero2} é " + Math.Pow(numero1, 2));
            Console.WriteLine($"Raiz quadrada de {numero1} é " + Math.Sqrt(numero1));

            Dev();

            Classe02.MetodoPublico();
        }

        static float Somar(float numero1, float numero2)
        {
            return (numero1 + numero2);
        }
        
        static float Subtrair(float numero1, float numero2)
        {
            return (numero1 - numero2);
        }
        
        static float Multiplicar(float numero1, float numero2)
        {
            return (numero1 * numero2);
        }
        
        static float Dividir(float numero1, float numero2)
        {
            if (numero2 > 0)
                return (numero1 / numero2);
            else
                return 0; 
        }

        static void Dev()
        {
            Console.WriteLine("\nCriado por Julia Alexandrino");
        }
    }
}
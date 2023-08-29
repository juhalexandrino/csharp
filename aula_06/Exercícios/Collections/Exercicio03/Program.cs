namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();
            int resposta, totalRespostas = 10;

            for (int i = 0; i < totalRespostas; i++){
                Console.Write("Digite um número inteiro: ");
                resposta = Convert.ToInt32(Console.ReadLine());
                numeros.Add(resposta);
            }

            Console.WriteLine("\nListando dados do HashSet: ");

            foreach (var numero in numeros){
                resposta = numero;
                Console.WriteLine(numero);
            }
        }
    }
}
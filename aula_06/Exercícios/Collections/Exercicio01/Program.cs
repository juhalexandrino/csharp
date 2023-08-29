using System.Runtime.ConstrainedExecution;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();
            string? resposta;
            int totalRespostas = 5;

            for (int i = 0; i < totalRespostas; i++){
                Console.Write("Digite uma cor: ");
                resposta = Console.ReadLine();
                cores.Add(resposta);
            }
            
            Console.WriteLine("\nListando todas as cores: ");

            foreach (var cor in cores){                
                resposta = cor;
                 Console.WriteLine(cor);
            }

            Console.WriteLine("\nOrdenando as cores: ");
            
            cores.Sort();

            foreach (var cor in cores){
                
                resposta = cor;
                Console.WriteLine(cor);
            }
            
            

        }
        }
    }
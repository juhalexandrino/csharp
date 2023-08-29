namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // adicionando notas em uma lista 
            List<double> notas = new List<double>();
            
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas){
                Console.WriteLine(nota);
            }
            
            // posição de um elemento dentro da lista    
            Console.WriteLine("\nPosição da nota 4.0 é " + notas.IndexOf(4.0));
            
            // verificar se um elemento existe na lista
            Console.WriteLine("\nA nota 4.0 existe? " + notas.Contains(4.0));
            
            // remoção de elemento
            notas.Remove(4.0);

            // retorna o total de elementos na lista
            Console.WriteLine("\nQuantos elementos tem nessa lista? "+ notas.Count);

            foreach (double nota in notas){
                Console.WriteLine(nota);
            }

            // ordenação da lista em ordem crescente
            Console.WriteLine();
            
            notas.Sort();

            foreach (double nota in notas){
                Console.WriteLine(nota);
            }

            // ordenação da lista em ordem decrescente
            Console.WriteLine() ;

            notas.Reverse();

            foreach (double nota in notas){
                Console.WriteLine(nota);
            }

            // trocando elemento do índice
            notas[0] = 9.0;

            // var: identifica o tipo da Collection e cria a variável do mesmo tipo
            foreach (var nota in notas){
                Console.WriteLine(nota);
            }
        }
    }
}
namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livro = new Stack<string>();
            string? nomeLivro;
            int entrada;

            do{
                Console.WriteLine("===============================================");
                Console.WriteLine("       1 - Adicionar livro na pilha");
                Console.WriteLine("       2 - Listar todos os livros");
                Console.WriteLine("       3 - Retirar livro da pilha");
                Console.WriteLine("       0 - Sair");
                Console.WriteLine("===============================================");

                Console.Write("\nEscolha a opção desejada: ");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada == 0)
                    Console.WriteLine("Programa finalizado!");
                else if (entrada < 0 || entrada >= 4)
                    Console.WriteLine("Digite uma opção válida.");

                switch (entrada){

                    case 1:
                        Console.Write("Digite o nome: ");
                        nomeLivro = Console.ReadLine();
                        livro.Push(nomeLivro);

                        Console.WriteLine("\nFila atual: ");
                        foreach (var todosLivros in livro){
                            Console.WriteLine(todosLivros);
                        }
                        Console.Write("\n\nLivro adicionado com sucesso!\n");
                        break;

                    case 2:
                        foreach (var todosLivros in livro){
                            Console.WriteLine(todosLivros);
                        }

                        if (livro.Count == 0)
                            Console.WriteLine("\nA fila está vazia!");
                        break;

                    case 3:
                        livro.Pop();
                        foreach (var todosLivros in livro){
                            Console.WriteLine("" + todosLivros);
                        }

                        Console.WriteLine("Um livro foi retirado da pilha!");

                        if (livro.Count == 0)
                            Console.WriteLine("A fila está vazia!");
                    break;
                }

            } while (entrada > 0 && entrada <= 3);
        }
    }
}
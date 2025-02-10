using System.Threading.Channels;

namespace GERENCIADOR
{
    class Formatacao
    {
            static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=======================");
                Console.WriteLine("GERENCIADOR DE TAFERAS");
                Console.WriteLine("=======================");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas");
                Console.WriteLine("3 - Concluir Tarefa");
                Console.WriteLine("4 - Remover Tarefa");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Digite o criar: ");
                    int tamanho = int.Parse(Console.ReadLine());

                    Console.Write("Digite: ");
                    string tipo = Console.ReadLine().ToLower();

                    string senha = Geranciador(tamanho, tipo);
                    Console.WriteLine($": {adicionar}");
                }
                else if (opcao == "2")
                {
                    Console.Write("Listar Tarefas: ");
                    string salvar = Console.ReadLine().ToLower();

                    if (salvar == "s")
                    {
                        Console.WriteLine("Tarefa pelo sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Foi Remove.");
                    }
                }
                else if (opcao == "3")
                {
                    RecuperarBackup();
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }
        }
    }
}


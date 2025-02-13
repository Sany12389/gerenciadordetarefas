using GerenciarTarefa;
using Layout;
using Taferas;

var Gerenciador = new Gerenciador();
string opcao;
opcao = Formatacao.ImprimirMenu();


switch (opcao)
{
    case "1":
        Console.WriteLine("Informar a descrição da tarefa: ");
        string descricao = Console.ReadLine();
        Gerenciador.AdicionarTarefa(descricao);
        break;
    case "2":
    
    break;
    default:
        break;
}



// switch (opcao)
// {
//     case "1":
//         Console.Write("Digite o criar: ");
//         int tamanho = int.Parse(Console.ReadLine());

//         Console.Write("Digite: ");
//         string tipo = Console.ReadLine().ToLower();

//         string criar = Geranciador(tamanho, tipo);
//         Console.WriteLine($": {adicionar}");
//         break;

//     case "2":
//         Console.Write("Listar Tarefa");
//         int tamanho = int.Parse(Console.ReadLine());
//         break;

//     case "3":
//         int tamanho = int.Parse(Console.ReadLine());

//         Console.Write("Digite: ");
//         string tipo = Console.ReadLine().ToLower();

//         string senha = Geranciador(tamanho, tipo);
//         Console.WriteLine($": {adicionar}");
//         break;

//     case "4":
//         int tamanho = int.Parse(Console.ReadLine());

//         Console.Write("Digite: ");
//         string tipo = Console.ReadLine().ToLower();

//         string senha = Geranciador(tamanho, tipo);
//         Console.WriteLine($": {adicionar}");
//         break;

//     case "0":
//         int tamanho = int.Parse(Console.ReadLine());

//         Console.Write("Digite: ");
//         string tipo = Console.ReadLine().ToLower();

//         string senha = Geranciador(tamanho, tipo);
//         Console.WriteLine($": {adicionar}");
//         break;
//     default:

// }

// if (opcao == "1")
// {
//     Console.Write("Digite o criar: ");
//     int tamanho = int.Parse(Console.ReadLine());

//     Console.Write("Digite: ");
//     string tipo = Console.ReadLine().ToLower();

//     string senha = Geranciador(tamanho, tipo);
//     Console.WriteLine($": {adicionar}");
// }
// else if (opcao == "2")
// {
//     Console.Write("Listar Tarefas: ");
//     string salvar = Console.ReadLine().ToLower();

//     if (opcao == "")
//     {
//         Console.WriteLine("Tarefa pelo sucesso!");
//     }
//     else
//     {
//         Console.WriteLine("Foi Remove.");
//     }
// }
// else if (opcao == "3")
// {
//     Console.WriteLine("");
//     break;
// }
// else if (opcao == "4")
// {
//     Console.WriteLine("Saindo...");
//     break;
// }
// else
// {
//     Console.WriteLine("Opção inválida, tente novamente.");
// }

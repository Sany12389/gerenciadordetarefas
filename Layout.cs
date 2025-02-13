namespace Layout
{
    class Formatacao
    {
        public static void Cor(string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        public static string ImprimirMenu()
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
            return opcao;
        }
    }
}
using Taferas;

namespace GerenciarTarefa
{
    class Gerenciador
    {
        public static List<Tarefa> tarefas = new List<Tarefa>();

        private static int contadorId = 1;
        public void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(contadorId++, descricao);

            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso! ");

        }
    }
}
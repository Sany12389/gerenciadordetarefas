using Layout;
using Tarefas;

namespace GerenciarTarefas
{
    class Gerenciador
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int contadorId = 1;
        public void AdicionarTarefa(string descricao)
        {
            var  novaTarefa = new Tarefa( contadorId++, descricao);
            tarefas.Add(novaTarefa);
            Formatacao.Cor("Tarefa adicionada  com sucesso!", ConsoleColor.Green);
        }
         public void ListarTarefa()
         {
            if (tarefas.Count == 0)
            {
               Console.WriteLine("Nao há nenhuma tarefas cadastradas.");
            }
            else
            {
                foreach (var tarefa in tarefas)
                {
                    tarefa.ExibirTarefa();
             }
             }
         }    
    }
}
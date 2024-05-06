using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IServicoTarefas
    {
        List<Tarefas> ObterTodasTarefas();
        Tarefas ObterTarefa(int Id);
        Tarefas AdicionarTarefa(Tarefas tarefa);
        Tarefas AtualizarTarefa(Tarefas tarefa);
        Tarefas DeletarTarefa(int Id);
    }
}

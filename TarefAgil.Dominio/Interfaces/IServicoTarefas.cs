using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IServicoTarefas
    {
        List<Tarefas> ObterTodasTarefas();
        Tarefas ObterTarefa(int Id);
        void AdicionarTarefa(Tarefas tarefa);
        void AtualizarTarefa(Tarefas tarefa);
        void DeletarTarefa(int Id);
    }
}

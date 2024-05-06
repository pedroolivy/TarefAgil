using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IRepositorioTarefas
    {
        List<Tarefas> GetAll();
        Tarefas GetById(int Id);
        Tarefas Add(Tarefas tarefa);
        Tarefas Update(Tarefas tarefa);
        Tarefas Delete(int Id);
    }
}

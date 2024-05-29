using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IRepositorioTarefas
    {
        List<Tarefas> GetAll();
        Tarefas GetById(int Id);
        List<Tarefas> ObterPorUsuario(int UsuarioId);
        void Add(Tarefas tarefa);
        void Update(Tarefas tarefa);
        void Delete(int Id);
    }
}

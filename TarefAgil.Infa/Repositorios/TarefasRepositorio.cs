using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;
using TarefAgil.Infa.Dados;

namespace TarefAgil.Infa.Repositorios
{
    public class TarefasRepositorio : IRepositorioTarefas
    {
        private readonly AppDbContext _appDbContext;
        public TarefasRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Tarefas> GetAll()
        {
             return _appDbContext.Tarefas.ToList();
        }

        public Tarefas GetById(int Id)
        {
            return _appDbContext.Tarefas.FirstOrDefault(x => x.Id == Id);
        }

        public List<Tarefas> ObterPorUsuario(int UsuarioId)
        {
            return _appDbContext.Tarefas.Where(x => x.UsuarioId == UsuarioId).ToList();
        }

        public void Add(Tarefas tarefa)
        {
            _appDbContext.Add(tarefa);
            _appDbContext.SaveChanges();
        }
        public void Update(Tarefas tarefa)
        {
            _appDbContext.Update(tarefa);
            _appDbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            _appDbContext.Remove(Id);
            _appDbContext.SaveChanges();
        }
    }
}

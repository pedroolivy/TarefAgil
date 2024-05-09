using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;
using TarefAgil.Infa.Dados;

namespace TarefAgil.Infa.Repositorios
{
    public class UsuarioRepositorio : IRepositorioUsuario
    {
        private readonly AppDbContext _appDbContext;
        public UsuarioRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<Usuario> GetAll()
        {
            return _appDbContext.Usuario.ToList();
        }

        public Usuario GetById(int Id)
        {
            return _appDbContext.Usuario.FirstOrDefault(x => x.Id == Id);
        }

        public void Add(Usuario usuario)
        {
            _appDbContext.Add(usuario);
            _appDbContext.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _appDbContext.Update(usuario);
            _appDbContext.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            _appDbContext.Remove(usuario);
            _appDbContext.SaveChanges();
        }
    }
}

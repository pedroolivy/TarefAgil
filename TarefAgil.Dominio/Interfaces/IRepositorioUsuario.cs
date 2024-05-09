using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        List<Usuario> GetAll();
        Usuario GetById(int Id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
    }
}

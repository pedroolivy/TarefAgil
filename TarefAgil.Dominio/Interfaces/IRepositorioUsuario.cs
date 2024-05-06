using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        List<Usuario> GetAll();
        Usuario GetById(int Id);
        Usuario Add(Usuario usuario);
        Usuario Update(Usuario usuario);
        Usuario Delete(int Id);
    }
}

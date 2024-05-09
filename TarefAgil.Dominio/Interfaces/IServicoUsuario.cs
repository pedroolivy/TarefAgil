using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IServicoUsuario
    {
        List<Usuario> ObterTodosUsuarios();
        Usuario ObterUsuario(int Id);
        void AdicionarUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void DeletarUsuario(int Id);
    }
}

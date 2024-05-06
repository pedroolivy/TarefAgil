using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Dominio.Interfaces
{
    public interface IServicoUsuario
    {
        List<Usuario> ObterTodosUsuarios();
        Usuario ObterUsuario(int Id);
        Usuario AdicionarUsuario(Usuario usuario);
        Usuario AtualizarUsuario(Usuario usuario);
        Usuario DeletarUsuario(int Id);
    }
}

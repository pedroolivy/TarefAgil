using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Infa.Servicos
{
    public class ServicoUsuario : IServicoUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        public ServicoUsuario(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public Usuario AdicionarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario AtualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario DeletarUsuario(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObterTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterUsuario(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

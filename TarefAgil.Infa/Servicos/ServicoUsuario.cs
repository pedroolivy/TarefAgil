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

        public List<Usuario> ObterTodosUsuarios()
        {
            var usuarios = _repositorioUsuario.GetAll();

            return usuarios;
        }

        public Usuario ObterUsuario(int Id)
        {
            var usuario = _repositorioUsuario.GetById(Id)
                ?? throw new Exception("Usuário não encontrado");
                
            return usuario;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _repositorioUsuario.Add(usuario);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _repositorioUsuario.Update(usuario);
        }

        public void DeletarUsuario(int Id)
        {
            var usuarioDoBanco = _repositorioUsuario.GetById(Id);

            if (usuarioDoBanco == null)
                throw new Exception("Não existe esse usuário");

            _repositorioUsuario.Delete(usuarioDoBanco);
        }
        
    }
}

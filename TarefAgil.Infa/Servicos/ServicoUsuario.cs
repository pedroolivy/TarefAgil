using FluentValidation;
using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Infa.Servicos
{
    public class ServicoUsuario : IServicoUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        private readonly IValidator<Usuario> _validator;
        public ServicoUsuario(IRepositorioUsuario repositorioUsuario, IValidator<Usuario> validator)
        {
            _repositorioUsuario = repositorioUsuario;
            _validator = validator;
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
            var mensagem = _validator.Validate(usuario);

            if (!mensagem.IsValid)
                throw new Exception(mensagem.ToString());

            _repositorioUsuario.Add(usuario);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            var mensagem = _validator.Validate(usuario);

            if (!mensagem.IsValid)
                throw new Exception(mensagem.ToString());

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

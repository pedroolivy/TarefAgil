using FluentValidation;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Validacoes
{
    public class ValidadorUsuario : AbstractValidator<Usuario>
    {
        public ValidadorUsuario()
        {
            RuleFor(usuario => usuario.Nome)
                .NotEmpty()
                .WithMessage("O nome é obrigatório.")
                .Length(1, 200)
                .WithMessage("O nome do usuario deve ter entre 1 e 200 caracteres.");

            RuleFor(usuario => usuario.Email)
                .NotEmpty()
                .WithMessage("O email é obrigatório.")
                .EmailAddress()
                .WithMessage("O email não é válido.");

            RuleFor(usuario => usuario.Senha)
                .NotEmpty()
                .WithMessage("A senha é obrigatória.")
                .Length(2, 20)
                .WithMessage("A senha deve ter entre 4 e 20 caracteres");

        }
    }
}

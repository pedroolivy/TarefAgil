using FluentValidation;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Validacoes
{
    public class ValidadorTarefa : AbstractValidator<Tarefas>
    {
        public ValidadorTarefa() 
        {
            RuleFor(tarefa => tarefa.Nome)
                .NotEmpty()
                .WithMessage("O nome é obrigatorio")
                .MaximumLength(50)
                .WithMessage("O nome é muito grande");

            RuleFor(tarefa => tarefa.Descricao)
                .NotEmpty()
                .WithMessage("Descrição é obrigatória")
                .MaximumLength(300)
                .WithMessage("A descrição é muito grande");

            RuleFor(tarefa => tarefa.Status)
                .NotNull()
                .WithMessage("Status é obrigatório")
                .IsInEnum()
                .WithMessage("Não existe esse status");

            RuleFor(tarefa => tarefa.UsuarioId)
                .NotNull()
                .WithMessage("Não pertence a nenhum usuário");

            RuleFor(tarefa => tarefa.DataInicial)
                .NotNull()
                .WithMessage("Peencha a data inicial")
                .GreaterThanOrEqualTo(DateTime.Today)
                .WithMessage("A data tem de ser igual ou maior que a data atual");

            RuleFor(tarefa => tarefa.DataFinal)
                .NotNull()
                .WithMessage("Peencha a data inicial")
                .GreaterThan(tarefa => tarefa.DataInicial)
                .WithMessage("A data tem de ser igual ou maior que a data atual");

        }
    }
}

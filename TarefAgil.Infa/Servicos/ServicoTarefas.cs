using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;
using FluentValidation;

namespace TarefAgil.Infa.Servicos
{
    public class ServicoTarefas : IServicoTarefas
    {
        private readonly IRepositorioTarefas _repositorioTarefas;
        private readonly IValidator<Tarefas> _validator;
        public ServicoTarefas(IRepositorioTarefas repositorioTarefas, IValidator<Tarefas> validator)
        {
            _repositorioTarefas = repositorioTarefas;
            _validator = validator;
        }
        public List<Tarefas> ObterTodasTarefas()
        {
            var tarefas = _repositorioTarefas.GetAll();

            return tarefas;
        }

        public Tarefas ObterTarefa(int Id)
        {
            var tarefa = _repositorioTarefas.GetById(Id)
                ?? throw new Exception("A tarefa não foi encontrada.");

            return tarefa;
        }

        public void AdicionarTarefa(Tarefas tarefa)
        {
            var Mensagem = _validator.Validate(tarefa);

            if(!Mensagem.IsValid)
                throw new Exception(Mensagem.ToString());

            _repositorioTarefas.Add(tarefa);
        }

        public void AtualizarTarefa(Tarefas tarefa)
        {
            var Mensagem = _validator.Validate(tarefa);

            if (!Mensagem.IsValid)
                throw new Exception(Mensagem.ToString());

            _repositorioTarefas.Update(tarefa);
        }

        public void DeletarTarefa(int Id)
        {
            var tarefaDoBanco = _repositorioTarefas.GetById(Id);

            if (tarefaDoBanco == null)
                throw new Exception("Essa tarefa não existe");

            _repositorioTarefas.Delete(tarefaDoBanco.Id);
        }
    }
}

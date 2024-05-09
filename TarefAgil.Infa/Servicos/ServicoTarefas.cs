using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;
using System.Data.SqlTypes;

namespace TarefAgil.Infa.Servicos
{
    public class ServicoTarefas : IServicoTarefas
    {
        private readonly IRepositorioTarefas _repositorioTarefas;
        public ServicoTarefas(IRepositorioTarefas repositorioTarefas)
        {
            _repositorioTarefas = repositorioTarefas;
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
            _repositorioTarefas.Add(tarefa);
        }

        public void AtualizarTarefa(Tarefas tarefa)
        {
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

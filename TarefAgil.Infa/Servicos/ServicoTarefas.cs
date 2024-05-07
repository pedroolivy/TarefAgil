using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Infa.Servicos
{
    public class ServicoTarefas : IServicoTarefas
    {
        private readonly IRepositorioTarefas _repositorioTarefas;
        public ServicoTarefas(IRepositorioTarefas repositorioTarefas)
        {
            _repositorioTarefas = repositorioTarefas;
        }

        public Tarefas AdicionarTarefa(Tarefas tarefa)
        {
            throw new NotImplementedException();
        }

        public Tarefas AtualizarTarefa(Tarefas tarefa)
        {
            throw new NotImplementedException();
        }

        public Tarefas DeletarTarefa(int Id)
        {
            throw new NotImplementedException();
        }

        public Tarefas ObterTarefa(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Tarefas> ObterTodasTarefas()
        {
            throw new NotImplementedException();
        }
    }
}

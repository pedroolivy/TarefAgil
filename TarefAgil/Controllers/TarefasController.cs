using Microsoft.AspNetCore.Mvc;
using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Controllers
{
    [Route("api/tarefas")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly IServicoTarefas _servicoTarefas;

        public TarefasController(IServicoTarefas servicoTarefas)
        {
            _servicoTarefas = servicoTarefas;
        }

        [HttpGet("ObterTodasTarefas")]
        public ActionResult ObterTodos() 
        {
            var tarefas = _servicoTarefas.ObterTodasTarefas();

            return Ok(tarefas);
        }

        [HttpGet("ObterTarefa/{Id}")]
        public ActionResult Obter(int Id)
        {
            var tarefa = _servicoTarefas.ObterTarefa(Id);

            return Ok(tarefa);
        }

        [HttpGet("ObterPorUsuario/{UsuarioId}")]
        public ActionResult ObterPorUsuario(int UsuarioId)
        {
            var tarefa = _servicoTarefas.ObterPorUsuario(UsuarioId);

            return Ok(tarefa);
        }

        [HttpPost("AdicionarTarefa")]
        public ActionResult Adicionar([FromBody] Tarefas terafa)
        {
            _servicoTarefas.AdicionarTarefa(terafa);

            return Created("Adicionada",terafa);
        }

        [HttpPut("EditarTarefa")]
        public ActionResult Editar([FromBody] Tarefas terafa)
        {
            _servicoTarefas.AtualizarTarefa(terafa);

            return Ok(terafa);
        }

        [HttpDelete("DeletarTarefa/{Id}")]
        public ActionResult Deletar(int Id)
        {
            _servicoTarefas.DeletarTarefa(Id);

            return NoContent();
        }
    }
}

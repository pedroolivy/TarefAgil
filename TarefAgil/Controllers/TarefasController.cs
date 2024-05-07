using Microsoft.AspNetCore.Mvc;
using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Controllers
{
    [Route("api/[controller]")]
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
            return Ok("Oi´s");
        }

        [HttpGet("ObterTarefa/{Id}")]
        public ActionResult Obter(int Id)
        {
            return Ok("Oi");
        }

        [HttpPost("AdicionarTarefa")]
        public ActionResult Adicionar([FromBody] Tarefas terafa)
        {
            return Created("Oi", terafa);
        }

        [HttpPut("EditarTarefa")]
        public ActionResult Editar([FromBody] Tarefas terafa)
        {
            return Ok(terafa);
        }

        [HttpDelete("DeletarTarefa/{Id}")]
        public ActionResult Deletar(int Id)
        {
            return NoContent();
        }
    }
}

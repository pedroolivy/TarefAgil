using Microsoft.AspNetCore.Mvc;
using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IServicoUsuario _servicoUsuario;

        public UsuarioController(IServicoUsuario servicoUsuario)
        {
            _servicoUsuario = servicoUsuario;
        }

        [HttpGet("ObterTodosUsuarios")]
        public ActionResult ObterTodos()
        {
            return Ok("Oi´s");
        }

        [HttpGet("ObterUsuario/{Id}")]
        public ActionResult Obter(int Id)
        {
            return Ok("Oi");
        }

        [HttpPost("AdicionarUsuario")]
        public ActionResult Adicionar([FromBody] Tarefas terafa)
        {
            return Created("Oi", terafa);
        }

        [HttpPut("EditarUsuario")]
        public ActionResult Editar([FromBody] Tarefas terafa)
        {
            return Ok(terafa);
        }

        [HttpDelete("DeletarUsuario/{Id}")]
        public ActionResult Deletar(int Id)
        {
            return NoContent();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using TarefAgil.Dominio.Interfaces;
using TarefAgil.Dominio.Modelos;

namespace TarefAgil.Controllers
{
    [Route("api/usuario")]
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
            var usuarios = _servicoUsuario.ObterTodosUsuarios();

            return Ok(usuarios);
        }

        [HttpGet("ObterUsuario/{Id}")]
        public ActionResult Obter(int Id)
        {
            var usuario = _servicoUsuario.ObterUsuario(Id);

            return Ok(usuario);
        }

        [HttpPost("AdicionarUsuario")]
        public ActionResult Adicionar([FromBody] Usuario terafa)
        {
            _servicoUsuario.AdicionarUsuario(terafa);

            return Created("Adicionado", terafa);
        }

        [HttpPut("EditarUsuario")]
        public ActionResult Editar([FromBody] Usuario terafa)
        {
            _servicoUsuario.AtualizarUsuario(terafa);

            return Ok(terafa);
        }

        [HttpDelete("DeletarUsuario/{Id}")]
        public ActionResult Deletar(int Id)
        {
            _servicoUsuario.DeletarUsuario(Id);

            return NoContent();
        }

    }
}

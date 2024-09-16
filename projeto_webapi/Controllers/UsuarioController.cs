using Microsoft.AspNetCore.Mvc;

namespace proejto_webapi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString(),
            };
            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome) {
            var mensagem = $"Olá{nome}, Seja bem vindo";
            return Ok( new {mensagem});

        }
    }
}

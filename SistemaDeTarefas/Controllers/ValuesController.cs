using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet] //metodo usado para buscar ususarios
        public ActionResult<List<UsuarioModel>> BuscarTodosUsuarios() 
        {
            return Ok();
        }
    }
}

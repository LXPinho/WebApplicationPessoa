using Microsoft.AspNetCore.Mvc;
using WebApplicationPessoa.Models;
using WebApplicationPessoa.Repository;

namespace WebApplicationPessoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<PessoaModel>> BuscarTodasPessoas(int? id)
        {
            return Ok(new ListaReporitory().GetListaPessoaModel(id));
        }
        [HttpPost]
        public ActionResult AdicionarPessoa(int? id, string? nome, string? email, string? telefone)
        {
            return Ok(new ListaReporitory().AdicionarPessoa(id, nome, email, telefone));
        }
        [HttpPut]
        public ActionResult AlterarPessoa(int id, string? nome, string? email, string? telefone)
        {
            return Ok(new ListaReporitory().AlterarPessoa(id, nome, email, telefone));
        }
        [HttpDelete]
        public ActionResult DeletePessoa(int id)
        {
            return Ok(new ListaReporitory().DeletarPessoa(id));
        }
    }
}

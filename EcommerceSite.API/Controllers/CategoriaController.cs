using EcommerceSite.Aplicacao.Servicos;
using EcommerceSite.Aplicacao.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaServico _categoriaServico;

        public CategoriaController(ICategoriaServico categoriaServico)
        {
            _categoriaServico = categoriaServico;
        }

        [HttpPost]
        public IActionResult Criar(CategoriaViewModel categoriaVw)
        {
            var retorno = _categoriaServico.Criar(categoriaVw);

            return Ok(retorno);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(CategoriaViewModel categoriaVw, int id)
        {
            if (categoriaVw.Id != id)
            {
                return BadRequest();
            }

            var retorno = _categoriaServico.Editar(categoriaVw);

            return Ok(retorno);
        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
            _categoriaServico.Excluir(id);

            return Ok();
        }

        [HttpGet]
        public IActionResult Obter(string descricao)
        {
            var retorno = _categoriaServico.Obter(descricao);

            return Ok(retorno);
        }
    }
}

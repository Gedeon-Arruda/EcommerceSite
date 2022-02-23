using EcommerceSite.Aplicacao.Servicos;
using EcommerceSite.Aplicacao.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace EcommerceSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoController(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        [HttpPost]
        public IActionResult Criar(ProdutoViewModel produtoVw)
        {
            var retorno = _produtoServico.Criar(produtoVw);

            return Ok(retorno);
        }

        [HttpPut("{id}")]
        public IActionResult EditarProduto(ProdutoViewModel produtoVw, int id)
        {
            if (produtoVw.Id != id)
            {
                return BadRequest();
            }

            var retorno = _produtoServico.EditarProduto(produtoVw);

            return Ok(retorno);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            if (id <=0)
            {
                return NotFound();
            }

            var retorno = _produtoServico.ObterPorId(id);

            return Ok(retorno);
        }

        [HttpDelete]
        public IActionResult Excluir(int id)
        {
             _produtoServico.Excluir(id);

            return Ok();
        }

        [HttpGet]
        public IActionResult Obter([FromQuery] string descricao)
        {
            var retorno = _produtoServico.Obter(descricao);
            return Ok(retorno);
        }

        [HttpGet("filtrar-preco/{preco}")]
        public IActionResult ObterProdutosPorPreco(double preco)
        {            
            var retorno = _produtoServico.ObterProdutosPorPreco(preco);
            return Ok(retorno);
        }
    }
}

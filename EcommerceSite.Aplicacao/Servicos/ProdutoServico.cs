using EcommerceSite.Aplicacao.ViewModel;
using EcommerceSite.Infraestrutura.Contexto;
using EcommerceSite.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceSite.Aplicacao.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly EcommerceSiteDbContext _ctx;

        public ProdutoServico(EcommerceSiteDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<ProdutoViewModel> Obter(string descricao)
        {
            var produtosQuery = _ctx.Produtos.AsQueryable();  //.OrderBy(p => p.Descricao).ThenBy(p => p.Preco);

            //var contemIgualdade = _ctx.Produtos.Any(p => p.Descricao == descricao).ToString();

            //produtosQuery = produtosQuery.Where(p => string.IsNullOrWhiteSpace(descricao) || p.Descricao.Contains(descricao));

            if (!string.IsNullOrWhiteSpace(descricao))
            {
                produtosQuery = produtosQuery.Where(p => p.Descricao.Contains(descricao));
            }

            //foreach (var item in produtosQuery)
            //{                
            //}

            var produtos = produtosQuery.OrderBy(p => p.Descricao).ThenBy(p => p.Preco).ToList();

            return produtos.Select(x => new ProdutoViewModel(x)).ToList();
        }

        public ProdutoViewModel ObterPorId(int id)
        {
            var produto = _ctx.Produtos.SingleOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return null;
            }

            return new ProdutoViewModel(produto);
        }

        public ProdutoViewModel Criar(ProdutoViewModel produtoVw)
        {
            var duplicado = _ctx.Produtos.Any(p => p.Descricao == produtoVw.Descricao);            

            if (duplicado)
            {
                return null;
            }

            var produto = new Produto(produtoVw.Descricao, produtoVw.Preco);

            _ctx.Produtos.Add(produto);

            _ctx.SaveChanges();

            return new ProdutoViewModel(produto);            
        }

        public ProdutoViewModel EditarProduto(ProdutoViewModel produtoVw)
        {
            //var duplicado = _ctx.Produtos.Any(p => p.Descricao == produtoVw.Descricao && p.Id != produtoVw.Id);
            var produto = _ctx.Produtos.FirstOrDefault(p => p.Id == produtoVw.Id);

            //if (duplicado)
            //{
            //    return null;               
            //}            

            if (produto == null)
            {
                return null;
            }

            produto.Descricao = produtoVw.Descricao;

            produto.Preco = produtoVw.Preco;
            //produto.Id = produtoVw.Id;

            //_ctx.Produtos.Update(produto);
            _ctx.SaveChanges();

            return new ProdutoViewModel(produto);
        }

        public void Excluir(int id)
        {
            var produto = _ctx.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto != null)
            {
                _ctx.Remove(produto);

                _ctx.SaveChanges();
            }           
        }
        public List<string> ObterProdutosPorPreco(double preco)
        {
            var produtosDescricao = _ctx.Produtos.Where(p => p.Preco >= preco).Select(p => p.Descricao).ToList();

            return produtosDescricao;            
        }
    }
}

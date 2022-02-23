using EcommerceSite.Aplicacao.ViewModel;
using EcommerceSite.Infraestrutura.Contexto;
using EcommerceSite.Negocio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceSite.Aplicacao.Servicos
{
    public class CategoriaServico : ICategoriaServico
    {
        private readonly EcommerceSiteDbContext _ctx;

        public CategoriaServico(EcommerceSiteDbContext ctx)
        {
            _ctx = ctx;
        }

        public CategoriaViewModel Criar(CategoriaViewModel categoriaVw)
        {
            var duplicado = _ctx.Categorias.Any(p => p.Descricao == categoriaVw.Descricao);

            if (duplicado)
            {
                return null;
            }

            var categoria = new Categoria(categoriaVw.Descricao);

            _ctx.Categorias.Add(categoria);

            _ctx.SaveChanges();

            return new CategoriaViewModel(categoria);
        }

        public CategoriaViewModel Editar(CategoriaViewModel categoriaVw)
        {
            var categoria = _ctx.Categorias.FirstOrDefault(p => p.Id == categoriaVw.Id);          

            if (categoria == null)
            {
                return null;
            }

            categoria.Descricao = categoriaVw.Descricao;

            _ctx.SaveChanges();

            return new CategoriaViewModel(categoria);
        }

        public void Excluir(int id)
        {
            var categoria = _ctx.Categorias.FirstOrDefault(p => p.Id == id);

            if (categoria != null)
            {
                _ctx.Remove(categoria);

                _ctx.SaveChanges();
            }
        }

        public List<CategoriaViewModel> Obter(string descricao)
        {
            var categoriasQuery = _ctx.Categorias.AsQueryable(); 

            if (!string.IsNullOrWhiteSpace(descricao))
            {
                categoriasQuery = categoriasQuery.Where(p => p.Descricao.Contains(descricao));
            }

            var categorias = categoriasQuery.OrderBy(p => p.Descricao).ToList();

            return categorias.Select(x => new CategoriaViewModel(x)).ToList();
        }
    }
}

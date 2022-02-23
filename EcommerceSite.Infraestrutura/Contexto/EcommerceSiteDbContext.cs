using EcommerceSite.Negocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EcommerceSite.Infraestrutura.Contexto
{
    public class EcommerceSiteDbContext : DbContext
    {
        public EcommerceSiteDbContext(DbContextOptions<EcommerceSiteDbContext> options) :base (options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        
    }
}

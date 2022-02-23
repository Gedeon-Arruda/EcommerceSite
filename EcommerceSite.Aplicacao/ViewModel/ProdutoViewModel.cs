using EcommerceSite.Negocio.Entidades;

namespace EcommerceSite.Aplicacao.ViewModel
{
    public class ProdutoViewModel
    {
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Id { get; set; }

        public ProdutoViewModel()
        {

        }

        public ProdutoViewModel(Produto produto)
        {
            Descricao = produto.Descricao;
            Preco = produto.Preco;
            Id = produto.Id;
        }
    }

}

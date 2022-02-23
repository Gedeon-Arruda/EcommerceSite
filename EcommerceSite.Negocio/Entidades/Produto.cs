namespace EcommerceSite.Negocio.Entidades
{
    public class Produto : EntidadeBase
    {        
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(string descricao, double preco)
        {
            Descricao = descricao;
            Preco = preco;
        }
    }
}

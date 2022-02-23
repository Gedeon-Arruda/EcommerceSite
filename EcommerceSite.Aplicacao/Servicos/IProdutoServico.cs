using EcommerceSite.Aplicacao.ViewModel;
using System.Collections.Generic;

namespace EcommerceSite.Aplicacao.Servicos
{
    public interface IProdutoServico
    {
        List<ProdutoViewModel> Obter(string descricao);
        List<string> ObterProdutosPorPreco(double preco);
        ProdutoViewModel ObterPorId(int id);
        ProdutoViewModel Criar(ProdutoViewModel produtoVw);
        ProdutoViewModel EditarProduto(ProdutoViewModel produtoVw);       
        void Excluir(int id);

    }
}
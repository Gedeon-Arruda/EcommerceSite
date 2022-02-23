using EcommerceSite.Aplicacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceSite.Aplicacao.Servicos
{
    public interface ICategoriaServico
    {
        List<CategoriaViewModel> Obter(string descricao);
        CategoriaViewModel Criar(CategoriaViewModel categoriaVw);
        CategoriaViewModel Editar(CategoriaViewModel categoriaVw);
        void Excluir(int id);
    }
}

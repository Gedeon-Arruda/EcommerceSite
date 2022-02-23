using EcommerceSite.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceSite.Aplicacao.ViewModel
{
    public class CategoriaViewModel
    {
        public string Descricao { get; set; }
        public int Id { get; set; }

        public CategoriaViewModel()
        {
        }

        public CategoriaViewModel(Categoria categoria)
        {
            Descricao = categoria.Descricao;
            Id =  categoria.Id;
        }
    }
}

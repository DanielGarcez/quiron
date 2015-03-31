using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidade;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.ViewModels
{
    public class ProdutoVM
    {
        #region Propriedades
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _produtosRepositorio;
        private int _produtosPorPagina = 8;

        public ActionResult ListaProdutos(int pagina = 1)
        {
            _produtosRepositorio = new ProdutosRepositorio();
            var produtos = _produtosRepositorio.Produtos
                                               .OrderBy(p => p.Nome)
                                               .Skip((pagina-1)*_produtosPorPagina)
                                               .Take(_produtosPorPagina);
            return View(produtos);
        }
    }
}
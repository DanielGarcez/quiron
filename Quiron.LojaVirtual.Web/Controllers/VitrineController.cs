using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.ViewModels;

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

            ProdutoVM model = new ProdutoVM
            {
                Produtos = produtos,

                Paginacao = new Paginacao
                {
                    ItensPorPagina = _produtosPorPagina,
                    PaginaAtual = pagina,
                    ItensTotal = _produtosRepositorio.Produtos.Count()

                }

            };



            return View(model);
        }
    }
}
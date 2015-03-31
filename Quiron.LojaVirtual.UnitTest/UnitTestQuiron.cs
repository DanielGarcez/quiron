using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuiron
    {


        #region Paginacao
        [TestMethod]
        public void VerificaPaginacao()
        {

            // Arrange
            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                ItensPorPagina = 10,
                PaginaAtual = 2,
                ItensTotal = 28
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            // ACT
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);


            // Assert
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Pagina1"">1</a>" +
                            @"<a class=""btn btn-primary selected"" href=""Pagina2"">2</a>" +
                            @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString());

        }
        #endregion
    }
}

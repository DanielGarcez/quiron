using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {


        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            try
            {
                StringBuilder resultado = new StringBuilder();

                for (int i = 1; i <= paginacao.PaginasTotal; i++)
                {
                    TagBuilder tag = new TagBuilder("a");
                    tag.MergeAttribute("href", paginaUrl(i));
                    tag.InnerHtml = i.ToString();

                    if (i == paginacao.PaginaAtual)
                    {
                        tag.AddCssClass("selected");
                        tag.AddCssClass("btn btn-primary");
                    }
                    else
                    {
                        tag.AddCssClass("btn btn-default");
                    }

                    resultado.Append(tag);
                }

                return MvcHtmlString.Create(resultado.ToString());
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }



    }
}
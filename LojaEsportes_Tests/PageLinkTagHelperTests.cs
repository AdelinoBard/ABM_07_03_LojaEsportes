using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using LojaEsportes_WebApp.Infrastructure;
using LojaEsportes_WebApp.Models.ViewModels;
using Xunit;

namespace LojaEsportes_WebApp.Tests {
    public class PageLinkTagHelperTests {
        [Fact]
        public void Can_Generate_Page_Links() {
            // Arrange
            var urlHelper = new Mock<IUrlHelper>();
            urlHelper.SetupSequence(x => x.Action(It.IsAny<UrlActionContext>()))
                .Returns("Test/Page1")
                .Returns("Test/Page2")
                .Returns("Test/Page3");
            var urlHelperFactory = new Mock<IUrlHelperFactory>();
            urlHelperFactory.Setup(f =>
                    f.GetUrlHelper(It.IsAny<ActionContext>()))
                        .Returns(urlHelper.Object);
            var viewContext = new Mock<ViewContext>();
            PageLinkTagHelper helper =
                    new PageLinkTagHelper(urlHelperFactory.Object) {
                        PageModel = new PagingInfo {
                            CurrentPage = 2,
                            TotalItems = 28,
                            ItemsPerPage = 10
                        },
                        ViewContext = viewContext.Object,
                        PageAction = "Test"
                    };
            TagHelperContext ctx = new TagHelperContext(
                new TagHelperAttributeList(),
                new Dictionary<object, object>(), "");
            var content = new Mock<TagHelperContent>();
            TagHelperOutput output = new TagHelperOutput("div",
                new TagHelperAttributeList(),
                (cache, encoder) => Task.FromResult(content.Object));
            // Act
            helper.Process(ctx, output);
            // Assert
            Assert.Equal(@"<a href=""Test/Page1"">1</a>"
                + @"<a href=""Test/Page2"">2</a>"
                + @"<a href=""Test/Page3"">3</a>",
                 output.Content.GetContent());
        }
    }
}

/*
A complexidade neste teste está na criação dos objetos que são necessários para criar e usar um tag helper. Os tag helpers usam objetos IUrlHelperFactory para gerar URLs que visam diferentes partes do aplicativo, e eu usei o Moq para criar uma implementação desta interface e da interface IUrlHelper relacionada que fornece dados de teste.

A parte central do teste verifica a saída do auxiliar de tag usando um valor de string literal que contém aspas duplas. C# é perfeitamente capaz de trabalhar com tais strings, desde que a string seja prefixada com @ e use dois conjuntos de aspas duplas ("") no lugar de um conjunto de aspas duplas. Você deve se lembrar de não quebrar a string literal em linhas separadas, a menos que a string com a qual você está comparando esteja quebrada de forma semelhante. Por exemplo, o literal que eu uso no método de teste foi quebrado em várias linhas porque a largura de uma página impressa é estreita. Eu não adicionei um caractere de nova linha; se eu adicionasse, o teste falharia.

*/
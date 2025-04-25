namespace LojaEsportes_WebApp.Models.ViewModels {
    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
            = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new();
        public string? CurrentCategory { get; set; }
    }
}

/*
Ainda preciso fornecer uma instância da classe de modelo de visualização PagingInfo para a visualização. Para fazer isso, adicionei um arquivo de classe chamado ProductsListViewModel.cs

na pasta Models/ViewModels. Esta classe contém duas propriedades: Products, que é uma coleção de produtos, e PagingInfo, que contém informações sobre a paginação. A propriedade Products é inicializada como uma coleção vazia para evitar erros de referência nula. A propriedade PagingInfo é inicializada com uma nova instância da classe PagingInfo.

A classe ProductsListViewModel é usada para passar dados da ação do controlador para a visualização. O controlador preenche a propriedade Products com uma lista de produtos e a propriedade PagingInfo com informações sobre a paginação. A visualização usa essas propriedades para exibir os produtos e os links de paginação.
*/
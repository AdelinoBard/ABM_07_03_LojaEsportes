namespace LojaEsportes_WebApp.Models.ViewModels {
    public class PagingInfo {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}

/*
## Adicionando o modelo de visualização
Para dar suporte ao auxiliar de tag, necessário passar informações para a visualização sobre o número de páginas disponíveis, a página atual e o número total de produtos no repositório. A maneira mais fácil de fazer isso é criar uma classe de modelo de visualização, que é usada especificamente para passar dados entre um controlador e uma visualização. Crie uma pasta Models/ViewModels no projeto, adicione a ela um arquivo de classe chamado PagingInfo.cs e defina conforme acima.
*/
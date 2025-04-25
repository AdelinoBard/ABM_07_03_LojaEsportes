using LojaEsportes_WebApp.Models;

namespace LojaEsportes_WebApp.Models 
{
    public class EFStoreRepository : IStoreRepository 
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx) 
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}

/*
A classe EFStoreRepository implementa a interface IStoreRepository e fornece acesso ao banco de dados por meio da propriedade Products. O construtor EFStoreRepository recebe um objeto StoreDbContext, que é injetado pelo ASP.NET Core. Isso significa que o ASP.NET Core cria uma instância do repositório e a injeta em qualquer controlador que precise dela. Isso é feito por meio do recurso de injeção de dependência do ASP.NET Core, que permite que os serviços sejam registrados e resolvidos automaticamente pelo contêiner de injeção de dependência.
*/
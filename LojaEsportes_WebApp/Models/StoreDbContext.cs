// storeDbContext.cs

using Microsoft.EntityFrameworkCore;
using LojaEsportes_WebApp.Models;

namespace LojaEsportes_WebApp.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();
    }
}

/*
A classe base DbContext fornece acesso à funcionalidade subjacente do Entity Framework Core, e a propriedade Products fornecerá acesso aos objetos Product no banco de dados. A classe StoreDbContext é derivada de DbContext e adiciona as propriedades que serão usadas para ler e gravar os dados do aplicativo. Há apenas uma propriedade por enquanto, que fornecerá acesso aos objetos Product.
*/
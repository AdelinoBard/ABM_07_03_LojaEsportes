using Microsoft.EntityFrameworkCore;

namespace LojaEsportes_WebApp.Models {
    public static class SeedData {
        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }
            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "Kayak", Description = "A boat for one person",
                        Category = "Watersports", Price = 275
                    },
                    new Product {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports", Price = 48.95m
                    },
                    new Product {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer", Price = 19.50m
                    },
                    new Product {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer", Price = 34.95m
                    },
                    new Product {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer", Price = 79500
                    },
                    new Product {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess", Price = 16
                    },
                    new Product {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess", Price = 29.95m
                    },
                    new Product {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess", Price = 75
                    },
                    new Product {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess", Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

/*
Para preencher o banco de dados e fornecer alguns dados de amostra, adicione um arquivo de classe chamado `SeedData.cs` à pasta _Modelos_.

O método estático `EnsurePopulated` recebe um argumento `IApplicationBuilder`, que é a interface usada no arquivo Program.cs para registrar componentes de middleware para manipular solicitações HTTP. 

IApplicationBuilder também fornece acesso aos serviços do aplicativo, incluindo o serviço de contexto de banco de dados Entity Framework Core.

O método EnsurePopulated obtém um objeto StoreDbContext por meio da interface IApplicationBuilder e chama o método Database.Migrate se houver alguma migração pendente, o que significa que o banco de dados será criado e preparado para que possa armazenar objetos Product. Em seguida, o número de objetos Product no banco de dados é verificado. Se não houver objetos no banco de dados, o banco de dados será preenchido usando uma coleção de objetos Product usando o método AddRange e, em seguida, gravado no banco de dados usando o método SaveChanges.

A alteração final é semear o banco de dados quando o aplicativo for iniciado, necessário adicionar uma chamada ao método EnsurePopulated do arquivo Program.cs;

SeedData.EnsurePopulated(app);

*/

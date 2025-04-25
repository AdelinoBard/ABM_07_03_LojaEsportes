namespace LojaEsportes_WebApp.Models {
    public interface IStoreRepository {
        IQueryable<Product> Products { get; }
    }
}

/*
Esta interface usa `IQueryable<T>`; para permitir que um chamador obtenha uma sequência de objetos Product. 

A interface `IQueryable<T>` é derivada da interface mais familiar `IEnumerable<T>` e representa uma coleção de objetos que podem ser consultados, como aqueles gerenciados por um banco de dados.

Uma classe que depende da interface `IStoreRepository` pode obter objetos Product sem precisar saber os detalhes de como eles são armazenados ou como a classe de implementação os entregará.
*/

/*
## ENTENDENDO AS INTERFACES `IENUMERABLE<T>` E `IQUERYABLE<T>`

A interface IQueryable<T> é útil porque permite que uma coleção de objetos seja consultada de forma eficiente. Mais adiante neste capítulo, adiciono suporte para recuperar um subconjunto de objetos Product de um banco de dados, e usar a interface IQueryable<T> me permite pedir ao banco de dados apenas os objetos que preciso usando instruções LINQ padrão e sem precisar saber qual servidor de banco de dados armazena os dados ou como ele processa a consulta. Sem a interface IQueryable<T>, eu teria que recuperar todos os objetos Product do banco de dados e então descartar aqueles que não quero, o que se torna uma operação cara à medida que a quantidade de dados usada por um aplicativo aumenta. É por esse motivo que a interface IQueryable<T> é normalmente usada em vez de IEnumerable<T> em interfaces e classes de repositório de banco de dados.

No entanto, é preciso ter cuidado com a interface IQueryable<T> porque cada vez que a coleção de objetos é enumerada, a consulta será avaliada novamente, o que significa que uma nova consulta será enviada ao banco de dados. Isso pode prejudicar os ganhos de eficiência do uso de IQueryable<T>. Em tais situações, você pode converter a interface IQueryable<T> para um formato mais previsível usando o método de extensão ToList ou ToArray.
*/
@*

1. A declaração `@using` me permitirá usar os tipos no namespace `LojaEsportes_WebApp.Models` em visualizações sem precisar fazer referência ao namespace.

2. A declaração `@addTagHelper` habilita os auxiliares de tag integrados.

A maioria dos componentes do ASP.NET Core, como controladores e visualizações, são descobertos automaticamente, mas os auxiliares de tag precisam ser registrados. Adiono uma instrução ao arquivo _ViewImports.cshtml na pasta Views que informa ao ASP.NET Core para procurar classes auxiliares de tag no projeto. Também adicionei uma expressão @using para que eu possa me referir às classes do modelo de visualização em visualizações sem ter que qualificar seus nomes com o namespace.



*@ 

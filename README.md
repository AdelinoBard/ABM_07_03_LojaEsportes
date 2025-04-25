# LojaEsportes

O modelo de carrinho (Cart) foi inicialmente armazenado como dados de sessão, gerenciado pela Página Razor Cart, mas essa abordagem exige duplicar código em outras páginas ou controladores. Para resolver isso, a seção propõe usar o recurso de **serviços** do ASP.NET Core, simplificando a gestão do objeto Cart. Além de ocultar os detalhes de implementação das interfaces, os serviços permitem remodelar a aplicação e otimizar processos, mesmo com classes concretas como Cart.

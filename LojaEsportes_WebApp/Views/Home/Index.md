
@* O Razor View é um arquivo de visualização que contém HTML e C# para renderizar a interface do usuário. Neste exemplo, o Razor View exibe uma lista de produtos.

A expressão @model no topo do arquivo especifica que a visualização espera receber uma sequência de objetos Product do método action como seus dados de modelo. 

É usada uma expressão @foreach para trabalhar na sequência e gerar um conjunto simples de elementos HTML para cada objeto Product que é recebido.

Há uma peculiaridade nesta maneira como o Razor Views funciona que significa que os dados do modelo são sempre anuláveis, mesmo quando o tipo especificado pela expressão @model não é. Por esse motivo, uso o operador null-coalescing na expressão @foreach com uma enumeração vazia.

A visualização não sabe de onde os objetos Product vieram, como foram obtidos ou se representam todos os produtos conhecidos pelo aplicativo. Em vez disso, a visualização lida apenas com como os detalhes de cada Product são exibidos usando elementos HTML.

> Dica: Converti a propriedade Price para uma string usando o método ToString("c"), que renderiza valores numéricos como moeda de acordo com as configurações de cultura que estão em vigor no seu servidor. Isso significa que o valor exibido pode ser diferente dependendo de onde o aplicativo estiver sendo executado. Você pode alterar a cultura do servidor no arquivo appsettings.json, alterando a propriedade DefaultCulture para pt-BR ou en-US, por exemplo. Isso afetará todos os valores numéricos exibidos no aplicativo.

Peguei a marcação que estava anteriormente na expressão @foreach na visualização Index.cshtml e a movi para a nova visualização parcial. Chamo a visualização parcial usando um elemento parcial, usando os atributos name e model para especificar o nome da visualização parcial e seu modelo de visualização. Usar uma visualização parcial permite que a mesma marcação seja inserida em qualquer visualização que precise exibir um resumo de um produto. Isso reduz a duplicação de código e torna o aplicativo mais fácil de manter. Você pode usar a visualização parcial em qualquer lugar do aplicativo, incluindo outras visualizações parciais. A visualização parcial é renderizada em uma visualização pai usando a diretiva @Html.Partial. A diretiva @Html.Partial aceita o nome da visualização parcial e o modelo a ser passado para ela. Você pode usar a visualização parcial em qualquer lugar do aplicativo, incluindo outras visualizações parciais. A visualização parcial é renderizada em uma visualização pai usando a diretiva @Html.Partial. A diretiva @Html.Partial aceita o nome da visualização parcial e o modelo a ser passado para ela. Você pode usar a visualização parcial em qualquer lugar do aplicativo, incluindo outras visualizações parciais.

*@


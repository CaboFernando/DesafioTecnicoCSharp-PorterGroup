# Desafio Técnico C# - Porter Group

1) - Como você implementou a função que retorna a representação por extenso
do número no desafio 1? Quais foram os principais desafios encontrados?

R: 
No desafio 1, a função ConverteNumerosEmPalavras() foi implementada usando recursividade para reduzir a reescrita de valores por extenso.

A primeira verificação, é se o número digitado é negativo. Se for, ele adiciona a palavra "menos" antes e segue para escrita normalmente, como se fosse positivo.

Após isso, se verifica se o número é menor que 20, pois tem diferenças das demais dezenas.

Se o número >= 20 && número < 100, se separa em duas partes: os dígitos da dezena e os dígitos da unidade. As dezenas se pega dividindo o número por 10 e procurando o nome correspondente no array de dezenas[]. Os dígitos da unidade obtem-se calculando o resto da divisão por 10 e nocamente a função ConverteNumerosEmPalavras() para convertê-la por extenso. Se as da unidade forem != de 0, a escrita das unidade é concatenada a parte da dezena usando a palavra "e".

Se o número >= 100 && número < 1000, segue igual, dividindo o número em três partes: centena, dezena e unidade. Nas centenas se divide o número por 100 e procura o nome no array centenas[]. A parte dos dígitos da dezena e da unidade são obtidas usando a mesma lógica explicada anteriormente.

A função continua a abordagem recursiva para números maiores, como mil (1000), milhão (1.000.000). Cada vez que a função é chamada recursivamente, ela divide o número em partes menores e adiciona as palavras adequadas para formar a representação por extenso completa.

Um dos principais desafios dessa implementação é lidar com os diferentes intervalos de números e garantir que as palavras sejam concatenadas corretamente. Ja tinha em mente que números menores que 20 deverias ter a particularidade. Mas oque mais me travou foi tentar pela recursão não repetir nenhuma palavra, uma vez que todas já estavam nos arrays, mesmo assim o "cem" e o "mil" se repetiram, pois a lógica estava ficando muito complexa apenas para colocar a palavra recursivamente.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2) Como você lidou com a performance na implementação do desafio 2,
considerando que o array pode ter até 1 milhão de números?

R:
No desafio 2, lidei com a perfomace utilizando a soma dos números em um loop simples e direto, de forma mais eficiente para o array que tem projeção de até um mihão de posições.
Utilizei também de boas práticas como o método SomarNumeros que tem como objetivo e ação específica, e também variáries locais.
No geral a implementação ficou bem simples, mas também está bem otimizada, uma vez que dos métodos tradicionais de loop, o for é um mais indicado quando se trata de iterar grande número de elementos.
Apesar de simples, pesquisei uma melhor forma de implementar a função lotes e também métodos async com Task, mas sinceramente se me questionassem não saberia explicar com clareza, então resolvei apostar no básico, limpo e bem escrito que finciona bem.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

3) Como você lidou com os possíveis erros de entrada na implementação do
desafio 3, como uma divisão por zero ou uma expressão inválida?

No desafio 3, utilizei antes do processamento substito todos os espaços da expressão para padronizar e evitar erros, verifico se a string está nula ou vazia, método HasErros da biblioteca de calculo usada NCalc e também valido divisões por zero através do Contains("/0"). Utilizo também o método HasError da Expression criada com a biblioteca NCalc para verificar erros na expressão. E após todas essas etapas no processamento da expressão, uso tratamento de erros com try-catch para verificar e tratar expressões inválidas ou erros de execução.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

4) Como você implementou a função que remove objetos repetidos na
implementação do desafio 4? Quais foram os principais desafios
encontrados?

No desafio 4, o enunciado ficou meio simplório não definindo limitações ou a permanência da ordem da lista original com a lista nova com dados únicos então de inicio criei um méto simples que recebe uma lista genérica e através do HashSet cria uma lista com base na lista de entrada só que sem repetições.
O principal desafio foi criar uma entrada de dados dinâmica de acordo com o que o usuário digitasse, ao invés de "chumbar" os valores via código.
Separar a entrada de dados em um método específico ajudou bastante a generalizar o código sendo possível a input de dados de qualquer tipo, sendo o código capaz de aceitar string, int, double e dateTime.

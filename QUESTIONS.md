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
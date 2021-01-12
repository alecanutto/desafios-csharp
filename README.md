# DESAFIOS C#

### Exercícios desenvolvidos durante os estudos do bootcamp .Net Fundamentals no site Digital Innovation One.

**Desafio 1 - Dividindo x por y**

Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

**Entrada**
A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

**Saída**

Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo. 

| Exemplo de Entrada | Exemplo de Saída   |
| ------------------ | ------------------ |
| 3                  |                    |
| 3 -2               | -1.5               |
| -8 0               | divisao impossivel |
| 0 8                | 0.0                |

________________________________________________________________________________

**Desafio 2 - Distância**

Duas motos (X e Y) partem em uma mesma direção. A moto X sai com velocidade constante de 60 Km/h e a moto Y sai com velocidade constante de 90 Km/h.

Em uma hora (60 minutos) a moto Y consegue se distanciar 30 quilômetros da moto X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.

O seu desafio é ler a distância (em Km) e calcular quanto tempo leva (em minutos) para a moto Y tomar essa distância da outra moto.

**Entrada**

O arquivo de entrada contém um número inteiro **K** que representa a quantidade de quilômetro que que a moto Y deve estar da moto X.

**Saída**

Imprima o tempo necessário para a moto Y ficar com a quantidade **K** de quilômetro da moto X, seguido da mensagem " minutos". 

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 30                 | 60 minutos       |
| 110                | 220 minutos      |

______________

**Desafio 3 - Quanta Mandioca?**

Os meses de Junho e Julho são tradicionalmente conhecidos por todo Brasil por suas festas típicas, e para o grupo de amigos da Marlene não é diferente, toda segunda quinzena do mês de Julho ela e seus amigos se reunem para tradicional mandiocada! Na festiva sempre se reúnem na casa da Marlene, o Chico, o Beto, o Bernardo, a Marina e a Iara. E como não poderia ser diferente o prato principal dessa reunião é a mandioca. Cada um deles come de uma a dez porções de mandioca e eles sempre avisam a Marlene com antecedência a respeito de quantas porções irão comer nesse dia. O tamanho da porção de cada um é diferente, mas sempre são os mesmos. As porções são as seguintes (em gramas):

- O Chico come 300
- O Bento come 1500
- O Bernardo come 600
- A Marina 1000
- A Iara come 150

Marlene por sua vez sempre come 225 gramas de mandioca. Cansada de todo ano ter que calcular quanta mandioca preparar ela te desafiou para escrever um programa que informe quanta mandioca deve ser preparada em gramas.

**Entrada**

A entrada consiste de 5 inteiros cada um representando as porções que os convidados de dona Chica vão consumir. O primeiro inteiro representa as porções do Chico, o segundo do Bento, o terceiro do Bernardo, o quarto da Marina e o quinto a da Iara.

**Saída**

A saída consiste de um único inteiro que representa quanta mandioca Marlene deve preparar em gramas.

| Exemplos de Entrada | Exemplos de Saída |
| ------------------- | ----------------- |
| 1                   | 3775              |
| 1                   |                   |
| 1                   |                   |
| 1                   |                   |
| 1                   |                   |
| 2                   | 7325              |
| 2                   |                   |
| 2                   |                   |
| 2                   |                   |
| 2                   |                   |

______

**Desafio 4 - Bazinga!**

Em um episódio da aclamada série The Big Ban Theor dois pernagens, Sheldon e Raj, discutem qual dos dois é o melhor: o filme *Saturn 3* ou a série *Deep Space 9*. A sugestão de Raj para a resolução do impasse é uma disputa de Pedra-Papel-Tesoura. Contudo, Sheldon argumenta que, se as partes envolvidas se conhecem, entre 75% e 80% das disputas de Pedra-Papel-Tesoura terminam empatadas, e então sugere o Pedra-Papel-Tesoura-Lagarto-Spock.

As regras do jogo proposto são:

1. a tesoura corta o papel;
2. o papel embrulha a pedra;
3. a pedra esmaga o lagarto;
4. o lagarto envenena Spock;
5. Spock destrói a tesoura;
6. a tesoura decapita o lagarto;
7. o lagarto come o papel;
8. o papel contesta Spock;
9. Spock vaporiza a pedra;
10. a pedra quebra a tesoura.

Conhecendo os personagens, sabemos que caso Sheldon vencesse, ele gritaria a vitória com um "Bazinga!". Se Raj vencesse, Sheldon o acusaria de ter trapaceado. Agora, se desse empate, Sheldon não descansaria e insistira para jogarem de novo até que seja decidido. Sabendo dessas ações, faça um programa que imprima a provável reação de Sheldon.

**Entrada**

A entrada consiste em uma série de casos de teste. A primeira linha contém um inteiro positivo **T** (**T** ≤ 100), que representa o número de casos de teste. Cada caso de teste é representado por uma linha da entrada, contendo as escolhas de Sheldon e Raj, respectivamente, separadas por um espaço em branco. As escolhas possíveis são as personagens do jogo: pedra, papel, tesoura, lagarto e Spock.

**Saída**

Para cada caso de teste deverá ser impressa a mensagem "Caso #**t**: **R**", onde **t** é o número do caso de teste (cuja contagem se inicia no número um) e **R** é uma das três reações possíveis de Sheldon: "Bazinga!", "Raj trapaceou!", ou "De novo!".

| Exemplos de Entrada | Exemplos de Saída       |
| ------------------- | ----------------------- |
| 3                   |                         |
| papel pedra         | Caso #1: Bazinga!       |
| lagarto tesoura     | Caso #2: Raj trapaceou! |
| Spock Spock         | Caso #3: De novo!       |

_______

**Desafio 5 - Coxinha de Bueno**

Em 2015 um novo record foi alcançado na competição de Coxinhas de Bueno de Andrada, onde Mônica mandou pra dentro 43 coxinhas em apenas 10 minutos, passando seu antecessor que conseguiu comer, no mesmo tempo, 38 coxinhas em 2014.

O restaurante especializado em coxinhas do pequeno distrito de Bueno de Andrada, interior de São Paulo, organiza essa competição todos os anos, mas nunca conseguiram entrar para o livro dos recordes, o Guinness Book. Para isso, o restaurante precisa preencher informações sobre a competição, como o número de coxinhas consumidas pelos competidores durante o evento. 

Porém, como já foi informado, a especialidade deles é coxinha, não matemática, então será que você pode ajudá-los? Com base no número total de coxinhas consumidas e o número de participantes na competição, o dono do restaurante precisa que você desenvolva um programa para saber a quantidade média de coxinha que os participantes da competição conseguem devorar.

Ah, lembre que, em troca da sua ajuda, você poderá comer quantas coxinhas conseguir.

**Entrada**

A entrada consiste de uma única linha que contém dois inteiros **H** e **P** (1 ≤ **H, P** ≤ 1000) indicando respectivamente o número total de coxinhas consumidas e o número total de participantes na competição.

**Saída**

Seu programa deve produzir uma única linha com um número racional representando o número médio de coxinhas consumidas pelos participantes. O resultado deve ser escrito como um número racional com exatamente dois dígitos após o ponto decimal, arredondado se necessário. 

| Exemplos de Entrada | Exemplos de Saída |
| ------------------- | ----------------- |
| 10 90               | 0.11              |
| 840 11              | 76.36             |
| 1 50                | 0.02              |

_______

**Desafio 6 - Programa para Validação de Notas**

O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. Visando em resolver a situação, a diretora da escola contratou você para desenvolver um programa que leia as notas da primeira e da segunda avaliação de um aluno. Calcule e imprima a média semestral.

O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.

**Entrada**

O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, deve ser lido um valor inteiro **X** . O programa deve parar quando o valor lido para este **X** for igual a 2.

**Saída**

Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. Quando duas notas válidas forem lidas, deve ser impressa a mensagem “media = ” seguido do valor do cálculo.

Antes da leitura de **X** deve ser impressa a mensagem "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada novamente se o valor da entrada padrão para **X** for menor do que 1 ou maior do que 2, conforme o exemplo abaixo.

A média deve ser impressa com dois dígitos após o ponto decimal. 

| Exemplo de Entrada | Exemplo de Saída           |
| ------------------ | -------------------------- |
| -3.5               | nota invalida              |
| 3.5                |                            |
| 11.0               | nota invalida              |
| 10.0               | media = 6.75               |
|                    | novo calculo (1-sim 2-nao) |
| 4                  | novo calculo (1-sim 2-nao) |
| 1                  |                            |
| 8                  |                            |
| 9.0                | media = 8.50               |
|                    | novo calculo (1-sim 2-nao) |
| 2                  |                            |

____________________

**Desafio 7 - Compras no supermercado**

Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.

O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.

**Entrada**

A primeira linha de entrada contém um inteiro **N** (**N** < 100) com a quantidade de casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.

**Saída**

A saída contém **N** linhas, cada uma representando uma lista de compra, sem os itens repetidos e em ordem alfabética. 

| Exemplo de Entrada                       | Exemplo de Saída          |
| ---------------------------------------- | ------------------------- |
| 2                                        |                           |
| carne laranja suco picles laranja picles | carne laranja picles suco |
| laranja pera laranja pera pera           | laranja pera              |

______________

**Desafio 8 - Validador de senha com requisitos**

Pedro e Fernando são os desenvolvedores em uma startup e vão desenvolver o novo sistema de cadastro, e pediram a sua ajuda. Sua task é fazer o código que valide as senhas que são cadastradas, para isso você deve atentar aos requisitos a seguir:

- A senha deve conter, no mínimo, uma letra maiúscula, uma letra minúscula e um número;
- A mesma não pode ter nenhum caractere de pontuação, acentuação ou espaço;
- Além disso, a senha pode ter de 6 a 32 caracteres.

**Entrada**

A entrada contém vários casos de teste e termina com final de arquivo. Cada linha tem uma string **S**, correspondente a senha que é inserida pelo usuário no momento do cadastro.

**Saída**

A saída contém uma linha, que pode ser “Senha valida.”, caso a senha tenha cada item dos requisitos solicitados anteriormente, ou “Senha invalida.”, se um ou mais requisitos não forem atendidos. 

| Exemplo de Entrada         | Exemplo de Saída |
| -------------------------- | ---------------- |
| Digital Innovation One     | Senha invalida.  |
| AbcdEfgh99                 | Senha valida.    |
| DigitalInnovationOne123    | Senha valida.    |
| Digital Innovation One 123 | Senha invalida.  |
| Aass9                      | Senha invalida.  |
| Aassd9                     | Senha valida.    |

_______

**Desafio 9 - Fila do banco**

O banco que você trabalha sempre tem problemas para organizar as filas de atendimento dos clientes. 

Após uma reunião com a gerência ficou decidido que os clientes ao chegar na agência receberão uma senha numérica em seu aparelho de celular via sms e que a ordem da fila será dada não pela ordem de chegada, mas sim pelo número recebido via sms. Sendo, aqueles com número maior deverão ser atendidos primeiro. 

Então, dada a ordem de chegada dos clientes reordene a fila de acordo com o número recebido via sms, e diga quantos clientes não precisaram trocar de lugar nessa reordenação.

**Entrada**

A primeira linha contém um inteiro **N**, indicando o número de casos de teste a seguir.

Cada caso de teste inicia com um inteiro **M** (1 ≤ **M** ≤ 1000), indicando o número de clientes. Em seguida haverá **M** inteiros distintos **Pi** (1 ≤ **Pi** ≤ 1000), onde o **i**-ésimo inteiro indica o número recebido via sms do **i**-ésimo cliente.

Os inteiros acima são dados em ordem de chegada, ou seja, o primeiro inteiro diz respeito ao primeiro cliente a chegar na fila, o segundo inteiro diz respeito ao segundo cliente, e assim sucessivamente.

**Saída**

Para cada caso de teste imprima uma linha, contendo um inteiro, indicando o número de clientes que não precisaram trocar de lugar mesmo após a fila ser reordenada.

| Exemplo de Entrada | Exemplo de Saída |
| ------------------ | ---------------- |
| 3                  |                  |
| 3                  |                  |
| 100 80 90          | 1                |
| 4                  |                  |
| 100 120 30 50      | 0                |
| 4                  |                  |
| 100 90 30 25       | 4                |


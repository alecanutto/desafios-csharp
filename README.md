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
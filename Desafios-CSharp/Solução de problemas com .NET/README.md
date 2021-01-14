# DESAFIOS C#

#### https://digitalinnovation.one/

### Exercícios realizados durante o bootcamp .Net Fundamentals

#### SOLUÇÃO DE PROBLEMAS COM .NET

______

**Desafio 1 - Programa para Validação de Notas**

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

**Desafio 2 - Quanta Mandioca?**

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

_____

**Desafio 3 - Compras no supermercado**

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

**Desafio 4 - Validador de senha com requisitos**

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

**Desafio 5 - Fila do banco**

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




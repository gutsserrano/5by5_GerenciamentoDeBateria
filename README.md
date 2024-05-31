# Gerenciamento de Bateria 

Este Software possui o intuito de aplicar e explicar o Design Pattern **States**.<br>
Projeto solicitado pelo programa de estágio da **5by5 - Soluções de Software**.

## Explicando States

"O **State** é um padrão de projeto comportamental que permite que um objeto altere seu comportamento quando seu estado interno muda. Parece como se o objeto mudasse de classe." <br>

Como citado no texto acima, o **State** é um Design Pattern que aplica diferentes comportamentos a um objeto de acordo com seu estado. 
Isto é, o método "XPTO" pode ter resultado X caso o estado do context seja X da mesma forma que este mesmo método "XPTO" pode resultar Y caso o estado do contexto seja Y.

Desta forma, para seguir as regras deste padrão, deve existir um **CONTEXTO**, um **ESTADO** (abstrato, para servir como uma interface) e vários **ESTADOS CONCRETOS**. 
No qual o **CONTEXTO** possui um atributo do tipo estado, e o **ESTADO** possui um atributo do tipo contexto. Para que desta forma ambos se conversem e podem transitar entre diferentes estados.

### Analogia com o mundo real
Os botões e interruptores de seu smartphone comportam-se de forma diferente dependendo do estado atual do dispositivo:

- Quando o telefone está desbloqueado, apertar os botões leva eles a executar várias funções.
- Quando o telefone está bloqueado, apertar qualquer botão leva a desbloquear a tela.
- Quando a carga da bateria está baixa, apertar qualquer botão mostra a tela de carregamento.

## Aplicação do Software

O software escolhido foi um gerenciador de bateria de um Notebook, no qual ele analisa o estado do notebook em relação ao uso de bateria.

### Os estados do Notebook são:
- DESLIGADO
- LIGADO
- SEM BATERIA
- CARREGANDO

*Levando em conta uma regra que o Notebook não poode estar em mais de um estado ao mesmo tempo, por exemplo, não é possivel utilizar o notebook no estado ligado enquanto está carregando.

## Diagrama de classes

  ![DiagramaControleBateria](https://github.com/gutsserrano/5by5_GerenciamentoDeBateria/assets/64173743/0ddb88fe-2b06-4986-84c1-b3db68f4b99b)

Fonte: https://refactoring.guru/pt-br/design-patterns/state

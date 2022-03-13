# Specification Pattern

O Specification Pattern é um padrão onde tem o intuito de isolar e deixar claro uma unidade de regra de negócio, sendo possível serem reutilizadas dentro do código e encadeadas com outras regras utilizando lógica booleana.

Este repositório foi inspirado no artigo de Eric Evans e Martin Fowler sobre o Specification Pattern e está disponível neste [link](https://www.martinfowler.com/apsupp/spec.pdf).

Nesse repositório temos três estratégias de implementação do padrão. Hard Coded Specification, Parameterized Specification e Composite Specification.

- Hard Coded Specification: Basicamente é a implementação onde regras de negócio estão explicitas diretamente no código. 
- Parameterized Specification: Nessa implementação é possivel passar parametros no construtor das especificações, ou seja, a regra de negócio são definidas em tempo de execução.
- Composite Specification: É utilizado quando se quer encadear uma ou mais especificações. Isso é feito por meio de classes que vão auxiliar nesse encadeamento. 

No projeto SpecificationPattern desse repositório é uma aplicação console onde são gerados caminhões e cargas, e é verificado se os caminhões gerados estão dentro das especificações para determinada carga. 
# TPs C# | INFNET

Este repositório reúne as resoluções dos **Testes de Performance (TPs)** da disciplina de **Fundamentos de desenvolvimento com C#**, ministrada no curso de graduação em Análise e Desenvolvimento de Sistemas do **Instituto INFNET**.

Os Testes de Performance (TPs) fazem parte do modelo de avaliação da instituição e possuem caráter obrigatório dentro da disciplina. Seu principal objetivo é proporcionar a aplicação prática dos conteúdos estudados em aula por meio da resolução de problemas e atividades que estimulam o desenvolvimento do raciocínio lógico, a compreensão dos fundamentos da linguagem e a construção de soluções computacionais.

---

## 📖 Sobre o TP1

O primeiro Teste de Performance de C# teve como foco os fundamentos da linguagem, os conceitos iniciais de Programação Orientada a Objetos (POO), as estruturas de controle e o funcionamento do ecossistema .NET.

As atividades combinaram questões teóricas e práticas. Na parte teórica, foram explorados conceitos relacionados ao ambiente de execução .NET, compilação, IL, CLR e JIT, além da utilização de ferramentas como .NET SDK, Visual Studio e .NET CLI.

Na parte prática, foram desenvolvidas soluções envolvendo declaração e manipulação de variáveis, operações matemáticas, estruturas condicionais, estruturas de repetição, entrada e saída de dados, conversão e validação de informações e criação de classes e objetos.

Entre os principais conhecimentos trabalhados neste TP estão:

* fundamentos da linguagem C#;
* instalação e configuração do .NET SDK;
* CLR (Common Language Runtime);
* IL (Intermediate Language);
* compilador Roslyn e JIT (Just-In-Time Compiler);
* BCL (Base Class Library);
* utilização do .NET CLI;
* criação, compilação e execução de projetos com `dotnet new`, `dotnet build` e `dotnet run`;
* declaração e inicialização de variáveis;
* tipos de dados (`int`, `double`, `string` e `bool`);
* declaração de constantes utilizando `const`;
* operadores aritméticos e relacionais;
* operadores de incremento;
* estruturas condicionais (`if`, `else if` e `else`);
* estrutura `switch/case`;
* estruturas de repetição (`while` e `do-while`);
* utilização de `break` e `continue`;
* entrada e saída de dados com `Console.ReadLine()`, `Console.Write()` e `Console.WriteLine()`;
* conversão e validação de dados com `int.TryParse()` e `double.TryParse()`;
* interpolação de strings;
* conceitos iniciais de Programação Orientada a Objetos;
* criação e utilização de classes e objetos;
* atributos, métodos e construtores;
* modificadores de acesso (`public` e `private`);
* utilização de `this`;
* organização de projetos em diferentes arquivos `.cs`;
* namespaces e diretivas `using`;
* organização e reutilização de código.

### Projetos desenvolvidos

**Calculadora de Tarifas de Estacionamento**

Desenvolvimento de uma calculadora que recebe o tempo de permanência de um veículo e o valor cobrado por hora.

O programa calcula as horas completas, os minutos restantes e o valor final da tarifa, considerando que qualquer fração de hora iniciada é cobrada como hora cheia.

Também foi implementada uma comparação do valor calculado com um teto diário definido no código.

**Classificador de Permanência**

Criação de um programa que classifica os veículos em três categorias de permanência: rotativa curta, rotativa padrão e diária.

Posteriormente, o programa foi aprimorado com um laço `while`, permitindo classificar vários veículos consecutivamente, utilizar um valor sentinela para encerrar a execução e contabilizar a quantidade de veículos em cada categoria.

**Menu de Estacionamento**

Desenvolvimento de um menu interativo utilizando `switch` e `do-while`, reunindo as funcionalidades de cálculo de tarifas, conversão de duração e classificação de permanência.

O trabalho foi finalizado com a consolidação das funcionalidades em um único programa e a adição de uma opção Sobre, que apresenta a versão do .NET utilizando `Environment.Version`.

---

## 📁 Estrutura do Repositório

```plaintext
TPs-CSharp-INFNET/
│
├── TP1/
│   │
│   ├── questao-01/
│   ├── questao-02/
│   ├── questao-03/
│   ├── questao-04/
│   ├── questao-05/
│   ├── questao-06/
│   ├── questao-07/
│   └── questao-08/
│
└── README.md
```

## 📃 Observações
Os exercícios presentes neste repositório foram desenvolvidos como parte das atividades acadêmicas da disciplina de Fundamentos de desenvolvimento com C#.

As soluções refletem os conhecimentos trabalhados durante a realização dos Testes de Performance e foram construídas com foco na aplicação prática dos conceitos estudados, respeitando o nível de complexidade esperado para cada etapa da formação.

Este material possui finalidade educacional e representa uma etapa da minha trajetória acadêmica, registrando o desenvolvimento gradual de habilidades em lógica computacional, Programação Orientada a Objetos e desenvolvimento de software utilizando C#.

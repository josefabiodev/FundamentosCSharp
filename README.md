# Curso Fundamentos C#

## Variáveis:
    variáveis é algo que utilizamos para armazenar uma informação.
    variável porque o valor varia, pode ser mudado.

Podemos usar um TIPO ou a palavra reservada var para criar uma variável.
    No C# o tipo vem sempre antes do nome da variável.

    Utilize nomes coesos
    Não utilize caracteres especiais ou espaços
    Não comece com números
    A primeira letra de cada palavra é SEMPRE minúscula

## Constantes
    Também utilizamos uma constante para armazenar uma informação

    As constantes NÃO PODEM ser alteradas
    Uma vez criadas somos obrigados a atribuir um valor
    Feito isso, elas não podem ser modificadas novamente
    Não funcionam com a utilização de var
    São mais otimizadas que as variáveis
    Recomendadas para uso frequentes

Definições
    A definição de constantes é dada pela palavra reservada const antes do tipo
    Caso não seja informado um valor, o valor padrão será atribuído
    Utilize nomes coesos
    Não utilize caracteres especiaos ou espaços
    Não comece com números
    É comum vermos constantes todas em maísculas, separadas por "_"
    A ideia é bater o olho e saber que aquilo é uma cosntatnte

## Palavras reservadas
    Definições
        Também chamdas de keywords
        São palavreas de uso exclusivo do C#
        Não podemos utilizar como nomes de variáveis ou constantes

 ## Comentários
    /**/ - comentário de multiplas linhas
    // - comentário de uma linha
    /// <property> - anotação XMl que explica o que o item faz (metadados)

    Esses são os modos de fazer comentários no C#   

## Tipos primitivos
    Definições
        Também conhecidos como built-in types
        São tipos base cujo outros tipos (Complexos) irão derivar
        São chamados de Tipos de Valor 
        Armazena o valor e não a referência para um item na memória
        São classificados em:
            Tipos Simples (Simple Types)
            Enumeradores (Enums)
            Estruturas (Structs)
            Tipos Nulos (Nullable Types)

 ## System
    No .NET tudo começa de um tipo base chamado system
    Todo e qualquer tipo, seja built-in ou complexo, deriva dele
    Ele é a base de todos os objetos no .NET
    Seu uso já é implícito

## Byte
    O tipo byte é utilizado para representar um bute de fato
    Temos também o sbyte, que permite valores negativos

    Definições
        byte (8 bits)
            0 até 255
        sbyte (8 bit)
            -128 até 127

## Números inteiros
    Números inteiros, ou seja, sem pontuação, podem ser definidos pelos tipos:
        - short/ushort
        - int/uint
        - long/ulong
    O tipo int é o mais comum a ser encontrado

int: 32 bits.  de -2.147.483.648 a 2.147.483.647. 

long: 64 bits. de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807. 

short: 16 bits. de -32.768 a 32.767. 

ushort: 16 bits. de 0 a 65.535.

uint (Unsigned Integer): 32 bits. de 0 a 4.294.967.295.
É comumente usado quando você precisa armazenar valores inteiros que não podem ser negativos e não precisam de um intervalo de valores negativos.

ulong (Unsigned Long): 64 bits. de 0 a 18.446.744.073.709.551.615.
É usado quando você precisa armazenar valores inteiros sem sinal que tenham um intervalo de valores muito grande.

## Números reais
    Números que exigem uma maior precisão, ou seja, com pontuação
        - float (Notação F)
        - double
        - decimal (Notação M)
    Possuem assimilação negativa e positiva por padrão, dispensando uso do signed/unsigne em seus tipos

    float (32 bit)
        -3.402823e38 até 3.402823e38
    double (64 bit)
        -1.79769313486232e308 até 1.79769313486232e308
    decimal (128 bit)
        (= ou -) 1.0x10e28 até 7.9x10e28

## Boolean    
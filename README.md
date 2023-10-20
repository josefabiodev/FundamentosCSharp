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
    Tipo booleano, armazena apenas true e false (Verdadeiro e Falso)
    Definido pela palavra reservada bool
    bool (8 bit)
        true ou false

## Char
    Utilizado para armazenar apenas um caractere no formato Unicode
    Definido pela palavra reservada char
    A atribuição de um valor pe dada por aspas simples
    char (16 bit)
        Qualquer caractere

## String
    Armazena uma cadeia de caracteres
    Podemos pensar nele como uma lista de char
    Definido pela palavra reservada string
    A atribuição de um valor string é dada por aspas duplas
    string (?)
        Uma cadeia de caracteres

## Var
    Substitui o nome de um tipo
    Será do tipo do primeiro valor atribuído
    Recomendado o uso
        Deixar para usar var quando já dominar os tipos

var idade = 25; // Será do tipo int
var nome = "André"; // Srá do tipo string

# Object
    Tipo genérico que recebe qualquer valor ou objeto
    Não possui intelisense
    Evite usar
    objetct idade = 25;

## Nullable Types
    Significa vazio, nada
    Diferente de zero ou uma string vazia
    Tdo tipo, primitivo ou complexo, pode receber o valor null
    O tipo deve ser marcado com Nullable Type

## Alias
    Alias é um apelido que todo tipo no .NET tem
    Por exemplo:
        - System.String tem o alias string
    Como o C# é Case Sensitive, tanto faz escrevermos um ou outro
    Porém. o recomendado é sempre usar o alis
    No caso abaixo o resultado é o mesmo
        - Com alias excrevemos menos
    int idade = 25;
    int32 idade = 25;

 ## Valores padrões
    Todo tipo nuilt-in já possui um valor padrão
    Se nenhum valor for informado, seu valor padrão será utilizado
        - int => 0
        - float => 0
        - decimal => 0
        - bool => false
        - char => '\0'
        - string => ""

 ## Conversão implícita
       Existem dois tipos de conversão, as implícitas e as explícitas
       As implícitas são conversões que:
        - Podem ser executadas apenas com passagem de dados
        - Possuem tipos compatíveis

    float valor = 25.8F;
    int outro = 25;

    valor = outro; // Conversão implícita

## Conversão explícita
    Ocorre quando os tipos não são compatíveis
    É dada pelo uso do tipo entre parênteses antes da atribuição

    int inteiro = 100;
    uint inteiroSemSinal = (uint)inteiro;

## Parse
    Método presente em todo tipo primitivo
    Usado para converter um caractere ou string para um tipo qualquer
    Caso acha alguma incompatibilidade, gera um erro

    int inteiro = int.Parse("100");

## Convert
    Similar ao parse
    Porém permite converter vários tipos de valor
     - Não apenas strings
    Devemos informar o tipo na chamada da conversão

int inteiro = Convert.ToInt32("100");

## Convertendo tipos

## Operadores aritméticos
    Soma -> +
    Subtração -> -
    Multiplicação -> *
    Divisão -> /
    Modulo -> %

    Multiplicação e divisão são executados primeiros
    Caso queira executar em outra ordem, usar parênteses
    aceita short, int, float, double e decinal

    Em caso de uso de números inteiros
        - se o valor for real, será arredondado
        - 4.4 = 5

    int soma = 25 + 22; // 47
    int subtracao = 25 -22; // 3
    int divisao = 22 / 5; // 4 - Foi aredondado
    int multiplicacao = 25 * 22; // 560

## Operadores de atribuição
    Utilizamos = para atribuir um valor
    Porém, podemos utilizar = junto a um operador aritmético
    - x += 5 é o mesmo que x = x + 5

    int x = 0;
    x += 5;
    x -= 1;
    x *= 10;
    x /= 2;

## Operadores de comparação
    - igual ==
    diferente !=
    menor que <
    maior que >
    menor ou igual <=
    maior ou igual >=

    int x = 25;
    x == 0; // false
    x != 0; // true
    x > 0; // true
    x < 0; // false
    x <= 0; // false
    x>= 0; // true

## Operadores lógicos
    Usados para operações condicionais
    Retorna sempre verdadeiro ou falso
    E - and
        - Deve atender TODAS as condições
        - &&
    OU - or
        - Se atender uma condição já retorna verdadeiro
        - ||
    NEGAÇÃO - not
        - !
    
## Estrutura condicional: if
    Tradução: "SE" ou seja, "caso alguma condição seja atendida"
    Utilizado para tomada de decisão
    Utiliza os operadores lógicos
    Caso a condição não eja atendida
    podemos ter
        - else if (condição)
    podemos ter apenas else para executar algo caso a condição seja atendida

    if(condição) {

    }else {

    }


    if(condição) {

    }else if(condição) {
        
    }else if(condição) {

    }else {

    }

## Estrutura condicional switch
    Utilizado quando temos muitas decisões
    executado em cascata
    Devemos para manual emnte a execução com o comando break
    Possui uma execução padrão chamada default

    int valor = 1;
    switch (valor)
    {
        case 1:
            Console.WriteLine("1");
            break;
        case 2:
            Console.WriteLine("2");
            break;
        case 3:
            Console.WriteLine("3");
            break;
        default:
            Console.WriteLine("4");
            break;
    }

# Laços de repetição

## Laço de repetição for
    Tradução "para", ou seja, para cada item em um valor
    Executa uma determinada ação várias vezes
    Definido pela palavra for
    Exige 3 parâmetros:
        - Contador
        - Condição
        - Incremento

for (var i = 0; i <= 5; i++) 
{
    Console.WriteLine(i);
}

for (var i = 5; i >= 0; i--) 
{
    Console.WriteLine(i);
}

## Laço de repetição while
    Tradução "Enquanto", ou seja, enquanto uma condição for verdadeira...
    Definido pela palavra while
    Exige apenas uma condição
    Checa a condição ANTES de executar
var valor = 0;
while (valor <= 5) 
{
    Console.WriteLine(valor);
    valor++;
}

## Laço de repetição do while
    tradução "Faça", ou seja, realiza uma ação enquanto...
    Definido pela palavra do/while
    Exige apenas uma condição no while
    Checa a condição DEPOIS de executar

var valor = 0;
do 
{
    Console.WriteLine(valor);
    valor++;
}
while (valor , 5);

## Métodos e Funções
    Podemos segmentar nosso programa wm funções
    Também conhecidos como métodos
    O **main** é um exemplo de método
    Possui um retorno, um nome e parâmetros
    Esta composição é chamada de assinatura
    Comçam sempre com maiúscula

    static void Main(string[] args)
    {
        // Invocação do método
        MeuMetodo("C# é legal");
    }

    // Definição do método
    static void MeuMetodo(string parametro)
    {
        Console.WriteLine(paramentro);
    }

## Referece Types (Tipos de referência)
    A memória é dividida em duas partes, **Heap** e **Stack**
    Heap armazena os dados
    Stark armazena as referências para os dados

    Qualquer tipo no .NET é tratado como:
        * Tipo de Referência (Reference Type)
        * Tipo de Valor (Value Type)
    Tipos de valor armazenam dados
    São armazenados em um local da memória chamada **stack**

    Armazenam o endereço do objeto que contém os dados
    Não armazena os dados em si
    São armazenados em um local da memória chamado de __Heap__
    Ao assimilar uma variável:
        * Criará uma referência
        * Aponta para mesma informação
        * Não são independentes
    Qunado não utilizados são marcados para exclusão
    **Garbage Collector** passa remocendo todos eles
    Classes, Objects, Arrays...

## Structs
    Tipos de dado estruturado
    Apenas a estrutura, o esqueleto
    Tipo de valor
    Armazenam apenas outros tipos de dados
    Definido pela palavra struct
    Composto de propriedades e métodos
    Nome sempre com maiúsculo
        - O mesmo para prorpiedades e métodos
    Criado a partir da palavra new
        - Neste momento sim temos os valores

    A anatomia de uma estrutura normalmente é:

    struct Product
    {
        // Propriedades
        public int Id;
        public float Price;

        // Métodos
        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }

    para criar uma estrutura:

    var product = new Product();
    product.Id = 1;
    product.Price = 197.23f;

    Método construtor é um método com o mesmo nome da struct

    struct Product
    {
        public Product(int id, string title, float price) 
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }

## Enums
    Usado para fornecer uma melhor visualização do código
    Substituem o uso de inteiros
    Usados em listas curtas
    Usados em dados fixos
        - Hard Coded
    Sempre em maiúsculo
        - Começar com a letra E

Anatomia de um enumerador

enum EEstadoCivil
{
    // Enumeradores
    Solteiro = 1;
    Casado = 2;
    Divorciado = 3;
}

Uso de um enumerador

struct Cliente
{
    public string Nome;
    public EEstadoCivil EstadoCivil;
}

var cliente = new Cliente("João Silva", EEstadoCivil.Casado);
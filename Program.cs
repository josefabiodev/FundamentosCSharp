// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using FundamentosCSharp.Metodos;
using FundamentosCSharp.Structs;

Console.WriteLine("Fundamentos do C#");

var idade = 25; // Correto
//var idade; // Errado
//int novaIdade; // Correto
int novaIdade = 25; //Correto
Console.WriteLine(idade);
Console.WriteLine(novaIdade);

// Constantes
const double PI = 3.14;
Console.WriteLine(PI);

// Byte
byte meuByte = 127;
Console.WriteLine(meuByte);

// Booleano
bool usuarioJaCadastrado = false;
var usuarioInativo = true;
Console.WriteLine(usuarioJaCadastrado);
Console.WriteLine(usuarioInativo);

// Char
char letra = 'a';
Console.WriteLine(letra);

// String
string nome = "Qualque nome";
Console.WriteLine(nome);

// Var
var idadeAndre = 25;
var nomeAndre = "André";
Console.WriteLine($"{idadeAndre} {nomeAndre}");

int inteiro = 100;
float real = 25.5f;

real = inteiro; // Permitido
/*inteiro = real; // Não suportado*/
inteiro = (int)real; // Permitido

// Condicionais
int idade1 = 18;
int maiorIdade = 21;
int idadeMaxima = 65;

if(!(idade1 >= maiorIdade)) // Negação
{
    Console.WriteLine("É maior de idade");
}
else
{
    Console.WriteLine("Não é maior de idade");
}

if(idade1 >= maiorIdade && idade1 < idadeMaxima) 
{
    Console.WriteLine("É maior de idade");
}
else
{
    Console.WriteLine("Não é maior de idade");
}

if(idade1 >= maiorIdade) // Negação
{
    Console.WriteLine("É maior de idade");
}
else if (idade1 > 32)
{
    Console.WriteLine("é maior de idade");
}
else if (idade1 > 38)
{
    Console.WriteLine("é maior de idade");
}
else
{
    Console.WriteLine("Não é maior de idade");
}

// Switch
string valor = "Fábio";
switch (valor)         
{
    case "Fábio":
        Console.WriteLine("É o cara");
        break;
    case "João":
        Console.WriteLine("Não é o cara");
        break;
    default:
        Console.WriteLine("Não é nenhum dos dois");
        break;
}

// Laço for
for (var i = 0; i <= 5; i++) 
{
    Console.WriteLine(i);
}

for (var i = 5; i >= 0; i--) 
{
    Console.WriteLine(i);
}

// Laço while
var valor1 = 0;
while (valor1 <= 5) 
{
    Console.WriteLine(valor1);
    valor1++;
}

// Laço do while
var valor2 = 0;
do 
{
    Console.WriteLine(valor2);
    valor2++;
}
while (valor2 < 5);

//Metodos metodos = new();
//metodos.MeuMetodo();
Metodos.MeuMetodo();
Metodos.retornaNome("Fábio");

// Value Types e reference Types
int x = 25; // Tipo de valor
int y = x; // Tipo de referência
Console.WriteLine(x);
Console.WriteLine(y);

x = 32;
Console.WriteLine(x);
Console.WriteLine(y);

var arr = new string[2];
arr[0] = "item 1";

var arr2 = arr;
Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);

arr[0] = "item 2";
Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);

// Enums
enum EProductType
{
    Product = 1,
    service = 2
}

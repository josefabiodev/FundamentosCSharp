// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

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
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
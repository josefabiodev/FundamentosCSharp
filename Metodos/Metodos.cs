using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Metodos
{
    public class Metodos
    {
        public static void MeuMetodo() 
        {
            Console.WriteLine("C# é legal");
        }

        public static string retornaNome(string nome, int idade = 35) // idade é parâmetro opcional
        {
            return nome;
        }
    }    
}
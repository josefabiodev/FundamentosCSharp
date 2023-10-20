using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCSharp.Structs
{
    public class Structs
    {
        struct Product
        {
            public Product(int id, string name, double price) 
            {
                Id = id;
                Name = name;
                Price = price;
            }

            public int Id;
            public string Name;
            public double Price;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }
    }
}
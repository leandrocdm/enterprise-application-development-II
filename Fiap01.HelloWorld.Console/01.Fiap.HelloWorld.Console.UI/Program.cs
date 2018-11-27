using _01.Fiap.HelloWorld.Console.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro(2010,2.0);
            carro.Ano = 2010; //Set
            carro.ArCondicionado = false; //Set

            System.Console.WriteLine(carro.Ano); //Get

            //Instanciar uma lancha
            var lancha = new Lancha(2019,50)
            {
                BoiaSalvaVida = true,
                Ano = 1999                
            };

            
        }
    }
}

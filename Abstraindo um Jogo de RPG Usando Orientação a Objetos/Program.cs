using System;
using Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities;

namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 1000, 200);
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard", 400, 1500);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 800, 800);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(wedge.Attack());
        }
    }
}

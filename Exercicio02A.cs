using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Arrays_vs_Lists
{
    public class Exercicio02A
    {
        //Desenvolvimento de um programa que armazena uma lista de convidados utilizando um array.

        public static void Main()

        {
            string[] convidados = new string[10];

            convidados[0] = "Antonio";
            convidados[1] = "Debora";
            convidados[2] = "Tamires";
            convidados[3] = "Arthur";
            convidados[4] = "Henrique";
            convidados[5] = "Amauri";
            convidados[6] = "Kelly;";
            convidados[7] = "Flavio";
            convidados[8] = "Karina";
            convidados[9] = "Nathalia";

            Console.WriteLine("O número de convidados é igual a " + convidados.Length);
        }

    }

              
}

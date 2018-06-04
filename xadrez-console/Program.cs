using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            Tabuleiro T;

            T = new Tabuleiro(8, 8);
            Tela.imprimirtabuleiro(T);
            
            Console.ReadLine();

        }
    }
}

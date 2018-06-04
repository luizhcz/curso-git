using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            Tabuleiro T;

            T = new Tabuleiro(8, 8);

            T.colocarPeca(new Torre(T,Cor.Preta), new Posicao(0, 0));
            T.colocarPeca(new Torre(T, Cor.Preta), new Posicao(1, 2));
            T.colocarPeca(new Rei(T, Cor.Preta), new Posicao(2, 4));
            
            Tela.imprimirtabuleiro(T);

            
            Console.ReadLine();

        }
    }
}

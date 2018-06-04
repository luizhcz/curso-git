using Models;
using System;
using Xadrez;
namespace xadrez_console
{
    class Tela
    {
        public static void imprimirtabuleiro(Tabuleiro tab)
        {
         for (int i = 0; i < tab.linhas; i++)
            {
             Console.Write(8 - i + " ");

             for (int j = 0; j < tab.colunas; j++)
             { 
                 imprimirPeca(tab.peca(i, j));    
             }
                Console.WriteLine();
            }
             Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirtabuleiro(Tabuleiro tab,bool [,] posicoesPossiveis)
        {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGreen;


            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }


        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }

            
        }
    }
}

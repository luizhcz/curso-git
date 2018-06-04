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

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirtabuleiro(partida.tab);

                    Console.WriteLine("");
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirtabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine("");
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();


                    partida.executaMovimento(origem, destino);
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }


            Console.ReadLine();

        }
    }
}

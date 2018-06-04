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

                    try
                    {
                        Console.Clear();
                        Tela.imprimirtabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                        Console.WriteLine("");
                        Console.WriteLine("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.valdiarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirtabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine("");
                        Console.WriteLine("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaodeDestino(origem, destino);


                        partida.realizaJogada(origem, destino);
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        Console.ReadLine();
                    }
                    
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

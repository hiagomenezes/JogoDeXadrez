using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(1, 6));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(5, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(6, 0));
                tab.ColocarPeca(new Rei(tab, Cor.Branco), new Posicao(2, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 4));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

           

        }
    }
}

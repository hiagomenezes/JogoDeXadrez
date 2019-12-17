using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; set; }
        public Tabuleiro tab { get; set; }


        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.cor = cor;
            this.posicao = posicao;
            this.tab = tab;
            this.qteMovimentos = 0;
        }
    }
}

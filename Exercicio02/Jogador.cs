using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Jogador
    {
        private string nome;
        private int gols;
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetGols(int g)
        {
            if (g > 0) gols = g;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetGols()
        {
            return gols;
        }
        public override string ToString()
        {
            if (gols <= 0)
                return $"{nome} - nenhum gol !!!";
            if (gols ==1)
                return $"{nome} - um gol";
            return $"{nome} - {gols} gols";
        }
    }
}

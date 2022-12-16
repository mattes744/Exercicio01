using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Intervalo
    {
        private int inicio, fim;
        public void SetInicio(int v)
        {
            inicio = v;
        }
        public void SetFim(int v)
        {
            fim = v;
        }
        public int GetInicio()
        {
            return inicio;
        }
        public int GetFim()
        {
            return fim;
        }
        public int[] Numeros()
        {
            if (inicio > fim)
            {
                int aux = inicio;
                inicio = fim;
                fim = aux;
            }
            int tamanho = fim - inicio + 1;
            int[] vetor = new int[tamanho];
            for (int i = inicio, k = 0; i <= fim; i++, k++)
                vetor[k] = i;
            return vetor;
        }
    }
}

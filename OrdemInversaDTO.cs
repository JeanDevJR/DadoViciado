using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemInversa
{
    public class OrdemInversaDTO
    {
        private int n;
        private int qtdeElementos;
        private int[] vetorEntrada;

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public int QtdeElementos
        {
            get { return qtdeElementos; }
            set { qtdeElementos = value; }
        }

        public int[] VetorEntrada
        {
            get { return vetorEntrada; }
            set { vetorEntrada = value; }
        }

        public OrdemInversaDTO()
        {
        }
    }
}
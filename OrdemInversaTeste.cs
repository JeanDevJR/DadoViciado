using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemInversa
{
    class OrdemInversaTeste
    {
        static void Main(string[] args)
        {
            OrdemInversaDTO numeros = new OrdemInversaDTO();

            OrdemInversaBusiness.obter(numeros);
            OrdemInversaBusiness.imprimir(numeros);

            Console.ReadKey();

        }
    }
}
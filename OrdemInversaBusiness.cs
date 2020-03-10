using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemInversa
{
    public class OrdemInversaBusiness
    {
        public static void obter(OrdemInversaDTO ordemInversaDTO) 
        {
            TextReader leitor = System.Console.In;

            Console.Write("Quantos lançamentos serão feitos?");
            ordemInversaDTO.N = Convert.ToInt32(leitor.ReadLine());

            ordemInversaDTO.VetorEntrada = new int[7];

            for (int i = 1; i <= ordemInversaDTO.N; i++)
            {
                Console.Write("Digite o lançamento {0}: ", i);
                ordemInversaDTO.QtdeElementos = Convert.ToInt32(leitor.ReadLine());

                if (ordemInversaDTO.QtdeElementos < 1 || ordemInversaDTO.QtdeElementos > 6)
                    ordemInversaDTO.VetorEntrada[0]++;
                else
                    ordemInversaDTO.VetorEntrada[ordemInversaDTO.QtdeElementos]++;
            }
        }// fim do método obterNumeros 

        public static void imprimir (OrdemInversaDTO ordemInversaDTO)
        {
            Console.WriteLine();
            Console.WriteLine("Número de ocorrências de cada face:");
            for (int i = 1; i < ordemInversaDTO.VetorEntrada.Length; i++)
                Console.WriteLine("Face {0} = {1}", i, ordemInversaDTO.VetorEntrada[i]);
            Console.ReadKey();
        }
    }//fim da classe business
}
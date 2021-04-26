/*
    * COmplete a seguinte função (public static List<Integer> calculation(int naxDigit)) para que a mesma devolva todos os números
    * de 4 dígitos, onde cada um será menor que o igual a <maxDigit>
    * e a soma do resultado igual a 21 em homenagem a este ano.
    * Exmeplos com maxDigit=6: 3666, 4566
    *
    * Em caso de não encontrar nada devolver nulo.
*/


using System;
using System.Collections.Generic;

namespace Decoponsicao
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = Calculation(9);

            if (lista.Count > 0)
            {
                foreach (var numero in lista)
                {
                    Console.WriteLine(numero);
                }
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        static List<int> Calculation(int maxDigit)
        {

            var max = maxDigit * 1111;

            var numeros = new List<int>();

            var resultado = new List<int>();

            for (int i = 1000; i <= max; i++)
            {
                numeros = Decomposicao(i);

                var soma = 0;

                foreach (var digito in numeros)
                {
                    soma += digito;
                }

                if (soma == 21)
                {
                    resultado.Add(i);
                }
            }

            return resultado;
        }

        private static List<int> Decomposicao(int i)
        {
            int milhar, centena, dezena, unidade, numero, aux;

            numero = i;

            milhar = numero / 1000;

            aux = numero - (milhar * 1000);

            centena = aux / 100;

            aux = aux - (centena * 100);

            dezena = aux / 10;

            unidade = aux - (dezena * 10);

            var resutaldo = new List<int> { milhar, centena, dezena, unidade };

            return resutaldo;

        }
    }
}

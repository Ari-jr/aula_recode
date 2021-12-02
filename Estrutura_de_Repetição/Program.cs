using System;

namespace Estrutura_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            /*
            Resultado da execução:

            0
            1
            2
            3
            4
            */

            // WHILE
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }

            /*
            Saída
            0
            1
            2
            3
            4
            */
        }
    }
}

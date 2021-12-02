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

            // WHILE com BREAK
            int k = 0;
            while (k < 5)
            {
                if (k>2)
                    break;
                Console.WriteLine(k);
                k++;
            }

            /*
            Saída

            0
            1
            2
            */

            //WHILE com CONTINUE
            int z = 0;
            while (z < 5)
            {
                if(z==2)
                {
                    z++;
                    continue;
                }
                Console.WriteLine(z);
                z++;
            }

            /*
            Saída
            0
            1
            3
            4
            */

        }
    }
}

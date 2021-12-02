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

            // DO WHILE
            int h = 0;
            do
            {
                Console.WriteLine(h);
                h++;
            } while (h < 5);

            /*
            Saída
            0
            1
            2
            3
            4
            */

            // FOR EACH
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                Console.WriteLine($"Elemento #{count}: {element}");
                count++;
            }
            Console.WriteLine($"Número de elementos: {count}");

            /*
            Saída
            Elemento #0: 0
            Elemento #1: 1
            Elemento #2: 1
            Elemento #3: 2
            Elemento #4: 3
            Elemento #5: 5
            Elemento #6: 8
            Elemento #7: 13
            Número de elementos: 8
            */


        }
    }
}

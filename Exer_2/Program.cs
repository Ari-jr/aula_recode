using System;

namespace Exer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Utilizando como base o código-fonte que você construiu na atividade anterior:

            1 - Adicione uma de repetição que tenha 5 execuções, utilizando a estrutura de controle de sua preferência.
            2 - Adicione uma nova variável para o controle das repetições.
            3 - A cada impressão, informe o número da execução em curso.
            4 - Ao final de cada volta, adicione 10 unidades a cada uma, das três variáveis definidas anteriormente.
            */

            int Var1 = 10;
            int Var2 = 20;
            int Var3 = 30;
            
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine(i);

                Console.WriteLine(Var1);
                Console.WriteLine(Var2);
                Console.WriteLine(Var3);

                Console.WriteLine(Var1 < Var2);
                Console.WriteLine(Var2 == Var3);

                Var1++;
                Var3--;

                Console.WriteLine(Var1);
                Console.WriteLine(Var3);

                Var1 = Var1 + 10;
                Var2 = Var2 + 10;
                Var3 = Var3 + 10;

            }


        }
    }
}

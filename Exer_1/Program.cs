using System;

namespace Exer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Praticando com variáveis, impressões, comentários e operadores:
            1 - Crie uma aplicação console contemplando:
            2 - três variáveis inteiras, com nomes livres.
            3 - Atribua valores iniciais às três.
            4 - Imprima o resultado de cada uma delas em linhas distintas.
            5 - Imprima o resultado utilizando operadores de comparação, a sua escolha, entre as duas primeiras variáveis.
            6 - Imprima o resultado utilizando operadores de igualdade entre as duas últimas variáveis.
            7 - Utilize operadores aritméticos distintos com a primeira e a última variáveis e em seguida imprima o novo resultado das duas em linhas distintas.
            */ 
            int Var1 = 10;
            int Var2 = 20;
            int Var3 = 30;

            Console.WriteLine(Var1);
            Console.WriteLine(Var2);
            Console.WriteLine(Var3);

            Console.WriteLine(Var1 < Var2);
            Console.WriteLine(Var2 == Var3);

            Var1++;
            Var3--;

            Console.WriteLine(Var1);
            Console.WriteLine(Var3);

        }
    }
}

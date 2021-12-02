using System;

namespace Estruturas_de_Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura do IF - ELSE
            int m = 12;
            int n = 18;

            if (m > 10)
                if (n > 20)
                {
                    Console.WriteLine("Result1");
                }
                else
                {
                    Console.WriteLine("Result2");
                }

            // Estrutura do SWITCH/CASE exemplo 01
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
                
                }


            }
    }        
}
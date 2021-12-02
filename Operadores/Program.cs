using System;

namespace operadores
{
    class Program
    {
        static void Main(string [] args)
        {
           
            //Operadores Aritméticos
            int i = 3;
            Console.WriteLine(i);   // saída: 3
            Console.WriteLine(i++); // saída: 3
            Console.WriteLine(i);   // saída: 4

            double a = 1.5;
            Console.WriteLine(a);   // saída: 1.5
            Console.WriteLine(++a); // saída: 2.5
            Console.WriteLine(a);   // saída: 2.5

            int i = 3;
            Console.WriteLine(i);   // saída: 3
            Console.WriteLine(i--); // saída: 3
            Console.WriteLine(i);   // saída: 2

            double a = 1.5;
            Console.WriteLine(a);   // saída: 1.5
            Console.WriteLine(--a); // saída: 0.5
            Console.WriteLine(a);   // saída: 0.5

            Console.WriteLine(+4);     // saída: 4
            Console.WriteLine(-4);     // saída: -4
            Console.WriteLine(-(-4));  // saída: 4

            Console.WriteLine(13 / 5);    // saída: 2
            Console.WriteLine(-13 / 5);   // saída: -2
            Console.WriteLine(13 / -5);   // saída: -2
            Console.WriteLine(-13 / -5);  // saída: 2

            Console.WriteLine(13 / 5.0);       // saída: 2.6
            int a = 13;
            int b = 5;
            Console.WriteLine((double)a / b);  // saída: 2.6

            Console.WriteLine(5 % 4);   // saída: 1
            Console.WriteLine(5 % -4);  // saída: 1
            Console.WriteLine(-5 % 4);  // saída: -1
            Console.WriteLine(-5 % -4); // saída: -1

            Console.WriteLine(5 + 4);       // saída: 9
            Console.WriteLine(5 + 4.3);     // saída: 9.3

            Console.WriteLine(47 - 3);      // saída: 44
            Console.WriteLine(5 - 4.3);     // saída: 0.7
            


            
            //Operadores de Comparação
            Console.WriteLine(7.0 < 5.1);   // saída: False
            Console.WriteLine(5.1 < 5.1);   // saída: False
            Console.WriteLine(0.0 < 5.1);   // saída: True

            Console.WriteLine(double.NaN < 5.1);   // saída: False
            Console.WriteLine(double.NaN >= 5.1);  // saída: False

            Console.WriteLine(7.0 > 5.1);   // saída: True
            Console.WriteLine(5.1 > 5.1);   // saída: False
            Console.WriteLine(0.0 > 5.1);   // saída: False

            Console.WriteLine(double.NaN > 5.1);   // saída: False
            Console.WriteLine(double.NaN <= 5.1);  // saída: False

            Console.WriteLine(7.0 <= 5.1);   // saída: False
            Console.WriteLine(5.1 <= 5.1);   // saída: True
            Console.WriteLine(0.0 <= 5.1);   // saída: True

            Console.WriteLine(double.NaN > 5.1);   // saída: False
            Console.WriteLine(double.NaN <= 5.1);  // saída: False

            Console.WriteLine(7.0 >= 5.1);   // saída: True
            Console.WriteLine(5.1 >= 5.1);   // saída: True
            Console.WriteLine(0.0 >= 5.1);   // saída: False

            Console.WriteLine(double.NaN < 5.1);   // saída: False
            Console.WriteLine(double.NaN >= 5.1);  // saída: False
            


            //Operadores Lógicos
            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False

            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a = false & SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluated.
            // False

            bool b = true & SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluated.
            // True

            //Operadores de Igualdade
            int a = 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a == b);  // output: True

            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);  // output: False
            Console.WriteLine(c1 == char.ToLower(c2));  // output: True

            string s1 = "hello!";
            string s2 = "HeLLo!";
            Console.WriteLine(s1 == s2.ToLower());  // output: True

            string s3 = "Hello!";
            Console.WriteLine(s1 == s3);  // output: False

            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False


        }
    }
}
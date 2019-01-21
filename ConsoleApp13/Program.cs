using System;

namespace Calculator
{
    class Program
    {
        double Num1;
        double Num2;
        double svar;
        string ops;

        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double svar;
            string ops;

            Console.WriteLine("\t\t\tConsole Calculator Tutorial in C#\r");
            Console.WriteLine("\t\t\t-----------------------------\r");
            Console.WriteLine("hej");
            Console.WriteLine("\t\t\tEnter Num1\n");
            Num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an operator: (+, -, *, /, %, ^)\n");
            ops = Console.ReadLine();

            //switch (ops)
            //{
            //    case "+":
            //        Console.WriteLine("hej");
            //        break;
            //    case "-":
            //        Console.WriteLine("hejdå");
            //        break;

            //}

            Console.WriteLine("\t\t\tEnter andra nummer\n");
            Num2 = Double.Parse(Console.ReadLine());


            if (ops == "+")
            {
                svar = Num1 + Num2;
                Console.Write("\n" + svar);
            }
            if (ops == "-")
            {
                svar = Num1 - Num2;
                Console.Write("\n" + svar);
            }

            if (ops == "*")
            {
                svar = Num1 * Num2;
                Console.Write("\n" + svar);
            }


            if (ops == "/") 
            {
                svar = Num1 / Num2;
                Console.Write("\n" + svar);
            }


            if (ops == "%")
            {
                svar = Num1 % Num2;
                Console.Write("\n" + svar);
            }

            Console.Write("\n" + "Press an key to exit...");
            Console.WriteLine("hejdå");
            Console.ReadKey();

        }
    }
}


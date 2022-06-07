using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(4,3));
            Console.WriteLine(add(4.43, 3.32));
            Console.WriteLine(add(0, 1, true));
            Console.WriteLine(add(43,45, true));

        }

        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static string add(int num1, int num2, bool dollar)
        {
            if(dollar == true && (num1+num2)>1) {
                return ((num1 + num2) + " dollars");
            }
            else if (dollar == true && (num1 + num2) <= 1)
            {
                return ((num1 + num2) + " dollar");
            }
            return ("Not money");
        }
    }
}

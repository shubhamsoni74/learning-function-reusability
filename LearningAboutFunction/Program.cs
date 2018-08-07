using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAboutFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            funwithnoreturnvalueandnoparameters();
            funwithnoreturnvalueandnoparameters();
            funwithreturnvalueandparameters(10, "shubhamsoni", 22.2f);
            int output = sum(5, 6);
            Console.WriteLine("5+6={0}", output);

            Console.ReadKey();
        }
        static void funwithnoreturnvalueandnoparameters()
        {
            Console.WriteLine("function with no return value and no parameters");
        }
        static int funwithreturnvalueandnoparameters()
        {
            Console.WriteLine("function with return value and no parameters");
            return 0;
        }
        static string funwithreturnvalueandparameters(int a, string b, float c)
        {
            Console.WriteLine("function  return string value and some parameters");
            return "";

        }
        static int sum(int a, int b)//5,6
        {
            int result = a + b;
            return result;
        }
    }
}

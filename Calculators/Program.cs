using System;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {            
            string result = Calculator.Add("100", "200");

            result = Calculator.Add("900", "200");
            result = Calculator.Add("909", "1");
            result = Calculator.Add("10009", "10005");

            Console.ReadLine();
        }
    }
}

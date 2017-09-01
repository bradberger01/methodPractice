using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 50;
            int total = Add(number1, number2);
            //Console.WriteLine(total);

            //Console.WriteLine(Multiply(number1, number2));
            Greeting();
            string name = "Will Robinson";
            RobotWArning(name);
        }
        public static int Add(int firstNumber, int secondNumber)
        {
        int sum = firstNumber + secondNumber;

        return sum;
        }
        public static int Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;

            return product;
        }
        public static void Greeting()
        {
            Console.WriteLine("Hello World");
        }

        public static void RobotWArning(string name)
        {
            Console.WriteLine("Danger, " + name);
        }
}
}

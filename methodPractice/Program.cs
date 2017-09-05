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
           
            favoriteFoods("pizza","Italian");

            Console.WriteLine("What is your age");
            int userAge = int.Parse(Console.ReadLine());
            retirementCalculator(userAge);


            //int number1 = 25;
            //int number2 = 50;
            //int total = Add(number1, number2);
            //Console.WriteLine(total);

            //Console.WriteLine(Multiply(number1, number2));
            //Greeting();
            //string name = "Will Robinson";
            //RobotWArning(name);
        }
        //public static int Add(int firstNumber, int secondNumber)
        //{
        //int sum = firstNumber + secondNumber;

        //return sum;
        //}
        //public static int Multiply(int firstNumber, int secondNumber)
        //{
        //    int product = firstNumber * secondNumber;

        //    return product;
        //}
        //public static void Greeting()
        //{
        //    Console.WriteLine("Hello World");
        //}

        //public static void RobotWArning(string name)
        //{
        //    Console.WriteLine("Danger, " + name);
        //}

        //create a method called favoiteFood. It should take two string parameters, one should be nameOfFood and other should be
        //being the food. It should be void return type. The method should concantinate the two values.

        public static void favoriteFoods (string nameOfFood, string typeOfFood)
        {
            Console.WriteLine(nameOfFood + " " + typeOfFood);
        }

        //retiremetn calculator - Create a method called retirementCalculator. It should take in int as a parameter representing userAge
        //The method should calculate how many more years until the user retires using 65 as the ageOfRetirement. The return type should
        //be void. Once it calculates the users retirement age it should print. "The user will retire in x years, where x represents the 
        //value that was calculated.

        public static void retirementCalculator(int userAge)
        {
            int x = 65 - userAge;
            Console.WriteLine("You will retire in " + x + " years.");

        }
    }
}

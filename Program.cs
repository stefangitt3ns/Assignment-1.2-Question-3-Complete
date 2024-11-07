using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignement 1.2";

            // Problem 2. 
            int sum = 0;

            for ( int i = 1; i <=10; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of the numbers is {sum}");

            Console.Read();

            // Problem 3. 

            Console.WriteLine("This program is a calculator that does subtraction, multiplication, and division with two numbers");
            Console.WriteLine();

            Console.WriteLine("Input your numbers and press enter after each");
            double numOne = Convert.ToDouble(Console.ReadLine());
            double numTwo = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Press 1 for Multiplication \n Press 2 for Addition \n Press 3 for Division \n Press 4 for Subtraction"); 

            int choice = Convert.ToInt32(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    Console.WriteLine($"You want me to multiply {numOne} by {numTwo}? Okay your answer is {numOne * numTwo}");
                    break;
                case 2:
                    Console.WriteLine($"You want me to Add {numOne} to {numTwo}? Okay your answer is {numOne + numTwo}");
                    break;
                case 3:
                    Console.WriteLine($"You want me to Divide {numOne} by {numTwo}? Okay your answer is {numOne / numTwo}");
                    break;
                case 4:
                    Console.WriteLine($"You want me to subtract {numOne} from {numTwo}? Okay your answer is {numOne - numTwo}");
                    break;
                default:
                    Console.WriteLine("I can't understand your input");
                    break;
            }
            Console.Read();



          
            







        }
    }
}

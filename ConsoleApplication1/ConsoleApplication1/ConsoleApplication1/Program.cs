using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string switchfun()
        {
            Console.WriteLine("Enter a Classmate name");
            string Student = Console.ReadLine();
            string result = "";
            switch (Student)
            {
                case "Ali":
                    result = "Called Name To Ali";
                    break;
                case "Asif":
                    result = "Called Name To Asif";
                    break;
                case "Rehan":
                    result = "Called Name To Rehan";
                    break;
                case "Waqas":
                    result = "Called Name To Waqas";
                    break;
                case "Sheraz":
                    result ="Called Name To Sheraz";
                    break;
                default:
                    result = "Not a vowel";
                    break;
            }
            return result;
        }


        public static void operatorfun()
        {

            Console.WriteLine("Enter Your number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                double result = num1 + num2;
                if (num1 > 2)
                {
                    Console.Write("Your Number is  greater than 2: " + result + " ");
                }
                else
                {

                    Console.Write("Your Number is less than 2: " + result + " ");
                }
            }
            else if (op == '-')

            {
                double result = num1 - num2;
                Console.WriteLine(num1 - num2);
            }
            else if (op == '/')
            {
                double result = num1 / num2;
                Console.WriteLine(num1 / num2);
            }
            else if (op == '*')
            {
                double result = num1 * num2;
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

          
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter 1 for Operator  and 2 for switches");
            int logicFun =   Convert.ToInt32(Console.ReadLine());

            switch(logicFun)
            {
                case 1:
                    
                    operatorfun();
                    break;
                case 2:
                    string abc = switchfun();
                    Console.WriteLine(abc);
                    break;
                default:
                    Console.WriteLine("Not a Valid Number");
                    break;
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information

using RegexPatternProblems;
using System;

namespace RegexPatternProblems
{
    class program
    {   //Method to check and take the first name using regex(UC1)
        public static string instr = Console.ReadLine();
        static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome to User Registation Problems");
            Pattern pattern = new Pattern(); //Creating Objects
            bool flag = true;
            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("\t-->Select To Programs Which can be executed<--");
                Console.WriteLine("\t1.Enter First Name \n\t2.Enter Last Name \n\t3.Exit");
                Console.Write("\tEnter Numbers: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Validating user entered a valid firstname or not(UC1)
                        Console.Write("\tEnter Your First Name: ");
                        pattern.CheckFirstName();//Call the Method.
                        break;
                    case 2:
                        //Validating user entered a valid firstname or not(UC1)
                        Console.Write("\tEnter Your Last Name: ");
                        pattern.CheckLastName();//Call the Method.
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\tSelect Correct Number");
                        break;
                }
            }
        }
    }
}

        
    
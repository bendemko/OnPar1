using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPar_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;

            do
            {
                Console.WriteLine("Enter a number to sum.");
                string number1AsString = Console.ReadLine();
                int number1 = Convert.ToInt32(number1AsString);

                Console.WriteLine("Enter a second number to sum.");
                string number2AsString = Console.ReadLine();
                int number2 = Convert.ToInt32(number1AsString);

            
                Console.WriteLine(number1 + number2);
                Console.WriteLine("Do you want to enter another number, y/n?");
                again = Console.ReadLine();

                //I can't figure out how to sum two numbers and then add additional numbers to that sum

            }
            

            while (again == "y");

        
        }
        

    }

    }

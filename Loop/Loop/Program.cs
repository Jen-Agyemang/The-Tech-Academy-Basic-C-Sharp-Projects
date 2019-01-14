using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {


            // IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

            // Do a boolean comparison using a while statement.

            Console.WriteLine("Guess age?");
            int age = Convert.ToInt32(Console.ReadLine());
            bool ageGuessed = age == 12; //bool ageGuessed = false;

            while (ageGuessed == false) //while(!ageGussed)

            switch (age)

            {
                case 1:
                    Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("guess age?");
                        age = Convert.ToInt32(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("You guessed 2. Try Agian.");
                    Console.WriteLine("Guess age?");
                        age = Convert.ToInt32(Console.ReadLine());
                    break;

                case 12:
                    Console.WriteLine("You guessed the number 12! That is correct!");
                        ageGuessed = true;
                        Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess age?");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                    
                    

            }
            Console.Read();
        }
    }
}


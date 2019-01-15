using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed = number == 4;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("you typed 1. Incorrect. Try Again!");
                        Console.WriteLine("guess number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("You typed 6. Incorrect. Try Again!");
                        Console.WriteLine("Guess number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("You typed 4. That is correct!");
                        numberGuessed = true;
                        break;

                   
                      

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
                

            } while (!numberGuessed);
            Console.Read();

        }
    }
}

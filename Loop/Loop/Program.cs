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
            // Do a boolean comparison using a while statement.
            
           // IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool inputs = Convert.ToBoolean(number);

            switch (number)

            {
                case 1:
                    Console.WriteLine("false");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("False");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("True!");
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("False.");
                    Console.ReadLine();


                    break;

                    
                    

            }
        }
    }
}


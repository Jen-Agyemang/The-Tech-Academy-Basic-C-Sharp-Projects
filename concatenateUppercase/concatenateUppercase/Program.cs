using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenateUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings.
            string name1 = "Jen";
            string name2 = "Nana";
            string name3 = "Bo";
            Console.WriteLine(name1 + ", " + name2 + " and " + name3 + " are all beautiful.");
            Console.ReadLine();


            // Convert a string to uppercase.
            string thing = "love";
            // Console.WriteLine("I " + thing + " Dubai.");
            string upper = thing.ToUpper();
            Console.WriteLine(upper);
            Console.ReadLine();

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            string place = "Kirkland";
            StringBuilder nameChange = new StringBuilder();
            nameChange.Append("Medina");
            Console.WriteLine(nameChange + " is a calm city.");
            Console.ReadLine();

            string school = "Edmonds";
            StringBuilder schoolChange = new StringBuilder();
            schoolChange.Append("Lynnwood");
            Console.WriteLine("I changed school from " + school + " to " + schoolChange);
            Console.ReadLine();

                }
    }
}

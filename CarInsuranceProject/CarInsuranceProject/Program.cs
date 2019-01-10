using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your job is to create a basic approval program for car insurance. It will ask the applicant some questions and return a “true” or “false” at the end as to whether or not the applicant qualified for car insurance.


            //  What is your age ?
           
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            //Have you ever had a DUI?
            Console.Write("Have you ever had a DUI? Please answer true  or false. ");
            string duiTickets = Console.ReadLine();
            bool DUI = Convert.ToBoolean(duiTickets);
            Console.ReadLine();


            // How many speeding tickets do you have?
            Console.Write("How many speeding tickets do you have?  ");
            string speedingTickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(speedingTickets);
            Console.ReadLine();



            //  Use the following qualification rules to determine if the applicant qualifies for car insurance:


            // Applicants must be over 15 years old.
            Console.WriteLine("Applicants must be fiften years old.");
            Console.ReadLine();

            Console.WriteLine("Applicants must not have any DUI'S");
            Console.ReadLine();

            Console.WriteLine("Applicants must not have more than 3 speeding tickets.");

            Console.ReadLine();

            Console.WriteLine("Qualified? ");
            bool qualifications = (age >= 15 && DUI == false && Tickets <=3 );
            Console.WriteLine(qualifications);
            Console.ReadLine();
            


        }
    }
}

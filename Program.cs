using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the school name 
            Console.WriteLine("Academy of Learning Career College");
            // Print the report title
            Console.WriteLine("Student Report");
            // Ask for the student's name and store it as a string
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Ask for the course name and store it as a string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            // Ask for the page number and store it as an integer
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            // Ask if the student needs help and store it as a boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            // Ask about positive experiences and store the response as a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            // Ask for additional feedback and store it as a string
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            // Ask how many hours were studied
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            // Print the final message to end the program
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

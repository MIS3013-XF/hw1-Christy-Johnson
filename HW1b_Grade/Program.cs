// HW1b Grade

// Your Name: Christy Johnson
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const double homework_weight = 0.20;
            const double participation_weight = 0.15;
            const double exam1_weight = 0.15;
            const double exam2_weight = 0.25;
            const double exam3_weight = 0.25;


            Console.WriteLine("What is your first name? ");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student id? ");
            int studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks? ");
            double homeworkgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations? ");
            double participationgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for Exam 1? ");
            double exam1grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the Exam 2? ");
            double exam2grade = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("What is your overall percentage grade for the Exam3? ");
            double exam3grade = Convert.ToDouble(Console.ReadLine());

            double FinalGrade = (homeworkgrade * homework_weight) +
                (participationgrade * participation_weight) + (exam1grade * exam1_weight)
                + (exam2grade * exam2_weight) + (exam3grade * exam3_weight);


            Console.WriteLine($"\n{firstname} {lastname} ({studentid}), your final grade is {FinalGrade:F2}%");
            
            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();





        }
    }
}

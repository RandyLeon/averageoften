using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Averageoften
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press enter to begin.");
            Console.ReadLine();
            Console.WriteLine("Enter grade");
            double value = double.Parse(Console.ReadLine());
            double sum = 0;
            double totalNumbers = 1;


            while (value <= 100 && value >= 0 && totalNumbers < 10)
            {

                sum += value;
                totalNumbers++;

                Console.WriteLine("Enter grade");
                value = double.Parse(Console.ReadLine());

            }

            double average = sum / totalNumbers;
            double Grade = average;

            if (Grade > 89)
            {
                Console.WriteLine("Grade = A");
            }

            else if (Grade > 79)
            {
                Console.WriteLine("Grade = B");
            }

            else if (Grade > 69)
            {
                Console.WriteLine("Grade = C");
            }

            else if (Grade > 59)
            {
                Console.WriteLine("Grade = D");
            }

            else
            {
                Console.WriteLine("Grade = F");
            }

            Console.WriteLine($"Average = {average}");
            Console.WriteLine($"Total assignments graded = {totalNumbers}");
        }
    }
}

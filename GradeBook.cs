using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitArray
{
    class GradeBook
    {
        private static Random randomNumbers = new Random();

        private int[] grades = new int[10];
        private double sum = 0;
        
        
        public GradeBook()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = randomNumbers.Next(101);
            }
            
        }
        public void execute()
        {
            for (var count = 0; count < grades.Length; count++)
            {
                Console.WriteLine($"Student{count+1,3}:{grades[count],4}");
            }
            Console.WriteLine($"\nClass average is {avg(grades)}");
            Console.WriteLine($"Lowest grade is {lowestGrade(grades)[0]}");
            Console.WriteLine($"Lowest grade is {lowestGrade(grades)[1]}");

            Console.WriteLine("Grade distribution:");

            for (var counter = 0; counter < grades.Length; counter++)
            {
                if (counter == 10) Console.Write("  100: ");
                else Console.Write($"{counter * 10:D2}-{counter * 10 + 9:D2}: ");
                for (var stars = 0; stars < grades[counter]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public double avg(int[] numbers)
        {

            foreach (int value in numbers)
            {
                sum += value;
            }

            return sum / 10;
        }
        public int[] lowestGrade(int[] numbers)
        {
            int lowest_Grade = numbers[0];
            int highest_Grade = numbers[0];
            int[] results = new int[2];

            foreach (int value in numbers)
            {
                if (value < lowest_Grade) lowest_Grade = value;
                if (value > highest_Grade) highest_Grade = value; 
            }
            results[0] = lowest_Grade;
            results[1] = highest_Grade;
            return results;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitArray
{
    public class RollDie
    {
        public void execute()
        {
            var randomNumbers = new Random();
            var frequency = new int[7];

            for (var roll = 1; roll < 600; roll++)
            {
                ++frequency[randomNumbers.Next(1, 7)];
            }
            Console.WriteLine($"{"Face"}{"Frequency",10}");
            for (var face = 1; face < frequency.Length; face++)
            {
                Console.WriteLine($"{face,4}{frequency[face],10}");
            }
        }
    }
}

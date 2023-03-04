using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] jagged = { new int[] { 1, 2 }, new int[] { 3 }, new int[] { 4, 5, 6 } };
            OutputArray(rectangular);
            Console.WriteLine();
            OutputArray(jagged);
            Console.ReadKey();

            Console.WriteLine("\n*** Foreach Test ***");
            ForEachTest foreachtest = new ForEachTest();
            foreachtest.execute();
            Console.ReadKey();

            Console.WriteLine("\n*** Bar Chart ***");
            BarChart barChartTest = new BarChart();
            barChartTest.execute();
            Console.ReadKey();

            Console.WriteLine("\n*** Deck Of Cards ***");
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            Card card = deckOfCards.DealCard();
            Console.Write(card.ToString());
            Console.ReadKey();

            Console.WriteLine("\n*** GRADE BOOK ***");
            GradeBook gradeBook = new GradeBook();
            gradeBook.execute();
            Console.ReadKey();

            Console.WriteLine("\n*** PASS ARRAY ***");
            PassArray passArray = new PassArray();
            passArray.execute();
            Console.ReadKey();

            Console.WriteLine("\n*** ROLL DIE ***");
            RollDie rollDie = new RollDie();
            rollDie.execute();
            Console.ReadKey();

            Console.WriteLine("\n*** Sum Array ***");
            SumArray sumArray = new SumArray();
            sumArray.SumsArray();
            Console.ReadKey();

        }
        static void OutputArray(int[,] array)
        {
            Console.WriteLine("Values in the rectangular array by row are");
            for (var row = 0; row < array.GetLength(0); row++)
            {
                for (var column = 0;  column < array.GetLength(1); column++)
                {
                    Console.Write($"{array[row, column]}  ");
                }
                Console.WriteLine();
            }
        }
        static void OutputArray(int[][] array)
        {
            Console.WriteLine("Values in the jagged array by row are");
            foreach (var row in array)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element}  ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace BrickWall.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[][]
            {
                new int[] { 1, 2, 2, 1 },
                new int[] { 3, 1, 2 },
                new int[] { 1, 3, 2 },
                new int[] { 2, 4 },
                new int[] { 3, 1, 2 },
                new int[] { 1, 3, 1, 1 },
            };

            var result = Library.BrickWall.LeastBricks(input);

            Console.WriteLine("Input:");

            foreach (var item in input)
            {
                Console.WriteLine(string.Join(", ", item));
            }

            Console.WriteLine("");
            Console.WriteLine("Output: " + result.ToString());
            Console.WriteLine("Expected: 2");
            Console.ReadKey();
        }
    }
}

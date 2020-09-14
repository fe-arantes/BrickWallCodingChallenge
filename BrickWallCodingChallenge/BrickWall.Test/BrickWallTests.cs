using System;
using Xunit;

namespace BrickWall.Test
{
    public class BrickWallTests
    {
        [Fact]
        public void Test1()
        {
            var input = new int[][]
            {
                new int[] { 3, 5, 1, 1 },
                new int[] { 2, 3, 3, 2 },
                new int[] { 5, 5 },
                new int[] { 4, 4, 2 },
                new int[] { 1, 3, 3, 3 },
                new int[] { 1, 1, 6, 1, 1 },
            };

            var result = Library.BrickWall.LeastBricks(input);
            var resultExpected = 2;

            Assert.Equal(resultExpected, result);
        }

        [Fact]
        public void Test2()
        {
            var input = new int[][]
            {
                new int[] { 5, 5 },
                new int[] { 2, 2, 2, 2, 2 },
                new int[] { 3, 4, 3 },
                new int[] { 7, 1, 2 },
                new int[] { 8, 1, 1 },
                new int[] { 1, 2, 3, 4 },
            };

            var result = Library.BrickWall.LeastBricks(input);
            var resultExpected = 3;

            Assert.Equal(resultExpected, result);
        }
    }
}

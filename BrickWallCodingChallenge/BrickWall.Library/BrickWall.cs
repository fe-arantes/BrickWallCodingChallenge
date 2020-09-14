using System;
using System.Collections.Generic;
using System.Linq;

namespace BrickWall.Library
{
    public class BrickWall
    {
        public static int LeastBricks(int[][] brickWall)
        {
            //Complexidade de Tempo = O(n)
            //Cada vez que n dobra de tamanho, o tempo de execução dobra.

            var maxEdges = 0;
            var edgesPerBricksSum = new Dictionary<int, int>();

            foreach (var brickLine in brickWall)
            {
                var bricksSum = 0;

                for (var brick = 0; brick < brickLine.Count() - 1; brick++)
                {
                    bricksSum += brickLine[brick];

                    edgesPerBricksSum.TryGetValue(bricksSum, out int current);
                    edgesPerBricksSum[bricksSum] = ++current;

                    if (current > maxEdges)
                    {
                        maxEdges = current;
                    }
                }
            }

            return brickWall.Count() - maxEdges;
        }
    }
}

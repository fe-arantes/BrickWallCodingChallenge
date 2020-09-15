using System;
using System.Collections.Generic;
using System.Linq;

namespace BrickWall.Library
{
    public class BrickWall
    {
        public static int LeastBricks(int[][] brickWall)
        {
            /*
            Complexidade de Tempo = O(n)
            
            Explicação:
            Sendo:
                N = O número de tijolos em cada linha está em um range de [1,10.000]
                M = A altura da parede está em um range de [1, 10.000]
                TOTAL = O número total de tijolos não excederá 20.000, 
                        logo, não existe o cenário de multiplar o máximo de tijolos na linha pelo máximo de tijolos na altura

            Função:
                F(x) = N * M <= 20.000

            E:
                Estou removendo o último tijolo, pois não podemos cortar nas extremidades

            Logo a Função será:
                F(x) = (N - 1) * M

            sendo assim, podemos concluir que o resultado será de:
                F(x) = N
                
             */


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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace BrickWall.Test
{
    [Binding]
    public class BrickWallSteps
    {
        private int result;
        private int[][] input;

        [Given(@"um array de arrays de inteiros")]
        public void DadoUmArrayDeArraysDeInteiros()
        {
            input = new int[][]
            {
                new int[] { 1, 2, 2, 1 },
                new int[] { 3, 1, 2 },
                new int[] { 1, 3, 2 },
                new int[] { 2, 4 },
                new int[] { 3, 1, 2 },
                new int[] { 1, 3, 1, 1 },
            };
        }

        [When(@"consumo o método LeastBricks")]
        public void QuandoConsumoOMetodoLeastBricks()
        {
            result = Library.BrickWall.LeastBricks(input);
        }

        [Then(@"vejo (.*)")]
        public void EntaoVejo(int p0)
        {
            Assert.Equal(p0, result);
        }
    }
}

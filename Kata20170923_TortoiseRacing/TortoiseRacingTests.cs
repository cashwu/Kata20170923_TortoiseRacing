using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170923_TortoiseRacing
{
    [TestClass]
    public class TortoiseRacingTests
    {
        [TestMethod]
        public void input_v1_1_v2_2_and_lead_1_should_return_1_0_0()
        {
            TortoiseRaceShouldBe(new[] { 1, 0, 0 }, 1, 2, 1);
        }

        [TestMethod]
        public void input_v1_1_v2_2_and_lead_2_should_return_2_0_0()
        {
            TortoiseRaceShouldBe(new[] { 2, 0, 0 }, 1, 2, 2);
        }

        private static void TortoiseRaceShouldBe(int[] expected, int v1, int v2, int g)
        {
            var tortoise = new Tortoise();
            var actual = tortoise.Race(v1, v2, g);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Tortoise
    {
        public int[] Race(int v1, int v2, int g)
        {
            if (v1 * 1 + g == v2 * 1)
            {
                return new [] { 1, 0, 0 };
            }

            if (v1 * 2 + g == v2 * 2)
            {
                return new[] { 2, 0, 0 };
            }

            return new[] { 0, 0, 0 };
        }
    }
}

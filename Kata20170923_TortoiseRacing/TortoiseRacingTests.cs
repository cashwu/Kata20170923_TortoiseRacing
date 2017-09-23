using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
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

        [TestMethod]
        public void input_v1_2_v2_4_and_lead_3_should_return_1_30_0()
        {
            TortoiseRaceShouldBe(new[] { 1, 30, 0 }, 2, 4, 3);
        }

        [TestMethod]
        public void input_v1_720_v2_850_and_lead_70_should_return_0_32_18()
        {
            TortoiseRaceShouldBe(new[] { 0, 32, 18 }, 720, 850, 70);
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
            var s = g * 1.0 / (v2 - v1) * 3600;
            var m = s / 60;
            s = s % 60 == 0 ? 0 : s % 60;

            var h = m / 60;
            m = m % 60 == 0 ? 0 : m % 60;

            return new[] { (int)h, (int)m, (int)s };
        }
    }
}

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

        [TestMethod]
        public void input_v1_80_v2_91_and_lead_37_should_return_3_21_49()
        {
            TortoiseRaceShouldBe(new[] { 3, 21, 49 }, 80, 91, 37);
        }

        [TestMethod]
        public void input_v1_820_v2_81_and_lead_550_should_return_0_n44_n39()
        {
            TortoiseRaceShouldBe(null, 820, 81, 550);
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
            var s = g * 3600.0 / (v2 - v1) ;
            var m = s / 60;
            s = s % 60 == 0 ? 0 : s % 60;

            var h = m / 60;
            m = m % 60 == 0 ? 0 : m % 60;

            if (h < 0 || m < 0 || s < 0)
            {
                return null;
            }

            return new[] { (int)h, (int)m, (int)s };
        }
    }
}

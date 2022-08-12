using Calculators;
using NUnit.Framework;
using System;

namespace CalculatorsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDecimalCalculations()
        {            
            Assert.AreEqual("300", Calculator.Add("100", "200"));
            Assert.AreEqual("1100", Calculator.Add("900", "200"));
            Assert.AreEqual("910", Calculator.Add("909", "1"));
            Assert.AreEqual("20014", Calculator.Add("10009", "10005"));
        }

    }
}
using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Calc.App.Calculator;

namespace Calc.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Given2And5ItAddItAs7()
        {
           Calculate(2, '+', 5).Should().Be(7);
        }

        [TestMethod]
        public void Given1And3ItSubtractsItAsMinus2()
        {
            Calculate(1, '-', 3).Should().Be(-2);
        }

        [TestMethod]
        public void Given2And2ItMultipliesItAs4()
        {
            Calculate(2, '*', 2).Should().Be(4);
        }

        [TestMethod]
        public void Given10And2ItDividesItAsMinus5()
        {
            Calculate(10, '/', 2).Should().Be(5);
        }

        [TestMethod]
        public void Given9And4ItModulatesItAs1()
        {
            Calculate(9, '%', 4).Should().Be(1);
        }
    }
}

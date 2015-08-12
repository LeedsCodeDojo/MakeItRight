using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prefix_Calc;

namespace Prefix_Calc_Test {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void OnePlusOneShouldReturnTwo() {
            var result = PrefixCalculator.Evaluate("+ 1 1");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OnePlusTwoShouldReturnThree() {
            var result = PrefixCalculator.Evaluate("+ 1 2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TwoPlusTwoShouldReturnFour() {
            var result = PrefixCalculator.Evaluate("+ 2 2");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TwoMinusOneShouldReturnOne() {
            var result = PrefixCalculator.Evaluate("- 2 1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TenMultiplyTwoShouldReturnTwenty() {
            var result = PrefixCalculator.Evaluate("* 10 2");
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TenDividedByTwoShouldReturnFive() {
            var result = PrefixCalculator.Evaluate("/ 10 2");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void NineDividedByTwoShouldReturnFour() {
            var result = PrefixCalculator.Evaluate("/ 9 2");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AddFromOneToNineShouldReturnFortyFive() {
            var result = PrefixCalculator.Evaluate("+ 1 2 3 4 5 6 7 8 9");
            Assert.AreEqual(45, result);
        }
    }
}

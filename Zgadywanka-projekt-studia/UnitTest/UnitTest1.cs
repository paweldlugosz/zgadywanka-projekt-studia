using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obiektowo;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(-100, 200)]
        [DataRow(10, -100)]
        [DataRow(7, 7)]
        public void Number_In_The_Range(int start, int end)
        {
            // Arange

            Game game = new Game(start, end);

            // Act

            int number = game.GiveUp();

            // Assert

            Assert.IsTrue(number >= Math.Min(start, end) && number <= Math.Max(start, end));
        }
    }
}

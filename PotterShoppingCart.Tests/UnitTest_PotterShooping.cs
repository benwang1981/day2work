using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day2HWLib;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class UnitTest_PotterShooping
    {
        [TestMethod]
        public void Test_Buy_V1_x1_should_ruturn_100()
        {
            //arrange
            var books = new List<Book>()
            {
                new Book() { Num = 1, Name = "哈利波特V1", Price = 100m},
            };

            //act
            var target = new ShoppingCart();
            decimal expected = 100m;
            decimal actual = target.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_V1_And_V2_x1_should_ruturn_190()
        {
            //arrange
            var books = new List<Book>()
            {
                new Book() { Num = 1, Name = "哈利波特V1", Price = 100m},
                new Book() { Num = 2, Name = "哈利波特V2", Price = 100m},
            };

            //act
            var target = new ShoppingCart();
            decimal expected = 190;
            decimal actual = target.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

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

        [TestMethod]
        public void Test_Buy_V1_And_V2_And_V3_x1_should_ruturn_270()
        {
            //arrange
            var books = new List<Book>()
            {
                new Book() { Num = 1, Name = "哈利波特V1", Price = 100m},
                new Book() { Num = 2, Name = "哈利波特V2", Price = 100m},
                new Book() { Num = 3, Name = "哈利波特V3", Price = 100m},
            };

            //act
            var target = new ShoppingCart();
            decimal expected = 270;
            decimal actual = target.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_V1_And_V2_And_V3_And_V4_x1_should_ruturn_320()
        {
            //arrange
            var books = new List<Book>()
            {
                new Book() { Num = 1, Name = "哈利波特V1", Price = 100m},
                new Book() { Num = 2, Name = "哈利波特V2", Price = 100m},
                new Book() { Num = 3, Name = "哈利波特V3", Price = 100m},
                new Book() { Num = 4, Name = "哈利波特V4", Price = 100m},
            };

            //act
            var target = new ShoppingCart();
            decimal expected = 320;
            decimal actual = target.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_V1_And_V2_And_V3_And_V4_And_V5_x1_should_ruturn_375()
        {
            //arrange
            var books = new List<Book>()
            {
                new Book() { Num = 1, Name = "哈利波特V1", Price = 100m},
                new Book() { Num = 2, Name = "哈利波特V2", Price = 100m},
                new Book() { Num = 3, Name = "哈利波特V3", Price = 100m},
                new Book() { Num = 4, Name = "哈利波特V4", Price = 100m},
                new Book() { Num = 5, Name = "哈利波特V5", Price = 100m},
            };

            //act
            var target = new ShoppingCart();
            decimal expected = 375;
            decimal actual = target.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_V1_And_V2_x1_And_V3_x2_should_ruturn_370()
        {
            //arrange
            var books = new List<Book>()
            {
                new Book() { Num = 1, Name = "哈利波特V1", Price = 100m},
                new Book() { Num = 2, Name = "哈利波特V2", Price = 100m},
                new Book() { Num = 3, Name = "哈利波特V3", Price = 100m},
                new Book() { Num = 3, Name = "哈利波特V3", Price = 100m},
            };

            //act
            var target = new ShoppingCart();
            decimal expected = 270;
            decimal actual = target.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}

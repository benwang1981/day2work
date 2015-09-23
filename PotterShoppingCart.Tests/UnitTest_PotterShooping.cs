﻿using System;
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
            var target = new PotterShoppingCart();
            decimal expected = 100m;
            decimal actual =  PotterShoppingCart.Calculate(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
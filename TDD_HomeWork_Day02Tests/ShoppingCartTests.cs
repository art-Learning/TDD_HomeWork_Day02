using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_HomeWork_Day02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HomeWork_Day02.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        [TestCategory("哈利波特優惠")]
        public void 第一集買了一本其他都沒買價格應為100元()
        {
            //arrange
            var books = new List<Book>
            {
                new Book {書名 = "哈利波特", 集數 = 1, 價格 = 100}
            };
            var target = new ShoppingCart();
            var expected = 100;
            //act
            var actual = target.Pay(books);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [TestCategory("哈利波特優惠")]
        public void 第一集買了一本第二集也買了一本價格應為190()
        {
            //arrange
            var books = new List<Book>
            {
                new Book {書名 = "哈利波特", 集數 = 1, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 2, 價格 = 100}
            };
            var target = new ShoppingCart();
            var expected = 190;
            //act
            var actual = target.Pay(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
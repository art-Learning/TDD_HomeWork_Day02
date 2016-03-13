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

        [TestMethod()]
        [TestCategory("哈利波特優惠")]
        public void 一二三集各買了一本價格應為270()
        {
            //arrange
            var books = new List<Book>
            {
                new Book {書名 = "哈利波特", 集數 = 1, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 2, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 3, 價格 = 100}
            };
            var target = new ShoppingCart();
            var expected = 270;
            //act
            var actual = target.Pay(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [TestCategory("哈利波特優惠")]
        public void 一二三四集各買了一本價格應為320()
        {
            //arrange
            var books = new List<Book>
            {
                new Book {書名 = "哈利波特", 集數 = 1, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 2, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 3, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 4, 價格 = 100}
            };
            var target = new ShoppingCart();
            var expected = 320;
            //act
            var actual = target.Pay(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [TestCategory("哈利波特優惠")]
        public void 一次買了整套一二三四五集各買了一本價格應為375()
        {
            //arrange
            var books = new List<Book>
            {
                new Book {書名 = "哈利波特", 集數 = 1, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 2, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 3, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 4, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 5, 價格 = 100}
            };
            var target = new ShoppingCart();
            var expected = 375;
            //act
            var actual = target.Pay(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [TestCategory("哈利波特優惠")]
        public void 一二集各買了一本第三集買了兩本價格應為370()
        {
            //arrange
            var books = new List<Book>
            {
                new Book {書名 = "哈利波特", 集數 = 1, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 2, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 3, 價格 = 100},
                new Book {書名 = "哈利波特", 集數 = 3, 價格 = 100}
            };
            var target = new ShoppingCart();
            var expected = 370;
            //act
            var actual = target.Pay(books);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
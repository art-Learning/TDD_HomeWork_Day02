using System.Collections.Generic;
using System.Linq;

namespace TDD_HomeWork_Day02
{
    /// <summary>
    /// 購物車
    /// </summary>
    public class ShoppingCart
    {
        private double _discount;
        private double _總金額;
        /// <summary>
        /// 結帳計算總金額
        /// </summary>
        /// <param name="books">要購買的書籍</param>
        /// <returns></returns>
        public double Pay(List<Book> books)
        {
            while (books.Any())
            {
                _discount = GetDiscount(books);
                var preferentialBooks = GetPreferentialBooks(books);
                GetPrice(books, preferentialBooks, _discount);
            }
            return _總金額;
        }
        /// <summary>
        /// 計算優惠書籍的價格，並將計算過的書從購物車中移除
        /// </summary>
        /// <param name="books">要購買的書籍</param>
        /// <param name="preferentialBooks">本次優惠書籍</param>
        /// <param name="disCount">本次優惠折扣</param>
        private void GetPrice(List<Book> books, List<Book> preferentialBooks,double disCount)
        {
            foreach (var book in preferentialBooks)
            {
                _總金額 += (book.價格* disCount);
                books.Remove(book);
            }
        }
        /// <summary>
        /// 取得符合優惠規則的書籍清單
        /// </summary>
        /// <param name="books">要購買的書籍</param>
        /// <returns></returns>
        private List<Book> GetPreferentialBooks(List<Book> books)
        {
            List<Book> preferentialBooks = new List<Book>();
            foreach (var 集數 in books.Select(x => x.集數).Distinct().ToList())
            {
                preferentialBooks.Add(books.Find(x => x.集數 == 集數));
            }
            return preferentialBooks;
        }
        /// <summary>
        /// 取得符合規則的優惠折扣，否則以原價計算
        /// </summary>
        /// <param name="books">要購買的書籍</param>
        /// <returns></returns>
        private double GetDiscount(List<Book> books)
        {
            var bookTypeCount = books.Select(x => x.集數).Distinct().Count();
            switch (bookTypeCount)
            {
                case 2:
                    _discount = 0.95;
                    break;
                case 3:
                    _discount = 0.9;
                    break;
                case 4:
                    _discount = 0.8;
                    break;
                case 5:
                    _discount = 0.75;
                    break;
                default:
                    _discount = 1;
                    break;
            }
            return _discount;
        }
    }
}

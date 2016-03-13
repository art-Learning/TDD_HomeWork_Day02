using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HomeWork_Day02
{
    /// <summary>
    /// 購物車
    /// </summary>
    public class ShoppingCart
    {
        private double discount;
        private double 總金額;
        /// <summary>
        /// 結帳計算總金額
        /// </summary>
        /// <param name="books">要購買的書籍</param>
        /// <returns></returns>
        public double Pay(List<Book> books)
        {
            while (books.Any())
            {
                //取得書籍優惠折扣
                var bookTypeCount = books.Select(x => x.集數).Distinct().Count();
                switch (bookTypeCount)
                {
                    case 2:
                        discount = 0.95;
                        break;
                    case 3:
                        discount = 0.9;
                        break;
                    case 4:
                        discount = 0.8;
                        break;
                    case 5:
                        discount = 0.75;
                        break;
                    default:
                        discount = 1;
                        break;
                }
                //這一次要優惠的書
                List<Book> preferentialBooks = new List<Book>();
                foreach (var 集數 in books.Select(x => x.集數).Distinct().ToList())
                {
                    preferentialBooks.Add(books.Find(x=>x.集數==集數));
                }
                    
                //價格加總
                foreach (var book in preferentialBooks)
                {
                    總金額 += (book.價格 * discount);
                    //從購物車中把這一次計算優惠的書拿出來
                    books.Remove(book);
                }
            }
            return 總金額;
        }
    }
}

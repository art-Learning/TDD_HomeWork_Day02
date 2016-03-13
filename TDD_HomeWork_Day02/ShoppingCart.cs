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
            //取得書籍優惠折扣
            var bookTypeCount = books.Distinct().Count();
            switch (bookTypeCount)
            {
                case 2:
                    discount = 0.95;
                    break;
                default:
                    discount = 1;
                    break;
            }
            //價格加總
            foreach (var book in books)
            {
                總金額 += (book.價格*discount);
            }
            return 總金額;
        }
    }
}

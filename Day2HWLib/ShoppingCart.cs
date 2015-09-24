using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2HWLib
{
    public class ShoppingCart
    {
        public decimal Calculate(List<Book> books)
        {
            decimal amount = 0;
            decimal discount = GetDiscount(books.GroupBy(book => book.Num).Count());

            amount = books.Sum(book => book.Price * discount);

            return amount;
        }

        private decimal GetDiscount(int numCount)
        {
            decimal discount = 1;

            switch (numCount)
            {
                case 1:
                    discount = 1;
                    break;
                case 2:
                    discount = 0.95m;
                    break;
                case 3:
                    discount = 0.9m;
                    break;
                case 4:
                    discount = 0.8m;
                    break;
                case 5:
                    discount = 0.75m;
                    break;
            }

            return discount;
        }
    }
}

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
            decimal discount = 1;

            amount = books.Sum(book => book.Price*discount);

            return amount;
        }
    }
}

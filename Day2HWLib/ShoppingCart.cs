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
            var bookGroup = from book in books
                group book by book.Num
                into gp
                select new
                {
                    Num = gp.Key,
                    Count = gp.Count(),
                    Price = gp.First().Price
                };

            var bookGroupList = bookGroup.ToList();
            var sumCount = 0;

            while (bookGroupList.Any(bg => bg.Count - sumCount > 0))
            {
                var matchedGroup = bookGroupList.FindAll(bg => bg.Count - sumCount > 0).ToList();
                int numCount = matchedGroup.Count();
                int minCount = matchedGroup.Min(item => item.Count - sumCount);

                decimal discount = GetDiscount(numCount);
                amount += matchedGroup.Sum(book => book.Price * minCount * discount);
                sumCount += minCount;
            }

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

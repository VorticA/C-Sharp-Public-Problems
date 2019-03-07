using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, double price)
        {
            base.Title = title;
            base.Author = author;
            base.Price = price * 130 / 100;
        }
    }
}

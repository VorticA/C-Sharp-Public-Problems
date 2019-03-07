using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Book
    {
        private string title;
        private string author;
        private double price;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Title not valid!");
                this.title = value;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                if (char.IsDigit(value[value.IndexOf(" ") + 1])) throw new ArgumentException("Author not valid!");
                this.author = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Price not valid!");
                this.price = value; 
            }
        }

        public Book()
        {

        }
        public Book(string author, string title, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public override string ToString()
        {
            return "Type: " + this.GetType().Name
                + "\nTitle: " + this.title
                + "\nAuthor: " + this.author
                + "\nPrice: " + String.Format("{0:0.00}", this.price);
        }
    }
}

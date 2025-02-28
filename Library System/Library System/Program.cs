using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;

        }
            public override string ToString()
            {
            return $"{Title} by {Author}, published in {Year}";
        }
    }


   public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
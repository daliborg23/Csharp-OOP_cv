using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition2 {
    public class Book {
        private string title;
        private Author author;
        private int pages;
        private double price;
        private bool available;

        #region properties
        public string Title { get => title; set => title = value; }
        public Author Author { get => author; set => author = value; }
        public int Pages { get => pages; set => pages = value; }
        public double Price { get => price; set => price = value; }
        public bool Available { get => available; set => available = value; }
        #endregion
        #region ctor
        public Book(string title, Author author, int pages, double price) {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.Price = price;
            this.Available = true;
        }
        #endregion
        public override string ToString() {
            return $"| {Author,19} - {Title,23} | Pages: {Pages,3} | Price: {Price.ToString("N2")},- | Available: {(Available == true ? "Yes" : "No"),3} |";
        }
    }
}

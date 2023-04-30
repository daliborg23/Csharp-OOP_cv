using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition2 {
    public class Reader {
        private string firstName;
        private string lastName;
        private List<Book> myBooks;
        private DateTime dateOfBirth;

        #region properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<Book> MyBooks { get => myBooks; set => myBooks = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        #endregion
        #region ctor
        public Reader() {
        }
        public Reader(string firstName, string lastName, List<Book> myBooks, DateTime dateOfBirth) {
            FirstName = firstName;
            LastName = lastName;
            MyBooks = myBooks;
            DateOfBirth = dateOfBirth;
        }
        #endregion

        public void borrowBook(Book book) {
            // if kniha available==true, nastavi na false a prida do myBooks
            if (book.Available == true) {
                MyBooks.Add(book);
                book.Available = false;
            } else {
                Console.WriteLine($"Kniha neni dostupna. {book.Author} - {book.Title}");
            }
        }
        public void returnBook(Book book) {
            if (book.Available == false && MyBooks.Contains(book)) {
                MyBooks.Remove(book);
                book.Available = true;
            }
            else {
                Console.WriteLine($"Nemuzes nam vratit neco co nemas. {book.Author} - {book.Title}");
            }
        }
        public void listBorrowed() {
            if (MyBooks.Count > 0) {
                Console.WriteLine($"  {FirstName} {LastName} si pujcil tyhle knihy:");
                foreach (Book book in MyBooks) {
                    Console.WriteLine($" {book.Author,20} - {book.Title,23}");
                }
            } else {
                Console.WriteLine($"{FirstName} {LastName} si nepujcil zadnou knihu.");
            }
        }
    }
}

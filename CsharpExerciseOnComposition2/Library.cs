using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition2 {

    public class Library {
        private List<Book> books;
        #region properties
        public List<Book> Books { get => books; set => books = value; }
        #endregion
        #region ctor
        public Library() {
            this.Books = new List<Book>();
        }
        #endregion

        public void addBook(Book book) { 
            Books.Add(book);
        }
        public void listAvailable() {
            Console.WriteLine("---------------------------------------Seznam-dostupnych-knih------------------------------------");
            bool empty = true;
            foreach (Book book in Books) {
                if (book.Available == true) { 
                    Console.WriteLine(book.ToString());
                    empty = false;
                }
            }
            if (empty == true) {
                Console.WriteLine("                                       Neni dostupna zadna kniha.");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }
        public void listUnavailable() {
            Console.WriteLine("--------------------------------------Seznam-vypujcenych-knih------------------------------------");
            bool full = true;
            foreach (Book book in Books) {
                if (book.Available == false) {
                    Console.WriteLine(book.ToString());
                    full = false;
                }
            }
            if (full == true) {
                Console.WriteLine("                                       Nikdo si nic nepujcil.");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }
        public void listAll() {
            Console.WriteLine("-----------------------------------------Seznam-vsech-knih---------------------------------------");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition2 {
    public class Author {
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime dateOfBirth;
        private List<Book> books;

        #region properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public List<Book> Books { get => books; set => books = value; }
        #endregion
        #region ctor
        public Author(string firstName, string lastName, DateTime dateOfBirth) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Books = new List<Book>();
        }
        public Author(string firstName, string middlename, string lastName, DateTime dateOfBirth) {
            this.FirstName = firstName;
            this.MiddleName = middlename;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Books = new List<Book>();
        }
        #endregion
        public void listBooks() { // vypise knihy autora
            
        }
        public override string ToString() {
            //return $"{FirstName} {(MiddleName == null ? string.Empty : MiddleName)} {LastName}";
            if (MiddleName == null) {
                return $"{FirstName} {LastName}";
            } else {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }
    }
}

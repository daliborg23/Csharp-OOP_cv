namespace CsharpExerciseOnComposition2 {
    class Program {
        public static void Main(string[] args) {
            Author a1 = new Author("Karel", "Jaromir", "Erben", new DateTime(11 / 07 / 1811));
            Book b1_1 = new Book("Kytice", a1, 350, 299.50);
            Book b1_2 = new Book("Vecer", a1, 400, 322.00);
            Book b1_3 = new Book("Na hrbitove", a1, 380, 310.50);
            Author a2 = new Author("Jaroslav", "Foglar", new DateTime(07 / 06 / 1907));
            Book b2_1 = new Book("Hosi od Bobri reky", a2, 450, 380.00);
            Book b2_2 = new Book("Zahada hlavolamu", a2, 280, 380.00);
            Book b2_3 = new Book("Stinadla se bouri", a2, 500, 505.00);
            Book b2_4 = new Book("Tajemstvi Velkeho Vonta", a2, 420, 450.00);
            Author a3 = new Author("Franz", "Kafka", new DateTime(07 / 03 / 1883));
            Book b3_1 = new Book("Promena", a3, 420, 420.42);
            Book b3_2 = new Book("Strazce hrobky", a3, 280, 199.99);
            Book b3_3 = new Book("Vsedni zmatek", a3, 333, 362.50);
            Author a4 = new Author("Karel", "Capek", new DateTime(01 / 09 / 1890));
            Book b4_1 = new Book("R.U.R.",a4,420,420.00);
            Book b4_2 = new Book("Tovarna na absolutno",a4,420,420.00);
            Book b4_3 = new Book("Valka s Mloky", a4, 420, 420.00);
            Book b4_4 = new Book("Bila nemoc", a4, 420, 420.00);
            Book b5_1 = new Book("1984", new Author("George", "Orwell", new DateTime(06 / 25 / 1903)),666,198.40);
            Book b5_2 = new Book("Farma zvirat", b5_1.Author, 350, 350.00);
            Book b5_3 = new Book("Barmske dny", b5_1.Author, 400, 400.00);

            Library library = new Library();
            //library.Books = new List<Book> { b1_1, b1_2, b1_3, b2_1, b2_2, b2_3, b2_4, b3_1, b3_2, b3_3, b4_1, b4_2, b4_3, b4_4, b5_1, b5_2, b5_3 }; // 2. varianta
            library.addBook(b1_1);
            library.addBook(b1_2);
            library.addBook(b1_3);
            library.addBook(b2_1);
            library.addBook(b2_2);
            library.addBook(b2_3);
            library.addBook(b2_4);
            library.addBook(b3_1);
            library.addBook(b3_2);
            library.addBook(b3_3);
            library.addBook(b4_1);
            library.addBook(b4_2);
            library.addBook(b4_3);
            library.addBook(b4_4);
            library.addBook(b5_1);
            library.addBook(b5_2);
            library.addBook(b5_3);

            // Vypis nove zrizene knihovny
            Console.WriteLine("=========================================ZRIZENA=KNIHOVNA========================================");
            library.listAll();
            Console.WriteLine();
            library.listAvailable();
            Console.WriteLine();
            library.listUnavailable();
            Console.WriteLine();

            // Vytvoreni ctenare
            Console.WriteLine("=================================VYTVOREN=CTENAR=A=PUJCIL=SI=3=KNIZKY============================");
            Reader reader = new Reader("Karel","Ctekniha",new List<Book>(),new DateTime(01/01/1990));
            reader.borrowBook(b1_1);
            reader.borrowBook(b1_2);
            reader.borrowBook(b1_3);

            // Vypis po vypujceni (knihovna)
            library.listAll();
            Console.WriteLine();
            library.listAvailable();
            Console.WriteLine();
            library.listUnavailable();
            Console.WriteLine();
            Console.WriteLine();
            // Vypis pujcenych knih ctenare
            reader.listBorrowed();
            Console.WriteLine();

            Console.WriteLine("====================================VRACENI=3=PUJCENYCH=KNIH=============================");
            reader.returnBook(b1_1);
            reader.returnBook(b1_2);
            reader.returnBook(b1_3);

            // Vypis po vypujceni
            library.listAll();
            Console.WriteLine();
            library.listAvailable();
            Console.WriteLine();
            library.listUnavailable();
            Console.WriteLine();

            // Dalsi ctenar
            Console.WriteLine("==========================VYTVOREN=DALSI=CTENAR=A=PUJCIL=SI=10=KNIZEK============================");
            Reader reader2 = new Reader("Ayem", "Readinbooks", new List<Book>(), new DateTime(01 / 01 / 1990));
            reader2.borrowBook(b2_1);
            reader2.borrowBook(b2_2);
            reader2.borrowBook(b2_3);
            reader2.borrowBook(b2_4);
            reader2.borrowBook(b3_1);
            reader2.borrowBook(b3_2);
            reader2.borrowBook(b3_3);
            reader2.borrowBook(b4_1);
            reader2.borrowBook(b4_2);
            reader2.borrowBook(b4_3);
            reader2.borrowBook(b4_4);

            // Vypis po vypujceni
            library.listAll();
            Console.WriteLine();
            library.listAvailable();
            Console.WriteLine();
            library.listUnavailable();
            Console.WriteLine();

            Console.WriteLine("Zkouska");
            // Zkouska pujceni knihy ktera uz je pujcena
            reader.borrowBook(b2_1);
            // Zkouska vraceni knihy, kterou ci pujcil nekdo jiny
            reader.returnBook(b2_1);

            reader.listBorrowed();

        }
    }

}
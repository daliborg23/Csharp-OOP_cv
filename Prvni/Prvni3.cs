namespace Prvni3 {
    class Prvni3 {
        public static void Mainx() {
            Student s1 = new Student(18, 10000);
            Accountant a1 = new Accountant(22, 25000);
            Teacher t1 = new Teacher(33, 35000, 12);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
        }
    }
    class Person {
        public int age;
    }
    class Employee : Person {
        public int salary;
    }
    class Student : Person {
        public int scholarship;
        public Student(int age, int scholarship) {
            this.age = age;
            this.scholarship = scholarship;
        }
        public void writeInfo() {
            Console.WriteLine("Vek studenta: " + age + " Stipendium: " + scholarship);
            //Console.WriteLine($"Vek: {age} Stipendium: {scholarship} PODRUHE"); //argument prikazoveho radku
        }
    }
    class Accountant : Employee {
        public Accountant(int age, int salary) {
            this.age = age;
            this.salary = salary;
        }
        public void writeInfo() {
            Console.WriteLine("Vek ekonomky: " + age + " Plat: " + salary);
        }
    }
    class Teacher : Employee {
        public int teachingTime;
        public Teacher(int age, int salary, int teachingTime) {
            this.age = age;
            this.salary = salary;
            this.teachingTime = teachingTime;
        }

        public void writeInfo() {
            Console.WriteLine("Vek ucitele: " + age + " Plat: " + salary + " Oduceny cas: " + teachingTime);
        }
    }
}
//3.       Přidání dědičnosti(kap.Dědičnost)
// Pozor: ! Nedělat úkoly dopředu, v nových třídách(Person a Employee) zatím nebudeme vytvářet konstruktor ani metodu writeInfo().
// Tedy třídy Person i Employee budou mít jen jeden řádek.A nevolat ještě :base(), tedy nevolat  nadřazený konstruktor z podřízeného, to je až v bodě 5
// Vidíme, že v programu je opakovaně deklarována datová složka age, také metoda writeInfo() a konstruktory jsou z větší části stejné.
// Zvláště při větším množství tříd by byl program zbytečně dlouhý. Proto provedeme analýzu, zda bychom mezi objekty nenašli znaky dědičnosti
// (tedy zda nemají třídy některé datové složky společné). Vytvoříme tedy třídu Person, která bude obsahovat datovou složku age,
// a ostatní tři třídy z ní budou dědit(doplňte za dvojtečku). Odstraňte z tříd Student, Accountant a Teacher datovou složku age,
// kterou již nepotřebují, neboť ji podědily.
// Nejprve si to vyzkoušíme pro třídu Student.Pokud se program spustí v pořádku, provedeme tytéž změny i pro ostatní dvě třídy.
// !! Takto budeme postupovat i v dalších bodech: nejprve změnu odzkoušíme na třídě Student a program spustíme.Teprve bude-li vše v pořádku, upravíme i další třídy!!
// 2. krok: Pokračujeme v analýze dále a zjistíme, že třída Accountant a Teacher mají společnou datovou složku salary.Takže vytvoříme jim nadřazenou třídu Employee,
// který bude dědit z třídy Person a navíc bude přidávat datovou složku salary.Takže  Student a Employee budou dědit z třídy Person.
// Teacher a Accountant pak budou v hierarchii ještě níže, budou dědit z třídy Employee.Odstraňte z tříd Accountant a Teacher datovou složku salary,
// kterou již nepotřebují.Pozor: v nových třídách zatím nevytváříme konstruktor ani metodu writeInfo().

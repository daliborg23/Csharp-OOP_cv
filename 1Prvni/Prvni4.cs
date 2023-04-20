namespace Prvni4 {
    class Prvni4 {
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
        public Person() { }
        public Person(int age) {
            this.age = age;
        }
    }
    class Employee : Person {
        public int salary;
        public Employee() { }
        public Employee(int age, int salary) {
            this.age = age;
            this.salary = salary;
        }
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
//4.Přidání konstruktoru do nadřazené třídy(kap.Dědičnost/Dědičnost konstruktorů)
//Pozor! Nedělat úkoly dopředu, tedy nevolat ještě :base(), tedy nevolat  nadřazený konstruktor z podřízeného, to je až v bodě 5
//Konstruktory podřízených tříd nejsou naprogramovány efektivně.Zbytečně všechny nastavují například age.
//Ve třídě Person proto vytvoříme konstruktor nastavující age, ve třídě Employee bude nastavovat salary (jiné konstruktory neměníme).
//Zkusíme program zkompilovat, objeví se hlášení, že chybí bezparametrový konstruktor Person() a Employee(). Proč předtím nechyběl?
//Vždyť nebyl ani předtím! A navíc stejně ani nikde není volán!


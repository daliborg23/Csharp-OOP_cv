namespace Prvni5 {
    class Prvni5 {
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
        //public Person() { }
        public Person(int age) {
            this.age = age;
        }
    }
    class Employee : Person {
        public int salary;
        //public Employee() { }
        public Employee(int age, int salary) : base(age) {
            this.salary = salary;
        }
    }
    class Student : Person {
        public int scholarship;
        public Student(int age, int scholarship) : base(age) {
            this.scholarship = scholarship;
        }
        public void writeInfo() {
            Console.WriteLine("Vek studenta: " + age + " Stipendium: " + scholarship);
            //Console.WriteLine($"Vek: {age} Stipendium: {scholarship} PODRUHE"); //argument prikazoveho radku
        }
    }
    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
        }
        public void writeInfo() {
            Console.WriteLine("Vek ekonomky: " + age + " Plat: " + salary);
        }
    }
    class Teacher : Employee {
        public int teachingTime;
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            this.teachingTime = teachingTime;
        }

        public void writeInfo() {
            Console.WriteLine("Vek ucitele: " + age + " Plat: " + salary + " Oduceny cas: " + teachingTime);
        }
    }
}
//5. Volání nadřazeného konstruktoru(:base) z podřízeného(tatáž kap.) (5b: přetěžování)
//  V minulém kroku jsme vytvořili konstruktor Osoby s parametrem, ale ještě není odnikud volán.
//  Upravíme tedy konstruktor ve třídě Student, bude nejprve volán bezparametrický nadřazený konstruktor :base().
//  Nic jiného neměníme.Program dále funguje.To je důkaz, že opravdu je implicitně volán nejprve bezparametrický konstruktor nadřazené třídy.
// Volání bezparametrického nadřazeného konstruktoru nám ale nepřináší žádnou výhodu. Proto jej změníme na volání konstruktoru s parametrem:  :base(age),
// u učitele a ekonomky :base(age, salary) a potom bude přiřazen už jen datová složka, který je proti nadřazené třídě navíc
// (pro kontrolu: Accountant nemá navíc žádnou datovou složku).
// Ověřte, že když už teď z tříd Student, Accountant a Teacher voláme explicitně parametrický konstruktor nadřazené třídy,
// tak již bezparametrický konstruktor třídy Employee ani Person 
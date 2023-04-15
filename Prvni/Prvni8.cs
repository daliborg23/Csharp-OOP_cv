namespace Prvni8 {
    class Prvni8 {
        public static void Mainx() {
            Student s1 = new Student(18, 10000);
            Accountant a1 = new Accountant(22, 25000);
            Teacher t1 = new Teacher(33, 35000, 12);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Student s2 = new Student();
            s2.writeInfo();
            Console.WriteLine("Celkovy pocet osob: " + Person.count + ", vek osoby t1: " + t1.age);
        }
    }
    class Person {
        public int age;
        public static int count = 0;
        public Person() {
            count++;
        }
        public Person(int age) {
            this.age = age;
            count++;
        }
        public virtual void writeInfo() {
            Console.Write("Vek: " + age);
        }
    }
    class Employee : Person {
        public int salary;
        public Employee() {
        }
        public Employee(int age, int salary) : base(age) {
            this.salary = salary;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.Write(", Plat: " + salary);
        }
    }
    class Student : Person {
        public int scholarship;
        public Student() {
        }
        public Student(int age, int scholarship) : base(age) {
            this.scholarship = scholarship;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Stipendium: " + scholarship);
            Console.WriteLine("Pocet osob: " + count);
        }
    }
    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine();
            //Console.WriteLine("Vek: " + age + " Plat: " + salary + " - Accountant");
        }
    }
    class Teacher : Employee {
        public int teachingTime;
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            this.teachingTime = teachingTime;
        }

        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Oduceny cas: " + teachingTime);
        }
    }
}
//8. Doplnění statické proměnné s počtem instancí(kap.Modifikátor Static)
//Třídu Person doplníme o statickou datovou složku count(tedy počet). V konstruktoru ji inkrementujeme.Doplníme její výpis do metody writeInfo() v třídě Person.
//Doplňte v třídě Student konstruktor bez parametru (snippet ctor-TAB-TAB), musí existovat i bezparametrický konstruktor třídy Person.V hlavním programu vytvořte dalšího studenta,
//tentokrát bez parametrů.Také pro něj spusťte výpis writeInfo(). Je údaj o počtu osob správně? je


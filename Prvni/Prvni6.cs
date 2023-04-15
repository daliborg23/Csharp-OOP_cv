namespace Prvni6 {
    class Prvni6 {
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
        public Person() {
        }
        public Person(int age) {
            this.age = age;
        }
        public void writeInfo() {
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
        public void writeInfo() {
            base.writeInfo();
            Console.Write(", Plat: " + salary);
        }
    }
    class Student : Person {
        public int scholarship;
        public Student(int age, int scholarship) : base(age) {
            this.scholarship = scholarship;
        }
        public void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Stipendium: " + scholarship);
        }
    }
    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
        }
        public void writeInfo() {
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

        public void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Oduceny cas: " + teachingTime);
        }
    }
}
//Přidání metody writeInfo() do nadřazené třídy(kap.Překrývání - úvod)
//Stále jsou neefektivně naprogramovány metody writeInfo.V případě, že by třídy měly desítky shodných datových složek,
//tak by měly zbytečně desítky shodných řádků.Hierarchie by se tedy dala použít i pro metodu writeInfo(). Nadřazené třídy Person a Employee by měly zajistit výpis datových složek,
//které jsou v nich deklarovány (age, resp.salary). Takže ve třídě Student pak stačí, když metoda writeInfo() zavolá stejnojmennou metodu z nadřazené třídy
//(base.writeInfo()) a pak sama navíc vypíše už jen scholarship.Obdobně tato metoda ve třídě Employee navíc vypíše salary a v třídě Teacher úvazkové hodiny.
//Ověřte, že příkaz base.writeInfo() nemusí být v metodě první.
//Co by se stalo, kdybychom prefix base neuvedli? Kompilátoru by to nevadilo, při běhu by se však program „zauzloval“, ohlásil by stackOverflowError.Proč?
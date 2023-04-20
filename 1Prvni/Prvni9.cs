namespace Prvni9 {
    class Prvni9 {
        public static void Mainx() {
            Student s1 = new Student(18, 10000);
            Accountant a1 = new Accountant(22, 25000);
            Teacher t1 = new Teacher(33, 35000, 39);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Console.WriteLine("Pocet osob: " + Person.getCount() + ", vek: " + t1.getAge());
            Console.WriteLine(t1.TeachingTime);
            Console.WriteLine(t1.Salary);
        }
    }
    class Person {
        private int age;
        protected static int count;
        public Person() {
            count++;
        }
        public Person(int age) {
            this.age = age;
            count++;
        }
        public static int getCount() {
            return count;
        }
        public int getAge() {
            return age;
        }
        public void setAge(int age) {
            this.age = age;
        }
        public virtual void writeInfo() {
            Console.Write("Pocet osob: " + count + ", Vek: " + age);
        }
    }
    class Employee : Person {
        //public int salary;
        //public int salary { get; set; }

        public int Salary { get; set; }
        public Employee() {
        }
        public Employee(int age, int salary) : base(age) {
            //this.salary = salary;
            this.Salary = salary;
        }
        public override void writeInfo() {
            base.writeInfo();
            //Console.WriteLine(", Plat: " + salary);
            Console.Write(", Plat: " + Salary);
            Console.Write(", pocet osob2: " + count);
            Console.Write(", vek: " + getAge());
            //Console.WriteLine("Vek: " + getAge() + " Pocet: " + getCount());
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
        private int teachingTime;
        public int TeachingTime {
            get {
                return teachingTime;
            }
            set {
                if (value > 40) {
                    Console.WriteLine("Uvazek nesmi presahnout 40 hodin.");
                } else {
                    teachingTime = value;
                }
            }
        }
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            TeachingTime = teachingTime;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Oduceny cas: " + teachingTime);
        }
    }
}
//9. Změna datové složky na privátní(kap Zapouzdření)
// Předělejte datovou složku age třídy Person na privátní a statickou datovou složku count na protected. Pokud se s touto proměnnou pracuje jen v třídě Person,
// pak se nic neděje.Jakmile však doplníme výpis této proměnné do jiné třídy, tak třída nepůjde skompilovat.Ověříme si to snahou vypsat hodnotu těchto datových složek
// v metodě writeInfo() ve třídě Employee(dědí z třídy Person) a v metodě Main, která je ve třídě Prvni9, která nedědí z třídy Person.Jak to bude vypadat s kompilací?
// Půjde něco zkompilovat? Ne
//Musíme tedy vytvořit přístupové metody getCount(), getAge() a setAge() v třídě Person, která bude mít přístup public. Budou to metody instance nebo statické metody?
//Pozor: použijeme běžné gettery a settery getCount(), getAge() a setAge(). Nebudeme vytvářet Vlastnosti(Properties) ze stejnojmenné(následující) kapitoly
// Pak použijeme volání těchto metod v místech, která nešla zkompilovat.
//
//Druhý krok (kap.Vlastnosti) Předělejte datovou složku teachingTime (ve třídě Teacher) na privátní.Vytvořte k ní vlastnost TeachingTime. Hlídejte například,
//že nesmí být větší než 40. Ověřte pomocí WriteLine v metodě Main.
//
//Třetí krok: místo datové složky salary ve třídě Employee použijte automaticky implementovanou vlastnost Salary.
//Vyzkoušejte nakonec i případ, kdy Salary bude mít jen sekci get nebo jen set. Jde to?. Ověřte pomocí WriteLine v metodě Main.


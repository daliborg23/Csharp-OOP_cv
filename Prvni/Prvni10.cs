namespace Prvni10 {
    class Prvni10 {
        public static void Mainx() {
            Student s1 = new Student(18, 10000);
            Accountant a1 = new Accountant(22, 25000);
            Teacher t1 = new Teacher(33, 35000, 33);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Console.WriteLine("Pocet osob: " + Person.getCount() + ", vek: " + t1.age);
        }
    }
    abstract class Person {
        public int age;
        private static int count;
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
        public abstract void writeInfo();
        //    {
        //      base.writeInfo();
        //    Console.WriteLine("Vek: " + age + "     Pocet instanci: " + getCount() + "      Vek getterem: " + getAge());
        //}
    }
    abstract class Employee : Person {
        private int salary;
        public Employee() {
        }
        public Employee(int age, int salary) : base(age) {
            this.salary = salary;
        }
        public override void writeInfo() {
            //base.writeInfo();
            Console.Write("Pocet osob: " + Person.getCount() + ", vek: " + age);
            Console.Write(", Plat: " + salary);
        }
    }
    class Student : Person {
        public int scholarship;
        public Student() { }
        public Student(int age, int scholarship) : base(age) {
            this.scholarship = scholarship;
        }
        public override void writeInfo() {
            //base.writeInfo();
            Console.Write("Pocet osob: " + Person.getCount() + ", vek: " + age);
            Console.WriteLine(", Stipendium: " + scholarship);
        }
    }
    class Accountant : Employee {
        public Accountant(int age, int salary) : base(age, salary) {
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine();
        }
    }
    class Teacher : Employee {
        private int teachingTime;
        public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
            this.teachingTime = teachingTime;
        }
        public override void writeInfo() {
            base.writeInfo();
            Console.WriteLine(", Oduceny cas: " + teachingTime);
        }
    }
}
//10. Změna třídy Person na abstraktní(kap.Třída a metoda typu abstract)
//Vyjdeme z 9a, tedy nebudeme používat vlastnosti(aby se program zjednodušil).
//Nasimulujme situaci, kdy programátor zapomene ve třídě Student překrýt metodu writeInfo().
//Zakomentujte metodu writeInfo() ve třídě Student(v ostatních ponechte).  Program se pak začne chovat podivně: metoda writeInfo() vypíše všem všechny údaje,
//studentovi ale jen věk(scholarship ne). Proč?
//
//Je nutno zajistit, aby překladač chránil před možnou sklerózou programátora.Proto prohlásíme metodu writeInfo() ve třídě Person za abstraktní.
//To zároveň znamená, že zakomentujeme její tělo včetně složených závorek (hlavičku ponecháme).
//Kompilátor nás donutí, abychom pak za abstraktní prohlásili i celou třídu Person.
//
//Nemůžeme potom ale bohužel v podřízených třídách tuto metodu volat, zakomentujeme tedy řádek base.writeInfo() a místo toho zajistíme výpis věku v každé zvlášť
//(tedy místo volání base.writeInfo() napíšeme Console.WriteLine(age) ).
//
//Při kompilaci pak zjistíme, že tentokrát překladač na absenci metody writeInfo() ve třídě
//Student upozorní(a o to nám šlo). Text kompilační chyby: Student doesn’t implement inherited abstract member Person.writeInfo.
// Pozn.:  užitečné bude prohlásit za abstraktní i třídu Employee, protože stejně nechceme povolit vytváření instancí této třídy
// (metodu writeInfo() ale na abstraktní nepředěláváme). Srovnejte: třídu Employee měníme v abstraktní dobrovolně, zatímco u třídy Person jsme k tomu byli nuceni,
// protože obsahuje abstraktní metodu.Platí to i naopak, tedy musí být v abstraktní třídě všechny metody také abstraktní?

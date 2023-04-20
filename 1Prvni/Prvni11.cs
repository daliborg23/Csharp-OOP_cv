using System.Diagnostics;
using System;
using System.Runtime.CompilerServices;

namespace Prvni11 {
    class Prvni11 {
        public static void Mainx() {
            Student s1 = new Student(18, 10000);
            Accountant a1 = new Accountant(22, 25000);
            Teacher t1 = new Teacher(33, 35000, 33);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Console.WriteLine("Pocet osob: " + Person.getCount() + ", vek: " + t1.age);
            Console.WriteLine(s1);
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1.toString());
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
        public override string ToString() {
            return "ToString: pocet osob: " + Person.getCount() + ", vek: " + age;
        }
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
        public string toString() {
            return base.ToString() + String.Format(" Stipendium: " + scholarship);
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
// 11.  Použití metody ToString()
// Vypište v hlavním programu informace o objektu studenta způsobem, jako by to byla proměnná primitivního typu, např.  Console.WriteLine(s1).
// V jakém tvaru se informace vypíše?
// Na dalším řádku napište: Console.WriteLine(s1.ToString())   vypíše se totéž, čímž je dokázáno, že WriteLine volá ToString().
// Jelikož tato metoda není definovaná v našem programu, tak se zřejmě dědí z třídy Object.
//
// Vytvořte ve třídě Person překrytí metody ToString() třídy Object. Nejprve neuvedeme klíčové slovo override.
// Zjistíme, že tentokrát oba řádky WriteLine stejné nejsou. Řádek WriteLine(s1) tuto metodu nevolá, píše postaru Prvni12.Student. Proč?
// Co se stane, když napíšeme malé „t“, tedy toString (a vysvětlit)

// Ještě doplňte překrytí ToString např. ve třídě Student. Použije se virtual override?
// 2. krok: chceme - li vracet řetězec pěkně formátovaný, použijeme String.Format. Vyzkoušíme ve třídě Student. Povšimněte si,
// že metoda Format je statická, metoda ToString instanční.

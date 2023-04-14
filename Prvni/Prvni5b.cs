using Prvni;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using Prvni1;
using System.Threading.Tasks;
using System.IO;

namespace Prvni5b;
class Prvni5b {
    public static void Mainx() {
        Student s1 = new Student(18, 10000);
        Accountant a1 = new Accountant(22, 25000);
        Teacher t1 = new Teacher(33, 35000, 12);
        s1.writeInfo();
        a1.writeInfo();
        t1.writeInfo();
        Student s2 = new Student(17);
        s2.writeInfo();
    }
}
class Person {
    public int age;
    //public Person() {}
    public Person(int age) {
        this.age = age;
    }
}
class Employee : Person {
    public int salary;
    //public Employee() {}
    public Employee(int age, int salary) : base(age) {
        this.salary = salary;
    }
}
class Student : Person {
    public int scholarship;
    public Student(int age, int scholarship) : base(age) {
        this.scholarship = scholarship;
    }
    public Student(int age):base(age) {
        this.age=age;
    }
    //public Student(int scholarship) {
    //    this.scholarship = scholarship;
    //}
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Stipendium: " + scholarship);
        Console.WriteLine($"Vek: {age} Stipendium: {scholarship} PODRUHE"); //argument prikazoveho radku
    }
}
class Accountant : Employee {
    public Accountant(int age, int salary) : base(age, salary) {
    }
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Plat: " + salary);
    }
}
class Teacher : Employee {
    public int teachingTime;
    public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
        this.teachingTime = teachingTime;
    }
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Plat: " + salary + " Oduceny cas: " + teachingTime);
    }
}

//5b: (kap.Přetěžování) zatím máme ve Studentovi konstruktor plnící všechny datové složky.
//Přidejte ještě konstruktor s parametrem jen věk. Potom zkuste přidat konstruktor s parametrem jen scholarship.
//Zjistíte, že to nejde, proč? ?????). Tak např.konstruktor na scholarship zrušte a nechte jen konstruktor plnící  věk.
//V metodě Main pak vytvořte studenta s2, pro kterého tento konstruktor použijete.V metodě writeInfo zjistíte, že scholarship má nulové.
//Můžeme samozřejmě po vytvoření s2 naplnit scholarship přiřazovacím příkazem.V dalším bodě tento konstruktor i s2 zrušíme (xx 5b vytvořit) xx hotovo, v solutionu v Agendě
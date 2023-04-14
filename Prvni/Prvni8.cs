using Prvni;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using Prvni1;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Prvni8;
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
    }
}
class Person {
    public int age;
    static int count;
    public Person() {
        //count++;
    }
    public Person(int age) {
        this.age = age;
        count++;
    }
    public virtual void writeInfo() {
        Console.WriteLine("Vek: " + age + "     Pocet instanci: " + count);
    }
}
class Employee : Person {
    public int salary;
    public Employee() {
    }
    public Employee(int age, int salary) : base(age) {
        this.salary = salary;
    }
    Person p = new Person();
    public override void writeInfo() {
        base.writeInfo();
        Console.WriteLine("Plat: " + salary);
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
        Console.WriteLine("Stipendium: " + scholarship);
    }
}
class Accountant : Employee {
    public Accountant(int age, int salary) : base(age, salary) {
    }
    public override void writeInfo() {
        base.writeInfo();
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
        Console.WriteLine("Oduceny cas: " + teachingTime);
    }
}

//8. Doplnění statické proměnné s počtem instancí(kap.Modifikátor Static)
//Třídu Person doplníme o statickou datovou složku count(tedy počet). V konstruktoru ji inkrementujeme.Doplníme její výpis do metody writeInfo() v třídě Person.
//Doplňte v třídě Student konstruktor bez parametru (snippet ctor-TAB-TAB), musí existovat i bezparametrický konstruktor třídy Person.V hlavním programu vytvořte dalšího studenta,
//tentokrát bez parametrů.Také pro něj spusťte výpis writeInfo(). Je údaj o počtu osob správně? neni


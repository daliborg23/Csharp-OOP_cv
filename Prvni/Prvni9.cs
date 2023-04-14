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
using System.Net.NetworkInformation;

namespace Prvni9;
class Prvni9 {
    public static void Mainx() {
        Student s1 = new Student(18, 10000);
        Accountant a1 = new Accountant(22, 25000);
        Teacher t1 = new Teacher(33, 35000, 41);
        s1.writeInfo();
        a1.writeInfo();
        t1.writeInfo();
        Student s2 = new Student();
        if(t1.TeachingTime > 40) Console.WriteLine("POZOR! Vetsi nez 40");
        t1.Salary = 40000;
        Console.WriteLine(t1.Salary);
        //Console.WriteLine();
    }
}
class Person {
    private int age;
    protected static int count;
    public int getCount() {
        return count;
    }
    public int getAge() {
        return age;
    }
    public void setAge(int age) {
        this.age = age;
    }
    public Person() {
        //count++;
    }
    public Person(int age) {
        this.age = age;
        count++;
    }
    public virtual void writeInfo() {
        Console.WriteLine("Vek: " + age + "     Pocet instanci: " + getCount() + "      Vek getterem: " + getAge());
    }
}
class Employee : Person {
    private int salary;
    public int Salary {
        get { return salary; }
        set { salary = value; }
    }
    public Employee() {
    }
    public Employee(int age, int salary) : base(age) {
        this.salary = salary;
    }
    public override void writeInfo() {
        base.writeInfo();
        Console.WriteLine("Plat: " + salary);
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
    private int teachingTime;
    public Teacher(int age, int salary, int teachingTime) : base(age, salary) {
        this.teachingTime = teachingTime;
    }
    public int TeachingTime {
        get { return teachingTime; }
        set { teachingTime = value; }
    }
    public override void writeInfo() {
        base.writeInfo();
        Console.WriteLine("Oduceny cas: " + teachingTime);
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

//Druhý krok (kap.Vlastnosti) Předělejte datovou složku teachingTime (ve třídě Teacher) na privátní.Vytvořte k ní vlastnost TeachingTime. Hlídejte například,
//že nesmí být větší než 40. Ověřte pomocí WriteLine v metodě Main.
//Třetí krok: místo datové složky salary ve třídě Employee použijte automaticky implementovanou vlastnost Salary.
//Vyzkoušejte nakonec i případ, kdy Salary bude mít jen sekci get nebo jen set. Jde to?. Ověřte pomocí WriteLine v metodě Main.


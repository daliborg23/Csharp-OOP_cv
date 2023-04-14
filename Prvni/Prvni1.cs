using Prvni;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;

namespace Prvni1;
class Prvni {
    public static void Mainx() {
        Student s1 = new Student { //objektova inicializace
            age = 18,
            scholarship = 10000,
        };
        Accountant a1 = new Accountant {
            age = 22,
            salary = 25000
        };
        Teacher t1 = new Teacher {
            age = 33,
            salary = 35000,
            teachingTime = 12
        };        
        s1.writeInfo();
        a1.writeInfo();
        t1.writeInfo();
    }
}
class Student {
    public int age;
    public int scholarship;
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Stipendium: " + scholarship);
        Console.WriteLine($"Vek: {age} Stipendium: {scholarship} PODRUHE"); //argument prikazoveho radku
    }
}
class Accountant {
    public int age;
    public int salary;
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Plat: " + salary);
    }
}
class Teacher {
    public int age;
    public int salary;
    public int teachingTime;
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Plat: " + salary + " Oduceny cas: " + teachingTime);
    }
}

//1.       Základ bez konstruktoru a dědičnosti(kap.První OOP, str 2)
// Vytvořte solution Csharp_OOP_cv a v něm projekt Prvni typu Console Application.Automaticky se v něm vytvoří třída Program.cs s metodou Main(). Vytvořte v projektu třídu Prvni1.cs, v ní veřejnou statickou metodu Mainx().
// Zavolejte metodu Mainx z metody Main třídy Program.cs.Ověřte, zda program chodí (i když dosud nic nedělá)
// Do souboru Prvni1.cs doplňte třídy Student, Accountant a Teacher(tedy všechny tři budou v jednom souboru s třídou Prvni).
// Všechny tři budou mít datovou složku age, Student navíc scholarship, Accountant a Teacher místo toho salary.A Teacher navíc třetí datovou složku: teachingTime
// (počet úvazkových hodin). Všechny datové složky budou celočíselné.Všechny třídy budou obsahovat metodu writeInfo(), která vypíše hodnotu všech datových složek.
//Do metody Mainx() umístěte vytvoření po jedné instanci z tříd Student, Accountant i Teacher (nazvěte je např. s1, a1, t1) včetně naplnění datových složek nějakými hodnotami.Potom datové složky každé instance vypište.V tomto bodě ještě nepoužívejte konstruktory ani dědičnost a dejte si pozor, abyste nedělali třídy jako vnitřní!


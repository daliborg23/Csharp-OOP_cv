using Prvni;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;

namespace Prvni2;
class Prvni2 {
    public static void Mainx() {
        Student s1 = new Student(18, 10000);
        Accountant a1 = new Accountant(22, 25000);
        Teacher t1 = new Teacher(33,35000,12);
        s1.writeInfo();
        a1.writeInfo();
        t1.writeInfo();
    }
}
class Student {
    public int age;
    public int scholarship;
    public Student(int age, int scholarship) {
        this.age = age;
        this.scholarship = scholarship;
    }
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Stipendium: " + scholarship);
        Console.WriteLine($"Vek: {age} Stipendium: {scholarship} PODRUHE"); //argument prikazoveho radku
    }
}
class Accountant {
    public int age;
    public int salary;
    public Accountant (int age, int salary) {
        this.age = age;
        this.salary = salary;
    }
    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Plat: " + salary);
    }
}
class Teacher {
    public int age;
    public int salary;
    public int teachingTime;
    public Teacher (int age, int salary, int teachingTime) {
        this.age = age;
        this.salary = salary;
        this.teachingTime = teachingTime;
    }

    public void writeInfo() {
        Console.WriteLine("Vek: " + age + " Plat: " + salary + " Oduceny cas: " + teachingTime);
    }
}

//A nyní zadání: Představme si, že každá třída má ve skutečnosti desítky datových složek. Tedy by vytvoření každé instance zabralo desítky řádků.
//roto program zkraťme použitím konstruktoru. Vytvořte v každé třídě konstruktor inicializující všechny potřebné datové složky
//(u třídy Teacher tedy tři datové složky). Upravte pak v metodě Mainx() tvorbu instancí tak, aby se použily konstruktory.
//Tvorba každé instance je pak na jeden řádek. Úspora se samozřejmě projeví až při větším počtu vytvořených instancí.
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

namespace Prvni7;
class Prvni7 {
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
    public virtual void writeInfo() {
        Console.WriteLine("Vek: " + age);
    }
    public virtual void info() {
        Console.WriteLine("Vek: " + age);
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
    public Student(int age, int scholarship) : base(age) {
        this.scholarship = scholarship;
    }
    public override void writeInfo() {
        base.writeInfo();
        Console.WriteLine("Stipendium: " + scholarship);
        //base.info();
        //info();
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

//7. Demonstrace rozdílu ve volání překryté a nepřekryté metody(kap.Překrývání/Mod. virtual, override, new)
//Zkopírujte ve třídě Person metodu writeInfo(). Kopii nazvěte jen info(). V metodě writeInfo() třídy Student tuto metodu zavolejte
//(takže se vlastně dvakrát volá totéž). Je nutno použít při volání také base.info() nebo stačí jen info()?
//Připomínám, že se ze Studenta volají dvě metody v třídě Person(tedy v nadřazené, bázové třídě). U metody writeInfo() se base musí použít
//(jinak volá stejnojmennou metodu v třídě Student). Musí se base použít i u info()?
//V dalších etapách již metodu info() nebudeme používat.
//
// Druhý krok: Podíváme-li se na seznam Warning, vidíme, že kompilátor si není jistý, zda k překrytí metody writeInfo došlo úmyslně.
// Proto přidáme před překrývanou metodu ve třídě Person klíčové slovo virtual. Tím dáme najevo, že s překrytím počítáme.
// U překrývajících metod přidáme klíčové slovo override, tím dáme najevo, že překrýváme úmyslně.

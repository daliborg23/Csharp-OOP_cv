using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpExerciseOnClasses1 {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("------------------------class Circle------------------------");
            Circle c1 = new Circle();
            Console.WriteLine($"The circle has radius of {c1.getRadius()} and area of {c1.getArea()}");
            Circle c2 = new Circle(2.0);
            Console.WriteLine($"The circle has radius of {c2.getRadius()} and area of {c2.getArea()}");
            Circle c3 = new Circle(3.0, "green");
            Console.WriteLine($"The circle has radius of {c3.getRadius()} and area of {c3.getArea()}");
            Circle c4 = new Circle(4.0);
            Console.WriteLine($"The {c4.getColor()} circle has radius of {c4.getRadius()} and area of {c4.getArea()}");
            //c1.radius; // is inaccessible
            //c1.radius = 5.0; // is inaccessible
            Circle c5 = new Circle();
            c5.setRadius(3.33);
            c5.setColor("blue");
            Console.WriteLine($"The {c4.getColor()} circle has radius of {c4.getRadius()} and area of {c4.getArea()}");
            //Console.WriteLine(c5.setRadius(6.66)); // void - nelze
            Circle c6 = new Circle(6.0);
            Console.WriteLine(c6.ToString()); // explicit call
            Console.WriteLine(c6); // implicit call
            Console.WriteLine("Operator '+' invokes ToString() too: " + c6);
            Console.WriteLine("------------------------class SimplifiedCircle------------------------");
            SimplifiedCircle s1 = new SimplifiedCircle();
            SimplifiedCircle s2 = new SimplifiedCircle(2.0);
            Console.WriteLine($"1. {s1}");
            Console.WriteLine($"2. {s2}");
            Console.WriteLine("Zmena prumeru prvniho kruhu s1 na 7.0cm");
            s1.setRadius(7.0);
            Console.WriteLine($"Prumer po zmene: {s1.getRadius()}");
            Console.WriteLine($"{s1.GetType().Name} ma plochu {s1.getArea()}cm{'\u00B2'} a obvod {s1.getCircumference()}cm"); // nejde na druhou
            Console.WriteLine("------------------------class Rectangle------------------------");
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(2.3f,4.2f);
            Console.WriteLine($"1. {r1}");
            Console.WriteLine($"2. {r2}");
            Console.WriteLine($"Prvni Rectangle ma delku {r1.getLength()} a sirku {r1.getWidth()}.");
            r1.setLength(3.3f);
            r1.setWidth(4.4f);
            Console.WriteLine($"Prvni Rectangle - zmena delky na {r1.getLength()} a sirky na  {r1.getWidth()}.");
            Console.WriteLine($"Prvni Rectangle ma plochu {r1.getArea()}cm2 a obvod {r1.getPerimeter()}cm.");
            Console.WriteLine("------------------------class Employee------------------------");
            Employee e1 = new Employee(1,"Jan","Novak",33333);
            //Employee e2 = new Employee();
            Console.WriteLine(e1);
            Console.WriteLine($"Zamestnanec s ID {e1.getID()} se jmenuje {e1.getFirstName()} {e1.getLastName()} (celym jmenem {e1.getName()})");
            Console.WriteLine($"Vydelava {e1.getSalary()},- mesicne, {e1.getAnnualSalary()},- rocne.");
            Console.WriteLine("Necekane zvednuti platu o 12%!!!");
            e1.raiseSalary(12);
            Console.WriteLine($"Vydelava {e1.getSalary()},- mesicne, {e1.getAnnualSalary()},- rocne.");
            Console.WriteLine("To je nejak moc... zaokrouhlime na 35000,-");
            e1.setSalary(35000);
            Console.WriteLine($"Vydelava {e1.getSalary()},- mesicne, {e1.getAnnualSalary()},- rocne.");
            //e1.setSalary(10000);
            //e1.raiseSalary(10);
            //Console.WriteLine($"Vydelava {e1.getSalary()},- mesicne, {e1.getAnnualSalary()},- rocne.");
            Console.WriteLine("------------------------class InvoiceItem------------------------");
            InvoiceItem i1 = new InvoiceItem("Sroub", "M4x8-8.8", 50, 1.4);
            Console.WriteLine(i1);
            Console.WriteLine($"Predmet: {i1.getID()}, Popis: {i1.getDesc()}, Pocet kusu: {i1.getQty()}, Cena/kus: {i1.getUnitPrice()},- | Cena celkem: {i1.getTotal()},-");
            Console.WriteLine("Omyl pri pocitani a zaroven i zdrazime proc ne..");
            i1.setQty(100);i1.setUnitPrice(1.9);
            Console.WriteLine($"Predmet: {i1.getID()}, Popis: {i1.getDesc()}, Pocet kusu: {i1.getQty()}, Cena/kus: {i1.getUnitPrice()},- | Cena celkem: {i1.getTotal()},-");
            Console.WriteLine("------------------------class Account------------------------");
            Account a1 = new Account("u1","ucet1", 100000);
            Account a2 = new Account("u2", "ucet2", 50000);
            Account a3 = new Account("u3", "ucet3");
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine($"{a1.getID()} {a1.getName()} {a1.getBalance()},-");
            a1.credit(10000);
            Console.WriteLine("Pridan kredit 10000,-");
            Console.WriteLine(a1);
            a1.debit(15000);
            Console.WriteLine("Debit 15000");
            Console.WriteLine(a1);
            Console.WriteLine("Odeslani 20000 z u1 na u3");
            a1.transferTo(a3, 20000);
            Console.WriteLine(a1);
            Console.WriteLine(a3);
            Console.WriteLine("------------------------class Date------------------------");
            Date d1 = new Date(4,6,1992);
            Console.WriteLine(d1);
            Console.WriteLine($"Den: {d1.getDay()} Mesic: {d1.getMonth()} Rok: {d1.getYear()}");
            Console.WriteLine("Zmena datumu na 08/08/2024 - dohromady");
            d1.setDate(8, 8, 2024);
            Console.WriteLine($"Den: {d1.getDay()} Mesic: {d1.getMonth()} Rok: {d1.getYear()}");
            Console.WriteLine("Zmena datumu na 24/12/2024 - zvlast");
            d1.setDay(24); d1.setMonth(12); d1.setYear(2024);
            Console.WriteLine($"Den: {d1.getDay()} Mesic: {d1.getMonth()} Rok: {d1.getYear()}");
            Console.WriteLine("------------------------class Time------------------------");
            Time t1 = new Time(16,20,00); // s 00 sekundama nejede (pri -1 spocte na 99 [neosetreno])]
            Console.WriteLine(t1);
            Console.WriteLine("Zmena casu na 23:23:23");
            t1.setHour(23);t1.setMinute(23);t1.setSecond(23);
            Console.WriteLine(t1);
            Console.Write("Pridana sekunda ");
            t1.nextSecond();
            Console.WriteLine(t1);
            Console.Write("Odebrana sekunda ");
            t1.previousSecond();
            Console.WriteLine(t1);
            Console.Write("Odebrana sekunda ");
            t1.previousSecond();
            Console.WriteLine(t1);
        }
    }
}

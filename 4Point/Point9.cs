using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4Point9 {
    interface IPocitani {
        double perimeter();
    }
    public class Person : IPocitani {
        public double pocetPiv;
        public double pocetSeduLehu;
        public static double BMI = 22.0; // ???
        public Person(double pocetPiv, double pocetSeduLehu) {
            this.pocetPiv = pocetPiv * 0.08;
            this.pocetSeduLehu = pocetSeduLehu * (0.17);
        }
        public double perimeter() {
            if (pocetPiv > pocetSeduLehu) {
                return (this.pocetPiv * 5 - this.pocetSeduLehu) * BMI;
            }
            else {
                return (this.pocetSeduLehu * 15) - this.pocetPiv * BMI;
            }
        }
    }
    public class ZapornaHodnotaException : Exception {
        public ZapornaHodnotaException(string s) : base(s) { }
    }
    public class Point {
        public double x; public double y;
        //public Point() {}
        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }
        public override string ToString() {
            return $"[{Math.Round(x, 2),0:F2}; {Math.Round(y, 2),0:F2}]";
            //return $"[{Math.Round(x, 2),5:F2}; {Math.Round(y,2),5:F2}]";
            //return $"[{String.Format("{0:0.00}", x)}; {String.Format("{0:0.00}", y)}]";
            //return "[" + Math.Round(x, 2).ToString("0.00") + "; " + Math.Round(y,2).ToString("0.00") + "]";
            //return "["+Math.Round(x, 2)+ "; "+ Math.Round(y, 2) + "]";
        }
    }
    public abstract class Shape { // : IPocitani
        public Point center;
        //public Shape(){}
        public Shape(Point center) {
            this.center = center;
        }
        public Shape(double x, double y) : this(new Point(x, y)) {
            //this.center = new Point(x, y);
        }
        // public abstract double perimeter();
        public abstract double area();
        public override string ToString() {
            return $"{center.ToString()}";
        }
        public virtual void writeInfo() {
            Console.WriteLine($"a Stred tvaru je v bode {center}.");
        }
    }
    public class Circle : Shape, IPocitani {
        public double r;
        //public Circle(){}
        public Circle(Point center, double r) : base(center) {
            if (r <= 0) {
                throw new ZapornaHodnotaException("Polomer musi byt kladne cislo vetsi nez 0cm.");
            }
            else {
                this.r = r;
            }
        }
        public Circle(double r) : this(new Point(0, 0), r) {
            //this.r = r;
        }
        public Circle(double x, double y, double r) : this(new Point(x, y), r) {
            //this.r = r;
        }
        public double perimeter() {
            return Math.Round(2 * Math.PI * r, 2);
        }
        public override double area() {
            return Math.Round(Math.PI * Math.Pow(r, 2), 2);
        }
        public override string ToString() {
            return $"Kruh s polomerem: {Math.Round(r, 2),5}cm";
        }
        public override void writeInfo() {
            Console.Write($"Kruh s polomerem: {Math.Round(r, 2),5}cm, Obvodem: {perimeter()}cm, Obsahem: {area()}cm2 ");
            base.writeInfo();
        }
    }
    public class Rectangle : Shape, IPocitani {
        public double a; public double b;
        //public Rectangle(){}
        public Rectangle(Point center, double a, double b) : base(center) {
            this.a = a; this.b = b;
        }
        public Rectangle(double a, double b) : this(new Point(0, 0), a, b) {
            //this.a = a; this.b = b;
        }
        public Rectangle(Point center, double a) : this(center, a, a) { // ctverec
            //this.a = a; this.b = a;
        }
        public Rectangle(double a) : this(new Point(0, 0), a) {
            //this.a = a; this.b = a;
        }
        public double perimeter() {
            return Math.Round(2 * (a + b), 2);
        }
        public override double area() {
            return Math.Round(a * b, 2);
        }
        public override string ToString() {
            if (a == b) {
                return $"Ctverec s delkou strany: a = {Math.Round(a, 2),5}cm, Obvodem: {perimeter()}cm, Obsahem: {area()}cm2 ";
            }
            else {
                return $"Obdelnik s delkou stran: a = {Math.Round(a, 2),5}cm, b = {Math.Round(b, 2),5}cm, Obvodem: {perimeter()}cm, Obsahem: {area()}cm2 ";
            }
        }
        public override void writeInfo() {
            if (a == b) {
                Console.Write($"Ctverec s delkou strany: a = {Math.Round(a, 2),5}cm ");
            }
            else {
                Console.Write($"Obdelnik s delkou stran: a = {Math.Round(a, 2),5}cm, b = {Math.Round(b, 2),5}cm, Obvodem: {perimeter()}cm, Obsahem: {area()}cm2 ");
            }
            base.writeInfo();
        }
    }
    public class Cylinder : Circle {
        public double height;
        //public Cylinder() { }
        public Cylinder(Point center, double r, double height) : base (center,r) {
            this.height = height;
        }
        public double surface() {
            return Math.Round(2 * base.area() + base.perimeter() * height, 2);
        }
        public double volume() {
            return Math.Round(base.area() * height, 2);
        }
        public override string ToString() {
            return $"Valec s objemem: {volume()}cm3, Povrchem: {surface()}cm2, Podstavou: {base.ToString()} stred je v bode: {base.center.ToString()}";
        }
        public override void writeInfo() {
            Console.Write($"Valec s objemem: {volume()}cm3, povrchem: {surface()}cm2, Podstavou: ");
            base.writeInfo();
        }
    }
    public class TestPoint {
        public static void Mainx() {
            //double sumaObvodu = 0.0;
            //List<IPocitani> ListTvaru = new List<IPocitani>() {
            //    new Circle(new Point(4.23, -6.66), 7),
            //    new Circle(4.2),
            //    new Circle(5.01, 3.88, 4.44),

            //    new Rectangle(new Point(-3.22, 3.98), 5.76, 4.09),
            //    new Rectangle(7.55, 6.49),
            //    new Rectangle(new Point(4.77, -5.29), 4.2),
            //    new Rectangle(7.77),

            //    new Person(15,0),
            //    new Person(0, 30)
            //};
            //for (int i = 0; i < ListTvaru.Count; i++) {
            //    sumaObvodu += ListTvaru[i].perimeter();
            //}
            //sumaObvodu = Math.Round(sumaObvodu, 2);
            //Console.WriteLine($"Soucet obvodu vsech vytvorenych kruhu je: {sumaObvodu}cm"); // 402.43

            Cylinder cyl1 = new Cylinder(new Point(2.34, 3.45), 3.6, 4.2);
            Console.WriteLine(cyl1);
            cyl1.writeInfo();





        }
    }
}


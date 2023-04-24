using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4Point5 {
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
    public abstract class Shape {
        public Point center;
        //public Shape(){}
        public Shape(Point center) {
            this.center = center;
        }
        public Shape(double x, double y) : this(new Point(x, y)) {
            //this.center = new Point(x, y);
        }
        public abstract double perimeter();
        public abstract double area();
        public override string ToString() {
            return $"{center.ToString()}";
        }
        public virtual void writeInfo() {
            Console.WriteLine($"a Stred tvaru je v bode {center}");
        }
    }
    public class Circle : Shape {
        public double r;
        //public Circle(){}
        public Circle(Point center, double r) : base(center) {
            if (r <= 0) {
                throw new ZapornaHodnotaException("Polomer musi byt kladne cislo vetsi nez 0.");
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
        public override double perimeter() {
            return Math.Round(2 * Math.PI * r, 2);
        }
        public override double area() {
            return Math.Round(Math.PI * Math.Pow(r, 2), 2);
        }
        public override string ToString() {
            return $"Kruh s polomerem: {Math.Round(r, 2),5}";
        }
        public override void writeInfo() {
            Console.Write($"Kruh s polomerem: {Math.Round(r, 2),5}, Obvodem: {perimeter()}, Obsahem: {area()} ");
            base.writeInfo();
        }
    }
    public class Rectangle : Shape {
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
        public override double perimeter() {
            return Math.Round(2 * (a + b), 2);
        }
        public override double area() {
            return Math.Round(a * b, 2);
        }
        public override string ToString() {
            if (a == b) {
                return $"Ctverec s delkou strany: a = {Math.Round(a, 2),5}, Obvodem: {perimeter()}, Obsahem: {area()} ";
            }
            else {
                return $"Obdelnik s delkou stran: a = {Math.Round(a, 2),5}, b = {Math.Round(b, 2),5}, Obvodem: {perimeter()}, Obsahem: {area()} ";
            }
        }
        public override void writeInfo() {
            if (a == b) {
                Console.Write($"Ctverec s delkou strany: a = {Math.Round(a, 2),5} ");
            }
            else {
                Console.Write($"Obdelnik s delkou stran: a = {Math.Round(a, 2),5}, b = {Math.Round(b, 2),5}, Obvodem: {perimeter()}, Obsahem: {area()} ");
            }
            base.writeInfo();
        }
    }
    public class TestPoint {
        public static void Mainx() {
            double polomer = 0;
            do {
                Console.Write("Zadejte polomer kruhu: ");
                try {
                    polomer = Double.Parse(Console.ReadLine());
                    Circle c1 = new Circle(polomer);
                    break;
                }
                catch (ZapornaHodnotaException e) { Console.WriteLine(e.Message); }
                catch (FormatException e) { Console.WriteLine(e.Message + " Tohle neni cislo"); }
            } while (true);
            Console.WriteLine($"Zadany polomer: {polomer} \t ");

            double strA; double strB; double strAOK; double strBOK;bool OKA; bool OKB; bool Smycka;
            do {
                Smycka = true;
                Console.Write("Zadejte delku strany A: ");
                OKA = Double.TryParse(Console.ReadLine(), out strA);
                Console.Write("Zadejte delku strany B: ");
                OKB = Double.TryParse(Console.ReadLine(), out strB);
                if (strA < 0 || strB < 0) {
                    Console.WriteLine("Nelze zadat zaporne cislo." + ((strA<0) ? "strana A" : "strana B"));
                    Smycka = false;
                } else if (!OKA) {
                    Console.WriteLine("Strana A nelze prevest na cislo.");
                    Smycka = false;
                } else if (!OKB) {
                    Console.WriteLine("Strana B nelze prevest na cislo.");
                    Smycka = false;
                } else { 
                    strAOK = strA;
                    strBOK = strB;
                    Rectangle r1 = new Rectangle(strAOK, strBOK);
                    r1.writeInfo();
                }
            } while (!Smycka);
            
        }
    }
}


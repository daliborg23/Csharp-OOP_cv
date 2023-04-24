using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Point4 {
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
            this.r = r;
        }
        public Circle(double r) : this(new Point(0, 0), r) {
            //this.r = r;
        }
        public Circle(double x, double y, double r) : this(new Point(x, y), r) {
            //this.r = r;
        }
        public override double perimeter() {
            return Math.Round(2*Math.PI*r,2);
        }
        public override double area() {
            return Math.Round(Math.PI * Math.Pow(r,2), 2);
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
            return Math.Round(2 * (a+b), 2);
        }
        public override double area() {
            return Math.Round(a*b, 2);
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

            Circle c1 = new Circle(new Point(4.23, -6.66), 7);
            Circle c2 = new Circle(4.2);
            Circle c3 = new Circle(5.01, -3.88, 4.44);

            Rectangle r1 = new Rectangle(new Point(3.22, -3.98), 5.76, 4.09);
            Rectangle r2 = new Rectangle(-7.55, -6.49);
            Rectangle r3 = new Rectangle(new Point(4.77, 5.29), 4.2);
            Rectangle r4 = new Rectangle(7.77);

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(r4);

            //Shape s1 = new Shape(new Point(1.11, 1.22));
            //Console.WriteLine(s1.ToString());
            //ShapeX s2 = new ShapeX(new Point(2.11, 2.43));
            //Console.WriteLine(s2.ToString());

            c1.writeInfo();
            c2.writeInfo();
            c3.writeInfo();

            r1.writeInfo();
            r2.writeInfo();
            r3.writeInfo();
            r4.writeInfo();

            Console.WriteLine("ToString:\n" + r1.ToString());
        }
    }
}

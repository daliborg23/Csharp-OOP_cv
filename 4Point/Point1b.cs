using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Point1b {
    public class Point {
        private double x; private double y;
        //public Point() {}
        #region GETTERSETTER
        public double getX() {
            return x;
        }
        public double getY() {
            return y;
        }
        public void setY(double y) {
            this.y = y;
        } 
        #endregion
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
    public class Shape {
        private Point center;
        //public Shape(){}
        private Point test;
        public Point Center {
            get { return center; }
            set { this.center = value; } 
        }

        public Point Test { get => test; set => test = value; }

        public Shape(Point center) {
            this.Center = center;
        }
        public Shape(double x, double y) {
            this.Center = new Point(x, y);
        }
    }
    public class Circle : Shape {
        public double r;
        //public Circle(){}
        public Circle(Point center, double r) : base(center) {
            this.r = r;
        }
        public Circle(double r) : base(new Point(0, 0)) {
            this.r = r;
        }
        public Circle(double x, double y, double r) : base(x, y) {
            this.r = r;
        }
        public override string ToString() {
            return $"Kruh s polomerem: {Math.Round(r, 2),5} a stredem: {Center.ToString()}";
        }
    }
    public class Rectangle : Shape {
        public double a; public double b;
        //public Rectangle(){}
        public Rectangle(Point center, double a, double b) : base(center) {
            this.a = a; this.b = b;
        }
        public Rectangle(double a, double b) : base(new Point(0, 0)) {
            this.a = a; this.b = b;
        }
        public Rectangle(Point center, double a) : base(center) { // ctverec
            this.a = a; this.b = a;
        }
        public Rectangle(double a) : base(new Point(0, 0)) {
            this.a = a; this.b = a;
        }
        public override string ToString() {
            if (a == b) {
                return $"Ctverec s delkou strany: a = {Math.Round(a, 2),5} a stredem: {Center.ToString()}";
            }
            else {
                return $"Obdelnik s delkou stran: a = {Math.Round(a, 2),5}, b = {Math.Round(b, 2),5} a stredem: {Center.ToString()}";
            }
        }
    }
    public class TestPoint {
        public static void Mainx() {
            Point p1 = new Point(3.66, -2.87);
            Console.WriteLine(p1);
            p1.setY(-3.41);
            Console.WriteLine(p1);

            Shape s1 = new Shape(1.38,2.11);
            Console.WriteLine(s1.Center);
        }
    }
}

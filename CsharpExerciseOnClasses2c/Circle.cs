using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses2c {
    public class Circle {
        private double radius;
        private string color;
        public Circle() {
            this.radius = 1.0;
            this.color = "red";
        }
        public Circle(double radius) {
            this.radius = radius;
            this.color = "red";
        }
        public Circle(double radius, string color) {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius() { return radius; }
        public void setRadius(double radius) {
            this.radius = radius;
        }
        public string getColor() { return color; }
        public void setColor(string color) {
            this.color = color;
        }
        public virtual double getArea() { return Math.Round(Math.PI * radius * radius, 2); }
        public override string ToString() { // Circle[radius=r,color=c]
            //return ("Original: " + base.ToString());
            return $"Circle[radius = {radius}, color = {color}]";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses2c {
    public class Cylinder {
        private Circle baseCircle;
        private double height;
        // Constructor with default color, radius and height
        public Cylinder() {// call superclass no-arg constructor Circle()
            baseCircle = new Circle();
            height = 1.0;
        }
        // Constructor with default radius, color but given height
        public Cylinder(double height) {// call superclass no-arg constructor Circle()  
            baseCircle = new Circle();
            this.height = height;
        }
        // Constructor with default color, but given radius, height
        public Cylinder(double radius, double height) {
            baseCircle = new Circle(radius);
            this.height = height;
        }
        // A public method for retrieving the height
        public double getHeight() {
            return height;
        }
        public double getRadius() {
            return baseCircle.getRadius();
        }
        // A public method for computing the volume of cylinder
        //  use superclass method getArea() to get the base area
        public double getVolume() {
            return Math.Round(baseCircle.getArea() * height, 2);
        }
        public double getArea() {
            return Math.Round((2 * Math.PI * baseCircle.getRadius() * height) + (2 * baseCircle.getArea()), 2);
        }
        public override string ToString() {
            return $"Cylinder: subclass of {baseCircle.ToString().TrimEnd(']')}, height = {height}]"; // aby se base.tostring predelal a dosadil do zavorky vysku
        }
    }
}

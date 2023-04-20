using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses2b {
    public class Cylinder : Circle {
        private double height;
        // Constructor with default color, radius and height
        public Cylinder() : base() {// call superclass no-arg constructor Circle()
            height = 1.0;
        }
        // Constructor with default radius, color but given height
        public Cylinder(double height) : base() {// call superclass no-arg constructor Circle()  
            this.height = height;
        }
        // Constructor with default color, but given radius, height
        public Cylinder(double radius, double height) : base(radius) { 
            this.height = height; 
        }
        // A public method for retrieving the height
        public double getHeight() {
            return height;
        }
        // A public method for computing the volume of cylinder
        //  use superclass method getArea() to get the base area
        public double getVolume() {
            return Math.Round(base.getArea() * height,2);
        }
        public override double getArea() { 
            return Math.Round((2*Math.PI*base.getRadius()*height)+(2*base.getArea()),2);
        }
        public override string ToString() {
            return $"Cylinder: subclass of {base.ToString().TrimEnd(']')}, height = {height}]"; // aby se base.tostring predelal a dosadil do zavorky vysku
        }
    }
}

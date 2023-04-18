using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses1 {
    public class SimplifiedCircle {
        private double radius;
        #region CTOR
        public SimplifiedCircle() {
            radius = 1.0;
        }
        public SimplifiedCircle(double radius) { // ctor TAB, dolu, doleva, shfit+nahoru, shift+end, backspace
            this.radius = radius;
        }
        #endregion CTOR
        #region gettersetter
        public double getRadius() {
            return radius;
        }
        public void setRadius(double radius) {
            this.radius = radius;
        }
        public double getArea() {
            return Math.Round(Math.PI * radius * radius, 2);
        }
        public double getCircumference() {
            return Math.Round(2 *Math.PI*radius,2);
        }
        #endregion gettersetter
        public override string ToString() {
            return $"Circle[radius={radius}]";
        }
    }
}

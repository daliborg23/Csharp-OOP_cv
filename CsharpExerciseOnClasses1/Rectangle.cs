using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses1 {
    public class Rectangle {
        private float length;
        private float width;
        public Rectangle() {
            length = 1.0f;
            width = 1.0f;
        }
        public Rectangle(float length, float width) {
            this.length = length;
            this.width = width;
        }
        public float getLength() {
            return length;
        }
        public void setLength(float length) {
            this.length = length;
        }
        public float getWidth() {
            return width;
        }
        public void setWidth(float width) {
            this.width = width;
        }
        public double getArea() {
            return Math.Round(length*width,2);
        }
        public double getPerimeter() {
            return Math.Round((length+width)*2,2);
        }
        public override string ToString() {
            return $"Rectangle[length={length},width={width}]";
        }
    }
}

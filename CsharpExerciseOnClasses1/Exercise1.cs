namespace CsharpExerciseOnClasses1 {
    public class Exercise1 {}
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
            this.radius=radius;
            this.color = color;
        }
        public double getRadius() { return radius; }
        public void setRadius(double radius) {
            this.radius = radius;
        }
        public string getColor() { return color; }
        public void setColor (string color) {
            this.color = color;
        }
        public double getArea() { return Math.Round(Math.PI * radius * radius,2); }

        // Circle[radius=r,color=c]
        public override string ToString() {
            //return ("Original: " + base.ToString());
            return $"Circle[radius = {radius}, color = {color}]";
        }
    }
}

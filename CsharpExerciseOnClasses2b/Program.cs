namespace CsharpExerciseOnClasses2b { 
    public class Program {
        public static void Main(string[] args) {
            // Declare and allocate a new instance of cylinder
            //   with default color, radius, and height
            Cylinder c1 = new Cylinder();
            Console.WriteLine($"Cylinder: radius={c1.getRadius(),-3} height={c1.getHeight(),-3} surface area={c1.getArea(),-7} volume={c1.getVolume(),-7}");

            // Declare and allocate a new instance of cylinder
            //   specifying height, with default color and radius
            Cylinder c2 = new Cylinder(10.0);
            Console.WriteLine($"Cylinder: radius={c2.getRadius(),-3} height={c2.getHeight(),-3} surface area={c2.getArea(),-7} volume={c2.getVolume(),-7}");

            // Declare and allocate a new instance of cylinder
            //   specifying radius and height, with default color
            Cylinder c3 = new Cylinder(2.0, 10.0);
            Console.WriteLine($"Cylinder: radius={c3.getRadius(),-3} height={c3.getHeight(),-3} surface area={c3.getArea(),-7} volume={c3.getVolume(),-7}");

            Cylinder c4 = new Cylinder(5.0, 8.0); // TSA = 2πr(r + h) = 2πr(r + h) = 2 × 3.14 × 5(5 + 8) = 408.41 cm2 --- Total Surface Area of Cylinder(TSA)
            Console.WriteLine($"Cylinder: radius={c4.getRadius(),-3} height={c4.getHeight(),-3} surface area={c4.getArea(),-7} volume={c4.getVolume(),-7}");
            Console.WriteLine();
            Console.WriteLine(c4.ToString());
            Circle circle1 = new Circle();
            Console.WriteLine(circle1.ToString());
        }
    }
}
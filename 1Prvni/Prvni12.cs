namespace Prvni12 {
    class Prvni12 {
        public static void Mainx() {
            Student s1 = new Student(18, 10000);
            Accountant a1 = new Accountant(22, 25000);
            Teacher t1 = new Teacher(33, 35000, 33);
            s1.writeInfo();
            a1.writeInfo();
            t1.writeInfo();
            Console.WriteLine("Pocet osob: " + Person.getCount() + ", vek: " + t1.age);
            Console.WriteLine(s1);
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1.toString());
        }
    }
}
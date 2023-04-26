namespace CsharpExerciseOnComposition {
    public class Program {
        public static void Main(string[] args) {
            Teacher t = new Teacher("Igor","Hnizdo",40);
            Student s1 = new Student("Jasmine","Jimenez", 22,4.49);
            Student s2 = new Student("Artturi","Birgitta", 23,2.11);
            Student s3 = new Student("Saiful","Fareeha", 24,1.29);
            Student s4 = new Student("Stu","Nastasya", 22,3.33);
            Student s5 = new Student("Cornell","Thomas", 25,1.01);
            Student s6 = new Student("Kyle","Waters", 20,3.89);
            Student s7 = new Student("Hassan","Brady", 20,3.89);
            Student s8 = new Student("Chung","Potts", 20,3.89);
            Student s9 = new Student("Alec","Gallegos", 20,3.89);
            Student s10 = new Student("Kate","Mullins", 20,3.89);
            Student s11 = new Student("Alvaro","Finley", 20,3.89);

            ClassRoom c1 = new ClassRoom(10);
            c1.Teacher = t;
            c1.addStudent(s1);
            c1.addStudent(s2);
            c1.addStudent(s3);
            c1.addStudent(s4);
            c1.addStudent(s5);
            c1.addStudent(s6);
            c1.addStudent(s7);
            c1.addStudent(s8);
            c1.addStudent(s9);
            c1.addStudent(s10);
            c1.addStudent(s11);

            Console.WriteLine(c1.ToString());

            Console.WriteLine(c1.Teacher.FullName()); // tridni ucitel
            Console.WriteLine(c1.Teacher.FirstName + " " + c1.Teacher.LastName);

            Console.WriteLine(c1.Students[2].ToString()); // treti zak
            Console.WriteLine(c1.Students[2].FirstName + " " + c1.Students[2].LastName); // treti zak

        }
    }
}
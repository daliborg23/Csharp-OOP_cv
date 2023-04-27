using System.Linq.Expressions;

namespace CsharpExerciseOnComposition {
    public class Program {
        public static void Main(string[] args) {
            ClassRoom c1 = new ClassRoom(10);
            Teacher t1 = new Teacher("Igor","Hnizdo",40);
            Teacher t2 = new Teacher("Tomas","Majer",40);
            c1.addTeacher(t1);
            Console.WriteLine(t1.ToString());
            //c1.addTeacher(t2);
            c1.removeTeacher(t1);
            c1.addTeacher(t2);
            Console.WriteLine(t2.ToString());

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
            c1.removeStudent(s10);
            c1.addStudent(s11);

            // vypis vyplaty zaklad a pak s premiame za zaky
            //Console.WriteLine(t1.Salary);
            //t1.salaryBonus();

            Console.WriteLine(c1.ToString());

            //Console.WriteLine(c1.Teacher.FullName()); // tridni ucitel
            //Console.WriteLine(c1.Teacher.FirstName + " " + c1.Teacher.LastName);

            //Console.WriteLine(c1.Students[2].ToString()); // treti zak
            //Console.WriteLine(c1.Students[2].FirstName + " " + c1.Students[2].LastName);

            // zkouska // nahodne znamky
            Random random = new Random();
            double[] poleZnamek = new double[c1.CurrentNumberOfStudents];
            for (int i = 0; i < 10; i++) {
                poleZnamek[i] = random.Next(1,6);
            }
            int ii = 0; string s = "";
            foreach (double d in poleZnamek) {
                s += d.ToString() + ", ";
                
            }
            Console.WriteLine("Znamky z testu: " + s);

            do {
                try {
                    if (c1.Students.Length == ii) throw new IndexOutOfRangeException();
                    if (c1.Students[ii] == null) throw new NullReferenceException();
                    c1.Students[ii].Zkouska(poleZnamek[ii]); // nezachyti se mi vyjimka???
                }
                catch (IndexOutOfRangeException) { // konec pole
                    break;
                }
                catch (NullReferenceException e) {
                    Console.WriteLine("A je po zkousce. Ve tride je momentalne nejake misto. " + e.Message);
                    Console.WriteLine("Pocet volnych mist: " + (c1.Students.Count() - ii));
                    break;
                }
                catch (SpatnyPrumerException e) {
                    Console.WriteLine(e.Message + "Vyhodit ze tridy? y/n");
                    string YesNo = Console.ReadLine();
                    if (YesNo == "y") {
                        Console.WriteLine(c1.Students[ii].FirstName + " je nejslabsi a dostava padaka.");
                        c1.removeStudent(c1.Students[ii]);
                    } else {
                        Console.WriteLine("Tak ale musi zabrat, uvidime po dalsi zkousce.");
                    }
                    //throw;
                }
                ii++;
            } while (c1.Students[ii-1] != null || c1.Students.Count() != ii);
            

            Console.WriteLine(c1.ToString());
            
        }
    }
}
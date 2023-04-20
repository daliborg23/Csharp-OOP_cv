using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prvni11zDisku {
  abstract class Person {
    public int age;
    private static int count = 0;
    public Person() { count++; }
    public Person(int vek) {
      age = vek; count++;
    }
    abstract public void writeInfo();
		public override string ToString() {                                      //
			return $"ToString: počet osob: {Person.getCount()}, věk:  {age}";  //
		}   //
		public static int getCount() {
      return count;
    }
  }
  class Employee : Person {
    public int salary;
    public Employee() { }
    public Employee(int vek, int plat)
      : base(vek) {
      salary = plat;
    }
    public override void writeInfo() {
      Console.Write($"počet osob: {Person.getCount()}, věk:  {age}");
      Console.Write($", salary: {salary}");
    }
  }
  class Student : Person {
    public int scholarship;
    //public Student() { }
    public Student(int vek, int stipendium)
      : base(vek) {
      scholarship = stipendium;
    }
    public override void writeInfo() {
      Console.Write($"počet osob: {Person.getCount()}, věk:  {age}");
      Console.WriteLine($", scholarship: {scholarship}");
    }
    public  string toString() {                         //
      //return base.ToString() + ", scholarship: " + scholarship; //
      return base.ToString() + String.Format(" scholarship: {0}", scholarship); //2
    }                                                           //
  }
  class Accountant : Employee {
    public Accountant(int vek, int plat)
      : base(vek, plat) {
    }
    public override void writeInfo() {
      base.writeInfo();
      Console.WriteLine();
    }
  }
  class Teacher : Employee {
    public int teachingTime;
    public Teacher(int vek, int plat, int uvazek)
      : base(vek, plat) {
      teachingTime = uvazek;
    }
    public override void writeInfo() {
      base.writeInfo();
      Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
    }
  }
  class Prvni {
    public static void Mainx(string[] args) {
      Student s1 = new Student(20, 1000);
      s1.writeInfo();
      Console.WriteLine(s1);
      Accountant e1 = new Accountant(30, 12000);
      e1.writeInfo();
      Teacher u1 = new Teacher(40, 20000, 22);
      u1.writeInfo();
      Console.WriteLine($"počet osob: {Person.getCount()}, věk:  {u1.age}");
    }
  }
}




﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnComposition {
    public class ClassRoom {
        private Teacher teacher;
        private Student[] students;
        private int currentNumberOfStudents;

        //public Teacher Teacher { get => teacher; set => teacher = value; }
        //public int CurrentNumberOfStudents { get => currentNumberOfStudents; set => currentNumberOfStudents = value; }
        //internal Student[] Students { get => students; set => students = value; }

        public Teacher Teacher {
            get { return teacher; }
            set { 
                teacher = value;
                if (Teacher != null) teacher.PupilsInClass = Students.Count();
            }
        }
        public Student[] Students {
            get { return students; }
            set { students = value; }
        }
        public int CurrentNumberOfStudents {
            get { return currentNumberOfStudents; }
            set { currentNumberOfStudents = value; }
        }
        public ClassRoom(int maxStudents) {
            Students = new Student[maxStudents];
        }
        public bool addStudent(Student student) {
            if (Students.Length == CurrentNumberOfStudents) {
                Console.WriteLine("Trida je plna, nelze pridat dalsiho studenta. " + student.FirstName + " " + student.LastName);
                return false;
            }
            else {
                Students[CurrentNumberOfStudents++] = student;
                Console.WriteLine("Pridan student " + student.FirstName + " " + student.LastName);
                return true;
            }
        }
        public bool removeStudent(Student student) {
            if (Students.Length == 0) {
                Console.WriteLine("Trida je prazdna, nelze odebrat dalsiho studenta. " + student.FirstName + " " + student.LastName);
                return false;
            }
            else {
                Students[CurrentNumberOfStudents--] = student;
                Console.WriteLine("Odebran student " + student.FirstName + " " + student.LastName);
                return true;
            }
        }
        public bool addTeacher(Teacher teacher) {
            if (Teacher != null) {
                Console.WriteLine("Trida uz tridniho ucitele ma.");
                return false;
            }
            else {
                this.Teacher = teacher;
                Console.WriteLine("Novy tridni ucitel " + Teacher.FullName() + " prirazen do tridy.");
                return true;
            }
        }
        public bool removeTeacher(Teacher teacher) {
            if (Teacher == null) {
                Console.WriteLine("Trida zadneho tridniho ucitele nema.");
                return false;
            }
            else {
                Console.WriteLine("Tridni ucitel " + Teacher.FullName() + " odebran ze tridy.");
                Teacher = null; // ?
                return true;
            }
        }
        public override string ToString() {
            string s = "------------------------------------------------------\n";
            s += "| Tridni ucitel: " + Teacher.FullName() + "                         |\n";
            s += "------------------------------------------------------\n";
            s += "| Seznam zaku:                                       |\n";
            s += "------------------------------------------------------\n";
            foreach (Student student in Students) {
                s += student.ToString() + "\n";
            }
            s += "------------------------------------------------------\n";
            return s;
        }
    }
}

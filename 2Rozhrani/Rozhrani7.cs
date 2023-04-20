using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani7 {
    interface ISoundable {
        public string sound();
        public string ToString();
        public string getName();
        string Jmeno { get; set; }
    }
    public class Car : ISoundable {
        public string name;
        public int speed;
        public Car() { }
        public Car(string name) {
            this.name = name;
        }
        public string Jmeno { 
            get { return name; } 
            set { this.name = value; } 
        }
        public string sound() {
            return "brrr";
        }
        public string getName() { return name; }
        public override string ToString() {
            return $"{GetType().Name} {name} vydava zvuk {sound()}";
        }
    }
    abstract class Animal {
        public string name;
        public static int countOfAnimals;
        public Animal() { }
        public Animal(string name) {
            this.name = name;
            countOfAnimals++;
        }
    }
    class Dog : Animal, ISoundable {
        Boolean isPedigree;
        public Dog() { }
        public Dog(string name) : base(name) {

        }
        public string Jmeno { 
            get { return name; } 
            set { this.name = value; } 
        }
        public string sound() {
            return "haf";
        }
        public string getName() { return name; }

        public override string ToString() {
            return $"{GetType().Name} {name} vydava zvuk {sound()}";
        }
    }
    class Cat : Animal, ISoundable {
        Boolean isPedigree;
        public Cat() { }
        public Cat(string name) : base(name) {

        }
        public string Jmeno { 
            get { return name; } 
            set { this.name = value; }
        }
        public string sound() {
            return "mnau";
        }
        public string getName() { return name; }
        public override string ToString() {
            return $"{GetType().Name} {name} vydava zvuk {sound()}";
        }
    }
    class Turtle : Animal {
        int speed;
        public Turtle() { }
        public Turtle(string name) : base(name) {

        }
    }
    class Rozhrani {
        public static void Mainx() {
            List<ISoundable> animals = new List<ISoundable> // animals.Add(Pes1); ...
            {
                new Dog("Alik"),
                new Dog("Azor"),
                new Cat("Fous"),
                new Cat("Tlapka"),
                new Car("Mercedes")
                //new Turtle("Tony"),
                //new Turtle("Greta")
            };
            foreach (var item in animals) {
                Console.WriteLine($"{item.GetType().Name} {item.getName()} vydava zvuk {item.sound()}");
            }
            Console.WriteLine("===============================");
            foreach (var item in animals) {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("===============================");
            foreach (var item in animals) {
                Console.WriteLine($"{item.GetType().Name} {item.Jmeno} vydava zvuk {item.sound()}");
            }
            Console.WriteLine("Pocet zvirat: " + Animal.countOfAnimals);
            //Console.ReadKey();
        }
    }
}

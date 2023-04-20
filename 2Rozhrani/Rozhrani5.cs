using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani5 {
    interface ISoundable {
        public string sound();
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
        public string sound() {
            return "haf";
        }
    }
    class Cat : Animal, ISoundable {
        Boolean isPedigree;
        public Cat() { }
        public Cat(string name) : base(name) {

        }
        public string sound() {
            return "mnau";
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
                new Cat("Tlapka")
                //new Turtle("Tony"),
                //new Turtle("Greta")
            };
            //foreach (var animal in animals) {
            //    Animal reference = (Animal)animal;
            //    if (animal is Dog) {
            //        Console.WriteLine($"{reference.name} - {reference.GetType().Name} - zvuk: {animal.sound()}");
            //    }
            //    else if (animal is Cat) {
            //        Console.WriteLine($"{reference.name} - {animal.GetType().Name} - zvuk: {animal.sound()}");
            //    }
            //    else {
            //        Console.WriteLine($"{animal} - {animal.GetType().Name}");
            //    }
            //}

            foreach (var animal in animals) {
                Console.WriteLine($"{((Animal)animal).name} - {animal.GetType().Name} - zvuk: {animal.sound()}");
            }
            Console.WriteLine("Pocet zvirat: " + Animal.countOfAnimals);
            //Console.ReadKey();
        }
    }
}

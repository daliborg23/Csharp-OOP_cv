using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani3 {
    abstract class Animal {
        public string name;
        public static int countOfAnimals;
        public Animal() { }
        public Animal(string name) {
            this.name = name;
            countOfAnimals++;
        }
    }
    class Dog : Animal {
        Boolean isPedigree;
        public Dog() { }
        public Dog(string name) : base(name) {

        }
        public string sound() {
            return "haf";
        }
    }
    class Cat : Animal {
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
            //Dog Pes1 = new Dog("Alik");
            //Dog Pes2 = new Dog("Azor");
            //Cat Kocka1 = new Cat("Fous");
            //Cat Kocka2 = new Cat("Tlapka");
            //Turtle Zelva1 = new Turtle("Tony");
            //Turtle Zelva2 = new Turtle("Greta");
            //Animal[] animals = new Animal[] { Pes1, Pes2, Kocka1, Kocka2, Zelva1, Zelva2 };
            //foreach (var animal in animals) {
            //    Console.WriteLine($"{animal.name} - {animal.GetType().Name}");
            //}
            List<Animal> animals = new List<Animal> // animals.Add(Pes1); ...
            {
                new Dog("Alik"),
                new Dog("Azor"),
                new Cat("Fous"),
                new Cat("Tlapka"),
                new Turtle("Tony"),
                new Turtle("Greta")
            };
            //foreach (var animal in animals) {
            //    Console.WriteLine($"{animal.name} - {animal.GetType().Name}");
            //}
            //Console.WriteLine(((Dog)animals[0]).sound());
            //Console.WriteLine((animals[1] as Dog).sound());

            //foreach (var animal in animals) {
            //    if (animal is Dog) {
            //        Console.WriteLine($"{animal.name} - {animal.GetType().Name} - zvuk: {((Dog)animal).sound()}");
            //    } else if (animal is Cat) {
            //        Console.WriteLine($"{animal.name} - {animal.GetType().Name} - zvuk: {((Cat)animal).sound()}");
            //    } else {
            //        Console.WriteLine($"{animal.name} - {animal.GetType().Name}");
            //    }
            //}

            //foreach (var animal in animals) {
            //    if (animal.GetType().Name == "Dog") {
            //        Console.WriteLine($"{animal.name} - {animal.GetType().Name} - zvuk: {((Dog)animal).sound()}");
            //    } else if (animal.GetType().Name == "Cat") {
            //        Console.WriteLine($"{animal.name} - {animal.GetType().Name} - zvuk: {((Cat)animal).sound()}");
            //    } else {
            //        Console.WriteLine($"{animal.name} - {animal.GetType().Name}");
            //    }
            //}

            foreach (var animal in animals) {
                if (animal.GetType().Name == "Turtle") {
                    Console.WriteLine($"{animal.name} - {animal.GetType().Name}");
                } else {
                    Console.Write($"{animal.name} - {animal.GetType().Name}");
                    Console.WriteLine((animal is Dog) ? ($" - zvuk: {(animal as Dog).sound()}") : (animal is Cat) ? ($" - zvuk: {(animal as Cat).sound()}") : "");
                }
            }

            Console.WriteLine("Pocet zvirat: " + Animal.countOfAnimals);
            //Console.ReadKey();
        }
    }
}

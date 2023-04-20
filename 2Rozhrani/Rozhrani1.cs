using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani1 {
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
        public Dog(string name) : base (name){
                
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
            //Cat Kocka1 = new Cat ("Fous");
            //Cat Kocka2 = new Cat ("Tlapka");
            //Turtle Zelva1 = new Turtle("Tony");
            //Turtle Zelva2 = new Turtle("Greta");
            //Animal[] animals = new Animal[Animal.countOfAnimals];
            //animals[0] = Pes1; animals[1] = Pes2; animals[2] = Kocka1; animals[3] = Kocka2; animals[4] = Zelva1; animals[5] = Zelva2;
            //Animal[] animals = new Animal[] {Pes1,Pes2,Kocka1,Kocka2,Zelva1,Zelva2};
            Animal[] animals = {
                new Dog("Alik"),
                new Dog("Azor"),
                new Cat ("Fous"),
                new Cat ("Tlapka"),
                new Turtle("Tony"),
                new Turtle("Greta")
            };
            //foreach (var animal in animals) {
            //    //Console.WriteLine(animal.name); // 1.
            //    Console.WriteLine($"{animal.name} - {animal.GetType().Name}"); // 2
            //}
            for (int i = 0;i<animals.Length;i++) {
                //Console.WriteLine(animal.name); // 1.
                Console.WriteLine($"{animals[i].name} - {animals[i].GetType().Name}"); // 2
            }
            Console.WriteLine("Pocet zvirat: " + Animal.countOfAnimals);
            //Console.ReadKey();
        }
    }
}

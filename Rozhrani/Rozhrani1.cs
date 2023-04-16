using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani1 {
    abstract class Animal {
        public string name;
        public Animal() { }
        public Animal(string name) {
            this.name = name;
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
            Dog Pes1 = new Dog("Alik");
            Dog Pes2 = new Dog("Azor");
            Cat Kocka1 = new Cat ("Fous");
            Cat Kocka2 = new Cat ("Tlapka");
            Turtle Zelva1 = new Turtle("Tony");
            Turtle Zelva2 = new Turtle("Greta");
            Animal[] animals = new Animal[] {Pes1,Pes2,Kocka1,Kocka2,Zelva1,Zelva2};
            foreach (var animal in animals) {
                //Console.WriteLine(animal.name); // 1.
                Console.WriteLine($"{animal.name} - {animal.GetType().Name}"); // 2
            }
        }
    }
}

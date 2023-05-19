using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Program {
        public static void Main(string[] args) {
            // vytvoreni vagonu
            BusinessWagon wagon1 = new BusinessWagon(new Person("Lenka", "Kozakova"),50);
            NightWagon wagon2 = new NightWagon(40, 40);
            Hopper wagon3 = new Hopper(30);
            Locomotive loko = new Locomotive(new Person("Karel","Novak"),new Engine("diesel"));
            // natvrdo zapojene vozy
            List<IConnectable> souprava = new List<IConnectable>() { wagon1, wagon2, wagon3 };
            // vytvoreni vlaku
            Train train = new Train(loko,souprava);
            // extra Hopper
            Hopper wagon4 = new Hopper(35);
            // vypis
            Console.WriteLine(train);
            Console.WriteLine("-------");
            train.ConnectWagon(wagon4);
            Console.WriteLine("-------");
            Console.WriteLine(train);
            Console.WriteLine("-------");
            train.DisconnectWagon(wagon1);
            Console.WriteLine("-------");
            Console.WriteLine(train);
            Console.WriteLine("-------");
            // nova parni lokomotiva
            Locomotive lokoParni = new Locomotive(new Person("Ivan", "Rychly"), new Engine("parni"));
            Hopper hopper1 = new Hopper(30);
            Hopper hopper2 = new Hopper(31);
            Hopper hopper3 = new Hopper(32);
            Hopper hopper4 = new Hopper(33);
            Hopper hopper5 = new Hopper(34);
            Hopper hopper6 = new Hopper(35);
            Train stary = new Train(lokoParni);
            // prirazeni hopperu do soupravy vlaku
            stary.ConnectWagon(hopper1);
            stary.ConnectWagon(hopper2);
            stary.ConnectWagon(hopper3);
            stary.ConnectWagon(hopper4);
            stary.ConnectWagon(hopper5);
            stary.ConnectWagon(hopper6); // nejde
            Console.WriteLine("-------");
            // rezervace sedadla
            // nova lokomotiva s vagony pro cestujici
            Locomotive lokoEle = new Locomotive(new Person("Matej", "Michalik"), new Engine("elektricka"));
            EconomyWagon e1 = new EconomyWagon(50);
            EconomyWagon e2 = new EconomyWagon(50);
            EconomyWagon e3 = new EconomyWagon(50);
            EconomyWagon e4 = new EconomyWagon(50);
            EconomyWagon e5 = new EconomyWagon(50);
            EconomyWagon e6 = new EconomyWagon(50);
            Hopper h7 = new Hopper(37);
            List<IConnectable> souprava2 = new List<IConnectable>() { e1, e2, e3, e4, e5, e6, h7 };
            Train train2 = new Train(lokoEle,souprava2);

            //((PersonalWagon)train2.Wagons[3]).Sits.Add(new Chair(1,false));
            train2.ReserveChair(2, 2);
            train2.ReserveChair(3, 3);
            train2.ReserveChair(3, 4);
            train2.ReserveChair(4, 30);

            train2.ReserveChair(6,1);
            Console.WriteLine("------- Rezervace stejneho sedadla");
            train2.ReserveChair(2, 2);
            Console.WriteLine("-------");
            // vypis reservovanych sedadel
            train2.ListReservedChairs();
            Console.WriteLine("-------");
            Console.WriteLine(train.ToString());
            Console.WriteLine("-------");
            Console.WriteLine(train2.ToString());


            Console.WriteLine();
            Console.WriteLine();
            // test enumu
            Engine engine = new Engine(0);
            Locomotive loco = new Locomotive(new Person("Alois", "Jirasek"), engine);
            Train EnumTrain = new Train(loco);
            Console.WriteLine(EnumTrain);
        }
    }
}

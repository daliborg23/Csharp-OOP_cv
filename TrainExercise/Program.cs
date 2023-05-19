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
            //BusinessWagon wagon1 = new BusinessWagon(new Person("Lenka", "Kozakova"),50);
            //NightWagon wagon2 = new NightWagon(40, 40);
            //Hopper wagon3 = new Hopper(30);
            //Locomotive loko = new Locomotive(new Person("Karel","Novak"),new Engine(1));
            //// natvrdo zapojene vozy
            //List<IConnectable> souprava = new List<IConnectable>() { wagon1, wagon2, wagon3 };

            //// vytvoreni vlaku
            //Train train = new Train(loko,souprava);
            //// extra Hopper
            //Hopper wagon4 = new Hopper(35);

            // vypis
            //Console.WriteLine(train);
            //Console.WriteLine("-------");
            //train.ConnectWagon(wagon4);
            //Console.WriteLine("-------");
            //Console.WriteLine(train);
            //Console.WriteLine("-------");
            //train.DisconnectWagon(wagon1);
            //Console.WriteLine("-------");
            //Console.WriteLine(train);
            //Console.WriteLine("-------");

            // nova parni lokomotiva
            //Locomotive lokoParni = new Locomotive(new Person("Ivan", "Rychly"), new Engine("parni"));
            //Hopper hopper1 = new Hopper(30);
            //Hopper hopper2 = new Hopper(31);
            //Hopper hopper3 = new Hopper(32);
            //Hopper hopper4 = new Hopper(33);
            //Hopper hopper5 = new Hopper(34);
            //Hopper hopper6 = new Hopper(35);
            //Train stary = new Train(lokoParni);

            //// prirazeni hopperu do soupravy vlaku
            //stary.ConnectWagon(hopper1);
            //stary.ConnectWagon(hopper2);
            //stary.ConnectWagon(hopper3);
            //stary.ConnectWagon(hopper4);
            //stary.ConnectWagon(hopper5);
            //stary.ConnectWagon(hopper6); // nejde
            //Console.WriteLine("-------");

            //// nova lokomotiva s vagony pro cestujici
            //Locomotive lokoEle = new Locomotive(new Person("Matej", "Michalik"), new Engine(0));
            //EconomyWagon e1 = new EconomyWagon(50);
            //EconomyWagon e2 = new EconomyWagon(50);
            //EconomyWagon e3 = new EconomyWagon(50);
            //EconomyWagon e4 = new EconomyWagon(50);
            //EconomyWagon e5 = new EconomyWagon(50);
            //EconomyWagon e6 = new EconomyWagon(50);
            //Hopper h7 = new Hopper(37);
            //List<IConnectable> souprava2 = new List<IConnectable>() { e1, e2, e3, e4, e5, e6, h7 };
            //Train train2 = new Train(lokoEle, souprava2);

            //// rezervace mist
            //((PersonalWagon)train2.Wagons[3]).Sits.Add(new Chair(1,false));
            //train2.ReserveChair(2, 2);
            //train2.ReserveChair(3, 3);
            //train2.ReserveChair(3, 4);
            //train2.ReserveChair(4, 30);

            //train2.ReserveChair(6,1);
            //Console.WriteLine("------- Rezervace stejneho sedadla");
            //train2.ReserveChair(2, 2);
            //Console.WriteLine("-------");
            //// vypis reservovanych sedadel
            //train2.ListReservedChairs();
            //Console.WriteLine("-------");
            //Console.WriteLine(train.ToString());
            //Console.WriteLine("-------");
            //Console.WriteLine(train2.ToString());

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            // test enumu
            Engine engine = new Engine(1);
            Locomotive loco = new Locomotive(new Person("Alois", "Jirasek"), engine);
            EconomyWagon ew1 = new EconomyWagon(60);
            EconomyWagon ew2 = new EconomyWagon(60);
            EconomyWagon ew3 = new EconomyWagon(60);
            Train EnumTrain = new Train(loco);
            EnumTrain.ConnectWagon(ew1);
            EnumTrain.ConnectWagon(ew2);
            EnumTrain.ConnectWagon(ew3);
            Console.WriteLine(EnumTrain);
            Console.WriteLine("-------");
            Engine engine2 = new Engine(2);
            Locomotive loco2 = new Locomotive(new Person("Ota", "Pavel"), engine2);
            NightWagon nw1 = new NightWagon(30, 30);
            NightWagon nw2 = new NightWagon(30, 30);
            NightWagon nw3 = new NightWagon(30, 30);
            Train EnumTrain2 = new Train(loco2);
            EnumTrain2.ConnectWagon(nw1);
            EnumTrain2.ConnectWagon(nw2);
            EnumTrain2.ConnectWagon(nw3);
            Console.WriteLine(EnumTrain2);
            Console.WriteLine("-------");
            Engine engine3 = new Engine(2);
            Locomotive loco3 = new Locomotive(new Person("Bozena", "Nemcova"), engine3);
            EconomyWagon ew4 = new EconomyWagon(60);
            EconomyWagon ew5 = new EconomyWagon(60);
            EconomyWagon ew6 = new EconomyWagon(60);
            Train EnumTrain3 = new Train(loco3);
            EnumTrain3.ConnectWagon(ew4);
            EnumTrain3.ConnectWagon(ew5);
            EnumTrain3.ConnectWagon(ew6);
            Console.WriteLine(EnumTrain3);
            Console.WriteLine("-------");
            //// vypis hodnot Enumu
            //foreach (var item in Enum.GetValues(typeof(Engine.EEngine))) {
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("-------");
            Traveller t1 = new Traveller("Frantisek", "Dobrota", 0);
            Traveller t2 = new Traveller("Ludek", "Sobota", 100);
            Traveller t3 = new Traveller("Milada", "Horakova", 50);
            Traveller t4 = new Traveller("Milada", "Horakova");
            EnumTrain.ReserveChair(1, 1, t1.cardNumber);
            EnumTrain.ReserveChair(1, 2, t2.cardNumber);
            EnumTrain.ReserveChair(1, 3, t3.cardNumber);
            EnumTrain.ReserveChair(1, 1, t4.cardNumber);
            Console.WriteLine("Pocet vlastniku karet: " + Traveller.Count());
            Console.WriteLine();
            Console.WriteLine("-------      +");
            Train train3 = EnumTrain + EnumTrain2;
            Console.WriteLine("-------      =");
            Console.WriteLine(train3);
            Console.WriteLine("-------      +");
            //Train train4 = train3 + EnumTrain;
            Train train4 = train3 + EnumTrain3;
            Console.WriteLine("-------      =");
            Console.WriteLine(train4);
            Console.WriteLine("------- ListReservedChairs");
            train4.ListReservedChairs();
            Console.WriteLine("-------      -");
            Train train5 = train4 - 3;
            Console.WriteLine("-------      =");
            Console.WriteLine(train5);

        }
    }
}

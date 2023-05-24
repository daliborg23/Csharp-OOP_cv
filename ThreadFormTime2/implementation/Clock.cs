using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadFormTime.implementation {
    public class Clock {
        bool shows = false;
        DateTime casStop;
        public bool Shows { 
            get => shows; 
            set => shows = value; 
        }
        public DateTime CasStop { 
            get => casStop; 
            set => casStop = value; 
        }

        public void show() {
            Shows = true;
            //Console.WriteLine("-- on");
            Console.WriteLine(String.Format("{0,-14}", "jdu kurit: ") + DateTime.Now);
            CasStop = DateTime.Now;
        }
        public void dontShow() {
            Shows = false;
            //Console.WriteLine("-- off");
            Console.WriteLine(String.Format("{0,-14}", "jsem zpatky: ") + DateTime.Now);
            Console.WriteLine(String.Format("{0,-14}", "kuril jsem: ") + (DateTime.Now - CasStop).Minutes + " minut " + (DateTime.Now - CasStop).Seconds + " sekund");
        }
        public void loop() {
            while (true) {
                if (Shows) {
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                    Thread.Sleep(1000);
                }
            }
        }
        public Task loopAsync() {
            while (true) {
                if (Shows) {
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                    Thread.Sleep(1000);
                }
            }
        }
        public void writeStr() {
            int i = 0;
            char[] array = new char[] {':','-',')'};
            while (i < 10) {
                if (i < array.Length - 1) { 
                    Console.Write(array[i]);
                } else {
                    Console.Write(array[2]);
                }
                i++;
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;

namespace VlaknaTrideni {
    static class Program5orig {
        static void Mainx()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            int velikost = 15;
            int[] data = new int[velikost];
            Random nahodneCislo = new Random();
            for (int x = 0; x < velikost; x++)
            {
                data[x] = nahodneCislo.Next(0, 101);
            }
            Form5orig f5orig = new Form5orig(data);
            //Thread t1 = new Thread (f5orig.showData); t1.Start();
            f5orig.Show();
            for (int i = 0; i < data.Length; i++) {
                data[i] = i * 3;
                f5orig.showData();
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);
        }
    }
}

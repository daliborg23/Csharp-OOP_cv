using System;
using System.Windows.Forms;

namespace VlaknaTrideni {
    static class Program4orig {
        static void Mainx()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int velikost = 15;
            int[] data = new int[velikost];
            Random nahodneCislo = new Random();
            for (int x = 0; x < velikost; x++)
            {
                data[x] = nahodneCislo.Next(0, 101);
            }
            Application.Run(new Form4orig(data));
        }
    }
}

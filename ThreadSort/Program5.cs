﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSort {
    internal static class Program5 {
        [STAThread]
        static void Main() {
            //int[] poleCisel = { 99, 22, 12, 84, 35, 62, 85, 25, 32, 47, 91, 12, 65, 88, 11 };
            int[] poleCisel = new int[15];
            Random r = new Random();
            for (int i = 0; i < 15; i++) {
                poleCisel[i] = r.Next(1, 101);
            }
            Form5 f1 = new Form5(poleCisel, "bubble"); 
            Form5 f2 = new Form5(poleCisel, "bubble");
            Thread t1 = new Thread(f1.PBBubbleSort2);
            Thread t2 = new Thread(f2.PBBubbleSort2);
            //Application.Run(f1);
            //Application.Run(f2);
            f1.Show();
            f2.Show();
            Thread.Sleep(1000);
            t1.Start();
            t2.Start();
            Thread.Sleep(1000);
        }

    }
}

        //Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);
        //Form5 f1 = new Form5(poleCisel, "bubble"); Form5 f2 = new Form5(poleCisel, "bubble");
        //Application.Run(new MultiFormContext(f1, f2));

        //public class MultiFormContext : ApplicationContext {
        //    private int openForms;
        //    public MultiFormContext(params Form5[] forms) {
        //        openForms = forms.Length;
        //        foreach (var form in forms) {
        //            form.FormClosed += (s, args) =>
        //            {
        //                //When we have closed the last of the "starting" forms, 
        //                //end the program.
        //                if (Interlocked.Decrement(ref openForms) == 0)
        //                    ExitThread();
        //            };
        //            form.Show();
        //        }
        //    }

        //}
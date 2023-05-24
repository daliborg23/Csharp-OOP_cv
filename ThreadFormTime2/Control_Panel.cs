using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTime.implementation;

namespace ThreadFormTime {
    public partial class Control_Panel : Form {
        Clock clock;
        public Control_Panel() {
            this.clock = new Clock();
            //clock.loop();
            //Thread t3 = new Thread(clock.loop);
            //t3.Start();
            
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e) {
            this.clock.show();
        }

        private void btnDontShow_Click(object sender, EventArgs e) {
            this.clock.dontShow();
        }

        private void btnString_Click(object sender, EventArgs e) {
            Thread t4 = new Thread(clock.writeStr);
            t4.Start();
        }
    }
}

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
    public partial class Control_Panel2 : Form {
        Clock clock;
        public Control_Panel2() {
            this.clock = new Clock();
            //Thread t3 = new Thread(clock.loop);
            //t3.Start();
            
            InitializeComponent();
        }
        public Control_Panel2(Clock clock) {
            this.clock = clock;
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

        private async void Control_Panel2_Load(object sender, EventArgs e) {
            //await clock.loopAsync();
            await Task.Run(() => { clock.loopAsync(); });
        }
    }
}

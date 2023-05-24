using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadFormTime {
    public partial class AsyncAwait : Form {
        public AsyncAwait() {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e) {
            MessageBox.Show("Still OK","OK");
        }

        private async void btnLoad_Click(object sender, EventArgs e) {
            string path = "C:\\Kurs\\CSharpTest\\Csharp-OOP_cv\\ThreadFormTime2\\bigtext\\bigText.txt";
            StreamReader input = new StreamReader(path);
            Task<string> bigTextTask = input.ReadToEndAsync();
            // 20 dalsich akci
            string bigText = await bigTextTask;
            // dalsich 20 akci
            textBox1.Text += $"Done with file! Length: {bigText.Length} \r\n";
        }
        //https://my.api.mockaroo.com/people.json?key=e1f12640
        private async void btnDownload_Click(object sender, EventArgs e) {
            HttpClient client = new HttpClient();
            string apiData = await client.GetStringAsync("https://my.api.mockaroo.com/people.json?key=e1f12640");
            textBox1.Text += $"Done with API! Length: {apiData.Length}\r\n";
        }
    }
}
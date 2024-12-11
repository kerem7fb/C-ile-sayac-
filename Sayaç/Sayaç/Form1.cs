using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayaç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0;
        int saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {//başlat komutu
                timer1.Start();
                button1.Text = "Durdur";
            }
            else 
            {//durdurma komutu
                timer1.Stop();
                button1.Text = "Devam Et";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lbl_saniye.Text = saniye.ToString();
            if (saniye == 60) 
            {
                dakika++;
                saniye = 0;
                lbl_dakika.Text = dakika.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_dakika.Text = "0";
            lbl_saniye.Text = "0";
            saniye = 0;
            dakika = 0;
            timer1.Enabled = false;
        }
    }
}

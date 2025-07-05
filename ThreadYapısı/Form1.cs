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

namespace ThreadYapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(SunucuBaslat));
            Thread thread2 = new Thread(new ThreadStart(DosyadanVerileriOku));
            thread.Start();
            thread2.Start();
           // SunucuBaslat();
        }
        public void DosyadanVerileriOku()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Veriler Okundu");
        }
        public void SunucuBaslat()
        {

            Thread.Sleep(1000);
            MessageBox.Show("Sunucu Başlat");
        }

        private void btn_verigonder_Click(object sender, EventArgs e)
        {
            string yazi = txt_VeriGirdi.Text;
            MessageBox.Show(" Veri Gönderildi: " + yazi);

        }
    }
}



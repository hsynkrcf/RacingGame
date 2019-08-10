using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Araba_Yarışı
{
    public partial class Form1 : Form
    {
        int _kazanan = 0;

        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public void sesBirKi()
        {
            SystemSounds.Exclamation.Play();
        }  //yarıs sonlandıgında cıkan ses
        public void agacKaydir()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    if (!(item == car1 || item == car2 || item == car3))
                    {
                        item.Top = item.Top + 10;
                        if (item.Top >= this.ClientSize.Height)
                        {
                            item.Top = -60;
                        }
                    }
                }
            }
        }  // ağaçları hareket ettiren metot
        public void aracLocation()
        {
            car1.Top = 610;
            car2.Top = 610;
            car3.Top = 610;
        }  // arac konum 0 lama
        private void btnReplay_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("YARIŞ DAHA BİTMEDİ!!");
                }
            else
            {
                aracLocation();
            }
        }   // yeniden oynamak

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            agacKaydir();
            car3.Top = car1.Top - rnd.Next(4, 12);
            car2.Top = car1.Top - rnd.Next(4, 12);   //aracları hareket ettirmek
            car1.Top = car1.Top - rnd.Next(4, 12);
            #region personİnfo                      
            if (car1.Top < car2.Top && car1.Top < car3.Top)
            {
                label1.Text = "BİR NUMARA ÖNDE";
            }
            else if (car2.Top < car1.Top && car2.Top < car3.Top)
            {
                label1.Text = "İKİ NUMARA ÖNDE";
            }
            else if (car3.Top < car1.Top && car3.Top < car2.Top)
            {
                label1.Text = "ÜÇ NUMARA ÖNDE";
            }
            //hangi aracın önde olduğunu anlık göstermek
            #endregion                                                    

            #region nextTour
            if (car1.Top <= -65)
            {
                car1.Top = this.ClientSize.Height;
            }
            else if (car2.Top <= -65)
            {
                car2.Top = this.ClientSize.Height;
            }
            else if (car3.Top <= -65)
            {
                car3.Top = this.ClientSize.Height;
            }
            // 2.tur için 
            #endregion

            #region winnerChickenDinner
            if (car3.Top >= 611 && car3.Top <= 620)
            {
                _kazanan = 3;
                sesBirKi();
                timer1.Enabled = false;
                MessageBox.Show("3.ARABA KAZANDI!! ");
                Bahis();
            }
            else if (car2.Top >= 610 && car2.Top <= 620)
            {
                _kazanan = 2;
                sesBirKi();
                timer1.Enabled = false;
                MessageBox.Show("2.ARABA KAZANDI!! ");
                Bahis();
            }
            else if (car1.Top >= 610 && car1.Top <= 620)
            {
                _kazanan = 1;
                sesBirKi();
                timer1.Enabled = false;
                MessageBox.Show("1.ARABA KAZANDI!! ");
                Bahis();
            }
            //kazananı belirleme
            
            #endregion
        }
        void Bahis()
        {
            //---------------------------------------------- BAHİS   
            if (form2.winner() == _kazanan)
            {
                MessageBox.Show("TEBRİKLER. 100 TL KAZANDINIZ");
                form2.bakiyeGuncelle(100);
            }
            else
            {
                MessageBox.Show("BAHSİNİZ TUTMADI. TEKRAR DENEYİNİZ.");
            }
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {            
            if (timer1.Enabled == true)
            {
                MessageBox.Show("YARIŞ ZATEN BAŞLADI!!");
            }
            else
            {
                if (car1.Top != 610 && car2.Top != 610 && car3.Top != 610)
                {
                    MessageBox.Show("LÜTFEN TEKRAR OYNA BUTONUNA BASINIZ!!");
                }
                else
                {
                timer1.Enabled = true;
                }
            }
        }  //oyuna baslamak

        private void Form1_Load(object sender, EventArgs e)
        {
            aracLocation();
        }
        private bahis form2 = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new bahis();
            }
            else
            {                
            }
            form2.Owner = this;
            form2.Show();
        }
    }
}

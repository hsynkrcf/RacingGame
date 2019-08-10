using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Araba_Yarışı
{
    public partial class bahis : Form
    {
        static int winn = 0;
        int bakiye = 0;
        public bahis()
        {
            InitializeComponent();
        }
        void anlıkBakiye()
        {
            lblBakiye.Text = "Bakiyeniz : " + bakiye;
        }
        private void bahis_Load(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                anlıkBakiye();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            if (sayi <= 100)
            {
                bakiye += sayi;
                anlıkBakiye();
            }
            else
            {
                MessageBox.Show("Tek seferde 100 tl'den fazla bakiye yüklenemez.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public int winner()
        {
            return winn;
        }
        public void bakiyeGuncelle(int yeniBakiye)
        {
            bakiye += yeniBakiye;
            anlıkBakiye();
        }
        private void button1_Click(object sender, EventArgs e)  // İf else ile kolay yapılırdı ama ben switch case yaptım.
        {
            if (bakiye >= 10)
            {               
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();            
                switch (radioBtn.Name)
                {
                    case "radioCar1":
                    winn = 1;
                        break;
                    case "radioCar2":
                    winn = 2;
                        break;
                    case "radioCar3":
                    winn = 3;
                        break;
                }

                MessageBox.Show($"{winn} Numaralı Araca Bahis Oynandı.");
                bakiye -= 10;
                anlıkBakiye();
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye. Bakiye Ekleyin");
            }
        }
    }
}

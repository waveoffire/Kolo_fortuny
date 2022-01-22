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

namespace Kolo_fortuny
{
    public partial class Form1 : Form
    {
        char litera;
        Haslo haslo2 = new Haslo("Programowanie obiektowe","Przedmioty");
        Kolo kolo2 = new Kolo();
        Gracz gracz2 = new Gracz();

        int nagroda = 0;


        public Form1()
        {
            InitializeComponent();
           
            haslo2.szyfruj();
            HasloLabel.Text = haslo2.Wyswietl();
            KategoriaLabel.Text = haslo2.kategoria;
            kolo2.losujNagrody();
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bool spolgloska = false;
            if (((e.KeyChar >= 65 && e.KeyChar <= 90)|| (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar >= 140))
            {
                Wcisnieto.Text = e.KeyChar.ToString();
                litera = e.KeyChar;
                if (e.KeyChar == 97|| e.KeyChar == 65|| e.KeyChar == 97|| e.KeyChar == 69||
                    e.KeyChar == 101|| e.KeyChar == 105|| e.KeyChar == 73|| e.KeyChar == 79|| e.KeyChar == 97|| e.KeyChar == 111||
                    e.KeyChar == 89|| e.KeyChar == 121 || e.KeyChar == 243 || e.KeyChar == 261 || e.KeyChar == 281
                    || e.KeyChar == 211 || e.KeyChar == 260 || e.KeyChar == 280
                    )
                {
                    spolgloska = true;
                }
            }
            if (spolgloska == true)
            {
                Potwierdz.Text = "Kup";
            }
            else
            {
                Potwierdz.Text = "Potwierdz";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kolo2.klik == true) 
            { 
                if (Potwierdz.Text == "Potwierdz") 
                {
                    var zgadniete = haslo2.zgadnij(litera);
                    if (zgadniete > 0) 
                    { 
                        HasloLabel.Text = haslo2.Wyswietl();
                        gracz2.dodaj(zgadniete * nagroda);
                        money.Text=gracz2.Wyswietl();
                    }
                    kolo2.klik = false;
                }
                else
                {
                    var zgadniete = haslo2.zgadnij(litera);
                    gracz2.kup(200);
                    money.Text = gracz2.Wyswietl();
                    HasloLabel.Text = haslo2.Wyswietl();
                 }        
            }
        }

        private async  void pictureBox1_Click(object sender, EventArgs e)
        {
            if (kolo2.klik == false) 
            {
                kolo2.klik = true;
                var random = kolo2.losuj();
                nagroda = kolo2.wezNagrode(random);
                Bitmap img = (Bitmap)pictureBox1.Image;
                var l = 0;
                for(var i = 0; i < 20* random; i++)
                {
                    l += 18;
                    pictureBox1.Image = kolo2.RotateImage(img, l);
                    await Task.Delay(1 * ((i + 1) / 100));
                }
                wylosowano.Text = nagroda.ToString();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
              

            
        }
    }

}

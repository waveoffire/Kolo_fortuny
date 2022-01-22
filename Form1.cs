using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        static string[] lines = File.ReadAllLines("hasla.txt");
        static Random r = new Random();
        static int randomLineNumber = r.Next(0, lines.Length - 1);
        static string line = lines[randomLineNumber];

        Haslo haslo2 = new Haslo(line.Split(";")[1], line.Split(";")[0]);
        Kolo kolo2 = new Kolo();
        Gracz gracz2 = new Gracz("Marek");

        int nagroda = 0;


        public Form1()
        {
            InitializeComponent();
           
            haslo2.szyfruj();
            HasloLabel.Text = haslo2.Wyswietl();
            KategoriaLabel.Text = haslo2.kategoria;
            //kolo2.losujNagrody();
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
                Potwierdz.Text = "Potwierdź";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kolo2.klik == true) 
            { 
                if (Potwierdz.Text == "Potwierdź") 
                {
                    var zgadniete = haslo2.zgadnij(litera);
                    if (zgadniete > 0) 
                    { 
                        HasloLabel.Text = haslo2.Wyswietl();
                        gracz2.dodaj(zgadniete * nagroda);
                        money.Text=gracz2.Wyswietl()+" zł";
                    }
                    kolo2.klik = false;
                }
                else
                {
                    var zgadniete = haslo2.zgadnij(litera);
                    gracz2.kup(200);
                    money.Text = gracz2.Wyswietl() + " zł";
                    HasloLabel.Text = haslo2.Wyswietl();
                 }
                kolo2.kat = 0;
                Bitmap img = (Bitmap)pictureBox1.Image;
                pictureBox1.Image = kolo2.RotateImage(img, -kolo2.zmiana);
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
                pictureBox1.Image = kolo2.RotateImage(img, 0);
                kolo2.kat = 9;
                kolo2.zmiana = random * 18+9;
                
                for (var i = 0;  i < 20*9 + random; i++)
                {
                    
                    kolo2.kat += 18;
                    
                    pictureBox1.Image = kolo2.RotateImage(img, kolo2.kat);
                    await Task.Delay(1 * ((i + 1) / 100));
                    
                }
                if (nagroda == 0)
                {
                    wylosowano.Text = "Bankrut";
                    gracz2.money = 0;
                }
                else if (nagroda == -1)
                {
                    wylosowano.Text = "STOP";
                }
                else
                {

                
                wylosowano.Text = nagroda.ToString() + " zł";
                }


            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
              

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            haslo2.zgadnijCalosc(textBox1.Text);
        }
    }

}

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
        char litera= '\0';
        string line;
        int nagroda = 0;
        int runda = 1;
        Haslo haslo2;
        Kolo kolo2;
        Gracz[] gracze;
        int numer_gracza = 0;
        Gracz gracz2;
        Gra gra1;
        public Form1()
        {
            changeHaslo();
            kolo2 = new Kolo();
            string name;
            gra1 = new Gra();
            int iloscGraczy = Int32.Parse(Gra.ShowDialog("Podaj ilość graczy", "Podaj ilość graczy"));
            gracze = new Gracz[iloscGraczy];
            for (int i=0; i < iloscGraczy; i++)
            {
                name = Gra.ShowDialog("Podaj nazwe gracza "+(i+1), "Podaj nazwe gracza");
                gracze[i] = new Gracz(name);
            }
            gracz2 = gracze[numer_gracza];
            
            InitializeComponent();
            
            RundaLabel.Text = runda.ToString();
            GraczLabel.Text = gracz2.name;
            
            HasloLabel.Text = haslo2.Wyswietl();
            KategoriaLabel.Text = haslo2.kategoria;
            //kolo2.losujNagrody();
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
    
            if (gra1.SprawdzLitere(e.KeyChar) == true)
            {
                Wcisnieto.Text = e.KeyChar.ToString();
                litera = e.KeyChar;
                if (gra1.SprawdzSpol(e.KeyChar) == true)
                {
                    Potwierdz.Text = "Kup";
                }
                else
                {
                    Potwierdz.Text = "Potwierdź";
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kolo2.klik == true&& litera!= '\0') 
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
                    else
                    {
                        changePlayer();
                    }
                    kolo2.klik = false;
                    litera = '\0';
                    Wcisnieto.Text = "Zakręć kołem";
                    kolo2.kat = 0;
                    Image img = (Image)pictureBox1.Image;
                    pictureBox1.Image = kolo2.RotateImage(img, -kolo2.zmiana);
                }
                else
                {
                    if (gracz2.kup(200))
                    {
                        var zgadniete = haslo2.zgadnij(litera);
                        litera = '\0';
                        Wcisnieto.Text = "Wpisz litere na klawiaturze";
                        money.Text = gracz2.Wyswietl() + " zł";
                        HasloLabel.Text = haslo2.Wyswietl();
                    }
                    
                 }

            }
        }

        private async  void pictureBox1_Click(object sender, EventArgs e)
        {
            if (kolo2.klik == false) 
            {
                Wcisnieto.Text = "Wpisz litere na klawiaturze";
                kolo2.klik = true;
                var random = kolo2.losuj();
                
                if (runda == 1)
                {
                    nagroda = kolo2.wezNagrode(random);
                }
                else if(runda == 2)
                {
                    nagroda = kolo2.wezNagrode2(random);
                }
                else
                {
                    nagroda = kolo2.wezNagrode3(random);
                }

                pictureBox1.Image.Dispose();
                pictureBox1.InitialImage.Dispose();
                pictureBox1.Image = null;        
                pictureBox1.ImageLocation = null;
                pictureBox1.Update();
                if (runda == 1) { 
                    pictureBox1.Image = Image.FromFile(@"..\..\..\wheel.png");
                }
                else if(runda == 2)
                {
                    pictureBox1.Image = Image.FromFile(@"..\..\..\wheel2.png");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"..\..\..\wheel3.png");
                }
                pictureBox1.Update();


                kolo2.kat = 9;
                kolo2.zmiana = random * 18+9;
                Image img = (Image)pictureBox1.Image;
                pictureBox1.Image = kolo2.RotateImage(img, 0);
                
                for (var i = 0;  i < 20 + random; i++)
                {
                    
                    kolo2.kat += 18;
                    
                    pictureBox1.Image = kolo2.RotateImage(img, kolo2.kat);
                    await Task.Delay(1 * ((i + 1) ));
                    
                }
                if (nagroda == 0)
                {
                    wylosowano.Text = "Bankrut";
                    gracz2.money = 0;
                    changePlayer();
                    kolo2.klik = false;
                }
                else if (nagroda == -1)
                {
                    wylosowano.Text = "STOP";
                    changePlayer();
                    kolo2.klik = false;
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
            if (haslo2.zgadnijCalosc(textBox1.Text)==true)
            {
                kolo2.klik = false;
                runda++;
                gracz2.moneyALL += gracz2.money;
                
                pictureBox1.Image = Image.FromFile(@"..\..\..\wheel2.png");
                if (runda > 2)
                {
                    pictureBox1.Image = Image.FromFile(@"..\..\..\wheel3.png");
                }
                if (runda > 5)
                {
                    MessageBox.Show("Gre wygrywa gracz " + gracz2.name + " z kwotą " + gracz2.moneyALL+" zł") ;
                    
                    this.Close();
                }
                RundaLabel.Text = runda.ToString();

                foreach (Gracz g in gracze)
                {
                    g.money = 0;
                }
                gracz2 = gracze[0];


                changeHaslo();
                HasloLabel.Text = haslo2.Wyswietl();
                KategoriaLabel.Text = haslo2.kategoria;
                GraczLabel.Text = gracz2.name;
                money.Text = gracz2.money.ToString() + " zł";
                litera = '\0';
                Wcisnieto.Text = "Zakręć kołem";
            }
            else
            {
                kolo2.klik = false;
                changePlayer();
                litera = '\0';
                Wcisnieto.Text = "Zakręć kołem";

            }
            
        }

        private void Wcisnieto_Click(object sender, EventArgs e)
        {

        }

        public void changePlayer()
        {
            numer_gracza++;
            if (numer_gracza >= gracze.Length)
            {
                numer_gracza = 0;
            }
            gracz2 = gracze[numer_gracza];
            GraczLabel.Text = gracz2.name;
            money.Text = gracz2.money.ToString() + " zł";
        }
        public void changeHaslo()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\hasla.txt");
            Random r = new Random();
            int randomLineNumber = r.Next(0, lines.Length - 1);
            line = lines[randomLineNumber];

            haslo2 = new Haslo(line.Split(";")[1], line.Split(";")[0]);
            haslo2.szyfruj();
        }
    }

}

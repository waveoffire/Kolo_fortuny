using System;
using System.Collections.Generic;
using System.Text;

namespace Kolo_fortuny
{
    public class Gracz
    {
        string name;
        private int money;
        public void kup(int ile) {
            money -= ile;
        }
        public void dodaj(int ile) {
            money += ile;
        }
        public string Wyswietl()
        {
            return money.ToString();
        }
    }
}

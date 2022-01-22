using System;
using System.Collections.Generic;
using System.Text;

namespace Kolo_fortuny
{
    public class Gracz
    {
        public Gracz(string _name)
        {
            name = _name;
        }
        public string name;
        public int money;
        public void kup(int ile) {
            if (money - ile > 0) { 
                money -= ile;
            }
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

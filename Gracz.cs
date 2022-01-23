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
        public int moneyALL=0;
        public bool kup(int ile) {
            if (money - ile > 0) { 
                money -= ile;
                return true;
            }
            else
            {
                return false;
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

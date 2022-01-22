using System;
using System.Collections.Generic;
using System.Text;

namespace Kolo_fortuny
{
    public class Haslo
    {
        string text;
        public string kategoria;
        public string encrypted_text;

        public Haslo(string _text,string _kategoria)
        {
            text = _text.ToLower();
            kategoria = _kategoria;
        }

        public string Wyswietl()
        {
            string temp = "";
            foreach (char c in encrypted_text)
            {
                if (c == 32)
                {
                    temp = temp + "\n";
                }
                else { 
                temp = temp + " " + c + " ";
                }
            } 
            return temp.ToUpper();
        }

        public void szyfruj()
        {
            encrypted_text = "";
            foreach (char c in text)
            {
                if (c == 32)
                {
                    encrypted_text = encrypted_text + c;
                }
                else
                {
                    encrypted_text = encrypted_text + "_";
                }
            }

        }
        public int zgadnij(char litera)
        {
            litera = Char.ToLower(litera);
            int zgadnieto = 0;
               string temp = "";
            for (int counter = 0; counter < encrypted_text.Length; counter++)
            {
                
                if (encrypted_text[counter] == 95)
                {
                    if(text[counter] == litera)
                    {
                        temp += litera;
                        zgadnieto++;
                    }
                    else
                    {
                        temp += encrypted_text[counter];
                    }
                }
                else
                {
                    temp += encrypted_text[counter];
                }
            }
            encrypted_text = temp;


            return zgadnieto;
        }
    }


}

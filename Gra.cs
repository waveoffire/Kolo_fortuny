using System;
using System.Collections.Generic;
using System.Text;

namespace Kolo_fortuny
{
    public class Gra
    {


       public bool SprawdzLitere(char c)
        {

            
            if (((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c >= 140))
            {
               
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool SprawdzSpol(char c)
        {

            if (c == 97 || c == 65 || c == 97 || c == 69 || c == 101 || c == 105 || c == 73 || c == 79 || c == 97 || c == 111 || c == 89 || c == 121 || c == 243 || c == 261 || c == 281 || c == 211 || c == 260 || c == 280)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}

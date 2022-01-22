using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Kolo_fortuny
{
    
    class Kolo
    {
        private int[] nagrody = new int[] { 425, 225, 375, -1, 25, 275, 400, 325, 100, 0, 200, 50, 350, 3000, 175, 475, 300, 125, 75, 500 };
        public bool klik = false;
        public int kat =0;
        public int zmiana = 0;
        public Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                g.DrawImage(bmp, new Point(0, 0));
            }
            return rotatedImage;
        }

        public int losuj()
        {
            var rand = new Random();
            return rand.Next(20);
        }
        public int wezNagrode(int ktora)
        {
            return nagrody[ktora];
        }
    }
}

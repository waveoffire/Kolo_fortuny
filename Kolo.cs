using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Kolo_fortuny
{
    
    class Kolo
    {
        private int[] nagrody = new int[] { 425, 225, 375, -1, 25, 275, 400, 325, 100, 0, 200, 50, 350, 3000, 175, 475, 300, 125, 75, 500 };
        private int[] nagrody2 = new int[]{ 300, 550 ,0 ,800 ,750 ,900 ,150 ,100 ,700 ,350 ,900 ,850 ,650 ,3000 ,500 ,200 ,650 ,450 ,875 ,600 };
        public bool klik = false;
        public int kat =0;
        public int zmiana = 0;
        public Image RotateImage(Image bmp, float angle)
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
        public int wezNagrode2(int ktora)
        {
            return nagrody2[ktora];
        }
    }
}

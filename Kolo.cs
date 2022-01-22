using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Kolo_fortuny
{
    
    class Kolo
    {
        private int[] nagrody = new int[20];
        public bool klik = false;
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
        public void losujNagrody()
        {
            for (var i = 0; i < 20; i++)
            {
                var rand = new Random();
                nagrody[i] = (rand.Next(10) + 1)*100;
            }
             
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

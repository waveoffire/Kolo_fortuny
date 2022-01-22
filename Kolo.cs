using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Kolo_fortuny
{
    
    class Kolo
    {
        private int[] nagrody;
        public Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }
        public void losujNagrody()
        {
            for (var i = 0; i > 20; i++)
            {
                var rand = new Random();
                nagrody[i] = (rand.Next(10) + 1)*100;
            }
             
        }
        public int losuj()
        {
            var rand = new Random();
            return rand.Next(20)+1;
        }
        public int wezNagrode(int ktora)
        {
          
            return nagrody[ktora];
        }
    }
}

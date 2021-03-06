using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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


        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width=300, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TEST27_WPF_Lotto
{
    public partial class MainWindow
    {
        private void GenerateNumbers()
        {
            Random rnd = new Random();
            int[] seq = new int[59];

            for (int i = 1; i < 60; i++)
            {
                seq[i - 1] = i;
            }
            for (int i = 0; i < 59; i++)
            {
                int j = (rnd.Next() % 59);      // modulo
                int k = seq[i];                 // store [next index]
                seq[i] = seq[j];                // swap array[random index] ...
                seq[j] = k;                     // with [next index]
            }
            box1.Text = seq[1].ToString().PadLeft(2, ' ');
            box1.Text = box1.Text.Substring(box1.Text.Length - 2);

            box2.Text = seq[2].ToString().PadLeft(2, ' ');
            box2.Text = box2.Text.Substring(box2.Text.Length - 2);

            box3.Text = seq[3].ToString().PadLeft(2, ' ');
            box3.Text = box3.Text.Substring(box3.Text.Length - 2);

            box4.Text = seq[4].ToString().PadLeft(2, ' ');
            box4.Text = box4.Text.Substring(box4.Text.Length - 2);

            box5.Text = seq[5].ToString().PadLeft(2, ' ');
            box5.Text = box5.Text.Substring(box5.Text.Length - 2);

            box6.Text = seq[6].ToString().PadLeft(2, ' ');
            box6.Text = box6.Text.Substring(box6.Text.Length - 2);

            //MessageBox.Show("Generate numbers...", "Generate",
            //MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Reset()
        {
            box1.Text = "__";
            box2.Text = "__";
            box3.Text = "__";
            box4.Text = "__";
            box5.Text = "__";
            box6.Text = "__";
        }
    }
}

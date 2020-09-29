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
            box1.Text = seq[1].ToString();
            box2.Text = seq[2].ToString();
            box3.Text = seq[3].ToString();
            box4.Text = seq[4].ToString();
            box5.Text = seq[5].ToString();
            box6.Text = seq[6].ToString();


            //MessageBox.Show("Generate numbers...", "Generate",
            //MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Reset()
        {
            box1.Text = "--";
            box2.Text = "--";
            box3.Text = "--";
            box4.Text = "--";
            box5.Text = "--";
            box6.Text = "--";
        }
    }
}

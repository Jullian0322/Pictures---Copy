using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            int[] mathArray = { 77, 86, 91, 58 , 66, 55, 44, 99, 88, 100 };
            int[] englishArray = { 87, 78, 98, 89, 79, 87, 77, 91, 92, 93 };
            int[] scienceArray = { 43, 34, 9, 100, 4, 100, 12, 100, 6, 55 };
            int[,] Box = new int[3, mathArray.Length];
            String newLine = Environment.NewLine;

            RTB1.Text = "The average for Math is: " + findAvg(mathArray).ToString("0.00") + newLine;
            RTB1.Text = "The average for English is: " + findAvg(englishArray).ToString("0.00") + newLine;
            RTB1.Text = "The average for Science is: " + findAvg(scienceArray).ToString("0.00") + newLine;

            for (int i = 0; i < mathArray.Length; i++)
            {
                Box[0, i] = mathArray[i];
                Box[1, i] = englishArray[i];
                Box[2, i] = scienceArray[i];
            }

            RTB1.Text += Environment.NewLine + "Averages minus high and low" + Environment.NewLine;
            RTB1.Text += "--------------------------------------" + Environment.NewLine;
            RTB1.Text += "The average for Math is: " + TrueAvg(Box, 0).ToString("0.00") + newLine;
            RTB1.Text += "The average for English is: " + TrueAvg(Box, 1).ToString("0.00") + newLine;
            RTB1.Text += "The average for Science is: " + TrueAvg(Box, 2).ToString("0.00") + newLine;


        }

        private double findAvg(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return (sum / a.Length);
        }

        private double TrueAvg(int[,] a, int row)
        {
            double sum = 0;
            int high, low;

            // Default the high and the low to the first element - one has to change
            // they both could change, but at least one has to change.
            high = a[row, 0];
            low = a[row, 0];

            for (int i = 1; i < a.GetLength(1); i++)
            {
                if (a[row, i] > high)
                {
                    high = a[row, i];
                }
                else if (a[row, i] < low)
                {
                    low = a[row, i];
                }
                sum += a[row, i];
            }

                sum += a[row, 0];

                return ((sum - (high + low)) / (a.GetLength(1) - 2));
        }
    }
}

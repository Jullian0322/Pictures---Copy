using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_MDA
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int[] prebuiltMulti1 = { 40, 42, 44, 46, 48, 50, 52, 54, 56, 58 };
        int[] prebuiltMulti2 = { 65, 67, 69, 71, 73, 75, 77, 79, 81, 83 };
        int[,] randomMulti1 = new int[1, 11];
        int[,] randomMulti2 = new int[1, 11];
        //Setting up the grid
        private void btnGo_Click(object sender, EventArgs e)
        {
                                                 
            Random rnd = new Random();


            //making the grid
            int[,] quizGrid = new int[prebuiltMulti1.Length, 4];

            for (int i = 0; i < prebuiltMulti1.Length; i++)
            {
                quizGrid[i, 0] = prebuiltMulti1[i];
                quizGrid[i, 1] = prebuiltMulti2[i];
                randomMulti1[i, 0] = rnd.Next(40, 51);
                randomMulti2[i, 0] = rnd.Next(50, 61);
                quizGrid[i, 2] = randomMulti1[i, 0];
                quizGrid[i, 3] = randomMulti2[i, 0];
            }

            rtbOutput.Text += "The sum of the first prebult is:" + addingStuff1(prebuiltMulti1).ToString("0") + Environment.NewLine;
            rtbOutput.Text += "The sum of the secound prebult is:" + addingStuff1(prebuiltMulti2).ToString("0") + Environment.NewLine;
            rtbOutput.Text += "The sum of the first random is:" + addingStuff2(randomMulti1).ToString("0") + Environment.NewLine;
            rtbOutput.Text += "The sum of the first random is:" + addingStuff2(randomMulti2).ToString("0") + Environment.NewLine;
            rtbOutput.Text += "The sum of everything is:" + addingStuff3().ToString("0") + Environment.NewLine;

        }

        //adding all int[] here
        private double addingStuff1(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        //adding all int[,] here
        private double addingStuff2(int[,] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[0, i];
            }
            return sum;
        }

        //adding everything together
        private double addingStuff3()
        {
            double sum5 = 0;
            sum5 = addingStuff1(prebuiltMulti1) + addingStuff1(prebuiltMulti2) + addingStuff2(randomMulti1) + addingStuff2(randomMulti2);
            return sum5;
        }
    }
}

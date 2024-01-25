using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms.Automation;
using System.Windows.Forms.Design;
using System.Windows.Forms.Internal;
using System.Windows.Forms.Layout;

namespace sophomore2026playground
{
    public partial class Form1 : Form
    {
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            string theLable = "";
            theLable = "This is what a Label is";


            if (flag)
            {
                lblfirst.Text = "We all live in a yellow suberine";
            }
            else
            {
                lblfirst.Text = theLable;
            }
            flag = !flag;

            BTN2.Visible = true;
            BTN1.BackColor = Color.DarkGoldenrod;
            BTN1.Top = 338;
            BTN1.Left = 132;
            BTN3.Top = 338;
            BTN3.Left = 557;
        }
        private void BTN_1_Click(object sender, EventArgs e)
        {
            BTN2.Visible = false;
            BTN3.Top += 50;
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            int pos = BTN1.Left;
            BTN1.Left = BTN3.Left;
            BTN3.Left = pos;

            pos = BTN1.Top;
            BTN1.Top = BTN3.Top;
            BTN3.Top = pos;
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            BTN2.Visible = true;
            BTN1.BackColor = Color.White;
        }

        private void BTNSTRING_Click(object sender, EventArgs e)
        {
            TXT1.Text = " I want to. Get started. ";
            string input = TXT1.Text;
            TXT2.Text = input + " - " + input;

            TXT2.Text += "\n" + "the Length is " + input.Length;

            TXT2.Text += "\n" + input.ToLower() + " - " + input.ToUpper();

            TXT2.Text += "\n" + "Found a period at pos: " + input.IndexOf(".");
            TXT2.Text += "\n" + " Found another period at pos: " + input.IndexOf(".", 11);

            TXT2.Text += "\n" + " Did I find a started: " + input.Contains("started");
            if (input.Contains("started"))
            {
                input = input.Replace("starded", "going");
                TXT2.Text += "\n" + " Replace the word: " + input;
            }

            TXT2.Text += "\n" + "Get rid of spaces: " + input.Trim();
            //same as the while loop
            for (int i = 0; i < 5; i++)
            {
                TXT2.Text += i;
            }
            TXT2.Text += "\n";
            int count = 0;
            bool done = false;
            //same as the for loop
            while (count < 5)
            {
                TXT2.Text += count;
                count++;
            }
            count = 0;
            input = "";
            while (!done)
            {
                if (count != 100)
                {
                    input += ", ";
                }
                input += count;
                if (count-- % 37 == 0)
                {
                    done = true;
                }
            }
            TXT2.Text += $"\n{input}";
        }

        private void BTNCAT_Click(object sender, EventArgs e)
        {
            TXT1.Text = "My kitty cat craves chicken, my kitty cat craves milk.  My kitty cat caves tuna, so my kitty cat craves Crave, yeah, my kitty cat craves Crave.";
            string input = TXT1.Text;
            string input2;
            bool fin = false;
            int kittys = 0, pos = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    TXT2.Text = "\r\n" + input.ToUpper();
                }
                else
                {
                    TXT2.Text = "\r\n" + input.ToLower();
                }
                if (i <= 5)
                {
                    input2 = input.Replace("cat", "elephant");
                    TXT2.Text += "\r\n" + input2;
                }
                while (!fin)
                {
                    pos = input.IndexOf("kitty", pos);
                    if (pos >= 0)
                    {
                        pos++;
                        kittys++;
                    }
                    else { fin = true; }
                }
                TXT2.Text += $"\nLooks like there are {kittys} kittyies\n";

                TXT2.Text += "\r\n(4) String Length;\r\n";
                TXT2.Text += $"\r\npre-elephant: {input.Length}\r\n";
                TXT2.Text += $"\r\npost-elephant: {input.Length}\r\n";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            String[] strings = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQR", "TUV", "WXY", "Z", "123" };
            String temp;
            String output = "";
            int count = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                temp = strings[i].ToUpper();
                for (int j = 0; j < temp.Length; j++)
                {
                    // Greater than T
                    // strings[i, j]
                    if ((char)temp[j] > 84)
                    {
                        count++;
                        output += temp[j];

                        // ++count plus it then uses varible;
                    }
                }
            }
            TXT2.Text += $"The Number of letters greater than T is {count}" + Environment.NewLine;
            TXT2.Text += $"The number of letters greater than T are {output}";


            // tewo dimensional array of random numbers
            //10 x 2

            // first row 100-200
            //secound row 500 - 1000
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            int[,] thisIsMyMulti = new int[10, 2];
            Random rnd = new Random();

            for (int i = 0; i < thisIsMyMulti.GetLength(0); i++)
            {
                // row 0
                thisIsMyMulti[i, 0] = rnd.Next(100, 200);
                TXT2.Text += thisIsMyMulti[i, 0] + ", ";
                // row 1
                thisIsMyMulti[i, 1] = rnd.Next(500, 1000);
                TXT2.Text += thisIsMyMulti[i, 1] + Environment.NewLine;
            }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            int[,] Box1 = new int[10, 2];
            int[,] Box2 = new int[10, 2];
            int[,] Box3 = new int[10, 2];
            Random rnd = new Random();

            for (int i = 0; i < Box1.GetLength(0); i++)
            {
                // row 0
                Box1[i, 0] = rnd.Next(1, 11);
                TXT2.Text += Box1[i, 0] + ", ";
                // row 1
                Box1[i, 1] = rnd.Next(25, 51);
                if (Box1[i, 0] < 10)
                {
                    TXT2.Text += " ";
                }
                TXT2.Text += Box1[i, 1] + Environment.NewLine;
            }
            TXT2.Text += "-------------" + Environment.NewLine;
            for (int i = 0; i < Box2.GetLength(0); i++)
            {
                // row 0
                Box2[i, 0] = rnd.Next(1, 11);
                TXT2.Text += Box2[i, 0] + ", ";
                if (Box2[i, 0] < 10)
                {
                    TXT2.Text += " ";
                }
                // row 1 .ToString().PadLeft(N) N = number // for next time
                Box2[i, 1] = rnd.Next(25, 51);
                TXT2.Text += Box2[i, 1] + Environment.NewLine;
            }
            TXT2.Text += "-------------" + Environment.NewLine;
            for (int i = 0; i < Box3.GetLength(0); i++)
            {
                Box3[i, 0] = Box1[i, 0] + Box2[i, 0];
                TXT2.Text += Box3[i, 0] + ", ";
                if (Box3[i, 0] < 10)
                {
                    TXT2.Text += " ";
                }
                Box3[i, 1] = Box1[i, 0] + Box1[i, 1];
                TXT2.Text += Box3[i, 1] + Environment.NewLine;
            }
            TXT2.Text += "-------------" + Environment.NewLine;
        }
        private void BTNSR_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int temp1 = rnd.Next(5, 50);
            int temp2 = rnd.Next(5, 50);


            TXT2.Text = printoutResult(FirstGreaterThanSecound(temp1, temp2), temp1, temp2);
        }

        private bool FirstGreaterThanSecound(int a, int b)
        {
            bool retVal = false;
            if (a > b)
            {
                retVal = true;
            }
            return retVal;
        }

        private String printoutResult(bool check, int a, int b)
        {
            String output = "";
            output = $"num1: {a} | num2: {b}";
            if (check)
            {
                output = "Greater";
            }
            else
            {
                output += "Not Greater";
            }
            return output;
        }

        private String Mpl(String input, int howBig)
        {
            for (int i = 0; i < howBig - input.Length; i++)
            {
                input = " " + input;
            }
            return input;
        }

        private void BTNGO_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            Random rnd = new Random();
            String gradeOutput = "";
            String grade = "";
            int Owned = 0;
            bool hasSS;

            //Builed the array of 10 numbers at Random // Also build a comma delimeted to every number ecept the first
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(40, 101);
                if (i != 0)
                {
                    gradeOutput += ", ";
                }
                gradeOutput += a[i];
            }
            grade = returnG(a);
            hasSS = returnS(grade);
            Owned = howMuch(hasSS, grade);
        }

        private String returnG(int[] arr)
        {
            double average;

            average = arr.Average();

            //If statements to get letter grade

            return "";
        }

        private bool returnS(String letterGrade)
        {
            bool check = false;

            //If statements to see if passed

            return check;
        }

        private int howMuch(bool failed, String letterGrade)
        {
            int retOwed = 0;

            //How much earned if failed

            return retOwed;
        }

        private void BTNhelp_Click(object sender, EventArgs e)
        {
            int[,] Box1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 8, 8, 8 } };
            int[,] Box2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 7, 1, 4 } };

            int[,] Box3 = { { 1, 2, 3, 4 }, { 4, 5, 6, 4 }, { 8, 8, 8, 4 }, { 1, 2, 3, 4 } };
            int[,] Box4 = { { 9, 8, 7, 5 }, { 6, 5, 4, 5 }, { 7, 1, 4, 5 }, { 1, 2, 3, 5 } };

            int[,] grid5 = { { 1, 2, 3, 6 }, { 4, 5, 6, 6 }, { 8, 8, 8, 6 }, { 1, 2, 3, 6 } };
            int[,] grid6 = { { 9, 8, 7, 6 }, { 6, 5, 4, 7 }, { 7, 1, 4, 7 }, { 1, 2, 3, 7 }, { 4, 5, 6, 7 } };
            buildAndShowGrid(Box1, Box2, Box3, Box4);
        }

        private void buildAndShowGrid(int[,] Box1, int[,] Box2, int[,] Box3, int[,] Box4)
        {
            String multiBox = "";
            String LeftDiog = "";
            String RightDiog = "";
            int RowupperBound = Box3.GetLength(0);
            int CollupperBound = Box4.GetLength(1);
            int RightDiogCounter = RowupperBound - 1;

            Boolean goodinput = (RowupperBound == CollupperBound);

            goodinput = (goodinput && RowupperBound == Box3.GetLength(0));

            goodinput = (goodinput && RowupperBound == Box4.GetLength(1));
            if (goodinput)
            {
                for (int i = 0; i < RowupperBound; i++)
                {
                    for (int j = 0; j < CollupperBound; j++)
                    {
                        multiBox += (Box3[i, j] * Box4[i, j]).ToString().PadLeft(3);
                    }
                    multiBox += Environment.NewLine;
                    //Multiple left diaginals
                    LeftDiog += (Box3[i, i] * Box4[i, i]).ToString().PadLeft(3);
                    //mutiple right diaginals
                    RightDiog += (Box3[i, RightDiogCounter - i] * Box4[i, RightDiogCounter - i]).ToString().PadLeft(3);

                    TXT2.Text = multiBox + LeftDiog + RightDiog;
                }
            }
        }
        private void buildAndShowMiniBox(int[,] Box3, int[,] Box4)
        {
            int rowUpperBound = Box3.GetLength(0);
            int collUpperBound = Box4.GetLength(1);
            String multiGrid = "";
            String leftDiag = "";
            String rightDiag = "";

            TXT2.Text = "";

            for (int i = 0; i < rowUpperBound; i++)
            {
                for (int j = 0; j < collUpperBound; j++)
                {
                    multiGrid += (Box3[i, j] * Box4[i, j]).ToString().PadLeft(3);
                }
                multiGrid += Environment.NewLine;
                //Multiple left diaginals
                leftDiag += (Box3[i, i] * Box4[i, i]).ToString().PadLeft(3);
                //mutiple right diaginals
                rightDiag += (Box3[i, 2 - i] * Box4[i, 2 - i]).ToString().PadLeft(3);
                TXT2.Text = multiGrid + leftDiag + rightDiag;
            }
        }
    }
}
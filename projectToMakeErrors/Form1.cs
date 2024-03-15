using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectToMakeErrors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static char[] myNewFunction()
        {
            char[] myArray = new char[26];
            for (int i = 0; i < 26; i++)
            {
                myArray[i] += ((char)(i + 65));
            }

            return myArray;
        }
        private void mainButton_Click(object sender, EventArgs e)
        {
            char[] myMainArray = new char[26];
            myMainArray = myNewFunction();
            for (int i = 0; i < 26; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int i = 0; i < 26; i++)
            {
                Console.Write(myMainArray[i]);
            }
            Console.Write("\n");
            for (int i = 25; i >= 0; i--)
            {
                Console.Write(myMainArray[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 26; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}

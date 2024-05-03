using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence");
            string text = Console.ReadLine();
            Console.WriteLine(checkTheSentence(text));
            Console.ReadLine();
        }

        static string checkTheSentence(string text)
        {
            int words = 0;
            int word = 0;
            string temp = text;
            string result = "";
            int j = 0;

            temp.Replace("'", "");
            temp.Replace(",", "");
            temp.Replace(".", "");
            temp.Replace("?", "");
            temp.Replace("!", "");

            string[] array = {temp};

            for (int i = 0; i <= array.Length; i++)
            {
                if (i < 5)
                {
                    word++;
                }
                else if (i >= 5)
                {
                    words++;
                }
            }

            if (words == 3)
            {
                while (j <= word)
                {
                    result += text;
                    j++;
                }
            }
            else
            {
                //Something to percentage and get a zero
                if (word % 2 == 0)
                {
                    for (int i = array.Length; i > 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestForConsoleJullian
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("[1] Double But Only Once");
            Console.WriteLine("[2] Inverse The Aplhapet");

            String input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine(DoubleOnlyOnce());
            }
            else if (input == "2")
            {
                Console.WriteLine(InverseAlphabet());
            }
        }

        static int[] DoubleOnlyOnce()
        {
            Console.WriteLine("Please enter a sentence");
            String input = Console.ReadLine();
            int[] charCount = new int[26];
            String temp = input;
            int[] results = charCount;
            int[] done = results;

            temp.Replace(" ", "");
            temp.Replace(",", "");
            temp.Replace(".", "");
            temp.Replace("!", "");
            temp.Replace("?", "");
            temp.ToUpper();

            for (int i = 65; i <= 91; i++)
            {
                i = charCount[i];

                Convert.ToChar(charCount[i]);

                if (charCount[i] == Convert.ToInt32(temp))
                {
                    int[] howMany = { charCount[i] };

                    if (charCount[i] == howMany[charCount[i]])
                    {
                        howMany[charCount[i]] = 00;
                    }

                    results = howMany;

                    Console.WriteLine(results);

                    return results;
                }
            }

            return done;
        }

        static String InverseAlphabet()
        {
            Console.WriteLine("Please enter a sentence");
            String input = Console.ReadLine();
            String temp = input;
            Boolean done = false;

            char min = 'a';
            char max = 'z';

            temp.Replace(" ", "");
            temp.Replace(",", "");
            temp.Replace(".", "");
            temp.Replace("!", "");
            temp.Replace("?", "");
            temp.ToUpper();

            while (!done)
            {
                temp.Replace(min, max);
                min++;
                max++;

                if (min == 'm')
                {
                    done = true;
                }
                temp.ToLower();
            }

            input = temp;

            Console.WriteLine(input);

            return input;
        }
    }
}
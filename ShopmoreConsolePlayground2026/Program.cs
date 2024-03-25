using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;

namespace ShopmoreConsolePlayground2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean done = false;
            String input;

            while (!done)
            {
                Console.WriteLine("[1] Trangles");
                Console.WriteLine("[2] While Loops");
                Console.WriteLine("[3] working with list");
                Console.WriteLine("[4] which is faster");
                Console.WriteLine("[Q] Exit");
                input = Console.ReadLine();
                if (input.ToUpper() == "Q")
                {
                    done = true;
                }
                else
                {
                    if (input == "1")
                    {
                        Console.WriteLine(triangleF('*', 4));
                        Console.WriteLine(triangleB('*', 4));
                        Console.WriteLine(triangleUF('*', 4));
                        Console.WriteLine(triangleUB('*', 4));
                        Console.WriteLine(triangleEvent('*', 4));
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine(WtriangleF('*', 4));
                        Console.WriteLine(WtriangleEvent('*', 4));
                        Console.WriteLine(TentoFifity());
                        Console.WriteLine(FiftytoFifteen());
                        Console.WriteLine(OnetoHundread());
                        Console.WriteLine(OutofFive());
                        Console.WriteLine(Superheros());
                        Console.WriteLine(sorehrepowS());
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine(workingwithList());
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine(faster());
                    }
                }
            }

        }

        static string triangleF(char symbol, int numRows)
        {
            string output = "";
            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        output += symbol;
                    }
                    output += "\n";
                }
            }
            return output;
        }

        static string triangleB(char symbol, int numRows)
        {
            string output = "";
            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = numRows - (i + 1); j > 0; j--)
                    {
                        output += " ";
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        output += symbol;
                    }
                    output += "\n";
                }
            }
            return output;
        }

        static string triangleUF(char symbol, int numRows)
        {
            string output = "";
            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {
                for (int i = numRows; i >= 0; i--)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        output += symbol;
                    }
                    output += "\n";
                }
            }
            return output;
        }

        static string triangleUB(char symbol, int numRows)
        {
            string output = "";
            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {
                for (int i = numRows; i >= 0; i--)
                {
                    for (int j = numRows - (i - 1); j > 0; j--)
                    {
                        output += " ";
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        output += symbol;
                    }
                    output += "\n";
                }
            }
            return output;
        }

        static string triangleEvent(char symbol, int numRows)
        {
            string output = "";
            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = numRows - i; j > 0; j--)
                    {
                        output += " ";
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        output += symbol + " ";
                    }
                    output += "\n";
                }
            }
            return output;
        }

        static string WtriangleF(char symbol, int numRows)
        {
            string output = "";
            int i = 0;
            int j;

            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {
                while (i < numRows)
                {
                    j = 0;
                    while (j <= i)
                    {
                        output += symbol;
                        j++;
                    }

                    output += "\n";
                    i++;
                }
            }
            return output;
        }

        static string WtriangleEvent(char symbol, int numRows)
        {
            string output = "";
            int i = 0;
            int j;
            int J;

            if (numRows > 100)
            {
                output = "To Many try again";
            }
            else
            {
                while (i < numRows)
                {
                    j = 0;
                    J = numRows - i;
                    while (J > 0)
                    {
                        output += " ";
                        J--;
                    }
                    while (j <= i)
                    {
                        output += symbol + " ";
                    }

                    output += "\n";
                    i++;
                }
            }
            return output;
        }

        static string TentoFifity()
        {
            string output = "";
            int i = 10;

            while (i <= 50)
            {
                if (i != 10)
                {
                    output += ", ";
                }
                else
                {
                    output += i.ToString();
                }
                i++;
            }

            return output;
        }

        static string FiftytoFifteen()
        {
            string output = "";
            int i = 50;

            while (i >= 15)
            {
                if (i != 50)
                {
                    output += ", ";
                }
                else
                {
                    output += i.ToString();
                }
                i++;
            }

            return output;
        }

        static string OnetoHundread()
        {
            string output = "";
            int i = 1;

            while (i <= 100)
            {
                if (i % 10 == 0)
                {
                    output += "\n";
                }
                else if (i % 7 == 0)
                {
                    output += "";
                }
                else
                {
                    output += i.ToString() + " ";
                }
            }

            return output;
        }

        static string OutofFive()
        {
            string output = "";
            int i = 0;
            int Outcounter = 0;
            int cuPos = 65;

            Boolean done = false;

            while (!done)
            {
                i = 0;
                output += Outcounter + ":\n";
                while (i < 5)
                {
                    if (cuPos > 91)
                    {
                        done = true;
                        i += 5;
                    }
                    else
                    {

                        if (i != 0)
                        {
                            output += ", ";
                        }
                        output += (char)cuPos++;
                        i++;
                    }
                }
                Outcounter++;

            }
            return output;
            }

        static string Superheros()
        {
            String[] heros = { "Superman", "Batman", "Wonder Woman", "Ant Man", "The Hulk", "Captain America", "Captain Marvel", "Deadpool", "Peter", "Spider Man" };
            string output = "";
            int herosCount = 0;
            int charsCount = 0;
            char indivalchar;

            bool done = false;

            while (herosCount < heros.Length)
            {
                charsCount = 0;
                while (charsCount < heros[herosCount].Length)
                {
                    indivalchar = heros[herosCount][charsCount++];
                    if (indivalchar == ' ')
                    {
                        indivalchar = '-';
                    }
                    output += indivalchar + " ";
                    
                    output += " | ";
                    herosCount++;
                }
                if (herosCount < heros.Length) 
                {
                    done = true;
                }
                else
                {
                    output += "| ";
                }
            }

            return  output;
        }

        static string sorehrepowS()
        {
            string output = "";
            string[] words = { "Superman", "Batman", "Wonder Woman", "Ant Man", "The Hulk", "Captain America", "Captain Marvel", "Deadpool", "Peter", "Spider Man" };

            // How many words and how many characters in each word
            int wordsCount = words.Length - 1;
            int charsCount = 0;

            // Only created for readability
            char individualChar;
            string individualWord;

            // Controls the loop
            Boolean done = false;
            Boolean upperCaseIt = false;
            while (!done)
            {
                individualWord = words[wordsCount];
                // Reset counter to the beginning of each word

                if (individualWord.ToLower().Contains("woman"))
                {
                    individualWord = individualWord.Replace("Woman", "Man");
                    individualWord = individualWord.Replace("woman", "man");
                    output += individualWord;
                }
                else if (individualWord.ToLower().Contains("man"))
                {
                    individualWord = individualWord.Replace("man", "woman");
                    individualWord = individualWord.Replace("Man", "Woman");
                    output += individualWord;
                }
                else
                {
                    individualWord = individualWord.ToLower();
                    charsCount = individualWord.Length - 1;

                    upperCaseIt = true;

                    // While there are words still left
                    while (charsCount >= 0)
                    {
                        // Save current character for readability
                        individualChar = individualWord[charsCount--];
                        if (upperCaseIt)
                        {
                            individualChar = (char)(individualChar - 32);
                            output += individualChar;
                            upperCaseIt = false;
                        }
                        else
                        {
                            output += individualChar;
                            if (individualChar == ' ')
                            {
                                upperCaseIt = true;
                            }
                        }
                    }
                }


                // Move to next word
                wordsCount--;

                // Since this is 0 based if we hit the words length
                // we have complete all the words
                if (wordsCount == 0) { done = true; }

                // Still words left, put out a pipe as a separator
                else { output += ", "; }
            }
            return output;
        }

        /*static string sentence()
        {
            String[] output = { "A simple sentence is the most basic sentence that we have in English. It has just one independent clause, which means only one subject and one predicate. A simple sentence is also the shortest possible sentence; it can have as little as two words!" };

            Boolean done = false;
            int words = output.Length - 1;
            string word;
            char singleword;

            while (!done)
            {

                
                if (words > 5 && != '.' || '!' || '?' || ','))
                {
                    words.ToString().ToUpper();
                }
                else if (words == 5 && != '.' || '!' || '?' || ',')
                {
                    words.ToString().Replace(words, );
                }
                else
                {

                }
            }

            return output;
        }
        */

        static string workingwithList()
        {
            string[] words = { "Superman", "Batman", "Wonder Woman", "Ant Man", "The Hulk", "Captain America", "Captain Marvel", "Deadpool", "Peter", "Spider Man" };
            ArrayList arrayList = new ArrayList();
            string output = "";

            for (int i = 0; i < words.Length; i++)
            {
                arrayList.Add(words[i]);
            }

            //using a array
            printArray(words);
            words = removeItem(words, 3);
            printArray(words);

            //using an arrayList
            printArray(arrayList);
            arrayList.RemoveAt(3);
            printArray(arrayList);


            return "";
        }

        static void printArray(string[] a)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void printArray(ArrayList a)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static string[] removeItem(string[] A, int b)
        {
            // build a new array thats smaller than og
            string[] newArr = new string[A.Length-1];
            int c = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (i != b)
                {
                    newArr[c++] = A[i];
                }
            }

            return newArr;
        }

        static string faster()
        {
            Stopwatch timer = new Stopwatch();
            TimeSpan timeTaken = new TimeSpan();
            int[] number = new int[200000];
            ArrayList arrayList = new ArrayList();
            Random rnd = new Random();

            for (int i = 0; i <number.Length; i++)
            {
                number[i] = rnd.Next(1, 1001);
                arrayList.Add(number[i]);
            }

            timer.Start();
            for (int i = 0; i <= 100000; i++)
            {
                number = removeItem(number, 50);
            }
            timer.Stop();

            timer.Start();
            for (int i = 0; i <= 100000; i++)
            {
                
                arrayList.RemoveAt(50);
                
            }
            timer.Stop();
            timeTaken = timer.Elapsed;

            Console.WriteLine(timeTaken.ToString());

            return "";
        }

        static int[] removeItem(int[] A, int b)
        {
            // build a new array thats smaller than og
            int[] newArr = new int[A.Length - 1];
            int c = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (i != b)
                {
                    newArr[c++] = A[i];
                }
            }

            return newArr;
        }
    }
}

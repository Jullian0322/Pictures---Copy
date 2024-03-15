using System;
using System.Diagnostics.PerformanceData;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Xml;

namespace ShopmoreConsolePlayground2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("thirty five");
            //for loop
            Console.WriteLine(triangleF('*', 4));
            Console.WriteLine(triangleB('*', 4));
            Console.WriteLine(triangleUF('*', 4));
            Console.WriteLine(triangleUB('*', 4));
            Console.WriteLine(triangleEvent('*', 4));
            //while loop
            Console.WriteLine(WtriangleF('*', 4));
            Console.WriteLine(WtriangleEvent('*', 4));
            Console.WriteLine(TentoFifity());
            Console.WriteLine(FiftytoFifteen());
            Console.WriteLine(OnetoHundread());
            Console.WriteLine(OutofFive());
            Console.WriteLine(Superheros());
            Console.WriteLine(sorehrepowS());
            Console.ReadKey();
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

            Boolean done = false;

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

        static string sentence()
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
    }
}

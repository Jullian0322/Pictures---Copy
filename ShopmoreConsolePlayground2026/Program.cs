using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
                Console.WriteLine("[5] Sort some numbers");
                Console.WriteLine("[6] Read and write");
                Console.WriteLine("[7] combine two list");
                Console.WriteLine("[8] see what remains");
                Console.WriteLine("[9] Console Assignments");
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
                    else if (input == "5")
                    {
                        Console.WriteLine(sort());
                        Console.WriteLine(swapSort());
                    }
                    else if (input == "6")
                    {
                       //Console.WriteLine(ReadandWrite(Result.txt));
                    }
                    else if (input == "7")
                    {
                        Console.WriteLine(CombinetwoArrays());
                    }
                    else if (input == "8")
                    {
                        Console.WriteLine(Combine2());
                    }
                    else if (input == "9")
                    {
                        String Input2;

                        input = "";

                        Input2 = Console.ReadLine();

                        Console.WriteLine("[1] see if it's a palindrome");
                        Console.WriteLine("[2] turn into binary");
                        Console.WriteLine("[3] turn into deciamal");
                        Console.WriteLine("[4] double time");
                        Console.WriteLine("[5] muitiples");
                        Console.WriteLine("[6] what chareters show up the most");
                        Console.WriteLine("[7] whats not there");
                        Console.WriteLine("[8] fip all w's and m's");
                        Console.WriteLine("[9] replace all the vowols");

                        if (Input2 == "1")
                        {
                            Console.WriteLine(isItAPalindrome());
                        }
                        else if (Input2 == "2")
                        {
                            Console.WriteLine(binary());
                        }
                        else if (Input2 == "3")
                        {
                            Console.WriteLine(decibial());
                        }
                        else if (Input2 == "4")
                        {
                            Console.WriteLine(doubleTime());
                        }
                        else if (Input2 == "5")
                        {
                            Console.WriteLine(Times());
                        }
                        else if (Input2 == "6")
                        {
                            Console.WriteLine(howManyTimes());
                        }
                        else if (Input2 == "7")
                        {
                            Console.WriteLine(whatNotThere());
                        }
                        else if (Input2 == "8")
                        {
                            Console.WriteLine(MtoW());
                        }
                        else if (Input2 == "9")
                        {
                            Console.WriteLine(changeVowols());
                        }
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
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(a[i]);
            }
        }

        static void printArray(ArrayList a)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < a.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(a[i]);
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

        static string sort()
        {
            int[] num = { 7, 9, 8, 1, 10, 5, 6, 2, 4, 3 };
            printArray(num);

            num = sorting(num);

            printArray(num);

            return "";
        }

        static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(a[i]);
    }

            Console.WriteLine("\n");
}

        static int[] sorting(int[] a)
        {
            int temp;
            Boolean swapped;

            for (int i = 0; i < a.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0;  j < a.Length - 1; j++)
                {
                    if(a[j] < a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j+1];
                        a[j + 1] = temp;
                        swapped = true;
                    }
                }
                
                if (!swapped)
                {
                    break;
                }
            }

            return a;
        }

        static int[] ReadandWrite(string fileName)
        {
            Random rnd = new Random();

            string output = "";

            int[] number = new int [10000];


            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(500, 1501);
            }

            for(int i = 0; i < number.Length; i++)
            {
                if (i!=0)
                {
                    output += ", ";
                }
                output += number[i];
            }

            FileStream stream = new FileStream(fileName, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(stream)) { sw.WriteLine(output); }

            return number;
        }

        static string swapSort()
        {
            int[] num = { 7, 9, 8, 1, 10, 5, 6, 2, 4, 3 };
            
            SwapingSort(num);

            printArray(num);
            
            return "";
        }

        static int[] SwapingSort(int[] a)
        {

            Boolean swapped = false;
            for (int i = 0; i < a.Length; i++)
            {
                int j = i;
                int theItem = a[i];
                while (j > 0 && theItem < a[j-1])
                {
                    a[j] = a[j - 1];
                    j--;
                    swapped = true;
                }

                if (swapped) 
                { 
                    a[j] = theItem; 
                }
            }

            return a;
        }

        static ArrayList CombinetwoArrays()
        {
            Random rnd = new Random();

            int[] a = new int[50];

            int[] b = new int[50];

            ArrayList c = new ArrayList();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(500, 1501);
            }

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(500, 1501);
            }

            a = sorting(a);

            b = SwapingSort(b);

            c = CombingTime(a, b);

            printArray(c);

            return c;
        }

        static ArrayList CombingTime(int[] a, int[] b)
        {
            ArrayList c = new ArrayList();

            int counterA = 0;

            int counterB = 0;

            while (counterA < a.Length && counterB < b.Length)
            {
                if (a[counterA] < b[counterB])
                {
                    c.Add(a[counterA]);
                    counterA++;
                }
                else
                {
                    c.Add(b[counterB]);
                    counterB++;
                }
            }

            while (counterA < a.Length)
            {
                c.Add(a[counterA++]);
            }

            while (counterB < b.Length)
            {
                c.Add(b[counterB++]);
            }

            return c;
        }

        static ArrayList Combine2 ()
        {
            int min = 500;
            int max = 575;
            int[] a = getRandom(50, min, max);
            int[] b = getRandom(50, min, max);
            ArrayList c = new ArrayList();

            a = sorting(a);
            b = sorting(b);
            c = CombingTime(a, b);
            c = findWhatsMissing(c, min, max);

            printArray(c);
            return c;
        }

        static int[] getRandom(int howMany, int min, int max)
        {
            int[] a = new int[howMany];

            Random rnd = new Random(Environment.TickCount);

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(min, max+1);
            }

            return a;
        }

        static ArrayList findWhatsMissing(ArrayList a, int min, int max)
        {
            Boolean doneOne = false;

            ArrayList b = new ArrayList();
            for (int i = min; i <= max; i++)
            {
                if (!a.Contains(i))
                {
                    if (doneOne)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(a[i]);
                    doneOne = true;
                }
            }
            return a;
        }

        static ArrayList isItAPalindrome()
        {
            String input;

            input = Console.ReadLine();

            String temp = input;

            temp.Replace(",", "");
            temp.Replace(".", "");
            temp.Replace("!", "");
            temp.Replace("?", "");

            ArrayList console = new ArrayList(); 

            console.Add(temp);

            for (int i = 0; i < temp.Length; i++)
            {

            }

            return console;
        }

        static string binary()
        {
            String input;

            int value = 0;

            input = Console.ReadLine();

            input = Convert.ToString(value);

            Console.WriteLine("Please put a binary number (It's Just 0's and 1's)");

            string binary = Convert.ToString(value, 2);

            return binary;
        }

        static string decibial()
        {
            String input;

            input = Console.ReadLine();

            Console.WriteLine("Please put a binary number (It's Just 0's and 1's)");

            string decibal = Convert.ToInt32(input, 2).ToString(); ;

            return decibal;
        }

        static ArrayList doubleTime()
        {
            String input;

            input = Console.ReadLine();

            ArrayList list = new ArrayList();

            for (int i = 0; i < input.Length; i++)
            {
                if (input == input + 1)
                {
                    list.Add(input);
                }
            }

            return list;
        }

        static string Times()
        {
            String input;

            input = Console.ReadLine();

            mutiplcation(5);

            mutiplcation(20);

            return input;
        }

        static int mutiplcation(int number)
        {
            int result = 0;

            for (int i = 0; i <= 20; i++)
            {
                result = number * i;
                i++;
            }

            Console.Write(result);
            return result;
        }

        static String howManyTimes()
        {
            Console.WriteLine("PLease type in a sentence");

            String input;
            String temp;

            input = Console.ReadLine();
            int i = 0;
            temp = input;

            temp.Replace(" ", "");
            temp.Replace(",", "");
            temp.Replace("!", "");
            temp.Replace(".", "");
            temp.Replace("?", "");

            while (i <= temp.Length)
            {
                
            }

            String results = "";

            return results;
        }

        static String whatNotThere()
        {
            String[] lowLetter = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            String[] highLetter = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.WriteLine("Please put a sentence here");

            String input = Console.ReadLine();
            String[] temp = { input };

            String[] one = Remove(temp, lowLetter);
            String[] two = Remove(temp, highLetter);
            
            Console.WriteLine($"There isn't any {one} or {two}");

            String results = "";

            return results;
        }

        static String[] Remove(String[] sentence, String[] example)
        {
            for (int i = 0; i <= sentence.Length; i++)
            {
                if (sentence == example)
                {
                    example = sentence;
                }
            }

            return example;
        }

        static String MtoW()
        {
            String input = Console.ReadLine();

            Console.WriteLine("Please put a sentence here");

            for(int i = 0; i <= input.Length; i++)
            {
                input.ToUpper();
                    
                if (input == "M")
                {
                    input = "W";
                }
                else if (input == "W")
                {
                    input = "M";
                }
                }

            Console.WriteLine(input);

            String results = "";

            return results;
            }

        static String changeVowols()
        {
            String input = Console.ReadLine();

            Console.WriteLine("Please put a sentence here");

            for (int i = 0; i <= input.Length; i++)
            {
                input.ToUpper();

                if (input == "A")
                {
                    input = i.ToString();
                }
                else if (input == "E")
                {
                    input = i.ToString();
                }
                else if (input == "I")
                {
                    input = i.ToString();
                }
                else if (input == "O")
                {
                    input = i.ToString();
                }
                else if (input == "U")
                {
                    input = i.ToString();
                }
            }

            Console.WriteLine(input);

            String result = "";

            return result;
        }
    }
}
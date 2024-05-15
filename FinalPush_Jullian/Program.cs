using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalPush_Jullian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hello());
            Console.WriteLine(Capitalize());
            Console.WriteLine(Capitalize());
        }
    }

    static String Hello()
    {
        String finish = "";
        for (int i = 10; i <= 45; i++)
        {
            if (i != 10)
            {
                finish += ", ";
            }
            else if (i % 3 = 0)
            {
                finish += ""; ;
            }
            else
            {
                finish += i;
            }

            return finish;
        }
    }

    static String Capitalize()
    {
        String sentence = "I really love to eat cheese, seriously";

        if (sentence == " ")
        {
            sentence.ToUpper();
        }
        else if (sentence == sentence.ToUpper())
        {
            sentence.ToLower();
        }

        return sentence;
    }

    static String DoubleOnly()
    {
        String sentence = "I really love to eat cheese, seriously";

        String temp = sentence;

        temp.Replace(" ", "");
        temp.Replace(",", "");

        sentence = "";

        if (temp == temp + 1)
        {
            sentence = temp;
        }

        return sentence;
    }

    static String Asciis()
    {
        String sentence = "I really love to eat cheese, seriously";

        String[] vowels = { "a", "e", "i", "o", "u" };

        String temp = sentence;

        temp.Replace(" ", "");
        temp.Replace(",", "");
    }

    static String StackCheck()
    {
        ArrayList list = new ArrayList { };

        String example = "{{{{)))))((}}";
        
        Push(list, example);

        SortThem(list);
    }

    private static ArrayList Push(ArrayList a, String b)
    {
        if (b != null && b != "")
        {
            a.Add(b);
        }

        return a;
    }
}

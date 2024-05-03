using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksandQueus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get stateted");
            Console.WriteLine("Q to Quit at anytime");
            Boolean done = false;

            String input = Console.ReadLine();

            if (input.ToUpper() == "Q")
            {
                done = true;
            }
            else
            {
                Console.WriteLine(wait());
            }
        }

        static ArrayList wait()
        {
            ArrayList list = new ArrayList(250);

            Random rnd = new Random(72 - 389);

            Boolean done = false;

            int RND = rnd;

            if (RND % 2 = 0)
            {
                Push(list, RND);
            }
            else if (RND % 2 = 1)
            {
                Eaqueue(list, RND);
            }

            Console.WriteLine("[6] divided by six");
            Console.WriteLine("[7] divided by seven");
            Console.WriteLine("[8] divided by eight");
            Console.WriteLine("[Q] quit");
            Console.WriteLine("What number do you want");

            String input = Console.ReadLine();

            if (input == "6")
            {
                Console.WriteLine();
            }
            else if (input == "7")
            {
                Console.WriteLine();
            }
            else if (input == "8")
            {
                Console.WriteLine();
            }
            else if (input.ToUpper() == "Q")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("What number do you want");
            }

            return list;
        }

        private static ArrayList Push(ArrayList a, int b)
        {
            if (b != null)
            {
                a.Add(b);
            }
            return a;
        }

        private static String Pop(ArrayList a)
        {
            String returns = null;
            if (a.Count > 0)
            {
                returns = a[(a.Count - 1)].ToString();
                a.RemoveAt(a.Count - 1);
            }

            return returns;
        }

        private static ArrayList Eaqueue(ArrayList a, int b)
        {
            if (b != null)
            {
                a.Add(b);
            }
            return a;
        }

        private static String Dequeue(ArrayList a)
        {
            String returns = null;
            if (0 > a.Count)
            {
                returns = a[(a.Count - 1)].ToString();
                a.RemoveAt(a.Count - 1);
            }

            return returns;
        }
    }
}

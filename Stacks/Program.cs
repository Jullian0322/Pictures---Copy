using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Lifo works");
            Console.WriteLine("[2] Queue works");
            Console.WriteLine("[Q] Quit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine(StackWork());
                Console.WriteLine(BalenceorNot());
            }
            else if (input == "2")
            {
                Console.WriteLine(QueueTime());
            }
            else if (input == "q")
            {
                Console.WriteLine();
            }
        }

        static ArrayList StackWork()
        {
            ArrayList list = new ArrayList { };
            ArrayList Data = new ArrayList { };
            String input = "", popedValue = "";

            while ((input = Console.ReadLine()) != "Quit")
            {
                Console.WriteLine("Please enter a sentence");

                list = Push(list, input);
            }

            while ((popedValue = Pop(list)) != null)
            {
                Console.WriteLine(popedValue);
            }

            return Data;
        }

        private static ArrayList Push(ArrayList a,  String b)
        {
            if (b != null && b != "")
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

        static ArrayList QueueTime()
        {
            ArrayList list = new ArrayList { };
            ArrayList Data = new ArrayList { };
            String input = "", DeQueuedValue = "";

            while ((input = Console.ReadLine()) != "Quit")
            {
                list = Eaqueue(list, input);
            }

            while ((DeQueuedValue = Dequeue(list)) != null)
            {
                Console.WriteLine(DeQueuedValue);
            }

            return Data;
        }

        private static ArrayList Eaqueue(ArrayList a, String b)
        {
            if (b != null && b != "")
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

        static String BalenceorNot()
        {
            ArrayList list = new ArrayList { };
            ArrayList Data = new ArrayList { };
            String input = "", popedValue = "";

            while ((input = Console.ReadLine()) != "Quit")
            {
                Console.WriteLine("((())(");

                list = Push(list, input);
            }

            while ((popedValue = Pop(list)) != null)
            {
                Console.WriteLine(popedValue);
            }

            if (list != null)
            {
                input = "Balence";
            }
            else
            {
                input = "Not Balence";
            }
            return input;
        }
    }
}

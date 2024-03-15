using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Quiz_Jullian_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(alphaPattern('a', 122));
            Console.WriteLine(alphaPattern2('e', 122));
            Console.WriteLine(alphaPattern3('i', 122));
            Console.WriteLine(alphaPattern4('o', 122));
            Console.WriteLine(alphaPattern5('u', 122));
            Console.ReadKey();
        }

        static string alphaPattern(char skip, int capitalize)
        {
            /*A patern take a out and everything else is capitalize
            E patern every other gets capitalize and get rid of e
            I patern evry two uncapitlize gets capitalize skip i
            O partern every three uncapitilize gets capitolize skip o
            U partern every fith gets capitolize skip u
            */

            string output = "";
            for (int i = 'a'; i <= 'z'; i++)
            {
                if (i == skip)
                {
                    output += Convert.ToChar(i).ToString().ToUpper() + ":" + "\n";
                }
                else
                {
                    output += Convert.ToChar(i).ToString().ToUpper();
                }
            }
            return output;
        }

        static string alphaPattern2(char skip, int capitalize)
        {
            string output = "";
            bool cap = false;
            bool newLine = false;

            int i = 'a';

            while (i <= 'z')
            {
                if (i == skip && newLine == false)
                {
                    output += Convert.ToChar(i).ToString().ToUpper() + ":" + "\n";
                    newLine = true;
                    i = '`';
                }
                else if (i < skip && newLine == false)
                {
                    output += "";
                }
                else
                {
                    if (cap == false)
                    {
                        if (i == skip)
                        {
                            output += "";
                        }
                        else
                        {
                            output += Convert.ToChar(i).ToString();
                            cap = true;
                        }
                    }
                    else
                    {
                        output += Convert.ToChar(i).ToString().ToUpper();
                        cap = false;
                    }
                }
                i++;
            }
            return output;
        }
        static string alphaPattern3(char skip, int capitalize)
        {
            string output = "";

            bool cap = false;
            bool newLine = false;

            int i = 'a';
            int j = 0;

            while (i <= 'z')
            {
                if (i == skip && newLine == false)
                {
                    output += Convert.ToChar(i).ToString().ToUpper() + ":" + "\n";
                    newLine = true;
                    i = '`';
                }
                else if (i < skip && newLine == false)
                {
                    output += "";
                }
                else
                {
                    if (cap == false)
                    {
                        if (i == skip)
                        {
                            output += "";
                        }
                        else if (j == 1)
                        {
                            output += Convert.ToChar(i).ToString();
                            cap = true;
                            j = 0;
                        }
                        else
                        {
                            output += Convert.ToChar(i).ToString();
                            j++;
                            
                        }
                    }
                    else
                    {
                        output += Convert.ToChar(i).ToString().ToUpper();
                        cap = false;
                    }
                }
                i++;
            }
            return output;
        }
        static string alphaPattern4(char skip, int capitalize)
        {
            string output = "";

            bool cap = false;
            bool newLine = false;

            int i = 'a';

            int j = 0;

            while (i <= 'z')
            {
                if (i == skip && newLine == false)
                {
                    output += Convert.ToChar(i).ToString().ToUpper() + ":" + "\n";
                    newLine = true;
                    i = '`';
                }
                else if (i < skip)
                {
                    output += "";
                }
                else
                {
                    if (cap == false)
                    {
                        if (i == skip)
                        {
                            output += "";
                        }
                        else if (j == 2)
                        {
                            output += Convert.ToChar(i).ToString();
                            cap = true;
                            j = 0;
                        }
                        else
                        {
                            output += Convert.ToChar(i).ToString();
                            cap = true;
                            j++;
                        }
                    }
                    else
                    {
                        output += Convert.ToChar(i).ToString().ToUpper();
                        cap = false;
                    }
                }
                i++;
            }
            return output;
        }

        static string alphaPattern5(char skip, int capitalize)
        {
            string output = "";

            bool cap = false;
            bool newLine = false;

            int i = 'a';

            int j = 0;

            while (i <= 'z')
            {
                if (i == skip && newLine == false)
                {
                    output += Convert.ToChar(i).ToString().ToUpper() + ":" + "\n";
                    newLine = true;
                    i = '`';
                }
                else if (i < skip && newLine == false)
                {
                    output += "";
                }
                else
                {
                    if (cap == false)
                    {
                        if (i == skip)
                        {
                            output += "";
                        }
                        else if (j == 3)
                        {
                            output += Convert.ToChar(i).ToString();
                            cap = true;
                            j = 0;
                        }
                        else
                        {
                            output += Convert.ToChar(i).ToString();
                            cap = true;
                            j++;
                        }
                    }
                    else
                    {
                        output += Convert.ToChar(i).ToString().ToUpper();
                        cap = false;
                    }
                }
                i++;
            }
            return output;
        }
    }
}

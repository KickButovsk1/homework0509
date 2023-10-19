using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строчку:");
            string str = Console.ReadLine();
            int i = getcountpunctuation(str);
            Console.WriteLine(i);
            string p = getnumber(str);
            Console.WriteLine(p);
            string a = getciclenumber(str);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        /// <summary>
        /// третья задача повторяющиеся цифры
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string getciclenumber(string str)
        {
            string d = "0123456789";
            string strNumbers = "";
            foreach (char item in str)
            {
                if (d.Contains(item))
                {
                    if (strNumbers.Contains(item))
                    {
                        Console.WriteLine(item);
                    }
                }


            }
            
            return strNumbers;


        }
        /// <summary>
        /// вторая задача все различные цифры
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string getnumber(string str)
        {
            string v = "0123456789";
            string strNumbers = "";
            foreach (char item in str)
            {
                if (v.Contains(item))
                {
                    if (!strNumbers.Contains(item))
                    {
                        strNumbers += item;
                    }
                }
                

            }
            if (strNumbers.Length == 0)
            {
                return "NO";
            }
            return strNumbers;
        }

        /// <summary>
        /// пунктуация первое задание
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static int getcountpunctuation(string str)
        {
            string p = ".,;:!?";
            int i = 0;
            foreach (char item in str)
            {
                if (p.Contains(item))
                {
                    i++;
                }
            }

            return i;
        }
    }
}

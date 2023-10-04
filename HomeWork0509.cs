using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = Console.ReadLine();
            string text = @"(^[;:])(-*)((\)))|((\())|((\[))|((\]))\S";
            if (Regex.Match(regex, text).Success)
            {
                Console.WriteLine(regex + " - СМАЙЛИК");
            }
            else
            {
                Console.WriteLine(regex + " - НЕ ЯВЛЯЕТСЯ СМАЙЛИКОМ");
            }
            Console.ReadKey();
        }
    }
}

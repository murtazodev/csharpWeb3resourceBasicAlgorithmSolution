using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Threading;


namespace BroCodef
{
    class Program
    {

        static void Main(string[] args)
        {

            String text = "else if";
            String text2 = "if else";
            Console.WriteLine(if_checker(text));
            Console.WriteLine(if_checker(text2));

            Console.ReadLine();

        }
        public static string if_checker(string word)
        {
            if (word.Substring(0, 2).Contains("if"))
            {
                return word;
            }
            else return "if " + word;





        }

    }
    
     

   
}

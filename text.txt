using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// generic in c#
            ///

            int[] intaray = { 1, 2, 3, 4 };
            double[] doubaray = { 1.0, 2.0, 3.0 };
            string[] straray = { "1", "2", "3" };

            displayelemet(intaray);
            displayelemet(doubaray);
            displayelemet(straray);

            ///displayelemet1(doubaray);
            //displayelemet11(straray);

            Console.ReadKey();
        }
        public static void displayelemet<Thing>(Thing[] aray)
        {
            foreach( Thing item in aray)
            {
                Console.WriteLine(item + " ");
            }
        }

        //public static void displayelemet1(double[] aray)
        //{
        //    foreach (double item in aray)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //}
        //public static void displayelemet11(string[] aray)
        //{
        ///    foreach (string item in aray)
        //    {
        //        Console.WriteLine(item + " ");
        //    }
        //}

    }

}

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            /// enums in c#
            /// 
            Console.WriteLine(Planets.Earth + " is a planet");
            Console.WriteLine(Planets.Earth + " is a planet $" + (int)Planets.Earth);
            Console.WriteLine(Planets.Venus + " is a planet $" + (int)Planets.Venus);

            string name = PlanetRadius.Venus.ToString();
            int rds = (int)PlanetRadius.Venus;
            Console.WriteLine("Planet " + name);
            Console.WriteLine("PlanetRadius " + rds + "km");


            double volume = vol(PlanetRadius.Earth);

            Console.WriteLine("volume : " + volume+ "km^3");
            Console.ReadKey();
        }
        public static double vol(PlanetRadius planetRadius)
        {
            double vol = (4.0 / 3.0) * Math.PI * Math.Pow((int)planetRadius, 3);
            return vol;
        }
       
    } 
    enum Planets
    {
        Mercury  = 1, 
        Venus  = 2,  
        Earth = 3, 
        Mars = 4, 
        Jupiter = 5, 
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8, 
        Pluto = 9
    }
    enum PlanetRadius
    {
        Mercury = 111,
        Venus = 112,
        Earth = 113,
        Mars = 114,
        Jupiter = 115,
        Saturn = 116,
        Uranus =117,
        Neptune = 118,
        Pluto = 119
    }
 
}
 

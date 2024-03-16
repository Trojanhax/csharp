using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // string method in c#

            string fullname = "jvukhvGCKCTOUDODjlscacack avakvk kvadvpav paPP PP";
            string phonenumber = "825-2072-37-632-62";


            // fullname = fullname.ToUpper();
            fullname = fullname.ToLower();

            phonenumber = phonenumber.Replace("-", "0");



            string uername = fullname.Insert(0,"@");

            Console.WriteLine(fullname.Length);

            string fistname = fullname.Substring(0,3);
            string lastname = fullname.Substring(4,7);


            Console.WriteLine(fullname); 
            Console.WriteLine(phonenumber);
            Console.WriteLine(uername);
            Console.WriteLine(fistname);
            Console.WriteLine(lastname);

            Console.ReadKey();
            


        }
    }
}
  

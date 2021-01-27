using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Alex","Smith","Al","Davis" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Alex","Smith","Al","Davis" };
            isimler2.Add("Mark");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        { 
            string name = "";
            Console.WriteLine("Please input your name");
            
            string x = Console.ReadLine();
            name = x;

            int times = name.Length;
            char[] letters = name.ToCharArray();
             
            for (int i = 0; i < times; i++)
            {
                Console.Write("Give me a " + letters[i] + "\r\n");
                
            }
            Console.WriteLine( "Hooray " + name + "!!!!");
            Console.ReadLine();
        }
    }
}

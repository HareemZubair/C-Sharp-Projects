using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int st;
            Console.WriteLine("Enter How many time you want to loop:");
            st = Convert.ToInt32(Console.ReadLine());
            for(int a=1;a<=st;a++)
            {
                Console.WriteLine("Messi");
            }
            Console.ReadLine();
        }
    }
}

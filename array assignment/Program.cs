using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a=1;
            int[] messi = new int[a]; 
            for (i = 0; i < messi.Length; i++)
            {
                Console.Write("\nEnter your number:\t");
                messi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            for (i = 0; i < messi.Length; i++)
            {
                Console.WriteLine("you entered {0}", messi[i]);
            }
            Console.ReadLine();
        }
    }
}

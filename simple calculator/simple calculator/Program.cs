using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int fno, sno;
            string sign;
            string sfno, ssno;
            bool bfno, bsno;

            Console.Write("Enter your First Number:");
            sfno = Console.ReadLine();

            bfno = int.TryParse(sfno, out fno);

            if (bfno == false)
            {
                Console.WriteLine("Enter your number in numeric value:");
                fno = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
            }
            bfno = int.TryParse(sfno, out fno);

            Console.Write("Enter your Second Number:");
            ssno = Console.ReadLine();

            bsno = int.TryParse(ssno, out sno);

            if (bsno == false)
            {
                Console.WriteLine("Enter your number in numeric value:");
                sno = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
            }
            bsno = int.TryParse(ssno, out sno);
            Console.WriteLine("Which operation you want to perform:");
            sign = Console.ReadLine();
                if (sign == "+")
                {
                    Console.WriteLine("add=" + (fno + sno));
                }
                else if (sign == "-")
                {
                    Console.WriteLine("sub=" + (fno - sno));
                }
                else if (sign == "*" )
                {
                    Console.WriteLine("pro=" + (fno * sno));
                }
                else if (sign == "/")
                {
                    Console.WriteLine("divide=" + (fno / sno));
                }
                else
                {
                    Console.WriteLine("Something else");
                }
            
            Console.ReadLine();

        }
    }
}

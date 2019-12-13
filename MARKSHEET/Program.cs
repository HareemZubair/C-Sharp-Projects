using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARKSHEET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mark Sheet";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            // user id and name
            string name, seng, smath, scomp;
            int id, eng, math, comp;
            bool beng, bcomp, bmath;
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student ID no:");
            id = Convert.ToInt32(Console.ReadLine());
            // user marks
            Console.WriteLine("Enter English Marks:");
            seng = Console.ReadLine();
            beng = int.TryParse(seng, out eng);
            if (beng == false)
            {
                Console.WriteLine("Enter Marks in Numbers:");
                Console.WriteLine("Enter English Marks:");
                seng = Console.ReadLine();
                beng = int.TryParse(seng, out eng);
            }
            if (eng>=40)
            {
                Console.WriteLine("Passed in English");
            }
            else
            {
                Console.WriteLine("Failed in English");
            }
            Console.WriteLine("Enter Maths Marks:");
            smath = Console.ReadLine();
            bmath = int.TryParse(smath, out math);
            if (bmath == false)
            {
                Console.WriteLine("Enter Marks in Numbers:");
                Console.WriteLine("Enter Maths MArks:");
                smath = Console.ReadLine();
                bmath = int.TryParse(smath, out math);
            }
            if(math>=40)
            {
                Console.WriteLine("Passed in Maths");
            }
            else
            {
                Console.WriteLine("Failed in Maths");
            }
            Console.WriteLine("Enter Computer Marks");
            scomp = Console.ReadLine();
            bcomp = int.TryParse(scomp, out comp);
            if (bcomp == false)
            {
                Console.WriteLine("Enter Marks in Numbers");
                Console.WriteLine("Enter Computer Marks");
                scomp = Console.ReadLine();
                bcomp = int.TryParse(scomp, out comp);
            }
            if(comp>=40)
            {
                Console.WriteLine("Passed in Computer");
            }
            else
            {
                Console.WriteLine("Failed in Computer");
            }
            //user obtained marks
            Console.WriteLine("Press Enter!");
            Console.ReadLine();
            int obt;
            obt = eng + math + comp;
            Console.WriteLine("Obtained Marks =" + obt);
            int total = 300;
            float per;
            per = (float)obt / total * 100;
            Console.WriteLine("Percentage =" + Math.Round(per, 2));
            // grades and remarks
            if (eng>=40 && math>=40 && comp>=40)
            {
                if (per>=40 && per<50)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Grade = D");
                }
                else if (per>=50 && per<60)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Grade = C");
                }
                else if (per>=60 && per<70)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Grade = B");
                }
                else if (per>=70 && per<80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Grade = A");
                }
                else if (per>=80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Grade = A +");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Grade = F");
                }
            }
                else
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Failed in Exam");
                }
            Console.ReadLine();
            }
        }
    }


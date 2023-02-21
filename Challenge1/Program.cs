using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {

            clockType clock1 = new clockType();
            Console.Write("Empty Time : ");
            clock1.printTime();

            clockType clock2 = new clockType(10);
            Console.Write("Hour Time : ");
            clock2.printTime();

            clockType clock3 = new clockType(10, 20);
            Console.Write("Minutes Time : ");
            clock3.printTime();

            clockType clock4 = new clockType(10, 20, 36);
            Console.Write("Full Time : ");
            clock4.printTime();

            clock4.incrementBySecond();
            Console.Write("Full Time (Increment second) : ");
            clock4.printTime();

            clock4.incrementByMinute();
            Console.Write("Full Time (Increment Minute) : ");
            clock4.printTime();

            clock4.incrementByHour();
            Console.Write("Full Time (Increment Hour) : ");
            clock4.printTime();

            int time = clock4.timeInSeconds(clock4);
            Console.WriteLine("Full Time (Elapsed time in seconds) : " + time + "s");

            int time1 = clock4.remainingTimeInSeconds(clock4);
            Console.WriteLine("Full Time (Remaining time in seconds) : " + time1 + "s");

            int time2 = clock4.diffBetTwoWatches(10, 20, 36);
            Console.WriteLine("Full Time (Diffrence in time in seconds) : " + time2 + "s");

            Console.Write("Full Time : ");
            clock4.printTime();

            bool flag = clock4.isEqual(11, 21, 37);
            Console.WriteLine("Flag : " + flag);

            clockType clock5 = new clockType(10, 20, 36);
            bool flag1 = clock4.isEqual(clock5);
            Console.WriteLine("Flag : " + flag1);


            Console.ReadKey();
        }
    }
}

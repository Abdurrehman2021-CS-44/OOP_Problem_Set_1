using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
{
    class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public clockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public void printTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
        public void incrementBySecond()
        {
            seconds++;
        }
        public void incrementByMinute()
        {
            minutes++;
        }
        public void incrementByHour()
        {
            hours++;
        }
        public bool isEqual(int h, int m, int s)
        {
            if (h == hours && m == minutes && s == seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType c)
        {
            if (c.hours == hours && c.minutes == minutes && c.seconds == seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int timeInSeconds(clockType c)
        {
            return c.hours * 60 * 60 + c.minutes * 60 + c.seconds;
        }
        public int remainingTimeInSeconds(clockType c)
        {
            return (24 - c.hours) * 60 * 60 + (60-c.minutes) * 60 + (60 - c.seconds);
        }
        public int diffBetTwoWatches(int h, int m, int s)
        {
            if(hours >= h && minutes >= m && seconds >= s)
                return (hours - h) * 60 * 60 + (minutes - m) * 60 + (seconds - s);
            else
                return (h - hours) * 60 * 60 + (m - minutes) * 60 + (h - seconds);
        }
    }
}

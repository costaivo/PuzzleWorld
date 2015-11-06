using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleWorld.Hackerrank.Algorithms.Warmup
{
    class TimeConversion
    {
        public static void Solution()
        {
            var data = Console.ReadLine();
            var splitData = data.Split(':');
            var hour = int.Parse(splitData[0]);
            var minutes = int.Parse(splitData[1]);
            var seconds = int.Parse(splitData[2].Substring(0, 2));
            var amOrPM = splitData[2].Substring(2, 2);
            if (amOrPM.ToUpper() == "PM")
            {
                if (hour != 12)
                    hour = hour + 12;

            }
            else
            {
                if (hour == 12)
                    hour = 00;
            }
            Console.WriteLine(string.Format("{0}:{1}:{2}", hour.ToString("00"),
                minutes.ToString("00"),
                seconds.ToString("00")));
        }
    }
}

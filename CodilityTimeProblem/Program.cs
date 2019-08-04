using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTimeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Solution.solution("15:15:00", "15:15:15");
            Console.Write("Result is : " + result);
            Console.ReadLine();
        }
    }

    public static class Solution {

        public static int solution(String S, String T)
        {
            TimeSpan startTime = TimeSpan.Parse(S);

            TimeSpan endTime = TimeSpan.Parse(T);
            TimeSpan oneSecond = TimeSpan.Parse("00:00:01");

            TimeSpan timeDiff = endTime - startTime;

           
            int interstingCount = 0;
            
                while (startTime <= endTime)
                {
                   
                    if (CheckForIntersting(startTime))
                    {
                        interstingCount++;
                    }
                startTime = startTime.Add(oneSecond);
            }
            
            return interstingCount;
        }
            
           
      
        public static bool CheckForIntersting(TimeSpan time)
        {
            //Hour
            int hours = time.Hours;
            int tenthPlaceHour = hours / 10;
            int unitPlaceHour = hours % 10;

            //Minute
            int minute = time.Minutes;
            int tenthPlaceMinute = minute / 10;
            int unitPlaceMinute= minute % 10;

            //Seconds
            int seconds = time.Seconds;
            int tenthPlaceSecond = seconds / 10;
            int unitPlaceSecond = seconds % 10;

            HashSet<int> timeSet = new HashSet<int>();
            timeSet.Add(tenthPlaceHour);
            timeSet.Add(unitPlaceHour);
            timeSet.Add(tenthPlaceMinute);
            timeSet.Add(unitPlaceMinute);
            timeSet.Add(tenthPlaceSecond);
            timeSet.Add(unitPlaceSecond);
            if (timeSet.Count == 2)
            {
                return true;
            }

            return false;
        }

    }
}

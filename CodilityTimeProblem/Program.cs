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
            int result = Solution.solution("15:15:00", "15:15:12");
            Console.ReadLine();
        }
    }

    public static class Solution {

        public static int solution(String S, String T)
        {
            TimeSpan startTime = TimeSpan.Parse(S);
            Console.WriteLine("Start Time : " + startTime.ToString());
            TimeSpan endTime = TimeSpan.Parse(T);
            TimeSpan oneSecond = TimeSpan.Parse("00:00:01");
            startTime = startTime.Add(oneSecond);
            Console.WriteLine("Start Time : " + startTime.ToString());
            if (startTime< endTime)
            {
                Console.WriteLine("S is less than T");
            }
            return 0;
        }
    }
}

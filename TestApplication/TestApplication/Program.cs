using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //string testLine = "01Jan00 20:07:16#[AA] :Sealer OFF - Preheat: 2264 ms, Seal:  8988 ms, Cut: 14252 ms, Avg pwr (x100): 3229";

            //var pattern = @"\b\d+(?=\s*ms\b|$)";//(?<preHeat>\w+:\s+(\d+)\sms,)|([\w\s]+\s\(\w+\):\s(\d+))");
            
            //var matches = Regex.Matches(testLine, pattern);

            //if (matches.Count > 0 && matches[0].Groups.Count > 1)
            //{
            //    // Do Nothing
            //}
            int[] linqtest = new int[5];
            linqtest[0] = 10;
            linqtest[1] = 20;
            linqtest[2] = 15;

            IEnumerable<int> result = from i in linqtest where i < 3 select i;
        }
    }
}

using System;
using System.Collections.Generic;

namespace ProcessingListOfStrings.Common
{
    public static class Results
    {
        public static void EndResult()
        {
            Console.WriteLine("Finished");
        }

        public static void JoinList(List<string>listToJoin)
        {
            Console.WriteLine(String.Join(" ", listToJoin));
        }

        public static void PrintCounter(int count)
        {
            Console.WriteLine(count);
        }
    }
}

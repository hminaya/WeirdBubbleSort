using System;
using System.Diagnostics;

namespace SampleBubbleSort
{
    class Program
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            var dataList = DataList();

            Console.WriteLine($"");
            Console.WriteLine($"✅ BubbleSort");

            var stopwatch = Stopwatch.StartNew();
            var sortedList = BubbleSort(dataList);
            stopwatch.Stop();

            Console.WriteLine($"- Sorted: {dataList.Length} in {stopwatch.Elapsed}. {count} levels of recursion");

        }

        public static int[] BubbleSort(int[] list)
        {

            var doThisAgain = false;

            for (int i = 0; i < list.Length - 1; i++)
            {
                var thisValue = list[i];
                var nextValue = list[i + 1];

                if (nextValue < thisValue)
                {
                    list[i] = nextValue;
                    list[i + 1] = thisValue;
                    doThisAgain = true;
                }
            }
            if (doThisAgain)
            {
                count = count + 1;
                return BubbleSort(list);
            }
            return list;
        }

        public static int[] DataList()
        {

            int[] result = new int[50000];
            var rnd = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rnd.Next(1, 500);
            }

            return result;

        }
    }
}

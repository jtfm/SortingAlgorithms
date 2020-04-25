using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class ListGenerator
    {
        public static List<int> GenerateListOfIntegers(int length, int min, int max)
        {
            var list = new List<int>();

            for (var n = 0; n < length; n++)
            {
                list.Add(new Random().Next(min, max));
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ListGenerator.GenerateListOfIntegers(100, 0, 100);

            foreach (int listItem in list)
            {
                Console.WriteLine(listItem);
            }
        }
    }
}

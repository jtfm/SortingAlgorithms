using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms.Algorithms
{
    public class BubbleSorter : ISorter
    {
        public List<int> Sort(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            return input.Count == 0 ? input : new List<int>();
        }
    }
}
